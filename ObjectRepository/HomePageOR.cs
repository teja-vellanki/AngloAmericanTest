using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using AngloAmericanTest.Pages;

namespace  AngloAmericanTest.ObjectRepository
{
    public class HomePageOR : Page
    {
        public HomePageOR(IWebDriver driver) : base(driver)
        { }

        public IList<IWebElement> ListOfBrands
        {
            get { return _driver.FindElements(By.CssSelector("[id='brandcarousal'] li div a img")); }
        }

        public IWebElement FirstBrand
        {
            get { return _driver.FindElement(By.CssSelector("[id='brandcarousal'] li")); }
        }

        public IWebElement SearchBar
        { 
            get { return _driver.FindElement(By.Id("search-input-location")); } 
        }

        public IWebElement SearchButton
        {
            get { return _driver.FindElement(By.Id("search-submit")); }
        }
        
    }
}
