using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Extension.TestData;
using Six.Scs.QA.Selenium.Extension.TestData.Factory;
using Six.Scs.QA.Selenium.Extension.TestData.ValueObjects;
using Six.Scs.QA.Selenium.Extension.TestObjects.Common;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Extension.Worklow;

namespace Six.Scs.QA.Selenium.Tests.Location.Create
{
    [TestClass]
    public class LocationCreateTest
    {
        private static LocationData _l;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate("Customer/?CustomerId=401983");
            _l = LocationFactory.Create();
            LocationService.Create(_l);
        }

        [TestMethod]
        public void Location()
        {
            LocationService.Check(_l);
        }

        [TestMethod]
        public void RecentElementsCheck()
        {
            NavigationBar.Lobby.Click();
            RecentElements.Latest.Click();

            LocationService.Check(_l);
        }
    }
}