Feature: Newsletter
	In order to subscribe to newsletter
	As a user
	I send a subscription form and subscribe to the newsletter

@mytag
Scenario: Subscribe to the Newsletter
	Given I am on landing page
	And I enter email address
	And I click on accept checkbox
	When I click Inspire me button
	Then newsletter subscription confirmation message shows

	