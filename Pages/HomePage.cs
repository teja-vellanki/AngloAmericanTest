using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using AngloAmericanTest.ObjectRepository;

namespace AngloAmericanTest.Pages
{
    /// <summary>
    ///    This class has all the page actions of Home Page
    /// </summary>
    public class HomePage : HomePageOR
    {
 
        public HomePage(IWebDriver driver) : base(driver)
        {

        }

        //This method clicks and reaches the specific brand page
        public void ClickOnBrandName(string brandname)
        {
            // Collection to read all the brands
            IList<IWebElement> _listofbrands = ListOfBrands;
            //Running the loop and writing condition to select the expected brand
            foreach (IWebElement element in _listofbrands)
            {
                if(element.GetAttribute("alt")==brandname)
                {
                    element.Click();
                    break;
                }
            }

        }


        //This method returns all the brand names
        public string[] ReadAllBrandNames()
        {
            // Collection to read all the brands
            IList<IWebElement> _listofbrands = ListOfBrands;

            String[] allBrands = new String[_listofbrands.Count];
            int i = 0;
            //Running the loop to collect all the brand in the list
            foreach (IWebElement element in _listofbrands)
            {
                allBrands[i++] = element.GetAttribute("alt");
            }
            //Returns all the brand names
            return allBrands;
        }
    }
}
