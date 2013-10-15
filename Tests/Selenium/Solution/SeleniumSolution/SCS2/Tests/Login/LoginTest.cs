using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Login
{
    [TestClass]
    public class LoginTest
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate();
        }

        [TestCategory("Application")]
        [TestMethod]
        public void ApplicationName()
        {
            Assert.IsTrue(ApplicationInfo.ApplicationName.Displayed);
        }

        [TestCategory("Logo")]
        [TestMethod]
        public void CompanyLogo()
        {
            Assert.IsTrue(LobbyView.CompanyLogo.Displayed);
        }

        [TestCategory("LobbyMenu")]
        [TestMethod]
        public void LobbyMenuCheck()
        {
            Assert.IsTrue(LobbyMenu.Lobby.Displayed);
        }
    }
}