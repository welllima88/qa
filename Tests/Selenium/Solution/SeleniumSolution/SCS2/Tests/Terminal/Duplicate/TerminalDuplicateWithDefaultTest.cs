using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal.Duplicate;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Terminal.Duplicate
{
    [TestClass]
    public class TerminalDuplicateWithDefaultTest
    {
        [TestInitialize]
        public void TestInit()
        {
            TestDirector.Navigate("TerminalDuplicate?TerminalId=21013049");
            TerminalDuplicate.DulpicateButton.Click();
        }

        [TestMethod]
        public void DuplicateTerminalWithCopyPasswordWithAcquirerNotificationToLocation()
        {
            TerminalDuplicate.NumberOfTerminals = "2";
            TerminalDuplicate.CopyPassword = true;
            TerminalDuplicate.AcquirerNotification = true;
            TerminalDuplicate.Location = "";
            TerminalDuplicate.InstallationMessage =
                "DuplicateTerminalWithCopyPasswordWithAcquirerNotificationToLocation";
        }

        [TestMethod]
        public void DuplicateTerminalWithNoCopyPasswordWithNoAcquirerNotificationToCustomerLocation()
        {
            TerminalDuplicate.NumberOfTerminals = "3";
            TerminalDuplicate.CopyPassword = false;
            TerminalDuplicate.AcquirerNotification = false;
            TerminalDuplicate.Location = "";
            TerminalDuplicate.InstallationMessage =
                "DuplicateTerminalWithCopyPasswordWithAcquirerNotificationToLocation";
            TerminalDuplicate.DulpicateButton.Click();
        }
    }
}