using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using AngloAmericanTest.Pages;
using AngloAmericanTest.Utils;

namespace AngloAmericanTest.StepDefinitions
{
    [Binding]
    public class BenefitsBrandSteps
    {
        public IWebDriver _driver;
        private BenefitsBrandPage _benefitsbrandpage;
        private readonly ScenarioContext _scenarioContext;

        public BenefitsBrandSteps(BenefitsBrandPage benefitsbrandpage, ScenarioContext scenarioContext)
        {
            _benefitsbrandpage = benefitsbrandpage;
            _scenarioContext = scenarioContext;
        }

        [Then(@"I should reach the ""(.*)""")]
        public void ThenIShouldReachThe(string p0)
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
            _benefitsbrandpage.SaleProductAddToBasket();

        }

        [When(@"I click on basket")]
        public void WhenIClickOnBasket()
        {
            _benefitsbrandpage.ClickOnBasket();
        }

    }
}
