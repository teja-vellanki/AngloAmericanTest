using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using AngloAmericanTest.Pages;

namespace AngloAmericanTest.StepDefinitions
{
    [Binding]
    public class BasketPageSteps
    {
        public IWebDriver _driver;
        private BasketPage _basketpage;
        private readonly ScenarioContext _scenarioContext;

        public BasketPageSteps( BasketPage basketpage, ScenarioContext scenarioContext)
        {
            _basketpage = basketpage;
            _scenarioContext = scenarioContext;
        }

        [Then(@"I should see the sale product is added in the basket")]
        public void ThenIShouldSeeTheSaleProductIsAddedInTheBasket()
        {
            double flatShippingRate = 2.00;
            double saleprice = double.Parse(_scenarioContext["saleprice"].ToString());
            double basketvalue =_basketpage.GetBasketPrice();
            Assert.AreEqual(saleprice+flatShippingRate, basketvalue);
        }

        [Then(@"I should see the basket value is equal to sum of all product prices plus shipping costs")]
        public void ThenIShouldSeeTheBasketValueIsEqualToSumOfAllProductPricesPlusShippingCosts()
        {
            double flatShippingRate = 2.00;
            double totalprice = double.Parse(_scenarioContext["TotalPriceValue"].ToString());
            double totalvalue = totalprice + flatShippingRate;
            Assert.AreEqual(totalvalue, _basketpage.GetBasketPrice());
        }

    }
}
