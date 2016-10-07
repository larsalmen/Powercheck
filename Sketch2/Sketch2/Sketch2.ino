#include <EthernetUdp.h>
#include <EthernetServer.h>
#include <EthernetClient.h>
#include <Ethernet.h>
#include <Dns.h>
#include <Dhcp.h>

byte mac[] = { 0xBE, 0xEF, 0xC0, 0xFF, 0xEE, 0x00 };	// The MAC adress of the eth.shield. Can be anything...

byte ip[] = { 10, 0, 0, 150 };		// Sets static ip. Comment out to use DHCP.

unsigned long previousMillis = 0;        // Will store last time ethernet maintain ran.

const long interval = 1000;           // Interval at which to maintain ethernet.

const int sdPin = 4;		// Sets do pin 4 as sdPin.

void setup() {
	// Starts ethernet. Remove ip part of method parameters to use DHCP.
	Ethernet.begin(mac, ip);
	// Sets sdPin to output.
	pinMode(sdPin, OUTPUT);
}

void loop() {
	int sdPin = HIGH;		// Sets sdPin to HIGH to excplicitly de-select it.
	unsigned long currentMillis = millis();

	if (currentMillis - previousMillis >= interval)		// Checks if the specified interval has elapsed.
		{
		previousMillis = currentMillis;		// Saves the last time the following code executed.
		Ethernet.maintain();
		}							
}