Feature: Add Sale Product to Basket - Benefit Brand

Scenario: Validate the Price in Basket
    Given I navigate to homepage
	When I click on brand "Benefit"
	Then I should reach the "Benefit brand page"
	When I add the sale product to the basket 
	And I click on basket in the benefits page
	Then I should see the sale product is added in the basket