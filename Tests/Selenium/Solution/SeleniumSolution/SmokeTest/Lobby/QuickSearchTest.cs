using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.View.Common;
using Six.Scs.QA.Selenium.View.Search;

namespace Six.Scs.QA.Selenium.SmokeTest.Lobby
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestFixture]
    public class QuickSearchTest
    {
        [SetUp]
        public void ClassInit()
        {
            TestDirector.Navigate();
        }

        [Test]
        [Category("LobbyCheck")]
        public void ClickSearchButtonLaunchesSearch()
        {
            QuickSearch.SearchField = "Click-Search";
            QuickSearch.SearchButton.Click();
            StringAssert.Contains("Click-Search", SearchResult.Headline);
        }

        [Test]
        [Category("LobbyCheck")]
        public void HitEnterLaunchesSearch()
        {
            QuickSearch.SearchField = "Hit-Enter";
            QuickSearch.HitEnter();
            StringAssert.Contains("Hit-Enter", SearchResult.Headline);
        }
    }
}