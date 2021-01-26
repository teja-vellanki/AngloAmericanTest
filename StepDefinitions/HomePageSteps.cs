using AngloAmericanTest.StepDefinitions;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using AngloAmericanTest.Pages;
using AngloAmericanTest.Utils;
using NUnit.Framework;

namespace AngloAmericanTest.StepDefinitions
{
    [Binding]
    public class HomePageSteps
    {
        private readonly ScenarioContext scenarioContext;
        private readonly BasePage _basePage;
        public IWebDriver _driver;
        private readonly HomePage homePage;
        private Brands _nameofthebrand;
       

        public HomePageSteps(ScenarioContext scenarioContext, BasePage basePage, HomePage homePage, Brands nameofthebrand)
        {
            this.scenarioContext = scenarioContext;
            _basePage = basePage;
            this.homePage = homePage;
            _nameofthebrand = nameofthebrand;
        }

        [Given(@"I navigate to homepage")]
        public void GivenINavigateToHomepage()
        {
            _basePage.NavigateToHomePage(Helper.GetUrl);
        }


        [When(@"I click on brand ""(.*)""")]
        public void WhenIClickOnBrand(string brandname)
        {
            homePage.ClickOnBrandName();
        }

        [When(@"I read all the brands available")]
        public void WhenIReadAllTheBrandsAvailable()
        {
            _nameofthebrand.BrandsList =  homePage.ReadAllBrandNames();
        }


        [Then(@"The brand names should match below list")]
        public void ThenTheBrandNamesShouldMatchBelowList(Table table)
        {
            int i = 0;
            int j = 0;
            foreach(string brandname in  _nameofthebrand.BrandsList)
            {
                
                    Assert.AreEqual(table.Rows[i][j], brandname);
                    i++;
                
            }
        }


    }
}