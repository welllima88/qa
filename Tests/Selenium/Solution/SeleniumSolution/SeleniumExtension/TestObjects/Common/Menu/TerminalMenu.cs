using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Extension.TestObjects.Common.Menu
{
    public class TerminalMenu : WebObject
    {
        public static IWebElement Terminal
        {
            get { return WebDriver.FindElement(By.CssSelector("td#leftHandMenu a[href*='/TerminalDashboard/?TERMINALID=']")); }
        }
    }
}