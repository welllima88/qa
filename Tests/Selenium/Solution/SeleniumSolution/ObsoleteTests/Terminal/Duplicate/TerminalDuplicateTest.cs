using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.TestData.Factory;
using TerminalDuplicate = Six.Scs.QA.Selenium.Terminal.Duplicate.TerminalDuplicate;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Terminal.Duplicate
{
    [TestClass]
    public class TerminalDuplicateTest
    {
        [TestInitialize]
        public void TestInit()
        {
            TestDirector.Navigate("TerminalDuplicate?TerminalId=21013049");
            Factory.GenerateTestId();
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