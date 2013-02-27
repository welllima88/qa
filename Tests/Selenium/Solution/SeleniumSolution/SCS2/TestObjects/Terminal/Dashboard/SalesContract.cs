using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal.Dashboard
{
    internal class SalesContract : PortletViewBase
    {
        public SalesContract(IWebDriver driver) : base(driver)
        {
            Pre = "div#portlet_SalesPortlet_content div#SetupDataTree ul";
        }

        public IWebElement ContractType
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector(
                            Pre + "li:nth-child(1)" + Suf));
            }
        }

        public IWebElement InstallType
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector(
                            Pre + "li:nth-child(2)" + Suf));
            }
        }

        public IWebElement DeliverDate
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector(
                            Pre + "li:nth-child(3)" + Suf));
            }
        }

        public IWebElement SupportContract
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector(
                            Pre + "li:nth-child(4)" + Suf));
            }
        }

        public IWebElement CashIntegrator
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector(
                            Pre + "li:nth-child(5)" + Suf));
            }
        }
    }
}