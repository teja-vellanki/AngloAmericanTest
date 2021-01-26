using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.Edge.SeleniumTools;

namespace AngloAmericanTest.Utils
{
    public class SetDriver
    {
        public IWebDriver GetDriver(string browser)
        {
            switch (browser.ToLower())
            {
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
