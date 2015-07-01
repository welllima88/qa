using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.View.Terminal.Dashboard.Portlets
{
    public class Activity : PortletViewBase
    {
        public Activity()
        {
            PortletId = "div#frame_TerminalActivityPortlet ";
        }

        public static IWebElement FoMessages
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(Prefix + PortletId + "div.portletLinks a[href*='/FOMessage?TerminalId=']"))
                    ;
            }
        }
    }
}