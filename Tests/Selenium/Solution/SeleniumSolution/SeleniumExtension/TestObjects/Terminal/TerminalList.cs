using OpenQA.Selenium;
using SIX.SCS.Tests.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.Tests.Selenium.Extension.TestObjects.Terminal
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