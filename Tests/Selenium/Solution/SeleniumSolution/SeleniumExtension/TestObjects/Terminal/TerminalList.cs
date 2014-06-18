using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Extension.TestObjects.Terminal
{
    public class TerminalList : WebObject
    {
        public static IWebElement First()
        {
            return
                WebDriver.FindAdaptedElement(
                    By.CssSelector(
                        "td#content table tbody tr td a[href*='/TerminalDashboard?TerminalId=']"));
        }
    }
}