using OpenQA.Selenium.Support.PageObjects;
using Six.QA.Selenium.Extension.WebDriver;

namespace Six.Saferpay.QA.Selenium.Pages.Menu
{
    public class Menu
    {
        public readonly FurtherProducts FurtherProducts;
        public readonly MySaferpay MySaferpay;
        public readonly Payments Payments;
        public readonly UserSetup UserSetup;

        private Menu()
        {
            FurtherProducts = new FurtherProducts();
            UserSetup = new UserSetup();
            MySaferpay = new MySaferpay();
            Payments = new Payments();

            PageFactory.InitElements(TestDirector.WebDriver, FurtherProducts);
            PageFactory.InitElements(TestDirector.WebDriver, UserSetup);
            PageFactory.InitElements(TestDirector.WebDriver, MySaferpay);
            PageFactory.InitElements(TestDirector.WebDriver, Payments);
        }

        public static Menu Home()
        {
            return new Menu();
        }
    }
}