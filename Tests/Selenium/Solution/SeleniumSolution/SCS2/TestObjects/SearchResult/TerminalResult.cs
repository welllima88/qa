using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.SearchResult
{
    class TerminalResult : AbstractSearchResult
    {
        public TerminalResult(IWebDriverAdapter driver)
            : base(driver)
        {
            Prefix = "div#terminalDiv.container ";
        }
    }
}