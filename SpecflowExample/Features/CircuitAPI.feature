Feature: CircuitsApi
	In order to impress my friends
	As a Formula 1 fan
	I want to know the number of races for a given Formula 1 season


@B_API
Scenario Outline: Check the number of races in a season
	Given I want to know the number of Formula One races in <season>
	When I retrieve the circuit list for that season
	Then there should be <numberOfCircuits> circuits in the list returned
	Examples:
	| season | numberOfCircuits |
	| 2017   | 20               |
	| 2016   | 21               |
	| 1966   | 9                |
	| 1950   | 7                |