Feature: Contact
	In order to submit contact form
	As a user
	I enter all info and submit the contact form

@mytag
Scenario: Fill in the contact form and send it
	Given I am on home page
	And I click contact link
	And I enter message
	And I enter name
	And I enter email
	And I select checkbox
	When I press submit
	Then I get confirmation that message sent successfully
