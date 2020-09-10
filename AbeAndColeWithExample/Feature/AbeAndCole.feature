Feature: AbeAndCole
	In order to enjoy all the rewards
	I will need to register

@mytag
Scenario Outline: Data Driven With Example
	Given I navigate to "https://www.abelandcole.co.uk/SignUp"
	When I Accept cookies
	And I click on dropdown
	And I click on title
	And I enter first name "<Firstname>"
	And I enter last name "<Lastname>"
	And I enter email address "<Email>"
	And I enter password "<Password>"
	And I enter postcode "<Postcode>"
	And I click on find address
	And I select from the drop down
	And I select Address from drop down arrow
	And I enter where to leave box "<Porch>"
	And I enter contact number "<Contactnumber>"
	And I click on the drop downarrow
	And I click on how did you hear about us 
	And I click on vegetarian box
	And I click on hear news from us 
	And I click on complete sign up
	Then I am logged in with account showing 


	Examples: 

	| Firstname | Lastname | Email                | Password     | Postcode | Porch     | Contactnumber |
	| Dodo      | Lang     | langdodo | Adel0nd0n007 | SE181NR  | Frontdoor | 07811697974   |


	