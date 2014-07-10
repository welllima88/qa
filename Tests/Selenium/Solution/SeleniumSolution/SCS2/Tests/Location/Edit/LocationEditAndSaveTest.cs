using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Extension.TestData;
using Six.Scs.QA.Selenium.Extension.TestData.Factory;
using Six.Scs.QA.Selenium.Extension.TestData.ValueObjects;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Extension.Worklow;

namespace Six.Scs.QA.Selenium.Tests.Location.Edit
{
    [TestClass]
    public class LocationEditAndSaveTest
    {
        [ClassInitialize]
        public static void Init(TestContext testContext)
        {
            TestDirector.Navigate("Location/?LOCATIONID=071b90c2-c8c5-42c5-87c5-d816b26b0a1a");
        }

        [TestMethod]
        public void EditLocationAndSave()
        {
            LocationData l = LocationFactory.Edit();
            LocationService.Edit(l);

            NavigationBar.Lobby.Click();
            RecentElements.Latest.Click();

            LocationService.Check(l);
        }
    }
}