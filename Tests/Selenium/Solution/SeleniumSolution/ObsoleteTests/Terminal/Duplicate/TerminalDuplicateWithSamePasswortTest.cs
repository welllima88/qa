using System.Linq;
using NUnit.Framework;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Massmuation;
using Six.Scs.QA.Selenium.Terminal.Dashboard.Portlets;
using Six.Scs.QA.Selenium.Terminal.Duplicate;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Terminal.Duplicate
{
    [TestFixture]
    public class TerminalDuplicateWithSamePasswortTest
    {
        private const int NumberOfTerminals = 5;
        private const string TerminalId = "21013049";

        [TestFixtureSetUp]
        public static void TestInit()
        {
            TestDirector.Navigate("TerminalDashboard/?TerminalId=" + TerminalId);
            SalesContract.TerminalDuplicate.Click();
            View.NumberOfTerminals = NumberOfTerminals.ToString();
            View.InstallationMessage = "TerminalDuplicateWithSamePasswortTest";
            View.CopyPassword = true;
            View.DulpicateButton.Click();
        }

        [Test]
        public void PasswordsAreSame()
        {
            Assert.AreEqual(1, TerminalValidation.Passwords.Distinct().Count());
        }

        [Test]
        public void LocationsAreSame()
        {
            Assert.AreEqual(1, TerminalValidation.Locations.Distinct().Count());
        }

        [Test]
        public void ReferenceTerminalIdsAreEqual()
        {
            foreach (string referenceTerminalId in TerminalValidation.ReferenceTerminalIds)
            {
                Assert.AreEqual(TerminalId, referenceTerminalId);
            }
        }

        [Test]
        public void NumberOfTerminalsToDuplicate()
        {
            Assert.AreEqual(TerminalValidation.Count, NumberOfTerminals);
        }
    }
}