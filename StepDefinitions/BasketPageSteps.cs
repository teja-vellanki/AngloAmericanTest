using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using AngloAmericanTest.Pages;
using AngloAmericanTest.Utils;

namespace AngloAmericanTest.StepDefinitions
{
    [Binding]
    public class BasketPageSteps
    {

        private readonly BasePage _basePage;
        public IWebDriver _driver;
        private readonly HomePage homePage;
        private BasketPage _basketpage;
        private readonly SeleniumHelper _seleniumHelper;
        private readonly ScenarioContext _scenarioContext;

        public BasketPageSteps(BasePage basePage, HomePage homePage, BasketPage basketpage, ScenarioContext scenarioContext, SeleniumHelper seleniumHelper)
        {
            _basePage = basePage;
            this.homePage = homePage;
            _basketpage = basketpage;
            _seleniumHelper = seleniumHelper;
            _scenarioContext = scenarioContext;
        }



        [Then(@"I should see the sale product is added in the basket")]
        public void ThenIShouldSeeTheSaleProductIsAddedInTheBasket()
        {
            string saleprice = _scenarioContext["saleprice"].ToString();
            string basketvalue =_basketpage.GetBasketPrice();
            Assert.AreEqual(saleprice, basketvalue);
        }



    }
}
