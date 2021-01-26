using BoDi;
using OpenQA.Selenium;
using System;
using System.Diagnostics;
using TechTalk.SpecFlow;
using AngloAmericanTest.Utils;

namespace AngloAmericanTest
{
    [Binding]
    /// <summary>
    ///  This class performs and helps as Hooks to drive before and after scenario
    /// </summary>
    public class TestRunContext : Steps
    {
        private IWebDriver _driver;
        private readonly IObjectContainer _container;
        private readonly SetDriver _setDriver;

        public TestRunContext(IObjectContainer container, SetDriver setDriver)
        {
            _container = container;
            _setDriver = setDriver;
        }

        //Before scenario hook to set up browser and set default timeout
        [BeforeScenario]
        public void BeforeScenario()
        {
            _driver = _setDriver.GetDriver(Helper.GetBrowser);
            _container.RegisterInstanceAs(_driver);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        //After scenario hook to dispose the driver after scenario
        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Close();
            _driver.Dispose();
            try
            { KillProcess("chromedriver.exe"); }
            catch
            { KillProcess("chromedriver.exe"); }
        }

        public void KillProcess(string processName)
        {
            foreach (var process in Process.GetProcessesByName(processName))
            {
                process.Kill();
            }
        }
    }
}
