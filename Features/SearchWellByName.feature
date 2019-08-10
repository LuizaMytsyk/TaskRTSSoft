Feature: Search Well by name
	In order to view information about well
	As a user
	I want to search well by name

@Browser:Chrome
Scenario: Input well name in Search field and press 'Enter'
	Given I Navigate to the Login page
	When I Login with Username 'luiza' and Password 'r5DAg97X' on the LoginPage
	Then the MainPage should be opened
	When I input well name '<wellName>' in Search field	
	Then I should see IntegritySummary tab opened
	And  '<wellName>' should be displayed as a link

@Browser:Chrome
Scenario: Input part of well name in Search field and wait for droplist with search suggestions
	Given I Navigate to the Login page
	When I Login with Username 'luiza' and Password 'r5DAg97X' on the LoginPage
	Then the MainPage should be opened
	When I input well name '<wellName>' in Search field	
	Then I should see droplist with search suggestions displayed