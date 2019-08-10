Feature: Login
	In order to view information about well
	As a user
	I want to be able to login to MainPage

@Browser:Chrome
Scenario: Successfull Login
	Given I Navigate to the Login page
	When I Login with Username 'luiza' and Password 'r5DAg97X' on the LoginPage
	Then the MainPage should be opened

	
@Browser:Chrome
Scenario Outline: Unsuccessfull Login
    Given I Navigate to the Login page
	When I Unsucessfully Login with Username '<username>' and Password '<password>' on the Login Page
	Then I Should See Error Message '<errorMsg>' on the Login Page

Examples: 
 | name             | username | password | errorMsg                                                 |
 | Blank Username   |          | r5DAg97X | User name is required                                    |
 | Blank Password   | luiza    |          | Password is required                                     |
 | invalid Password | luiza    | $%GGH    | Your login attempt was not successful. Please try again. |
 | invalid username | 66987    | r5DAg97X | Your login attempt was not successful. Please try again. |

