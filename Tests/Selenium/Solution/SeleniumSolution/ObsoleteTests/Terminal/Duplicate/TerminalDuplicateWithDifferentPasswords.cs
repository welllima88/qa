using System.Linq;
using NUnit.Framework;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Massmuation;
using Six.Scs.QA.Selenium.Terminal.Dashboard.Portlets;
using Six.Scs.QA.Selenium.Terminal.Duplicate;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Terminal.Duplicate
{
    [TestFixture]
    public class TerminalDuplicateWithDifferentPasswords
    {
        private const int NumberOfDuplications = 10;
        private const string TerminalId = "21013049";

        [TestFixtureSetUp]
        public static void TestInit()
        {
            TestDirector.Navigate("TerminalDashboard/?TerminalId=" + TerminalId);
            SalesContract.TerminalDuplicate.Click();
            View.NumberOfTerminals = NumberOfDuplications.ToString();
            View.CopyPassword = false;
            View.DulpicateButton.Click();
        }

        [Test]
        public void PasswordsAreDifferent()
        {
            CollectionAssert.AllItemsAreUnique(TerminalValidation.Passwords);
            Assert.AreEqual(NumberOfDuplications, TerminalValidation.Passwords.Distinct().Count());
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
            Assert.AreEqual(NumberOfDuplications, TerminalValidation.Count);
        }
    }
}