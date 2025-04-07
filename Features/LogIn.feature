Feature: LogIn Feature

Login To healthcare Application

@HealthCare
Scenario: Login to Application 
	Given open the browser
	And Navigate to Login Page 
	When User entered valid user id and password
	And Hit login button
	Then User should be redirected to the homepage



