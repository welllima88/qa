using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.UI.Terminal.Dashboard.Portlets.Brand
{
    public class Acquirer : WebObject
    {
        private const string PortletLocator = "div[id*='BrandPortlet']";
        private const string ContractTreeLocator = "div[id*='ContractTree']>ul";
        private readonly string _acquirerId;

        public Acquirer(string acquirerId)
        {
            _acquirerId = acquirerId;
        }

        public string BusinessTemplate
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(string.Format("div#{0} +ul li[id$='_Business Template'] div.treeValueCol>span:nth-of-type(1)",
                            _acquirerId))).Text;
            }
        }

        public string Name
        {
            get
            {
                return WebDriver.FindElement(
                    By.CssSelector(string.Format(
                        PortletLocator + " " + ContractTreeLocator + " li[id^='acqContract_'] div#{0}>span", _acquirerId)))
                    .Text;
            }
        }
    }
}