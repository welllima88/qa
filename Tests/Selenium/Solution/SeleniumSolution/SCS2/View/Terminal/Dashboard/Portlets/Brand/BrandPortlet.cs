using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Terminal.Dashboard.Portlets.Brand
{
    public class BrandPortlet : PortletViewBase
    {
        private const string PortletLocator = "div[id*='BrandPortlet']";
        private const string ContractTreeLocator = "div[id*='ContractTree']>ul";

        public static IWebElementAdapter NewBrandButton
        {
            get
            {
                var w = WebDriver.WebDriverWait();
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

        public static IEnumerable<string> Brands()
        {
            return
                WebDriver.FindAdaptedElements(
                    By.CssSelector(string.Format(
                        PortletLocator + " " + ContractTreeLocator +
                        " ul li[id^='brandContract_'] div.treeParentNode span:nth-child(3)")))
                    .Select(e => e.Text);
        }

        public static IWebElementAdapter Acquirer(string acquirerId)
        {
            return
                WebDriver.FindAdaptedElement(
                    By.CssSelector(string.Format(
                        PortletLocator + " " + ContractTreeLocator + " li[id^='acqContract_'] div#{0}", acquirerId)));
        }

        public static IEnumerable<string> Acquirers()
        {
            return
                WebDriver.FindAdaptedElements(
                    By.CssSelector(string.Format(
                        PortletLocator + " " + ContractTreeLocator + " li[id^='acqContract_'] a.acqContractNode span")))
                    .Select(e => e.Text);
        }
    }
}