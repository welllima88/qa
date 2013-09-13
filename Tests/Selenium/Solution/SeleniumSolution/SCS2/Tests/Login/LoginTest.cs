using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Common;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Login
{
    [TestClass]
    public class LoginTest
    {
        private static LobbyView _lobby;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _lobby = new LobbyView();
            TestLauncher.Navigate("");
        }

        [TestCategory("BasicLoginTest")]
        [TestMethod]
        public void ApplicationName()
        {
            Assert.IsTrue(_lobby.ApplicationInfo.ApplicationName.Displayed);
        }

        [TestCategory("BasicLoginTest")]
        [TestMethod]
        public void CompanyLogo()
        {
            Assert.IsTrue(_lobby.CompanyLogo.Displayed);
        }

        [TestCategory("BasicLoginTest")]
        [TestMethod]
        public void LobbyMenu()
        {
            Assert.IsTrue(_lobby.Menu.Lobby.Displayed);
        }
    }
}