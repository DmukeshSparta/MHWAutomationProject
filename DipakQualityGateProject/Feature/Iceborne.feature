Feature: Iceborne
       As a user i want to access iceborne offical site 
	   And access all the information relate to iceborne 

Scenario: Access iceborne offical site 
     Given I am on the Main-page
	 And I am on the iceborne homepage
	 And I click on consent messagebox
	 And I am on the EventQuest schedule 
	 When I am on the Master Rank
	 Then I should be able to see Event Schedule date