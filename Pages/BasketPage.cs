using OpenQA.Selenium;
using AngloAmericanTest.ObjectRepository;
using AngloAmericanTest.Utils;

namespace AngloAmericanTest.Pages
{
    /// <summary>
    ///  This class has all the page actions of Basket Page
    /// </summary>
    public class BasketPage : BasketPageOR
    {

        public BasketPage(IWebDriver driver) : base(driver)
        {
        }

        // This method returns total basket prices
        public double GetBasketPrice()
        {
            //Reading the text of the total basket value
            string price = TotalBasketValue.Text;
            // Removing the $ to convert to double
            var charsToRemove = new string[] { "$" };
            foreach (var c in charsToRemove)
            {
                price = price.Replace(c, string.Empty);
            }
            //returning the total basket value
            return double.Parse(price);
        }

       
    }
}
