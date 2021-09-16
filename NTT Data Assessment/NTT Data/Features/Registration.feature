Feature: Registration
	Register as a Student

@smoke
Scenario: Valid Registration (Default)
	Given I Navigate to "https://demoqa.com/automation-practice-form"
	And I Enter a first name "bowale1"
	And I Enter a last name "nubi2"
	And I Enter my email "bowalenubi@gmail.com"
	And I Select male as gender
	And I Enter my mobile number "1234567892"
	#And I Enter my date of birth
	#And I Enter subjects
	#And I Select my hobby
	#And I Upload a picture
	#And I Enter my address
	#And I Select state and city
	When I Click submit
	Then I Should see a pop up showing all information that was sent



@smoke
Scenario: Valid Registration using female as the gender
	Given I Navigate to "https://demoqa.com/automation-practice-form"
	And I Enter a first name "bowale1"
	And I Enter a last name "nubi2"
	And I Enter my email "bowalenubi@gmail.com"
	And I Select female as gender
	And I Enter my mobile number "1234567892"
	When I Click submit
	Then I Should see a pop up showing all information that was sent



@smoke
Scenario: Valid Registration using more than 1 alpha numeric character in first and last name
	Given I Navigate to "https://demoqa.com/automation-practice-form"
	And I Enter a first name "bowale01"
	And I Enter a last name "nubi02"
	And I Enter my email "bowalenubi@gmail.com"
	And I Select male as gender
	And I Enter my mobile number "1234567892"
	When I Click submit
	Then I Should see a pop up showing all information that was sent





@smoke
Scenario: Registration using an invalid email
	Given I Navigate to "https://demoqa.com/automation-practice-form"
	And I Enter a first name "bowale01"
	And I Enter a last name "nubi02"
	And I Enter my email "bownub"
	And I Select male as gender
	And I Enter my mobile number "1234567892"
	When I Click submit
	#Then I Should not see the pop up message and error is displayed




@smoke	
Scenario: Registration using 9 digits in the mobile field
	Given I Navigate to "https://demoqa.com/automation-practice-form"
	And I Enter a first name "bowale01"
	And I Enter a last name "nubi02"
	And I Enter my email "bowalenubi@gmail.com"
	And I Select male as gender
	And I Enter my mobile number "123456789"
	When I Click submit
	#Then I Should not see the pop up message and error is displayed

