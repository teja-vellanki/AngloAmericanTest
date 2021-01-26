using OpenQA.Selenium;
using System.Collections.Generic;
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
        
    }
}
