using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AngloAmericanTest.Utils
{
    /// <summary>
    ///  This class has all the selenium helper actions
    /// </summary>
    public class SeleniumHelper
    {
        public readonly IWebDriver _driver;
        public static void DelayTime(int time)
        {
            Task t = Task.Run(() =>
            {
                Task.Delay(time).Wait();
                Console.WriteLine("Task ended delay..");
            });
        }

        //This method helps to select from the drop down list using value
        public void SelectValueFromList(IList<IWebElement> element, string value)
        {
            foreach (var item in element)
            {
                if (item.Text == value)
                {
                    item.Click();
                    break;
                }
            }
        }

        //This method helps to select from the drop down list using text
        public void SelectValueFromDropDownAsText(IWebElement element, string value)
        {
            var selectElement = new SelectElement(element);
            selectElement.SelectByText(value);
        }

        //This method helps to select from the drop down list using index
        public void SelectValueFromDropDownAsIndex(IWebElement element, int value)
        {
            var selectElement = new SelectElement(element);
            selectElement.SelectByIndex(value);
        }

        // //This method helps to wait until the expected condition is met
        public bool WaitForElementToBeDisplayed(IWebElement element, string objectName)
        {
            try
            {
                var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
                return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element)).Displayed;
            }
            catch
            {
                return false;
            }
        }
    }
}
