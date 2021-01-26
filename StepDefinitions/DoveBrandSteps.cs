using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using AngloAmericanTest.Pages;
using AngloAmericanTest.Utils;
using TechTalk.SpecFlow.Assist;
using System.Collections.Generic;

namespace AngloAmericanTest.StepDefinitions
{
    [Binding]
    public class DoveBrandSteps
    {
        public IWebDriver _driver;
        private DoveBrandPage _dovebrandpage;
        private readonly ScenarioContext _scenarioContext;

        public DoveBrandSteps( DoveBrandPage dovebrandpage, ScenarioContext scenarioContext)
        {
            _dovebrandpage = dovebrandpage;
            _scenarioContext = scenarioContext;
        }

        [Then(@"I should see the below products are availble")]
        public void ThenIShouldSeeTheBelowProductsAreAvailble(Table table)
        {
            IEnumerable<ProductInfo> productinformation = table.CreateSet<ProductInfo>();
            List<string> titles = _dovebrandpage.GetALLProductTitles();
            List<double> productPrices = _dovebrandpage.GetALLProductPrices();
            int i = 0;
            double totalValue=0;
            foreach (var productinf in productinformation)
            {
                Assert.AreEqual(titles[i], productinf.ProductName);
                Assert.AreEqual(productPrices[i], productinf.ProductPrice);
                totalValue += productPrices[i];
                i++;
            }

            _scenarioContext["TotalPriceValue"] = totalValue;
        }

        [When(@"I add add the products to basket")]
        public void WhenIAddAddTheProductsToBasket()
        {
            _dovebrandpage.AddAllProdctsToBasket();
        }

        
    }
}