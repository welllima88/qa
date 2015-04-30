using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Six.Saferpay.Backoffice.Test.Pages.Menu
{
    public class FurtherProducts
    {
        [FindsBy(How = How.CssSelector,
            Using = "div#menu li a[href='https://www.six-payment-services.com/de/shared/offering/products/psp.html']")]
        public IWebElement ProductInfo;

        [FindsBy(How = How.CssSelector, Using = "div#menu li a[href='https://gate.telekurs.ch/pmsp/?login']")]
        public
            IWebElement TopasPms;
    }
}