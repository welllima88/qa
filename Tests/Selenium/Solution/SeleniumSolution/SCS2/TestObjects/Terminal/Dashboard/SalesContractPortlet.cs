using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal.Dashboard
{
    public class SalesContractPortlet : PortletViewBase
    {
        public SalesContractPortlet(IWebDriverAdapter driver) : base(driver)
        {
            PortletId = "div#frame_SalesPortlet "; // div#SetupDataTree ul
        }

        public IWebElement ContractType
        {
            get { return Driver.FindElement(By.CssSelector(Prefix + PortletId + "li:nth-child(1)" + Suffix)); }
        }

        public IWebElement InstallType
        {
            get { return Driver.FindElement(By.CssSelector(Prefix + PortletId + "li:nth-child(2)" + Suffix)); }
        }

        public IWebElement DeliverDate
        {
            get { return Driver.FindElement(By.CssSelector(Prefix + PortletId + "li:nth-child(3)" + Suffix)); }
        }

        public IWebElement SupportContract
        {
            get { return Driver.FindElement(By.CssSelector(Prefix + PortletId + "li:nth-child(4)" + Suffix)); }
        }

        public IWebElement CashIntegrator
        {
            get { return Driver.FindElement(By.CssSelector(Prefix + PortletId + "li:nth-child(5)" + Suffix)); }
        }
    }
}