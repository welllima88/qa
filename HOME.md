#SCS Test Automation-Solution
Contains all files and sources for launching the test automation.
Cooding Guidelines
http://dgi.six-group.net/confluence/display/CardsBO/%28Secure%29+Coding+Guidelines

##Build Server

###Folder structure
Files are expected to be present in this folder because they are used for:
	• SeleniumServer jar-file, which is used to launch grid server and nodes
	• Browser driver are used for the nodes
	• The firefox binary is located there to have a reliable version of firefox availble
		○ Firefox has increased the rate release cycles that development of Selenium often can not follow
		○ Somer version had serious problems. A node is able to use explicitly this (last) stable version
	• The Firefox profile s might be used, but this point is still unclear due to the development of Selenium
		○ It contains a profile for Authentication with
			- Certificate
			- And a very plain default profile
		○ Better way is to inject a profile with its configuration programatically

##Teamcity
There are three projects in Teamcity for the test automation solution
	• CI
		○ Continous Integration, where code is taken from GIT and compiled after pushing commits
	• Smoke Test
		○ Builds the SmokeTest.csproj
		○ Executes a kind of health check
		○ No changes
	• Regression Test
		○ Builds the SystemTest.csproj
		○ Executes an overall system check
		○ A complete structure is created, modified and in some cases deleted

##Repository with GIT

###Sources
The sources are under version control with GIT under the following link:
https://mdzhwcdev01:8443/summary/scs%2Fqa.git

ssh://siegmund@mdzhwcdev01:8022/scs/qa.git
https://siegmund@mdzhwcdev01:8443/r/scs/qa.git

###Workflow in GIT
It is good practis to have to permanent branches (at least)

master
It has the stable version of the solution which contains tests *ready* for development environment at least.
The build Server will use this branch to execute regulary tests.
The point of a develop branch will be *merged* into the master as soon as it is ready for use.

develop
This is the more dynamic branch where tests can be *developed* independently and *comitted* to.

*features*
There can be branches for (larger) features (like ArticleChange in picture below)  to keep even the development branch plain.

#Web UI Testing
Executes tests via local or grid execution.

##Selenium
Useful links:
http://docs.seleniumhq.org/
http://www.seleniumwiki.com/
http://code.google.com/p/selenium/wiki/Grid2
http://www.seleniumtests.com/

###Locator
Default locators are 'By.Id' and 'By.CssSelector'

##Selenium Grid
The Selenium Grid is used for isolated and scalable testing.

#Build Server
The grid with its nodes on the build server is the main entry point for test automation

pro:
	• Dedicated server
	• Very isolated so execution of tests is not influenced by user input
	
drawback:
	• Good for debugging

#Local
It is recommended to set up a local grid with nodes.

pro:
	• Primär: debuggen, da die GUI ersichtlich ist
	• das GRID anders konfigurieren
	• Ausführung ohne Netzwerkprobleme
	• Zusätzliche Browser testen
	
drawback:
	• Execution can be influenced by user inputs in some cases which leads to failed tests

##Tasks
The grid and the nodes are started by Windows Task-Scheduler and there are two tasks for starting them:
	• a grid server
	• nodes which connect to the grid server
	• The tasks are executed on system startup (independently if a user has logged in already or not)

##Firefox
Firefox is the standard browser for automated testing with Selenium, because it is supported per default when running locally and easy to configure the node for grid.

###Example for node configuration
start java -jar D:\SeleniumGrid\selenium-server-standalone.jar -role node -hub http://localhost:4488/grid/register -port 5555 -browser "browserName=firefox,version=23.0.1,firefox_binary=D:\git\ScsDev\QA\Tests\Selenium\Solution\SeleniumSolution\Browser\Firefox\firefox.exe ,maxInstances=3, platform=WINDOWS"

###Profile

###Problems:
	• Different behavior when running locally or on a grid
	• User-Profile with grid:
		○ Certifacte
		○ Seems that it can not be solved  programmatically
	• Release cycles are very short 
		○ the selenium project often can not follow
		○ Problems with new versions
		○ Can be solved by using a fix version which is easy to manage with grid


##Architecture (Software)
###Infrastructure
	• encapsulates the selenium webdriver
		○ other projects should not use Selenium package directly except SCSPlatin
	• WebElements (helpers) which arent supported per default by Selenium (Checkbox, Textbox, Textarea, ..)
	• Defines Authentication modes and it UIs
	• Defines TestEnvironments

###Application
	• TestData object contain only the data (for Cusomers, Location, Terminals ..)
	• SCS Platin represents necessary UI elements (Buttons, Textsfields, Labels, Lists ..)
	• Basic Workflows which represent (basic) flows of user input, without checking anything
	• Testlogic uses workflows with some additional procedure and does mainly checks on th UI elements compared with the data objects
###Tests
	• Contains concrete tests
	• Outlined are Smoke Tests and Regressiontests
	• Smoke Test 
		○ is regulary executed 
		○ does neither create objects nor modification
	• Regression Test
		○ More complex
		○ Create typical structures (Customer with Locations, Terminals with Brands, Users just to mention some) the steps are usually the precondtion for the next actions and tests

##Regression Test

##SmokeTest

##Test Launcher
Sets globally the environment and starts a webdriver instance for one test project (namespace)
###Set Environment 
	• Base URL
	• Authentication (UAC, WES)
	• Application
	• Timeouts

###Authentication
Mainly the UAF Authentication method is used for login.

###Prepare Browser
	• Selenium GRID URL (remote)
	• Otherwise Firefox (local )

#Creating a Test
There are basically two ways to create a test:
Either start with abstracting the objects from the UI and use them for tests or vice versa create the test complete the necessary workflow and objects.

##bottom up
means first creating the interactably elements
	1. create objects
		- UI elements
		- Data objects
		- Factories
	2. Define
		- Workflow
		- Test Logic with it checks
	3. Add Test to (existing/new) Project
		- Define test steps

##top down
means first creating a test and build up all necesseray elements
	1. Create Test in Project
		- Be sure a Test Lauchner exists for this namespace
	2. Define Steps in Test
	3. Define Testlogic
		- Make use of Workflows or complex Builders
		- Implement checks in Testlogic or Builders
	4. Create
		- UI elements
		- Data objects (if not in Builders)

#SCS preparation
Some preparation need to be done in the Service Center System to allow automated testing. The most important point is to have a user account configured.

##User
For testing a user must be present. Be aware that executing tests in parallel with them user can cause side effects. This can happen because histories or last elements are changed by open an object already.

###Admin User
For smoke and regression tests an admin user **six_scs_auto** is used.
Roles:
	• SCS Administrator

Services:
	• SCS- acquirer		alle Acquirer
	• SCS- supplier		alle Supplier
	• SCS- ticket		Alle Tickets
	• SCS				Entwicklung SCS erweitert
	• SCS2.0			SCS2 Dummy
	• _Analyzer (not necessary for now)_

WES-Mandant:
	• TKCPOS(L/K)

###Restricted User
_open point_

#COI
This automation is due

#Markdown
https://guides.github.com/features/mastering-markdown/
https://help.github.com/articles/github-flavored-markdown/