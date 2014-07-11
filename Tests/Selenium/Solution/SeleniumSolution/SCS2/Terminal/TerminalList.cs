using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Terminal
{
    public class TerminalList : WebObject
    {
        public static IWebElementAdapter First()
        {
            return
                WebDriver.FindAdaptedElement(
                    By.CssSelector(
                        "tbody tr td#content table tbody tr td a[href*='/TerminalDashboard?TerminalId=']"));
        }
    }
}