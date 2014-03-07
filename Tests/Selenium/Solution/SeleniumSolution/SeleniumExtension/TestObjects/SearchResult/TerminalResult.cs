using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.SearchResult
{
    public class TerminalResult : SearchResults
    {
        public TerminalResult()
        {
            Prefix = "div#terminalDiv.container ";
        }

        public static IWebElement First()
        {
            IWebElement element =
                WebDriver.FindAdaptedElement(
                    By.CssSelector(
                        "div#terminalDiv tbody#terminalResult tr td a#terminalLink[href*='/TerminalDashboard/?terminalId=']"));
            return element;
        }
    }
}