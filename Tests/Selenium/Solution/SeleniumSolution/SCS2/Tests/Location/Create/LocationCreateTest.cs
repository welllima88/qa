﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.Tests.Selenium.Extension.TestData;
using Six.Scs.Tests.Selenium.Extension.TestObjects.Common;
using Six.Scs.Tests.Selenium.Extension.TestObjects.Definitions;
using Six.Scs.Tests.Selenium.Extension.WebDriver;
using Six.Scs.Tests.Selenium.Extension.Worklow;

namespace Six.Scs.Tests.Selenium.Tests.Location.Create
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