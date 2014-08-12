using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Terminal.Dashboard.Portlets
{
    public class TerminalTexts : PortletViewBase
    {
        public static IWebElementAdapter CreateInfotext
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(
                            "div#frame_TerminalInfotextPortlet div.portletLinks a[href*='/TerminalInfoText/List?&TerminalId=']"));
            }
        }

        public static IWebElementAdapter Infotexts
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(
                            "div#frame_TerminalInfotextPortlet div.portletLinks a[href*='/TerminalInfoText/List?&TerminalId=']"));
            }
        }
    }
}