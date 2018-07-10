Feature: Search
	In order to search for any location
	As a user
	I use search bar to search location on Room5

@mytags
Scenario: Search for any location on Room5 by using the search bar
	Given I am on Room5 landing page
	When I click on search icon
	And I click on destination canada
	And I click on recommanded tags budget
	Then single search result shows