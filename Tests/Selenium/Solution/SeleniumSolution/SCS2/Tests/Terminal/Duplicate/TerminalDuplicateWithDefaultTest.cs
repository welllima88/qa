using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Massmuation;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal.Dashboard;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal.Duplicate;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Terminal.Duplicate
{
    [TestClass]
    public class TerminalDuplicateWithDefaultTest
    {
        private const int NumberOfTerminals = 10;

        [ClassInitialize]
        public static void TestInit(TestContext testContext)
        {
            TestDirector.Navigate("TerminalDashboard/?TerminalId=21013049");
            SalesContractPortlet.TerminalDuplicate.Click();
            TerminalDuplicate.NumberOfTerminals = NumberOfTerminals;
            TerminalDuplicate.InstallationMessage = "TerminalDuplicateWithDefaultTest";
            TerminalDuplicate.DulpicateButton.Click();
        }

        [TestMethod]
        public void PasswordsAreDifferent()
        {
            CollectionAssert.AllItemsAreUnique(TerminalMassValidation.Passwords);
        }

        [TestMethod]
        public void ReferenceTerminalIdsAreEqual()
        {
            foreach (string referenceTerminalId in TerminalMassValidation.ReferenceTerminalIds)
            {
                Assert.AreEqual("21013049", referenceTerminalId);
            }
        }

        [TestMethod]
        public void NumberOfTerminalsToDuplicate()
        {
            Assert.AreEqual(TerminalMassValidation.Count, NumberOfTerminals);
        }
    }
}