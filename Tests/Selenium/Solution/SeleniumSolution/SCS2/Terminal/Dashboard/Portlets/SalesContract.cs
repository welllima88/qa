using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Terminal.Dashboard.Portlets
{
    public class SalesContract : PortletViewBase
    {
        public SalesContract()
        {
            PortletId = "div#frame_SalesPortlet "; // div#SetupDataTree ul
        }

        public IWebElementAdapter ContractType
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector(Prefix + PortletId + "li:nth-child(1)" + Suffix));
            }
        }

        public IWebElementAdapter InstallType
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector(Prefix + PortletId + "li:nth-child(2)" + Suffix));
            }
        }

        public IWebElementAdapter DeliverDate
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector(Prefix + PortletId + "li:nth-child(3)" + Suffix));
            }
        }

        public IWebElementAdapter SupportContract
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector(Prefix + PortletId + "li:nth-child(4)" + Suffix));
            }
        }

        public IWebElementAdapter CashIntegrator
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector(Prefix + PortletId + "li:nth-child(5)" + Suffix));
            }
        }

        public static IWebElementAdapter TerminalDuplicate
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(
                            "div#frame_SalesPortlet div.portletLinks a[href*='/TerminalDuplicate?TerminalId=']"));
            }
        }

        public static IWebElementAdapter Quit
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(
                            "div#frame_SalesPortlet div.portletLinks a[href*='/TerminalState/Edit?TerminalId='][href$='&cancel=True']"));
            }
        }

        public static IWebElementAdapter Replace
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(
                            "div#frame_SalesPortlet div.portletLinks a[href*='/TerminalArticleSelector/ReplaceTerminal/?TerminalId=']"));
            }
        }
    }
}