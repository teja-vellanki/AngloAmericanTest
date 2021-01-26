using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using AngloAmericanTest.Pages;
using AngloAmericanTest.Utils;

namespace AngloAmericanTest.StepDefinitions
{
    [Binding]
    public class ToRentSteps
    {
        private readonly ToRentPage _toRentPage;
        public IWebDriver _driver;
        private readonly HomePage homePage;
        private readonly RegisterPage _registerPage;
        private readonly SeleniumHelper _seleniumHelper;
        private readonly MyAccountPage _myAccountPage;
        
        public ToRentSteps(ToRentPage toRentPage, HomePage homePage, RegisterPage registerPage, SeleniumHelper seleniumHelper, MyAccountPage myAccountPage)
        {
            _toRentPage = toRentPage;
            this.homePage = homePage;
            _registerPage = registerPage;
            _seleniumHelper = seleniumHelper;
            _myAccountPage = myAccountPage;
        }

      
    }
}
