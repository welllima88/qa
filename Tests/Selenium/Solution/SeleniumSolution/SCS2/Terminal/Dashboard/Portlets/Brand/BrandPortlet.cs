using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Terminal.Dashboard.Portlets.Brand
{
    public class BrandPortlet : PortletViewBase
    {
        private const string PortletLocator = "div[id*='BrandPortlet']";
        private const string ContractTreeLocator = "div[id*='ContractTree']>ul";

        public static IWebElementAdapter NewBrandButton
        {
            get
            {
                WebDriverWait w = WebDriver.WebDriverWait();
                return
                    new WebElementAdapter(
                        w.Until(
                            d =>
                                d.FindElement(
                                    By.CssSelector(
                                        PortletLocator +
                                        " div.portletLinks a[href*='ContractCreate/ListByTerminal?TerminalId=']"))));
            }
        }

        public static IWebElementAdapter Brand(string brandId)
        {
            return
                WebDriver.FindAdaptedElement(
                    By.CssSelector(string.Format(
                        PortletLocator + " " + ContractTreeLocator + " ul li[id^='brandContract_{0}']", brandId)));
        }

        public static IWebElementAdapter Acquirer(string acquirerId)
        {
            return
                WebDriver.FindAdaptedElement(
                    By.CssSelector(string.Format(
                        PortletLocator + " " + ContractTreeLocator + " li[id^='acqContract_'] div#{0}", acquirerId)));
        }
    }
}