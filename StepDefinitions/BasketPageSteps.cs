using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using AngloAmericanTest.Pages;

namespace AngloAmericanTest.StepDefinitions
{
    [Binding]
    /// <summary>
    ///  This class performs all the step actions of the Basket Page
    /// </summary>
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
            //Declared the Static value for flat shipping
            double flatShippingRate = 2.00;
            //Reading the scenario context value and parsing into double
            double saleprice = double.Parse(_scenarioContext["saleprice"].ToString());
            //Calling the method to read the basket value and assigned to local variable
            double basketvalue =_basketpage.GetBasketPrice();
            //Assertion for expected and actual vaue
            Assert.AreEqual(saleprice+flatShippingRate, basketvalue);
        }

        [Then(@"I should see the basket value is equal to sum of all product prices plus shipping costs")]
        public void ThenIShouldSeeTheBasketValueIsEqualToSumOfAllProductPricesPlusShippingCosts()
        {
            //Declared the Static value for flat shipping
            double flatShippingRate = 2.00;
            //Reading the scenario context value and parsing into double
            double totalprice = double.Parse(_scenarioContext["TotalPriceValue"].ToString());
            //Adding the basket value and flat shipping rate to get the total basket value
            double totalvalue = totalprice + flatShippingRate;
            // Assertion for expected and actual vaue
            Assert.AreEqual(totalvalue, _basketpage.GetBasketPrice());
        }

    }
}
