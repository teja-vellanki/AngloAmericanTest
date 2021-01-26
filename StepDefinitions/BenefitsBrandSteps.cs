using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using AngloAmericanTest.Pages;
using AngloAmericanTest.Utils;

namespace AngloAmericanTest.StepDefinitions
{
    [Binding]
    /// <summary>
    ///  This class performs all the step actions of the Benefits Band Page
    /// </summary>
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
            //Resding the title of the Page
            string actualTitle = _benefitsbrandpage.GetTitle();
            //Validating the title to make sure we reach the benefit brand page
            if (!actualTitle.Contains("Benefit"))
            {
                Assert.Fail("Search Title does not contains expected title " + actualTitle);
            }
        }


        [When(@"I add the sale product to the basket")]
        public void WhenIAddTheSaleProductToTheBasket()
        {
            //Declaring a context Key Value pair to set the sale price
            _scenarioContext["saleprice"]= _benefitsbrandpage.GetSalePrice();
            //Declaring a context Key Value pair to set the original price
            _scenarioContext["originalprice"] = _benefitsbrandpage.GetOriginalPrice();
            //Adding Sale product to the basket
            _benefitsbrandpage.SaleProductAddToBasket();

        }

        [When(@"I click on basket")]
        public void WhenIClickOnBasket()
        {
            //Clicking on basket to reach the basket page
            _benefitsbrandpage.ClickOnBasket();
        }

    }
}
