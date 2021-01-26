using NUnit.Framework;

namespace AngloAmericanTest.Utils
{
    /// <summary>
    ///  This class helps reading the setting file
    /// </summary>
    public class Helper
    {
        //Reading the Webdriver directory from run settings files
        public static string WebDriverDirectory = TestContext.Parameters.Get("WebDriverDirectory");
        //Reading the browser value from run settings files
        public static string GetBrowser = TestContext.Parameters.Get("Browser");
        //Reading the home page url from run settings files
        public static string GetUrl = TestContext.Parameters.Get("URL");
        //Reading the password from run settings files
        public static string GetPassword = TestContext.Parameters.Get("Password");
    }
}
