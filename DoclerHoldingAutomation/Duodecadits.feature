Feature: Duodecadits Functionality 
	In order to do my job
	As a User
	I want duodecadits.com web application to function properly

@mytag
Scenario: The title of every page in the application is "UI Testing Site"
	Given I Navigated to "http://uitest.duodecadits.com/"
	When I navigate to each page in the application
	Then the title of each page should be "UI Testing Site"

@mytag
Scenario: The Company logo is present  in each page
	Given I Navigated to "http://uitest.duodecadits.com/"
	When I navigate to each page in the application
	Then the company logo must be present

@mytag
Scenario: Clicking the home button redirects to the home page
	Given I Navigated to "http://uitest.duodecadits.com/"
	When I Click on the Home button
	Then I am redirected to the home page

@mytag
Scenario: Clicking the home button turns the home button active
	Given I Navigated to "http://uitest.duodecadits.com/"
	When I Click on the Home button
	Then the home button becomes active

@mytag
Scenario: Clicking the form button redirects to the form page
	Given I Navigated to "http://uitest.duodecadits.com/"
	When I Click on the Form button
	Then I am redirected to the Form page

@mytag
Scenario: Clicking the form button turns the form button active
	Given I Navigated to "http://uitest.duodecadits.com/"
	When I Click on the Form button
	Then the Form button becomes active

@mytag
Scenario: Clicking the error button gives an 404 HTTP response code
	Given I Navigated to "http://uitest.duodecadits.com/"
	When I Click on the Error button
	Then i get a 404 HTTP response code

@mytag
Scenario: Clicking the UI Testong button redirects to the home page
	Given I Navigated to "http://uitest.duodecadits.com/"
	When I Click on the UI Testing button
	Then I am redirected to the home page

@mytag
Scenario: The header of the Home Page should be Correct
	Given I Navigated to "http://uitest.duodecadits.com/"
	When I Click on the Home button
	Then the header of the page should be "Welcome to the Docler Holding QA Department"

@mytag
Scenario: The content message of the Home Page should be Correct
	Given I Navigated to "http://uitest.duodecadits.com/"
	When I Click on the Home button
	Then the content message of the page should be "This site is dedicated to perform some exercises and demonstrate automated web testing."

@mytag
Scenario: Form page contains one input box and one submit button
	Given I Navigated to "http://uitest.duodecadits.com/"
	When I Click on the Form button
	Then the form page opens and contains one input box and one submit button

@mytag
Scenario: Submiting the form in the form page redirects to the hello page which shows the correct output
	Given I Navigated to "http://uitest.duodecadits.com/"
	When  i submit the form with a name
	Then the hello page appears and it contains the name i submitted along side a hello message