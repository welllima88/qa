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
                        "tbody tr td#content table.dataTable tbody tr td a[href*='/TerminalDashboard?TerminalId=']"));
        }
    }
}