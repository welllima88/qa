using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Administration.SimCard;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Administration.SIMCard
{
    [TestClass]
    public class SimCardViewTest
    {
        [TestInitialize]
        public void TestInit()
        {
            TestDirector.Navigate("/SIMCard/New");
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

            SimCardCreate.NetProvider = netProvider;
            SimCardCreate.SimCardNumber = simCardNumber;
            SimCardCreate.MobileNumber = mobileNumber;
            SimCardCreate.Pin = pin;
            SimCardCreate.Puk = puk;
            SimCardCreate.Region = region;
            SimCardCreate.Usage = usage;
            SimCardCreate.SaveButton.Click();

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