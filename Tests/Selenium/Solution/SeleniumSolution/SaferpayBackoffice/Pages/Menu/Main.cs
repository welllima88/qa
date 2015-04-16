using OpenQA.Selenium.Support.PageObjects;
using Six.QA.Selenium.Extension.WebDriver;

namespace Six.Saferpay.QA.Selenium.Pages.Menu
{
    public class Main
    {
        public readonly FurtherProducts FurtherProducts;
        public readonly MySaferpay MySaferpay;
        public readonly UserSetup UserSetup;

        private Main()
        {
            FurtherProducts = new FurtherProducts();
            UserSetup = new UserSetup();
            MySaferpay = new MySaferpay();
            PageFactory.InitElements(TestDirector.WebDriver, FurtherProducts);
            PageFactory.InitElements(TestDirector.WebDriver, UserSetup);
            PageFactory.InitElements(TestDirector.WebDriver, MySaferpay);
        }

        public static Main Menu()
        {
            return new Main();
        }
    }
}