using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Extension;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Terminal.Duplicate;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Terminal.Duplicate
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
            Assert.AreEqual("1", View.NumberOfTerminals);
        }

        [TestMethod]
        public void CopyPassword()
        {
            Assert.AreEqual(false, View.CopyPassword);
        }

        [TestMethod]
        public void AcquirerNotification()
        {
            Assert.AreEqual(false, View.AcquirerNotification);
        }

        [TestMethod]
        public void Location()
        {
            StringAssert.Matches(View.Location, new Regex(TestRegExpPatterns.NotEmpty));
        }

        [TestMethod]
        public void InstallationMessage()
        {
            Assert.AreEqual("", View.InstallationMessage);
        }
    }
}