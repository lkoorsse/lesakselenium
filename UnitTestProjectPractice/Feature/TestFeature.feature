Feature: TestFeature
	In order to get a successfull quote from GoCompare
	As a user  I am on the google website
	I want to input my car details


Scenario: Navigation
	Given I browse to  'http://www.gocompare.com'
	And I select get quote
	And I insert 'la03tvv'
	When I select find car
	Then the car reg is popolated into the reg field

