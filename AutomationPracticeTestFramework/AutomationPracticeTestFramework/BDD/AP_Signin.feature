Feature: AP_Signin
As a registered user of the Automation Practice Website
Iwant to be able to sign in to my account
So that I can buy items

@sad
Scenario: Invalid password - too short
	Given I am on the signin page
	And I have entered the email "testing@snailmail.ccm"
	And I have entered the password <password>
	When I click the sign in button
	Then I should see an alert containing the error message "Invalid password"
	Examples:
	| password |
	| four     |
	| 1234     |
	| N        |

@sad
Scenario: Invalid email
	Given I am on the signin page
	And I have entered the email "testingsnailmail.com"
	And I have entered the password four
	When I click the sign in button
	Then I should see an alert containing the error message "Invalid email address"


@happy
Scenario: Navigate to signin page from home page
	Given I am on th home page
	And I have clicked the signin link
	Then I will be on the signin page

@sad
Scenario: Invalid email - empty
	Given I am on the signin page
	And I have entered the email ""
	And I have entered the password password
	When I click the sign in button
	Then I should see an alert containing the error message "An email address required"

@sad
Scenario: Invalid password - empty
	Given I am on the signin page
	And I have entered the email "testing@snailmail.ccm"
	And I have entered the password <password>
	When I click the sign in button
	Then I should see an alert containing the error message "Password is required"
Examples:
	| password |
	|          |