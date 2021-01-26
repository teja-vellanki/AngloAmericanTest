Feature: DoveBrandItems 

Scenario: Add all the Dove Products to Basket and check basket total
	Given I navigate to homepage
	When I click on brand "Dove"
	Then I should see the below products are availble
	| ProductName                       | ProductPrice |
	| MEN+CARE CLEAN COMFORT DEODORANT  | 7.20         |
	| DOVE MEN +CARE BODY WASH          | 6.70         |
	| MEN+CARE ACTIVE CLEAN SHOWER TOOL | 6.00         |
	When I add add the products to basket
	And I click on basket
	Then I should see the basket value is equal to sum of all product prices plus shipping costs
