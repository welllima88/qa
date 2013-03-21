using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.SearchResult
{
    internal class SimCardResult : AbstractSearchResult
    {
        public SimCardResult(IWebDriverAdapter driver)
            : base(driver)
        {
            Prefix = "div#simcardDiv.container ";
        }
    }
}