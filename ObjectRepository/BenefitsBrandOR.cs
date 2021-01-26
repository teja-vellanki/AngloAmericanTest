using OpenQA.Selenium;

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
        
    }
}
