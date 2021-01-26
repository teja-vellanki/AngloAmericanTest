Feature: ToRent

Scenario: Change the frequency of an existing email update
	Given I navigate to zoopla homepage
	And I choose 'To rent' section
	When I enter a search value 'London'
	And I choose min price '£800 pcm' and max price '£1,000 pcm'
	And I choose number of bedrooms as '1+'
	#And I click on Advanced search link
	Then I click on submit button
	And I verify page contains search title as 'Property to Rent in London'
	When I click on "Create email alert" from side bar
	Then I verify page contains search title as 'Register'
	And I register a user
	Then I see account 'My Zoopla' gets created
	And I click on my account
	When I choose 'Email preferences' from my account page
	Then I choose 'No' to Zoopla news
	And I verify the success message 'Update successful.'