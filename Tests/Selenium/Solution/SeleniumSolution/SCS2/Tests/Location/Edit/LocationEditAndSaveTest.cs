using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.Tests.Selenium.Extension.TestData;
using Six.Scs.Tests.Selenium.Extension.TestObjects.Common;
using Six.Scs.Tests.Selenium.Extension.TestObjects.Definitions;
using Six.Scs.Tests.Selenium.Extension.WebDriver;
using Six.Scs.Tests.Selenium.Extension.Worklow;

namespace Six.Scs.Tests.Selenium.Tests.Location.Edit
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