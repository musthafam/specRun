Feature: ExampleKeyword
	
@mytag
Scenario Outline: Example Keyword
	Given I am on guru demo site
	When I enter <username> and <password>
	Then I should be logged in successfully.

Examples:
| username   | password |
| mngr178148 | nenYmej  |
