using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using AngloAmericanTest.ObjectRepository;

namespace AngloAmericanTest.Pages
{
    public class HomePage : HomePageOR
    {
 
        public HomePage(IWebDriver driver) : base(driver)
        {

        }

        public void ClickOnBrandName(string brandname)
        {
            IList<IWebElement> _listofbrands = ListOfBrands;
            foreach (IWebElement element in _listofbrands)
            {
                if(element.GetAttribute("alt")==brandname)
                {
                    element.Click();
                    break;
                }
            }

        }

        public string[] ReadAllBrandNames()
        {
            IList<IWebElement> _listofbrands = ListOfBrands;

            String[] allBrands = new String[_listofbrands.Count];
            int i = 0;
            foreach (IWebElement element in _listofbrands)
            {
                allBrands[i++] = element.GetAttribute("alt");
            }

            return allBrands;
        }
    }
}
