# Webiste Automation Project
Testing the Website: https://www.monsterhunterworld.com/

## Table of contents
* [General info](#general-info)
* [Prerequisites](#Prerequisites)
* [Setup](#setup)
* [NuGet Packages](#Nuget-Packages)
* [Running the tests](#Running-the-tests)
* [Implementation](#Implementation)
* [Built With](#Built-With)

## Getting Started
These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system.

## General info
The project was based on website automation, as group we spilt the into 3 different group with each objectives: navigation, purchasing and account). our Group was to suppose to work on purchasing objectives. 

Group: Dipak Mukesh, Brandon Stephens, Cosmin Balosache, Nazir Ahmed and Norberta Balaisyte

## Prerequisites
What things you need to install the software and how to install them
```
Website - testing automation:  http://automationpractice.com/index.php
Gitbash - Create or Clone the Repository: https://www.github.com/
Visual Studio - Run the application: https://visualstudio.microsoft.com/downloads/ 
Trello - Trello is a task management app: https://trello.com/b/L3MpJ20m/automation-practice
Selenium WebDriver - WebDriver is a web automation framework: https://www.seleniumhq.org/projects/webdriver/
SpecFlow with Gerkin - Use SpecFlow to define, manage and automatically execute human-readable acceptance tests in .NET projects: 
https://specflow.org/
```

## Setup
A step by step series of examples that tell you how to get a website automation environment running
```
1) Open the Visual Studio
2) Create Class Library project
3) Add NuGet packages (See NuGet section)
4) Add 3 folders: Feature, Pages and Steps
5) Inside Feature folder: add SpecFlow features
6) Inside Pages folder: Website pages 
7) Inside Steps folder: Generate step definitions (check step 5) and save to this folder.
```

## NuGet Packages
NuGet packages used in this project
```
NUnit - NUnit is a unit-testing framework for all .Net languages with a strong TDD focus.
NUnit3TestAdapter - NUnit 3 adapter for running tests in Visual Studio.
RestSharp - Simple REST and HTTP API Client
Gherkin - Cross-platform parser for the Gherkin language, used by SpecFlow
Selenium.Support - Provides support classes for selenium webdriver 
Selenium.Webdriver - .Net bindings for the Selenium WebDriver API
Selenium.Webdriver.Chrome - Selenium Google Chrome driver 
Selenium.WebDriverBackedSelenium - implementation of the selenium remote control, API
SpecFlow - communication gap between domain experts and developers
SpecFlow.Runner - support SpecRun.runner and SpecRun.Nunit
SpecRun.SpecFlow.3-0-0 - smarter integration test runner for SpecFlow
```

## Running the tests
Step by Step for running the tests:
* Clone this git repository
* Open Engineering40AutomationPracticeProject.sln
* Click on View -> Solution Explorer or to view the Solution Explorer
* Build the project by clicking on Build -> Build Solution on the menu
* Right click on the solution to Restore NuGuet Packges
* Click on Test -> Windows -> Test Explorer to view the test window
* Click on the run all button to run all the tests or run selected button to specific selected tests in the Test Explorer
* Below show the example of tests. 

![Tests]( "Example of test result")

```C#
Example of Test written

```

```SpecFlow

```

## Implementation
```
1) Go to the website.
2) Write User stories based on the website on the trello.
3) Follow Steps section 
4) Process of testing a feature
   4.1) create SpecFlow.Feature file inside feature folder
   4.2) convert the user story into Gherkin syantax inside first created in 4.1
   4.3) create two c# file for homepage and feature page (e.g product) inside page folder
   4.4) homepage and feature page uses Selenium NuGet package to call the web driver, locating and manipulating 
        elements within a browser
   4.5) Generate step definitions from feature file and save to Step folders 
   4.6) Inside step folder, use Generate step file (e.g AddToChartSteps) for writing the automation test 
   4.7) inside step file, use Selenium chrome driver to communicate with goolge chrome, NUnit framework to
        write the test.
```

## Built With
```
selenium - testing the website 
specflow - writing scenario in Ghrekin 
trello - create user stories with scrum artifact
Gitbash - create, push, commit and pull Git Repository
Visual Studio - Create the project 
```
