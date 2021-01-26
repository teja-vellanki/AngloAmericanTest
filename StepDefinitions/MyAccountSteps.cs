using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using AngloAmericanTest.Pages;

namespace AngloAmericanTest.StepDefinitions
{
    [Binding]
    public class MyAccountSteps
    {
        private readonly ScenarioContext scenarioContext;
        private readonly MyAccountPage _myAccountPage;
        public IWebDriver _driver;
        private readonly HomePage homePage;
        private ToRentPage _toRentPage;

        public MyAccountSteps(MyAccountPage myAccountPage, HomePage homePage, ToRentPage toRentPage)
        {
            _myAccountPage = myAccountPage;
            this.homePage = homePage;
            _toRentPage = toRentPage;
        }


       


    }
}
