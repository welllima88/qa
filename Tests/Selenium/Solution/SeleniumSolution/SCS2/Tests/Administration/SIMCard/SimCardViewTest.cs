using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Administration.SimCard;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Administration.SIMCard
{
    [TestClass]
    public class SimCardCreateTest
    {
        private static SimCardView SimCardView;
        private static LobbyView LobbyView;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            SimCardView = new SimCardView();
            LobbyView = new LobbyView();
        }

        [TestInitialize]
        public void TestInit()
        {
            TestLauncher.Navigate("/SIMCard/Details?SIMCardId=1");
        }

        [TestMethod]
        public void CheckSimCardView()
        {
            StringAssert.Matches(SimCardView.SimCardElement.MobileNumber, new Regex(@"\d{10}"));
            StringAssert.Matches(SimCardView.SimCardElement.SimCardNumber, new Regex(@"\d{18}"));
            StringAssert.Matches(SimCardView.SimCardElement.Pin, new Regex(@"\d{4}"));
            StringAssert.Matches(SimCardView.SimCardElement.Puk, new Regex(@"\d{8}"));
            StringAssert.Matches(SimCardView.SimCardElement.TerminalId, new Regex(@"\d+"));
            Assert.IsNotNull(SimCardView.SimCardElement.Status);
            Assert.IsNotNull(SimCardView.SimCardElement.Region);
            Assert.IsNotNull(SimCardView.SimCardElement.Usage);
        }

        [TestMethod]
        public void SimCardMenuCheck()
        {
            Assert.IsTrue(SimCardMenu.SimCardManagement.Displayed);
        }

        [TestMethod]
        public void CheckNavigationBar()
        {
        }
    }
}