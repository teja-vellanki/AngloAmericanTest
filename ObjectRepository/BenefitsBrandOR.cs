using OpenQA.Selenium;

namespace AngloAmericanTest.ObjectRepository
{
    /// <summary>
    ///  The is the object repository for Benefits Brand page
    /// </summary>
    public class BenefitsBrandOR : HomePageOR
    {
        public BenefitsBrandOR(IWebDriver driver) : base(driver)
        { 
        }

        public IWebElement SaleProductNewPrice
        {
            //Returns the sale price of the product 
            get { return _driver.FindElement(By.CssSelector("[class='price'] [class='pricenew']")); }
        }

        public IWebElement SaleProductOldPrice
        {
            //Returns the original price of the product 
            get { return _driver.FindElement(By.CssSelector("[class='price'] [class='priceold']")); }
        }

        public IWebElement ProductAddToBasket
        {
            //Returns Add to basket element
            get { return _driver.FindElement(By.CssSelector("[data-id='51'] i")); }
        }

        public IWebElement Basket
        {
            //Returns the element Basket
            get { return _driver.FindElement(By.CssSelector("[data-id='menu_cart']")); }
        }
        
    }
}
