using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Massmuation;
using Six.Scs.QA.Selenium.Terminal.Dashboard;
using Six.Scs.QA.Selenium.Terminal.Duplicate;

namespace Six.Scs.QA.Selenium.Tests.Terminal.Duplicate
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
            SalesContractPortlet.TerminalDuplicate.Click();
            TerminalDuplicate.NumberOfTerminals = NumberOfTerminals.ToString();
            TerminalDuplicate.InstallationMessage = "TerminalDuplicateWithSamePasswortTest";
            TerminalDuplicate.CopyPassword = true;
            TerminalDuplicate.DulpicateButton.Click();
        }

        [TestMethod]
        public void PasswordsAreSame()
        {
            Assert.AreEqual(1, TerminalMassValidation.Passwords.Distinct().Count());
        }

        [TestMethod]
        public void LocationsAreSame()
        {
            Assert.AreEqual(1, TerminalMassValidation.Locations.Distinct().Count());
        }

        [TestMethod]
        public void ReferenceTerminalIdsAreEqual()
        {
            foreach (string referenceTerminalId in TerminalMassValidation.ReferenceTerminalIds)
            {
                Assert.AreEqual(TerminalId, referenceTerminalId);
            }
        }

        [TestMethod]
        public void NumberOfTerminalsToDuplicate()
        {
            Assert.AreEqual(TerminalMassValidation.Count, NumberOfTerminals);
        }
    }
}