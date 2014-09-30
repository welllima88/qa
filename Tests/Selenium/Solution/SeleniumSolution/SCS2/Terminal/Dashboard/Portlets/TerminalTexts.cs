using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
                            "div#frame_TerminalInfotextPortlet div.portletLinks a[href*='/TerminalInfoText/Create?&TerminalId=']"));
            }
        }

        public static IWebElementAdapter Infotexts
        {
            get
            {
                WebDriverWait w = WebDriver.WebDriverWait();
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