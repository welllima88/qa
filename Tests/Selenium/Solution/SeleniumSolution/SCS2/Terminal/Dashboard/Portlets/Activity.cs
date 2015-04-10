using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Terminal.Dashboard.Portlets
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