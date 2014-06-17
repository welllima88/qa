﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.Tests.Selenium.Extension.TestData;
using Six.Scs.Tests.Selenium.Extension.TestObjects.Terminal.Duplicate;
using Six.Scs.Tests.Selenium.Extension.WebDriver;

namespace Six.Scs.Tests.Selenium.Tests.Terminal.Duplicate
{
    [TestClass]
    public class TerminalDuplicateTest
    {
        private string _dt;

        [TestInitialize]
        public void TestInit()
        {
            TestDirector.Navigate("TerminalDuplicate?TerminalId=21013049");
            _dt = Factory.GenerateTestId();
        }

        [TestMethod]
        public void DuplicateTerminalWithCopyPasswordWithAcquirerNotificationToLocation()
        {
            TerminalDuplicate.NumberOfTerminals = "2";
            TerminalDuplicate.CopyPassword = true;
            TerminalDuplicate.AcquirerNotification = true;
            // TerminalDuplicate.Location = "";
            TerminalDuplicate.InstallationMessage =
                "DuplicateTerminalWithCopyPasswordWithAcquirerNotificationToLocation";

            TerminalDuplicate.DulpicateButton.Click();
        }

        [TestMethod]
        public void DuplicateTerminalWithNoCopyPasswordWithNoAcquirerNotificationToCustomerLocation()
        {
            TerminalDuplicate.NumberOfTerminals = "3";
            TerminalDuplicate.CopyPassword = false;
            TerminalDuplicate.AcquirerNotification = false;
            // TerminalDuplicate.Location = "";
            TerminalDuplicate.InstallationMessage =
                "DuplicateTerminalWithCopyPasswordWithAcquirerNotificationToLocation";
            TerminalDuplicate.DulpicateButton.Click();
        }
    }
}