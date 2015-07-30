Feature: Clam Card Journeys
	In order to travel around London
	As a traveller
	I want to be charged the correct amount

@mytag
Scenario: Zone A Single Journey
Given Michael has a ClamCard
And Michael travels from Asterisk to Aldgate
Then Michael will be charged £2.50 for all his journeys


Scenario: Zone A Return Journey
Given Michael has a ClamCard
And Michael travels from Asterisk to Aldgate
And Michael travels from Aldgate to Asterisk
Then Michael will be charged £5.00 for all his journeys


Scenario: Zone A to B Journey
Given Michael has a ClamCard
And Michael travels from Asterisk to Barbican
Then Michael will be charged £3.00 for all his journeys


Scenario: Zone B to B Journey
Given Michael has a ClamCard
And Michael travels from Barbican to Barbican
Then Michael will be charged £3.00 for all his journeys


Scenario: Zone A to B and Then B to B Journey
Given Michael has a ClamCard
And Michael travels from Asterisk to Barbican
And Michael travels from Barbican to Balham
Then Michael will be charged £3.00 for his first journey
And a further £3.00 for his second journey

Scenario: Day Cap Reached Zone A Journey
Given Michael has a ClamCard
And Michael travels from Asterisk to Aldgate
And Michael travels from Aldgate to Asterisk
And Michael travels from Asterisk to Aldgate
Then Michael will be charged £7.00 for all his journeys

Scenario: Day Cap Reached Zone B Journey
Given Michael has a ClamCard
And Michael travels from Asterisk to Balham
And Michael travels from Aldgate to Barbican
And Michael travels from Barbican to Aldgate
And Michael travels from Barbican to Aldgate
And Michael travels from Barbican to Aldgate
Then Michael will be charged £8.00 for all his journeys

Scenario Outline: Michael travelling two days in a row
Given Michael has a ClamCard
And the date is <first_date>
And Michael travels from Asterisk to Aldgate
And Michael travels from Asterisk to Aldgate
And Michael travels from Asterisk to Aldgate
And Michael travels from Asterisk to Aldgate
And the date is <second_date>
And Michael travels from Asterisk to Aldgate
And Michael travels from Asterisk to Aldgate
And Michael travels from Asterisk to Aldgate
And Michael travels from Asterisk to Aldgate
And Michael travels from Asterisk to Aldgate
Then Michael will be charged £14.00 for all his journeys

    Examples:
    | first_date           | second_date               | 
    | 2015-01-01T00:00:00  | 2015-02-01T00:00:00         |  