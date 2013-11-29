using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal.Dashboard
{
    public class SalesContractPortlet : PortletViewBase
    {
        public SalesContractPortlet()
        {
            PortletId = "div#frame_SalesPortlet "; // div#SetupDataTree ul
        }

        public IWebElement ContractType
        {
            get { return WebDriver.FindElement(By.CssSelector(Prefix + PortletId + "li:nth-child(1)" + Suffix)); }
        }

        public IWebElement InstallType
        {
            get { return WebDriver.FindElement(By.CssSelector(Prefix + PortletId + "li:nth-child(2)" + Suffix)); }
        }

        public IWebElement DeliverDate
        {
            get { return WebDriver.FindElement(By.CssSelector(Prefix + PortletId + "li:nth-child(3)" + Suffix)); }
        }

        public IWebElement SupportContract
        {
            get { return WebDriver.FindElement(By.CssSelector(Prefix + PortletId + "li:nth-child(4)" + Suffix)); }
        }

        public IWebElement CashIntegrator
        {
            get { return WebDriver.FindElement(By.CssSelector(Prefix + PortletId + "li:nth-child(5)" + Suffix)); }
        }

        public static IWebElement TerminalDuplicate
        {
            get { return WebDriver.FindElement(By.CssSelector("div#frame_SalesPortlet div.portletLinks #duplicateLink")); }
        }
    }
}