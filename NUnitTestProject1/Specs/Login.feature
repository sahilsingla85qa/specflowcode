Feature: Login
	In order to browse the site
	As an user
	I will not be able to login using wrong credentials 

@mytag
Scenario: check the login functionality with invalid credentials
	Given I am on the Login page
	And Enter wrong username and password 
	When I press login button
	Then the result should be validation message
