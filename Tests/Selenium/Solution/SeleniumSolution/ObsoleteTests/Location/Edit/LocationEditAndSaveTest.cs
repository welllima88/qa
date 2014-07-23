using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Location.Edit
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
            TestData.ValueObjects.Location l = TestData.Factory.Location.Edit();
            Workflow.Location.Edit(l);

            NavigationBar.Lobby.Click();
            RecentElements.Latest.Click();

            Testlogic.Location.Check(l);
        }
    }
}