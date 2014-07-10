using OpenQA.Selenium;

namespace Six.Scs.QA.Selenium.Terminal.Dashboard
{
    public class TerminalTextsPortlet : PortletViewBase
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
    }
}