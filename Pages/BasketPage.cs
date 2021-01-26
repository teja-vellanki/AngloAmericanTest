using OpenQA.Selenium;
using AngloAmericanTest.ObjectRepository;
using AngloAmericanTest.Utils;

namespace AngloAmericanTest.Pages
{
    public class BasketPage : BasketPageOR
    {

        public BasketPage(IWebDriver driver) : base(driver)
        {
        }

     
        public double GetBasketPrice()
        {
            string price = TotalBasketValue.Text;
            var charsToRemove = new string[] { "$" };
            foreach (var c in charsToRemove)
            {
                price = price.Replace(c, string.Empty);
            }
            return double.Parse(price);
        }

       
    }
}
