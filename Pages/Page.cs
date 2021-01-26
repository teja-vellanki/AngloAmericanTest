using OpenQA.Selenium;

namespace AngloAmericanTest.Pages
{
    /// <summary>
    ///   This class is the base page to invoke driver
    /// </summary>
    public abstract class Page
    {
        protected readonly IWebDriver _driver;
        protected Page(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
