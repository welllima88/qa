using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Massmuation;
using Six.Scs.QA.Selenium.Terminal.Dashboard.Portlets;
using Six.Scs.QA.Selenium.Terminal.Duplicate;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Terminal.Duplicate
{
    [TestClass]
    public class TerminalDuplicateWithSamePasswortTest
    {
        private const int NumberOfTerminals = 5;
        private const string TerminalId = "21013049";

        [ClassInitialize]
        public static void TestInit(TestContext testContext)
        {
            TestDirector.Navigate("TerminalDashboard/?TerminalId=" + TerminalId);
            SalesContract.TerminalDuplicate.Click();
            View.NumberOfTerminals = NumberOfTerminals.ToString();
            View.InstallationMessage = "TerminalDuplicateWithSamePasswortTest";
            View.CopyPassword = true;
            View.DulpicateButton.Click();
        }

        [TestMethod]
        public void PasswordsAreSame()
        {
            Assert.AreEqual(1, TerminalValidation.Passwords.Distinct().Count());
        }

        [TestMethod]
        public void LocationsAreSame()
        {
            Assert.AreEqual(1, TerminalValidation.Locations.Distinct().Count());
        }

        [TestMethod]
        public void ReferenceTerminalIdsAreEqual()
        {
            foreach (string referenceTerminalId in TerminalValidation.ReferenceTerminalIds)
            {
                Assert.AreEqual(TerminalId, referenceTerminalId);
            }
        }

        [TestMethod]
        public void NumberOfTerminalsToDuplicate()
        {
            Assert.AreEqual(TerminalValidation.Count, NumberOfTerminals);
        }
    }
}