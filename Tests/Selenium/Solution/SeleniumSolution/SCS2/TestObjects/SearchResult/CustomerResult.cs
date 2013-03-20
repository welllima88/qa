using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.SearchResult
{
    class CustomerResult : AbstractSearchResult
    {
        public CustomerResult(IWebDriverAdapter driver) : base(driver)
        {
            Prefix = "div#customerDiv.container ";
        }
    }
}