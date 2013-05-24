using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Login
{
    [TestClass]
    public class LoginTest
    {
        private static TestDirector _tb;
        private static IWebDriverAdapter _driver;
        private static Lobby _lobby;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _tb = new ScsPlatinTestDirector();
            _driver = _tb.DefaultTestSetup();
            _lobby = new Lobby(_driver);
        }

        [TestInitialize]
        public void TestInit()
        {
        }

        [TestCleanup]
        public void TestCleanup()
        {
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            //after last test-method finished
            _tb.ShutDownTest();
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