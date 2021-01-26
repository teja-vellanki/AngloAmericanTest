# Zoopla Tech Challenge - Quality Team

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












Welcome!

Thank you again for considering Zoopla for the next stage of your career. This tech challenge is designed as a chance for you to show us what you can do.

We appreciate that you are taking time out of your schedule to do this, and we thank you and promise to give you feedback on your submission.

If you run out of time, first of all don’t panic. Secondly, just let us know what you would have done next or differently if you’d had more time.

This test is designed for us to get an insight into how you think, work, and what you’re comfortable with. We believe everyone and everything can always improve, so if you have any feedback for us on this challenge, please do share it. :) 

## The Challenge
Your task, should you choose to accept it, is to create a basic automation suite to verify several user journeys on the  [zoopla.co.uk](http://zoopla.co.uk/)  site, and then submit a PR to this repo as if it was part of your day to day work here at Zoopla.

The user journeys we would like you to automate are:
- Register for daily email updates on rental property in London for 1 bed properties between £800 and £1000 per month
- Change the frequency of an existing email update
- Search for a particular property in the house prices search and confirm that it appears as the first result
- Search houses for sale including the key word “garage” and check that results have garages
- Save a search for property within 15 minutes drive of SE1 2LH.
- Check that saved searches can be retrieved

> NOTE: Please ONLY submit the forms _required_ for this technical test.

Zoopla's core languages are:
- JavaScript
- Python

We are also migrating our End-to-End automated regression suite to Cypress.

Please don’t feel you *must* use the languages above, or Cypress to complete this challenge; we'd rather see an excellent solution which suitably demonstrates your skillset.

The challenge should take no longer than 2 hours, so please prioritise your effort to focus on the most important pages, and try and limit yourself to this timeframe.

Thank you, and good luck!

The Zoopla Quality Team

