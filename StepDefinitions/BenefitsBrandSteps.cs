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
    public class BenefitsBrandSteps
    {
        private readonly BasePage _basePage;
        public IWebDriver _driver;
        private readonly HomePage homePage;
        private BenefitsBrandPage _benefitsbrandpage;
        private readonly SeleniumHelper _seleniumHelper;
        private readonly ScenarioContext _scenarioContext;

        public BenefitsBrandSteps(BasePage basePage, HomePage homePage, BenefitsBrandPage benefitsbrandpage, SeleniumHelper seleniumHelper, ScenarioContext scenarioContext)
        {
            _basePage = basePage;
            this.homePage = homePage;
            _benefitsbrandpage = benefitsbrandpage;
            _seleniumHelper = seleniumHelper;
            _scenarioContext = scenarioContext;
        }


        [When(@"I reach the ""(.*)""")]
        public void WhenIReachThe(string p0)
        {
            string actualTitle = _benefitsbrandpage.GetTitle();
            if (!actualTitle.Contains("Benefit"))
            {
                Assert.Fail("Search Title does not contains expected title " + actualTitle);
            }
        }


        [When(@"I add the sale product to the basket")]
        public void WhenIAddTheSaleProductToTheBasket()
        {
            _scenarioContext["saleprice"]= _benefitsbrandpage.GetSalePrice();
            _scenarioContext["originalprice"] = _benefitsbrandpage.GetOriginalPrice();
            Console.WriteLine("tete" + _scenarioContext["saleprice"]);
            _benefitsbrandpage.SaleProductAddToBasket();

        }

        [When(@"I click on basket in the benefits page")]
        public void WhenIClickOnBasketInTheBenefitsPage()
        {
            _benefitsbrandpage.ClickOnBasket();
        }

    







    }
}
