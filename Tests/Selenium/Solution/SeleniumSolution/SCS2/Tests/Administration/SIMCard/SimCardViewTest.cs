using System.Text.RegularExpressions;
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
        private static LobbyView _lobby;
        private static TestDirector _tb;


        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            //before first test-method starts
            _tb = new ScsPlatinTestDirector();
            _driver = _tb.DefaultTestSetup(); //default QA-L with certificate login and 10 seconds response timeout

            _simCardView = new SimCardView(_driver);
            _navigationBar = new NavigationBar(_driver);
            _lobby = new LobbyView(_driver);
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
            StringAssert.Matches(_simCardView.SimCardElement.MobileNumber, new Regex(@"\d{10}"));
            StringAssert.Matches(_simCardView.SimCardElement.SimCardNumber, new Regex(@"\d{18}"));
            StringAssert.Matches(_simCardView.SimCardElement.Pin, new Regex(@"\d{4}"));
            StringAssert.Matches(_simCardView.SimCardElement.Puk, new Regex(@"\d{8}"));
            StringAssert.Matches(_simCardView.SimCardElement.TerminalId, new Regex(@"\d+"));
            Assert.IsNotNull(_simCardView.SimCardElement.Status);
            Assert.IsNotNull(_simCardView.SimCardElement.Region);
            Assert.IsNotNull(_simCardView.SimCardElement.Usage);
        }

        [TestMethod]
        public void SimCardMenu()
        {
            Assert.IsTrue(_lobby.Menu.SimCard.SimCardManagement.Displayed);
        }

        [TestMethod]
        public void CheckNavigationBar()
        {
        }
    }
}