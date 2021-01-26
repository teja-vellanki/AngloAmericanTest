using OpenQA.Selenium;
using System.Collections.Generic;
using AngloAmericanTest.Pages;

namespace  AngloAmericanTest.ObjectRepository
{
    /// <summary>
    ///   The is the object repository for Home page
    /// </summary>
    public class HomePageOR : Page
    {
        public HomePageOR(IWebDriver driver) : base(driver)
        { }

 
        public IList<IWebElement> ListOfBrands
        {
            // Returns all elements from the brand image carousel
            get { return _driver.FindElements(By.CssSelector("[id='brandcarousal'] li div a img")); }
        }
        
    }
}
