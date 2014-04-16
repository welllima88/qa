using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.Selenium;
using SIX.SCS.QA.Selenium.Extension.TestData;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Definitions;
using SIX.SCS.QA.Selenium.Extension.Worklow;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Location.Edit
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
            LocationData l = Factory.Location.Edit();
            LocationService.Edit(l);

            NavigationBar.Lobby.Click();
            RecentElements.Latest.Click();

            LocationService.Check(l);
        }
    }
}