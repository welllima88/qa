using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Search
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestClass]
    public class SearchForCustomerByIdTest
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestLauncher.Navigate("");
            QuickSearch.SearchField.TypeText("85025");
            QuickSearch.SearchButton.Click();
        }

        [TestMethod]
        [TestCategory("Search"), TestCategory("Customer")]
        public void SearchById()
        {
        }
    }
}