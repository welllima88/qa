﻿using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Extension;
using Six.Scs.QA.Selenium.Extension.TestObjects.Administration.SimCard;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.Tests.Administration.SIMCard
{
    [TestClass]
    public class SimCardViewTest
    {
        [TestInitialize]
        public void TestInit()
        {
            TestDirector.Navigate("SIMCard/New");
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

            Assert.AreEqual(SimCardView.NetProvider, netProvider);
            Assert.AreEqual(SimCardView.SimCardNumber, simCardNumber);
            Assert.AreEqual(SimCardView.MobileNumber, mobileNumber);
            Assert.AreEqual(SimCardView.Pin, pin);
            Assert.AreEqual(SimCardView.Puk, puk);
            Assert.AreEqual(SimCardView.Status, true);
            Assert.AreEqual(SimCardView.TerminalId, "");
            Assert.AreEqual(SimCardView.Region, region);
            Assert.AreEqual(SimCardView.Usage, usage);

            Assert.IsTrue(SimCardHistory.HistoryList.Count == 1);
            // "13.12.2012 15:49:27 tksyr SIM-Karte erfasst"
            StringAssert.Matches(SimCardHistory.HistoryList[0],
                new Regex(TestRegExpPatterns.DateTime + " " + TestRegExpPatterns.UserName +
                          " SIM Karte erfasst"));
        }
    }
}