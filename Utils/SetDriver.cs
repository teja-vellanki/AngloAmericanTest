using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.Edge.SeleniumTools;

namespace AngloAmericanTest.Utils
{
    /// <summary>
    ///  This class performs an important function.
    /// </summary>
    public class SetDriver
    {
        public IWebDriver GetDriver(string browser)
        {
            switch (browser.ToLower())
            {
                //Using switch acase to run tests on specific browser
                case "chrome":
                    var chromeOptions = new ChromeOptions();
                    chromeOptions.AddArgument("--start-mazimised");
                    chromeOptions.AddArgument("--disable-notifications");
                    return new ChromeDriver(Helper.WebDriverDirectory, chromeOptions);
                case "edge":
                    EdgeOptions edgeOptions = new EdgeOptions();
                    edgeOptions.UseChromium = true;
                    return new EdgeDriver(Helper.WebDriverDirectory, edgeOptions);
                default:
                    return new ChromeDriver();
            }
        }
    }
}
