using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Administration.SimCard;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Common;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Administration.SIMCard
{
    [TestClass]
    public class SimCardCreateTest
    {
        private static SimCardView _simCardView;
        private static LobbyView _lobby;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _simCardView = new SimCardView();
            _lobby = new LobbyView();
        }

        [TestInitialize]
        public void TestInit()
        {
            TestLauncher.Navigate("/SIMCard/Details?SIMCardId=1");
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