using OpenQA.Selenium;
using System.Collections.Generic;

namespace AngloAmericanTest.ObjectRepository
{
    /// <summary>
    ///  The is the object repository for Dove Brand page
    /// </summary>
    public class DoveBrandOR : HomePageOR
    {

        public DoveBrandOR(IWebDriver driver) : base(driver)
        {
        }

        public IList<IWebElement> ProductsInformation
        {
            //Returns all the title elements of all product titles in the DOVE brand page 
            get { return _driver.FindElements(By.CssSelector("[class='fixed'] a")); }
        }

        public IList<IWebElement> ProductPrices
        {
            //Returns all the title elements of all product prices in the DOVE brand page 
            get { return _driver.FindElements(By.CssSelector("[class='pricetag jumbotron'] [class='price'] [class='oneprice']")); }
        }

        public IWebElement AddFirstProductToBasket
        {
            //Returns Element of first product to add to basket
            get { return _driver.FindElement(By.CssSelector("[data-id='76'] i")); }
        }

        public IWebElement AddSecondProductToBasket
        {
            //Returns Element of second product to add to basket
            get { return _driver.FindElement(By.CssSelector("[data-id='75'] i")); }
        }


        public IWebElement AddThirdProductToBasket
        {
            //Returns Element of third product to add to basket
            get { return _driver.FindElement(By.CssSelector("[data-id='77'] i")); }
        }


    }
}
