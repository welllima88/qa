using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.View.Terminal.Dashboard.Portlets.Brand
{
    public class BrandPortlet : PortletViewBase
    {
        private const string PortletLocator = "div[id*='BrandPortlet']";
        private const string ContractTreeLocator = "div[id*='ContractTree']>ul";

        public static IWebElement NewBrandButton
        {
            get
            {
                var w = WebDriver.WebDriverWait();
                return
                    new WebElement(
                        w.Until(
                            d =>
                                d.FindElement(
                                    By.CssSelector(
                                        PortletLocator +
                                        " div.portletLinks a[href*='ContractCreate/ListByTerminal?TerminalId=']"))));
            }
        }

        public static IWebElement Brand(string brandId)
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

        public static IWebElement Acquirer(string acquirerId)
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
        public static IEnumerable<IWebElement> Tickets()
        {

            //acqContract_
            //_ProcessTicket
            //css=acqContract #774e1b93-b51f-4e38-84e3-2b014ffaca98_730746 > div.portletKeyValueRow div.treeValueCol > a
            return WebDriver.FindAdaptedElements(By.CssSelector("li[id$='acqContract']"));
        }
        

        public static void ExpandAll()
        {
            WebDriver.FindAdaptedElement(By.CssSelector(PortletLocator + " span[title='expand']")).Click();
        }
    }
}