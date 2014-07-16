﻿/* RegExp
 * http://openbook.galileocomputing.de/csharp/kap17.htm
 * 
 * Strings als Parameter:
 * http://openbook.galileocomputing.de/csharp/kap19.htm
 * "Kundenname" statt k.Name Feld-Bezeichnung ist viel flexibler für zukünftige Struktur
 *  
 * http://openbook.galileocomputing.de/csharp/kap31.htm#t25
 * 
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.SearchResult;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Lobby
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestClass]
    public class QuickSearchTest
    {
        [TestInitialize]
        public void ClassInit()
        {
            TestDirector.Navigate();
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void ClickSearchButtonLaunchesSearch()
        {
            QuickSearch.SearchField = "Click-Search";
            QuickSearch.SearchButton.Click();
            StringAssert.Contains(SearchResults.Headline, "Click-Search");
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void HitEnterLaunchesSearch()
        {
            QuickSearch.SearchField = "Hit-Enter";
            QuickSearch.HitEnter();
            StringAssert.Contains(SearchResults.Headline, "Hit-Enter");
        }
    }
}