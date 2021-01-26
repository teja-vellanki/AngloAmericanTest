using NUnit.Framework;

namespace AngloAmericanTest.Utils
{
    public class Helper
    {
        public static string WebDriverDirectory = TestContext.Parameters.Get("WebDriverDirectory");
        public static string GetBrowser = TestContext.Parameters.Get("Browser");
        public static string GetUrl = TestContext.Parameters.Get("URL");
        public static string GetPassword = TestContext.Parameters.Get("Password");
    }
}
