Feature: Login 
	Login to  Joe’s Pizza demo site



@mytag
Scenario: preform Login of Joe’s Pizza demo site 
	Given I lanunch the site 
	And I click login link 
	And I enter the following detals
		| UserName | password |
		| abdullah | 123      |
	And I click login boutton  
	Then go to dashebord 