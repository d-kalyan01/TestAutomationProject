Feature: RegisterForm

@Register
Scenario: Register to the application
	Given Open the browser
	When Navigate to URL
	And Click on Register Menu
	And Enter First Name as Kalyan
	And Enter Last Name as Deshpande
	And Enter Email as kalyan01@gmail.com
	And Enter Password as kalyan@456
	And Enter Confirm Password as kalyan@456 
	And Click on Register Button
	Then Message is displayed as Thank you for registering with Main Website Store.