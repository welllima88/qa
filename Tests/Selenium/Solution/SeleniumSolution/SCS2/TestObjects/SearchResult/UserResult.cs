using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.SearchResult
{
    internal class UserResult : AbstractSearchResult
    {
        public UserResult(IWebDriverAdapter driver)
            : base(driver)
        {
            Prefix = "div#userDiv.container ";
        }
    }
}