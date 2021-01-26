using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using AngloAmericanTest.ObjectRepository;
using AngloAmericanTest.Utils;

namespace AngloAmericanTest.Pages
{
    public class RegisterPage 
    {
        private readonly SeleniumHelper _seleniumHelper;
        public RegisterPage(IWebDriver driver, SeleniumHelper seleniumHelper)
        {
            _seleniumHelper = seleniumHelper;
        }

        public void AccountRegistration()
        {
           
        }
    }
}
