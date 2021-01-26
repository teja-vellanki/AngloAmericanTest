using OpenQA.Selenium;
using AngloAmericanTest.Pages;

namespace AngloAmericanTest.ObjectRepository
{
    /// <summary>
    ///  This is the object repository for Basket Page
    /// </summary>
    public class BasketPageOR : Page
    {
        public BasketPageOR(IWebDriver driver) : base(driver)
        { 
        }
        
        //
        public IWebElement BasketUnitPrice
        {
            //Returns the element from the product added in the basket
            get { return _driver.FindElement(By.XPath("//*[@id='cart']/div/div[1]/table/tbody/tr[2]/td[4]")); }
        }

        public IWebElement TotalBasketValue
        {
            //Returns the element from the total basket value
            get { return _driver.FindElement(By.XPath("//*[@id='totals_table']/tbody/tr[3]/td[2]/span")); }
        }


    }
}
