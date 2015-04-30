using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Terminal.Dashboard.Portlets
{
    public class Activity : PortletViewBase
    {
        public Activity()
        {
            PortletId = "div#frame_TerminalActivityPortlet ";
        }

        public static IWebElementAdapter FoMessages
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