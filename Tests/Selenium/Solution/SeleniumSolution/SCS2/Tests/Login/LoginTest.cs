using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.Login;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Login
{
    [TestClass]
    public class LoginTest : ILoginCheck
    {
        private static TestDirector _tb;
        private static IWebDriverAdapter _driver;
        private static Lobby _lobby;

        #region ILoginCheck Members

        public void CheckLogInSucess()
        {
            throw new NotImplementedException("Needs to make sure that _lobby is valid value (circular)");
        }

        #endregion

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            //before first test-method starts
            _tb = new ScsPlatinTestDirector();
            _driver = _tb.WebDriver;
            _tb.DefaultTestSetup(); //default QA-L with certificate login and 10 seconds response timeout
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
        public void SuccessfullLoginTest()
        {
            Assert.IsTrue(_lobby.ApplicationInfo.ApplicationName.Displayed);
            Assert.IsTrue(_lobby.CompanyLogo.Displayed);
            Assert.IsTrue(_lobby.Menu.Lobby.Displayed);
        }
    }
}