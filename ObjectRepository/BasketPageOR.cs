using OpenQA.Selenium;
using AngloAmericanTest.Pages;

namespace AngloAmericanTest.ObjectRepository
{
    public class BasketPageOR : Page
    {
        public BasketPageOR(IWebDriver driver) : base(driver)
        { 
        }
        public IWebElement BasketUnitPrice
        {
            get { return _driver.FindElement(By.XPath("//*[@id='cart']/div/div[1]/table/tbody/tr[2]/td[4]")); }
        }

        public IWebElement TotalBasketValue
        {
            get { return _driver.FindElement(By.XPath("//*[@id='totals_table']/tbody/tr[3]/td[2]/span")); }
        }


    }
}
