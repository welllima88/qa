using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.Selenium;
using SIX.SCS.QA.Selenium.Extension.TestData;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Definitions;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Location;
using SIX.SCS.QA.Selenium.Extension.Worklow;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Location.Create
{
    [TestClass]
    public class LocationCreateTest
    {
        private static LocationData _l;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate("Customer/?CustomerId=401983");
            _l = Factory.Location.Create();
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