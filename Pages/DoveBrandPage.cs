using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using AngloAmericanTest.ObjectRepository;

namespace AngloAmericanTest.Pages
{
    public class DoveBrandPage : DoveBrandOR
    {
   
        
        public DoveBrandPage(IWebDriver driver) : base(driver)
        {
 
        }

        public List<string> GetALLProductTitles()
        {
            IList<IWebElement> _listOfProducts = ProductsInformation;
            List<string> ProductTitles = new List<string>();
            foreach (IWebElement product in _listOfProducts)
            {
                ProductTitles.Add(product.Text);
            }
            return ProductTitles;
        }

        public List<double> GetALLProductPrices()
        {
            IList<IWebElement> _listOfPProductPrices = ProductPrices;
            List<double> productPrices = new List<double>();
           
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
            return productPrices;
        }

        public void AddAllProdctsToBasket()
        {
            AddFirstProductToBasket.Click();
            AddSecondProductToBasket.Click();
            AddThirdProductToBasket.Click();
        }


 }
}
