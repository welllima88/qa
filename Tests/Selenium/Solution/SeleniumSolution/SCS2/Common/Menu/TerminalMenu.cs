using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Common.Menu
{
    public class TerminalMenu : WebObject
    {
        public static IWebElementAdapter Terminal
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href*='/TerminalDashboard/?TERMINALID=']"));
            }
        }
    }
}