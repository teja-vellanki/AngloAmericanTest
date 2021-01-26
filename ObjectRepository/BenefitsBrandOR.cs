using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AngloAmericanTest.ObjectRepository
{
    public class BenefitsBrandOR : HomePageOR
    {
        public BenefitsBrandOR(IWebDriver driver) : base(driver)
        { 
        }

        public IWebElement SaleProductNewPrice
        {
            get { return _driver.FindElement(By.CssSelector("[class='price'] [class='pricenew']")); }
        }

        public IWebElement SaleProductOldPrice
        {
            get { return _driver.FindElement(By.CssSelector("[class='price'] [class='priceold']")); }
        }

        public IWebElement ProductAddToBasket
        {
            get { return _driver.FindElement(By.CssSelector("[data-id='51'] i")); }
        }

        public IWebElement Basket
        {
            get { return _driver.FindElement(By.CssSelector("[data-id='menu_cart']")); }
        }

        public IWebElement Search
        {
            get { return _driver.FindElement(By.Id("search-submit")); }
        }

        public IWebElement ResultsTitle
        {
            get { return _driver.FindElement(By.CssSelector("h1[data-testid='results-title']")); }
        }

        public IList<IWebElement> SideSearchBar
        {
            get { return _driver.FindElements(By.CssSelector("aside[data-testid='search-sidebar'] div a")); }
        }
        
    }
}
