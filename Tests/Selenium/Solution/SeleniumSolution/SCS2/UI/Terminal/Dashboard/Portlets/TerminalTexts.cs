using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.UI.Terminal.Dashboard.Portlets
{
    public class TerminalTexts : PortletViewBase
    {
        public static IWebElement CreateInfotext
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(
                            "div#frame_TerminalInfotextPortlet div.portletLinks a[href*='/TerminalInfoText/Create?&TerminalId=']"));
            }
        }

        public static IWebElement Infotexts
        {
            get
            {
                var w = WebDriver.WebDriverWait();
                return
                    new WebElement(
                        w.Until(
                            d =>
                                d.FindElement(
                                    By.CssSelector(
                                        "div#frame_TerminalInfotextPortlet div.portletLinks a[href*='/TerminalInfoText/Create?&TerminalId=']"))));
            }
        }
    }
}