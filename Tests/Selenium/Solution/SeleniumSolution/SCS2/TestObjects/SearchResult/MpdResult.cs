using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.SearchResult
{
    internal class MpdResult : AbstractSearchResult
    {
        public MpdResult(IWebDriverAdapter driver)
            : base(driver)
        {
            Prefix = "div#mpdDiv.container ";
        }
    }
}