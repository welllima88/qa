using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Customer;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Location;
using SIX.SCS.QA.Selenium.Extension.TestObjects.SearchResult;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Regression
{
    [TestClass]
    public class TryTest
    {
        [TestMethod]
        public void SearchButton()
        {
            for (int i = 0; i < 10; i++)
            {
                QuickSearch.SearchField = "1382705283807";
                QuickSearch.SearchButton.Click();

                LocationResult.Result().Click();
                Assert.AreEqual("e7fc5338-dff2-4556-866d-27b96d225a97", LocationView.Guid);
            }
        }

        [TestMethod]
        public void HitEnter()
        {
            for (int i = 0; i < 10; i++)
            {
                QuickSearch.SearchField = "1382705283807";
                QuickSearch.HitEnter();

                LocationResult.Result().Click();
                Assert.AreEqual("e7fc5338-dff2-4556-866d-27b96d225a97", LocationView.Guid);
            }
        }        [TestMethod]
        public void SearchButtonC()
        {
            for (int i = 0; i < 10; i++)
            {
                QuickSearch.SearchField = "Kunde635291813584619755";
                QuickSearch.SearchButton.Click();

                CustomerResult.Result().Click();
                Assert.AreEqual("SYR Kunde635291813584619755", CustomerView.CustomerName);
            }
        }

        [TestMethod]
        public void HitEnterC()
        {
            for (int i = 0; i < 10; i++)
            {
                QuickSearch.SearchField = "Kunde635291813584619755";
                QuickSearch.HitEnter();

                CustomerResult.Result().Click();
                Assert.AreEqual("SYR Kunde635291813584619755", CustomerView.CustomerName);
            }
        }
    }
}