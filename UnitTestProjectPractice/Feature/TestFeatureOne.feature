Feature: TestFeatureOne
	In order to get a successfull quote from GoCompare
	As a user  I am on the gocompare website
	I want to submit my car details 


Scenario: 01TestFeatureOne
	Given I browse to  'http://www.gocompare.com'
	And I select get quote
	And I insert 'la03tvv'
	When I select find car
	Then the car reg is popolated into the reg field

