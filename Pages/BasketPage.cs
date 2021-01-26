using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using AngloAmericanTest.ObjectRepository;
using AngloAmericanTest.Utils;

namespace AngloAmericanTest.Pages
{
    public class BasketPage : BasketPageOR
    {

        private readonly SeleniumHelper _seleniumHelper;
        private readonly HomePage _homePage;
        public BasketPage(IWebDriver driver, SeleniumHelper seleniumHelper, HomePage homePage) : base(driver)
        {
            _seleniumHelper = seleniumHelper;
            _homePage = homePage;
        }

     
        public string GetBasketPrice()
        {
            return BasketUnitPrice.Text;
        }

       
    }
}
