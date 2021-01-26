using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using AngloAmericanTest.ObjectRepository;
using AngloAmericanTest.Utils;

namespace AngloAmericanTest.Pages
{
    public class HomePage : HomePageOR
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly SeleniumHelper _seleniumHelper;
        public HomePage(IWebDriver driver, ScenarioContext scenarioContext, SeleniumHelper seleniumHelper) : base(driver)
        {
            _scenarioContext = scenarioContext;
            _seleniumHelper = seleniumHelper;
        }

        public IWebElement SaveMyPreferences => CookieOptions[0];
        public IWebElement AcceptAllCookies => CookieOptions[1];

        public IWebElement SignIn => HeaderProfileSignIn[0];
        public IWebElement Account => HeaderProfileAccount[0];
  

        public void EnterSearchValue(string searchValue)
        {
            SearchBar.SendKeys(searchValue);
        }

        public void SelectValueFromSearchSuggestions(string value)
        {
            SearchBar.SendKeys(Keys.ArrowDown);
            SearchBar.SendKeys(Keys.Escape);
        }

        public void ClickSearchButton()
        {
            SearchButton.Click();
        }

 

        public void ClickMyAccount()
        {
            Account.Click();
        }

        public void ClickOnBrandName()
        {
            FirstBrand.Click();
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
