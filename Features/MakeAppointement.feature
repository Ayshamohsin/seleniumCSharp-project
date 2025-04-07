Feature: Appointment Creation

Create an Appointment
Background: 
  Given the user logs in with "user_id" and "password"

@Appointment
Scenario: Successfull appointment creation
  
	When  User creats an appointment with:
    | Facility                        | Date       | Comments             |
    | Seoul CURA Healthcare Center    | 2021-01-20 | We are new patients   |
    | Hongkong CURA Healthcare Center | 2023-02-02 | I am not new patient |
	Then the appointment should be created successfully





    
    Scenario: Successfully appointment creations
  
	When  User created an appointment with:
    | Facility                     | Date       | Comments           |
    | Seoul CURA Healthcare Center | 2021-03-20 | We are not new patients |
    
	Then  Appointment should be created successfully
   
    

    








