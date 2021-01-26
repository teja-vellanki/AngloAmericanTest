using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace AngloAmericanTest.Utils
{
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
        public void SelectValueFromDropDownAsText(IWebElement element, string value)
        {
            var selectElement = new SelectElement(element);
            selectElement.SelectByText(value);
        }

        public void SelectValueFromDropDownAsIndex(IWebElement element, int value)
        {
            var selectElement = new SelectElement(element);
            selectElement.SelectByIndex(value);
        }

        public int GetRandomNumber()
        {
            Random random = new Random();
            return random.Next(1, 5000000);
        }

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
