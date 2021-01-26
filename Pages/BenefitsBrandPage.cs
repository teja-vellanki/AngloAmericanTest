using OpenQA.Selenium;
using AngloAmericanTest.ObjectRepository;
using AngloAmericanTest.Utils;

namespace AngloAmericanTest.Pages
{
    /// <summary>
    /// This class has all the page actions of Benefits brand Page
    /// </summary>
    public class BenefitsBrandPage : BenefitsBrandOR
    {
        public BenefitsBrandPage(IWebDriver driver) : base(driver)
        {
        }
        
        //Returns the title of the page
        public string GetTitle()
        {
            var title = _driver.Title;
            return title;
        }

        //Returns Sale prece of the product
        public double GetSalePrice()
        {
            //Reading the Sale Price
            string saleprice = SaleProductNewPrice.Text;
            // Removing the $ to convert to double
            var charsToRemove = new string[] { "$" };
            foreach (var c in charsToRemove)
            {
                saleprice = saleprice.Replace(c, string.Empty);
            }
            //return the sale price
            return double.Parse(saleprice);
        }

        //Returns the original price of the product
        public double GetOriginalPrice()
        {
            //Reading the Original price
            string originalprice = SaleProductOldPrice.Text;
            // Removing the $ to convert to double
            var charsToRemove = new string[] { "$" };
            foreach (var c in charsToRemove)
            {
                originalprice = originalprice.Replace(c, string.Empty);
            }
            //return the original price
            return double.Parse(originalprice);
        }

        //Add poduct to the basket
        public void SaleProductAddToBasket()
        {
            //Adding the Sale product to the basket
            ProductAddToBasket.Click();
        }

        // Clickng on the Basket to reach the Basket oage
        public void ClickOnBasket()
        {
            //Basket Element clicking to reach the basket page
            Basket.Click();
        }
    }
}
