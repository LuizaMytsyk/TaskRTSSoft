Feature: HeaderFluentNavigation
	In order to navigate to pages
	As a user
	I want to open pages using buttons in header menu

@Browser:Chrome
Scenario: Header panel is displayed on HomePage
	Given I Navigate to the Login page
	When I Login with Username 'luiza' and Password 'r5DAg97X' on the LoginPage
	Then the MainPage should be opened
	And Header panel is displayed
	
@Browser:Chrome
Scenario: HomePage is opened when clicking 'Home' button on Header panel
	Given I Navigate to the Login page
	When I Login with Username 'luiza' and Password 'r5DAg97X' on the LoginPage
	Then the MainPage should be opened
	And Header panel is displayed
	When I input well name '<wellName>' in Search field	
	Then I should see IntegritySummary tab opened
	When I click on Home button
	Then the MainPage should be opened

@Browser:Chrome
Scenario: HomePage is opened when clicking Header Logo on Header panel
	Given I Navigate to the Login page
	When I Login with Username 'luiza' and Password 'r5DAg97X' on the LoginPage
	Then the MainPage should be opened
	And Header panel is displayed
	When I input well name '<wellName>' in Search field	
	Then I should see IntegritySummary tab opened
	When I click on Header logo
	Then the MainPage should be opened