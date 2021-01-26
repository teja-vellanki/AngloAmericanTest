using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using AngloAmericanTest.ObjectRepository;
using AngloAmericanTest.Utils;

namespace AngloAmericanTest.Pages
{
    public class BenefitsBrandPage : BenefitsBrandOR
    {

        private readonly SeleniumHelper _seleniumHelper;
        private readonly HomePage _homePage;
        public BenefitsBrandPage(IWebDriver driver, SeleniumHelper seleniumHelper, HomePage homePage) : base(driver)
        {
            _seleniumHelper = seleniumHelper;
            _homePage = homePage;
        }

        public string GetTitle()
        {
            var title = _driver.Title;
            return title;
        }

        public string GetSalePrice()
        {
            return SaleProductNewPrice.Text;
        }

        public string GetOriginalPrice()
        {
            return SaleProductOldPrice.Text;
        }


        public void SaleProductAddToBasket()
        {
            ProductAddToBasket.Click();
        }

        public void ClickOnBasket()
        {
            Basket.Click();
        }
    }
}
