Feature: DataDriven Testing

Data Driven Testing by applying different methods
Background: 
Given the user logs in for datadriven with "user_id" and "password"

@tag1
Scenario: Testing by passing data from steps
	Then user entered the data 'I AM NOT A NEW PATIENT'
