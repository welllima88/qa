using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Extension.TestObjects.Common;
using Six.Scs.QA.Selenium.Extension.TestObjects.Common.Menu;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.Tests.LogOn
{
    /// <summary>
    ///     Some checks which validate a successful login
    /// </summary>
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