Feature: Brand Names


Scenario: Validate All the Brand Names in AutomateTestStore
	Given I navigate to homepage
	When I read all the brands available
	Then The brand names should match below list
	| Brand Names    |
	| Benefit        |
	| Pantene        |
	| M·A·C          |
	| Lancôme        |
	| Gucci          |
	| Giorgio Armani |
	| Dove           |
	| Calvin Klein   |
	| Bvlgari        |
	| Sephora        |


	