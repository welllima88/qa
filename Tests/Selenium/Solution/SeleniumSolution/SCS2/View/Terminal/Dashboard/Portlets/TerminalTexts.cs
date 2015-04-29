using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Terminal.Dashboard.Portlets
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
                            "div#frame_TerminalInfotextPortlet div.portletLinks a[href*='/TerminalInfoText/Create?&TerminalId=']"));
            }
        }

        public static IWebElementAdapter Infotexts
        {
            get
            {
                var w = WebDriver.WebDriverWait();
                return
                    new WebElementAdapter(
                        w.Until(
                            d =>
                                d.FindElement(
                                    By.CssSelector(
                                        "div#frame_TerminalInfotextPortlet div.portletLinks a[href*='/TerminalInfoText/List?&TerminalId=']"))));
            }
        }
    }
}