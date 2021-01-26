using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using AngloAmericanTest.ObjectRepository;
using AngloAmericanTest.Utils;

namespace AngloAmericanTest.Pages
{
    public class ToRentPage
    {
        private readonly SeleniumHelper _seleniumHelper;
        private readonly HomePage _homePage;
        public ToRentPage(IWebDriver driver, SeleniumHelper seleniumHelper, HomePage homePage)
        {
            _seleniumHelper = seleniumHelper;
            _homePage = homePage;
        }

       
    }
}
