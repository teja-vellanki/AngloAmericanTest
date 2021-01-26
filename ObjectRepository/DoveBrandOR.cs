using OpenQA.Selenium;
using System.Collections.Generic;

namespace AngloAmericanTest.ObjectRepository
{
    public class DoveBrandOR : HomePageOR
    {

        public DoveBrandOR(IWebDriver driver) : base(driver)
        {
        }

        public IList<IWebElement> ProductsInformation
        {
            get { return _driver.FindElements(By.CssSelector("[class='fixed'] a")); }
        }

        public IList<IWebElement> ProductPrices
        {
            get { return _driver.FindElements(By.CssSelector("[class='pricetag jumbotron'] [class='price'] [class='oneprice']")); }
        }

        public IWebElement AddFirstProductToBasket
        {
            get { return _driver.FindElement(By.CssSelector("[data-id='76'] i")); }
        }

        public IWebElement AddSecondProductToBasket
        {
            get { return _driver.FindElement(By.CssSelector("[data-id='75'] i")); }
        }


        public IWebElement AddThirdProductToBasket
        {
            get { return _driver.FindElement(By.CssSelector("[data-id='77'] i")); }
        }


    }
}
