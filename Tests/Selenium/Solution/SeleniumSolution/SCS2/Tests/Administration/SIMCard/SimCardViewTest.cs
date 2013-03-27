using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Administration.SimCard;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Administration.SIMCard
{
    [TestClass]
    public class SimCardCreateTest
    {
        private static SimCardView _simCardView;
        private static IWebDriverAdapter _driver;
        private static NavigationBar _navigationBar;
        private static Lobby _lobby;
        private static TestDirector _tb;


        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            //before first test-method starts
            _tb = new ScsPlatinTestDirector();
            _driver = _tb.DefaultTestSetup(); //default QA-L with certificate login and 10 seconds response timeout

            _simCardView = new SimCardView(_driver);
            _navigationBar = new NavigationBar(_driver);
            _lobby = new Lobby(_driver);
        }

        [TestInitialize]
        public void TestInit()
        {
            // todo: specify generic url to sim
            _driver.Url = _tb.BaseUrl + "/SIMCard/Details?SIMCardId=1";
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

        [TestMethod]
        public void CheckSimCardView()
        {
        }

        [TestMethod]
        public void CheckLobbyMenu()
        {
            Assert.IsTrue(_lobby.Menu.SimCardManagement.Displayed);
        }

        [TestMethod]
        public void CheckNavigationBar()
        {
        }
    }
}