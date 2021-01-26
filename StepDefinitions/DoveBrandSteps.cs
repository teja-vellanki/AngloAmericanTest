using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using AngloAmericanTest.Pages;
using TechTalk.SpecFlow.Assist;
using System.Collections.Generic;

namespace AngloAmericanTest.StepDefinitions
{
    [Binding]
    /// <summary>
    /// This class performs all the step actions of the Dove Brand 
    /// </summary>
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
            //Creating a data set using the table data from spec file
            IEnumerable<ProductInfo> productinformation = table.CreateSet<ProductInfo>();
            //Reading all the titles into a local list
            List<string> titles = _dovebrandpage.GetALLProductTitles();
            //Reading all the prices into a local list
            List<double> productPrices = _dovebrandpage.GetALLProductPrices();
            int i = 0;
            double totalValue=0;
            //Running loop to assert all the product title and prices
            foreach (var productinf in productinformation)
            {
                Assert.AreEqual(titles[i], productinf.ProductName);
                Assert.AreEqual(productPrices[i], productinf.ProductPrice);
                totalValue += productPrices[i];
                i++;
            }

            //Declaring a context Key Value pair to set the total basket value
            _scenarioContext["TotalPriceValue"] = totalValue;
        }

        [When(@"I add add the products to basket")]
        public void WhenIAddAddTheProductsToBasket()
        {
            //Adding all the products in dove brand page to basket
            _dovebrandpage.AddAllProdctsToBasket();
        }

        
    }
}