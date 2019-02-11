Feature: guru99
	

@mytag
Scenario: Demo Guru 99
	Given I guru demo site
	When I enter credentials as 'mngr171499' & 'anugege'
	Then I should be logged in successfully
