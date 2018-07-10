Feature: Destination
	In order to see a destination
	As a user
	I navigate to a destination through the menu on the top left

@mytag
Scenario: Navigate to a destination through the menu on the top left
	Given I am on magazine home page
	And I click on menu
	And I click on a destination item
	When I click on final destination
	Then I land on final destination artical
