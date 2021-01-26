using OpenQA.Selenium;

namespace AngloAmericanTest.Pages
{
    public abstract class Page
    {
        protected readonly IWebDriver _driver;
        protected Page(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
