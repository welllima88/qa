using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Location.Create
{
    [TestClass]
    public class LocationCreateTest
    {
        private static TestData.ValueObjects.Location _l;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate("Customer/?CustomerId=401983");
            _l = TestData.Factory.Location.Create();
            Workflow.Location.Create(_l);
        }

        [TestMethod]
        public void Location()
        {
            Testlogic.Location.Check(_l);
        }

        [TestMethod]
        public void RecentElementsCheck()
        {
            NavigationBar.Lobby.Click();
            RecentElements.Latest.Click();

            Testlogic.Location.Check(_l);
        }
    }
}