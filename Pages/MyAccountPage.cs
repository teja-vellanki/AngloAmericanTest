using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using AngloAmericanTest.ObjectRepository;
using AngloAmericanTest.Utils;

namespace AngloAmericanTest.Pages
{
    public class MyAccountPage 
    {

        private readonly SeleniumHelper _seleniumHelper;
        private readonly HomePage _homePage;
        public MyAccountPage(IWebDriver driver, SeleniumHelper seleniumHelper, HomePage homePage)
        {
            _seleniumHelper = seleniumHelper;
            _homePage = homePage;
        }

   
    }
}
