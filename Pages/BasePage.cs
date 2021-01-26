using OpenQA.Selenium;
using System;

namespace AngloAmericanTest.Pages
{
    /// <summary>
    ///  This class performs an important function.
    /// </summary>
    public class BasePage :Page
    {
        public BasePage(IWebDriver driver) : base(driver)
        { }

        ///<summary>
        ///Navigates to home page
        ///</summary>
        public void NavigateToHomePage(string url)
        {
            //Navigate to the URL
            _driver.Navigate().GoToUrl(url);
            //Maximize the Windiws
            _driver.Manage().Window.Maximize();
            //Setting default wait time of 30 seconds 
            _driver.Manage().Timeouts().ImplicitWait = new TimeSpan(0,0,30);
            Console.WriteLine("::Navigate to " + url);
        }
    }
}
