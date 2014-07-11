using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.SearchResult
{
    public class TerminalResult : SearchResults
    {
        public TerminalResult()
        {
            Prefix = "div#terminalDiv.container ";
        }

        public static IWebElementAdapter First()
        {
            IWebElementAdapter element =
                WebDriver.FindAdaptedElement(
                    By.CssSelector(
                        "div#terminalDiv tbody#terminalResult tr td a#terminalLink[href*='/TerminalDashboard/?terminalId=']"));
            return element;
        }
    }
}