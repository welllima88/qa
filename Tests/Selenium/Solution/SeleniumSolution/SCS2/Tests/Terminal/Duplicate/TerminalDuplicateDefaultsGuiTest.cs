﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.Tests.Selenium.Extension;
using Six.Scs.Tests.Selenium.Extension.TestObjects.Terminal.Duplicate;
using Six.Scs.Tests.Selenium.Extension.WebDriver;

namespace Six.Scs.Tests.Selenium.Tests.Terminal.Duplicate
{
    [TestClass]
    public class TerminalDuplicateDefaultsGuiTest
    {
        [TestInitialize]
        public void TestInit()
        {
            TestDirector.Navigate("TerminalDuplicate?TerminalId=21013049");
        }

        [TestMethod]
        public void NumberOfTerminals()
        {
            Assert.AreEqual("1", TerminalDuplicate.NumberOfTerminals);
        }

        [TestMethod]
        public void CopyPassword()
        {
            Assert.AreEqual(false, TerminalDuplicate.CopyPassword);
        }

        [TestMethod]
        public void AcquirerNotification()
        {
            Assert.AreEqual(false, TerminalDuplicate.AcquirerNotification);
        }

        [TestMethod]
        public void Location()
        {
            StringAssert.Matches(TerminalDuplicate.Location, TestRegExpPatterns.NotEmpty);
        }

        [TestMethod]
        public void InstallationMessage()
        {
            Assert.AreEqual("", TerminalDuplicate.InstallationMessage);
        }
    }
}