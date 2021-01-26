using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AngloAmericanTest.Pages
{
    public class BasePage :Page
    {
        public BasePage(IWebDriver driver) : base(driver)
        { }

        ///<summary>
        ///Navigates to home page
        ///</summary>
        public void NavigateToHomePage(string url)
        {
            _driver.Navigate().GoToUrl(url);
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = new TimeSpan(0,0,30);
            Console.WriteLine("::Navigate to " + url);
        }
    }
}
