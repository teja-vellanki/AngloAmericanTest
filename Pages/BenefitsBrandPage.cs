using OpenQA.Selenium;
using AngloAmericanTest.ObjectRepository;
using AngloAmericanTest.Utils;

namespace AngloAmericanTest.Pages
{
    public class BenefitsBrandPage : BenefitsBrandOR
    {
        public BenefitsBrandPage(IWebDriver driver) : base(driver)
        {
        }

        public string GetTitle()
        {
            var title = _driver.Title;
            return title;
        }

        public double GetSalePrice()
        {
            string saleprice = SaleProductNewPrice.Text;
            var charsToRemove = new string[] { "$" };
            foreach (var c in charsToRemove)
            {
                saleprice = saleprice.Replace(c, string.Empty);
            }
            return double.Parse(saleprice);
        }

        public double GetOriginalPrice()
        {

            string originalprice = SaleProductOldPrice.Text;
            var charsToRemove = new string[] { "$" };
            foreach (var c in charsToRemove)
            {
                originalprice = originalprice.Replace(c, string.Empty);
            }
            return double.Parse(originalprice);
        }

        public void SaleProductAddToBasket()
        {
            ProductAddToBasket.Click();
        }

        public void ClickOnBasket()
        {
            Basket.Click();
        }
    }
}
