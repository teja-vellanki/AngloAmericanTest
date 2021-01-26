#Anglo American Tech Challenge - Quality Team

Hi,
Thanks for detailed description about the technical test. 

Below are the tools that i have used to setup a basic framework and write the tests
Specflow
Nunit
C#
Selenium

Framework: PageObject model with BDD

Few things i wanted to highlight to run the tests once you clone into your machine.

A. Please create a folder called "webdrivers" in C drive  and download chromedriver.exe and place it in below location
Webdrivers Location: C:\webdrivers

B. Configure local.runsettings file before executing the tests.

I generally don't include Drivers folder in my framework and push it to the git as it is not a good practise, but i have made an exception to include this time as you don't have to google to download(if it is not already installed).

All the project dependencies are included, however below is the list.
1. DotNetSeleniumExtras.WaitHelpers
2.Microsoft.Edge.SeleniumTools
3.Microsoft.Net.Test.sdk
4.Nunit
5.Nunit.Console
6.Nunit.ConsoleRunner
7.Nunit3TestAdapter
8.Selenium.Support
9.Selenium.Webdriver
10.Selenium.WebDriver.ChromeDriver
11.SpecFlow
12.Specflow.Nunit
13.Specflow.Tools.MsBuild.Generation