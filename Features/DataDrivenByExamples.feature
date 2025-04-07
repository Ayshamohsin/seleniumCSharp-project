Feature: DataDrivenByExamples

Testing feature with multiple test data inputs

@tag1
Scenario Outline: DataDrivenByExamples
	Given Enter the URL
	Then search with "<Enter search data>"
	Examples: 
	
	| Enter search data      |
	| Selenium Documentation |
	| Basics of .Net         |
	| Containernization      |


	
