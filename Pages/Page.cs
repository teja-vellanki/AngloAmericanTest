using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AngloAmericanTest.Pages
{
    public abstract class Page
    {
        protected readonly IWebDriver _driver;
        protected Page(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
