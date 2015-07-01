using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.View.Terminal.Dashboard.Portlets
{
    public class SalesContract : PortletViewBase
    {
        public SalesContract()
        {
            PortletId = "div#frame_SalesPortlet "; // div#SetupDataTree ul
        }

        public IWebElement ContractType
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector(Prefix + PortletId + "li:nth-child(1)" + Suffix));
            }
        }

        public IWebElement InstallType
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector(Prefix + PortletId + "li:nth-child(2)" + Suffix));
            }
        }

        public IWebElement DeliverDate
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector(Prefix + PortletId + "li:nth-child(3)" + Suffix));
            }
        }

        public IWebElement SupportContract
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector(Prefix + PortletId + "li:nth-child(4)" + Suffix));
            }
        }

        public IWebElement CashIntegrator
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector(Prefix + PortletId + "li:nth-child(5)" + Suffix));
            }
        }

        public static IWebElement TerminalDuplicate
        {
            get
            {
                return
                    new WebElement(WebDriver.WebDriverWait().Until(d => d.FindElement((
                        By.CssSelector(
                            "div#frame_SalesPortlet div.portletLinks a[href*='/TerminalDuplicate?TerminalId=']")))));
            }
        }

        public static IWebElement Quit
        {
            get
            {
                return
                    new WebElement(WebDriverWait.Until(d => d.FindElement(By.CssSelector(
                        "div#frame_SalesPortlet div.portletLinks a[href*='/TerminalState/Edit?TerminalId='][href$='&cancel=True']"))));
            }
        }

        public static IWebElement Replace
        {
            get
            {
                return
                    new WebElement(WebDriver.WebDriverWait().Until(d => d.FindElement(
                        By.CssSelector(
                            "div#frame_SalesPortlet div.portletLinks a[href*='/TerminalArticleSelector/ReplaceTerminal/?TerminalId=']"))));
            }
        }

        public static IWebElement MarkAsRetour
        {
            get { return WebDriver.FindAdaptedElement(By.Id("markAsReturnLink")); }
        }
    }
}