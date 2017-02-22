Feature: login2	
	In order to browse the site
	As an user
	I will be able to login using credentials 

@mytag
Scenario Outline: login using credentials	
	Given I am on the Login page 
	And I have entered <usernamelogin> and <passwordlogin> in textboxes	
	When I press login button
	Examples:
| usernamelogin   | passwordlogin |
| msantiagopcp2 | TestPassword1! |
    

