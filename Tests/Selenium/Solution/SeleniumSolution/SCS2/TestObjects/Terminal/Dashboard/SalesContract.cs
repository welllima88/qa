using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal.Dashboard
{
    internal class SalesContract : PortletViewBase
    {
        public SalesContract(IWebDriverAdapter driver) : base(driver)
        {
            Prefix = "div#portlet_SalesPortlet_content div#SetupDataTree ul";
        }

        public IWebElement ContractType
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector(
                            Prefix + "li:nth-child(1)" + Suffix));
            }
        }

        public IWebElement InstallType
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector(
                            Prefix + "li:nth-child(2)" + Suffix));
            }
        }

        public IWebElement DeliverDate
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector(
                            Prefix + "li:nth-child(3)" + Suffix));
            }
        }

        public IWebElement SupportContract
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector(
                            Prefix + "li:nth-child(4)" + Suffix));
            }
        }

        public IWebElement CashIntegrator
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector(
                            Prefix + "li:nth-child(5)" + Suffix));
            }
        }
    }
}