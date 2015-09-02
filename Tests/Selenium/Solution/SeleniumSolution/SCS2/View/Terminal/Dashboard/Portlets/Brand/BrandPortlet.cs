using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.View.Terminal.Dashboard.Portlets.Brand
{
    public class BrandPortlet : PortletViewBase
    {
        private const string PortletLocator = ""; //"div[id*='BrandPortlet']";
        private const string ContractTreeLocator = "div[id*='ContractTree']>ul";

        public static IWebElement NewBrandButton
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(PortletLocator +
                                       " div.portletLinks a[href*='ContractCreate/ListByTerminal?TerminalId=']"));
            }
        }

        public static IWebElement AcuirerExchange
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(PortletLocator +
                                       " a[href*='/Location/PrepareForAcquirerExchangeTerminal?TerminalId=']"));
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
                        " ul li[id^='brandContract_'] div.treeParentNode span:nth-of-type(2)")))
                    .Select(e => e.Text);
        }

        public static Acquirer Acquirer(string acquirerId)
        {
            return
                new Acquirer(acquirerId);
        }

        public static IEnumerable<string> Acquirers()
        {
            return
                WebDriver.FindAdaptedElements(
                    By.CssSelector(string.Format(
                        PortletLocator + " " + ContractTreeLocator + " li[id^='acqContract_'] .acqContractNode>span")))
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
            WebDriver.FindAdaptedElement(By.CssSelector("div#dashboarditems div[id$='BrandPortlet'] span[title='expand']")).Click();
        }
    }
}