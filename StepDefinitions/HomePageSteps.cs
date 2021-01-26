using OpenQA.Selenium;
using TechTalk.SpecFlow;
using AngloAmericanTest.Pages;
using AngloAmericanTest.Utils;
using NUnit.Framework;

namespace AngloAmericanTest.StepDefinitions
{
    [Binding]
    /// <summary>
    ///   This class performs all the step actions of the Home Page  
    /// </summary>
    public class HomePageSteps
    {
        private readonly BasePage _basePage;
        public IWebDriver _driver;
        private readonly HomePage homePage;
        private Brands _nameofthebrand;
       

        public HomePageSteps(BasePage basePage, HomePage homePage, Brands nameofthebrand)
        {
            _basePage = basePage;
            this.homePage = homePage;
            _nameofthebrand = nameofthebrand;
        }

        [Given(@"I navigate to homepage")]
        public void GivenINavigateToHomepage()
        {
            //Navigating to the home page
            _basePage.NavigateToHomePage(Helper.GetUrl);
        }


        [When(@"I click on brand ""(.*)""")]
        public void WhenIClickOnBrand(string brandname)
        {
            //Click on brand with brand name
            homePage.ClickOnBrandName(brandname);
        }

        [When(@"I read all the brands available")]
        public void WhenIReadAllTheBrandsAvailable()
        {
            //Creating object of all the brand names
            _nameofthebrand.BrandsList =  homePage.ReadAllBrandNames();
        }


        [Then(@"The brand names should match below list")]
        public void ThenTheBrandNamesShouldMatchBelowList(Table table)
        {
            int i = 0;
            int j = 0;
            //Running for loop to Assert the brand titles with expected list
            foreach(string brandname in _nameofthebrand.BrandsList)
            {
                    Assert.AreEqual(table.Rows[i][j], brandname);
                    i++; 
            }
        }
    }
}