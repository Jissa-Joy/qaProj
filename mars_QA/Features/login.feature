Feature: login
	Simple calculator for adding two numbers

@mytag


Scenario: Successful Login with valid Credentials
	Given user is on home page
	When user clicks Signin
	Then  user enters 'jisaelza@gmail.com' and 'EA6qqHxnsrJv6HF'
	And  user clicks on login
	Then login should be successful
	