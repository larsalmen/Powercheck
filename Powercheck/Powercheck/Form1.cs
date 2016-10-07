using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Net.NetworkInformation;
using System.Timers;

namespace Powercheck
{

    /// <summary>
    /// TODO: Encapsulate all variables with props. DRY it up, some methods are extremely similar.
    /// Understand threading, not just work around it. Use backgroundworker or something for timer.
    /// Add list of hosts to ping, with dropdown menu.
    /// Add tooltip over trayicon that shows current status.
    /// Log failures and exceptions. Validate hosts input...?
    /// </summary>
    public partial class Form1 : Form
    {
        delegate void SetTextCallback(string text); // Delegate used to set textboxes when threading acts up...
        int timeToShutdown; // Time in minutes until shutdown via windows logoff screen. Set via numericupdown.
        int pingTimer; // Time in minutes between ping tries. Set via numericupdown.
        string hostToPing; // Host to ping. Input from textbox.
        int allowablePingFail; // Allowable tries before shutdown. Set via numericupdown.
        int currentPingFail; // Current failures, increments every failed ping.
        System.Timers.Timer ping; // Timer used to ping etc.
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Sets numericupdowns, host textbox etc from Settings file.
            // Starts timer.
            UpdateFromSettings();

            checkBoxStartStopp.Appearance = Appearance.Button;

            ping = new System.Timers.Timer();
            ping.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            ping.Interval = pingTimer;
        }
        private void UpdateSettings()
        {
            // Updates variables with values from controls.
            timeToShutdown = 60 * Convert.ToInt32(numericUpDownKeepAlive.Value.ToString());
            pingTimer = 60 * (Convert.ToInt32(numericUpDownPingTimer.Value.ToString()) * 1000);
            allowablePingFail = Convert.ToInt32(numericUpDownTries.Value.ToString());
            hostToPing = textBoxHost.Text;
        }
        private bool PingHost(string ipAdress)
        {
            // Pings host, calls to method to display result on main form and returns ping result as bool.
            bool pingable = false;
            Ping pinger = new Ping();
            try
            {
                PingReply reply = pinger.Send(hostToPing);
                pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                // Discard PingExceptions and return false;
                // Should probably implement logging here.
            }
            DisplayPingResult(pingable);
            return pingable;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Calls to method to update variables with current settings and method to save settings in settings file.
            UpdateSettings();
            SaveSettings();
        }
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            // Does all the magic when the pingTimer has elapsed.
            if (!PingHost(hostToPing))
                currentPingFail++;
            else
                currentPingFail = 0;

            string result = $"Ping failures: {currentPingFail}";
            SetLabelPingFail(result);

            if (currentPingFail > allowablePingFail)
                Process.Start($"shutdown", $"/s /t {timeToShutdown}");
        }
        private void SaveSettings()
        {
            // Saves current settings to settings file.
            Properties.Settings.Default.TimeToShutDownSetting = (int)numericUpDownKeepAlive.Value;
            Properties.Settings.Default.PingTimerSetting = (int)numericUpDownPingTimer.Value;
            Properties.Settings.Default.HostToPingSetting = hostToPing;
            Properties.Settings.Default.AllowablePingFailSetting = (int)numericUpDownTries.Value;
            Properties.Settings.Default.Save();
        }
        private void UpdateFromSettings()
        {
            // Update controls with values from current settings file.
            timeToShutdown = 60 * Properties.Settings.Default.TimeToShutDownSetting;
            pingTimer = (Properties.Settings.Default.PingTimerSetting * 1000) * 60;
            hostToPing = Properties.Settings.Default.HostToPingSetting;
            allowablePingFail = Properties.Settings.Default.AllowablePingFailSetting;

            textBoxHost.Text = Properties.Settings.Default.HostToPingSetting;
            numericUpDownKeepAlive.Value = Properties.Settings.Default.TimeToShutDownSetting;
            numericUpDownPingTimer.Value = Properties.Settings.Default.PingTimerSetting;
            numericUpDownTries.Value = Properties.Settings.Default.AllowablePingFailSetting;
        }
        private void Start_Stopp(bool start)
        {
            // Starts or stops the timer and enables/disables controls.
            if (start)
            {
                ping.Enabled = true;
                textBoxHost.Enabled = false;
                panelNumeric.Enabled = false;
            }
            else
            {
                ping.Enabled = false;
                textBoxHost.Enabled = true;
                panelNumeric.Enabled = true;
            }
            currentPingFail = 0;
        }
        private void buttonTest_Click(object sender, EventArgs e)
        {
            // Test to see if the current set host is pingable.
            hostToPing = textBoxHost.Text;
            DisplayPingResult(PingHost(hostToPing));
        }
        private void checkBoxStartStopp_CheckStateChanged(object sender, EventArgs e)
        {
            // Updates variables, clears labels and toggles timer.
            UpdateSettings();
            Start_Stopp(checkBoxStartStopp.Checked);
            labelPingFail.Text = "";
            labelPingResult.Text = "";
        }
        public void DisplayPingResult(bool pingable)
        {
            // Displays the result of the last attempt to ping host.
            if (pingable)
            {
                string result = "Ping succesful.";
                SetLabelPingResult(result);
                labelPingResult.BackColor = Color.Green;
            }
            else
            {
                string result = "Ping unsuccesful.";
                SetLabelPingResult(result);
                labelPingResult.BackColor = Color.Red;
            }
        }
        private void SetLabelPingResult(string result)
        {
            // Uses delagate to update labels on main form with the last ping results.
            if (labelPingResult.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetLabelPingResult);
                Invoke(d, new object[] { result });
            }
            else
            {
                labelPingResult.Text = result;
            }
        }
        private void SetLabelPingFail(string result)
        {
            // Uses delagate to update labels on main form with the last ping results.

            if (labelPingFail.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetLabelPingFail);
                Invoke(d, new object[] { result });
            }
            else
            {
                labelPingFail.Text = result;
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // Cancels current shutdown timer (if any) and stops the timer.
            AbortShutdown();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            // Minimizes the window to system tray.
            if (FormWindowState.Minimized == WindowState)
            {
                systemTrayicon.Visible = true;                
                Hide();
            }
            else if (FormWindowState.Normal == WindowState)
            {
                systemTrayicon.Visible = false;
            }
        }
        private void systemTrayicon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Shows the main form and brings it to focus.
            Show();
            WindowState = FormWindowState.Normal;
            Activate();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Start_Stopp(true);
        }
        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Start_Stopp(false);
        }
        private void abortShutdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbortShutdown();
        }
        private void AbortShutdown()
        {
            Process.Start($"shutdown", $"/a");
            Start_Stopp(false);
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
