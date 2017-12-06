Feature: FeatureTwoPOM
In order to get a successfull quote from GoCompare
	As a user  I am on the gocompare website
	I want to submit my car details 


Scenario: 02TestFeatureTwo1
	Given I am at 'https//www.google.co.uk' website
	And I browse to website 'gocompare' 
	And I select get quote button
	And I insert 'la03tvv' into car reg field
	When I select find car button 
	Then the car reg field is popolated into the reg field

	When I complete all mandatory radio buttons to Yes
	And I complete purchased car month '08' and year '2003'
	And I select for use of car dropdown 'Business use by you'
	And I select 'ON A DRIVEWAY' button
	And select for total annual milage dropdown 'More than 50 000'
	And for first name insert 'John' and Surname 'Doe'
	And for Date of birth Day '01 month '08' year '1988'
	And insert e-mail adress 'john@doe.com'
	Then the email adress should contain 'john@doe.com'
