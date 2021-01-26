using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using AngloAmericanTest.ObjectRepository;

namespace AngloAmericanTest.Pages
{
    /// <summary>
    ///  This class has all the page actions of Dove brand Page
    /// </summary>
    public class DoveBrandPage : DoveBrandOR
    {
        public DoveBrandPage(IWebDriver driver) : base(driver)
        {
 
        }


        //This method returns all the list of product titles
        public List<string> GetALLProductTitles()
        {
            // Collection  of the Product Titles
            IList<IWebElement> _listOfProducts = ProductsInformation;
            List<string> ProductTitles = new List<string>();
            // Looping to add the dictionary of product titles
            foreach (IWebElement product in _listOfProducts)
            {
                ProductTitles.Add(product.Text);
            }
            //Returns product titles dictionary
            return ProductTitles;
        }

        //This method returns all the list of prices
        public List<double> GetALLProductPrices()
        {
            // Collection  of the Product Prices 
            IList<IWebElement> _listOfPProductPrices = ProductPrices;
            List<double> productPrices = new List<double>();
            // Looping to add the dictionary of product titles
            foreach (IWebElement productprices in _listOfPProductPrices)
            {
                string test =  productprices.Text;
                var charsToRemove = new string[] { "$" };
                foreach (var c in charsToRemove)
                {
                    test = test.Replace(c, string.Empty);
                }
                productPrices.Add(Double.Parse(test));
            }
            //Returns product titles dictionary
            return productPrices;
        }

        //Add all the prodcuts to the basket
        public void AddAllProdctsToBasket()
        {
            //Adding first product to basket
            AddFirstProductToBasket.Click();
            //Adding second product to basket
            AddSecondProductToBasket.Click();
            //Adding third product to basket
            AddThirdProductToBasket.Click();
        }


 }
}
