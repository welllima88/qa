using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Administration.SimCard;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Administration.SIMCard
{
    [TestClass]
    public class SimCardViewTest
    {
        private static SimCardView SimCardView;
        private static SimCardCreate _simCardCreate;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            SimCardView = new SimCardView();
            _simCardCreate = new SimCardCreate();
        }

        [TestInitialize]
        public void TestInit()
        {
            TestLauncher.Navigate("/SIMCard/New");
        }

        [TestMethod]
        public void CreateSimCardAndSave()
        {
            string netProvider = "SIX via Swisscom";
            string simCardNumber = "0123456789012345679";
            string mobileNumber = "0123456789";
            string puk = "01234567";
            string pin = "0123";
            string region = "Schweiz";
            string usage = "Kauf";

            _simCardCreate.NetProvider = netProvider;
            _simCardCreate.SimCardNumber = simCardNumber;
            _simCardCreate.MobileNumber = mobileNumber;
            _simCardCreate.Pin = pin;
            _simCardCreate.Puk = puk;
            _simCardCreate.Region = region;
            _simCardCreate.Usage = usage;
            _simCardCreate.SaveButton.Click();

            Assert.AreEqual(SimCardView.SimCardElement.NetProvider, netProvider);
            Assert.AreEqual(SimCardView.SimCardElement.SimCardNumber, simCardNumber);
            Assert.AreEqual(SimCardView.SimCardElement.MobileNumber, mobileNumber);
            Assert.AreEqual(SimCardView.SimCardElement.Pin, pin);
            Assert.AreEqual(SimCardView.SimCardElement.Puk, puk);
            Assert.AreEqual(SimCardView.SimCardElement.Status, true);
            Assert.AreEqual(SimCardView.SimCardElement.TerminalId, "");
            Assert.AreEqual(SimCardView.SimCardElement.Region, region);
            Assert.AreEqual(SimCardView.SimCardElement.Usage, usage);

            Assert.IsTrue(SimCardView.SimCardHistory.HistoryList.Count == 1);
            // "13.12.2012 15:49:27 tksyr SIM-Karte erfasst"
            StringAssert.Matches(SimCardView.SimCardHistory.HistoryList[0],
                                 new Regex(TestRegExpPatterns.DateTime + " " + TestRegExpPatterns.UserName +
                                           " SIM Karte erfasst"));
        }
    }
}