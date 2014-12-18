using NUnit.Framework;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Terminal.Duplicate;
using Six.Scs.QA.TestData.Factory;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Terminal.Duplicate
{
    [TestFixture]
    public class TerminalDuplicateTest
    {
        [SetUp]
        public void TestInit()
        {
            TestDirector.Navigate("TerminalDuplicate?TerminalId=21013049");
            Factory.GenerateTestId();
        }

        [Test]
        public void DuplicateTerminalWithCopyPasswordWithAcquirerNotificationToLocation()
        {
            View.NumberOfTerminals = "2";
            View.CopyPassword = true;
            View.AcquirerNotification = true;
            // TerminalDuplicate.Location = "";
            View.InstallationMessage =
                "DuplicateTerminalWithCopyPasswordWithAcquirerNotificationToLocation";

            View.DulpicateButton.Click();
        }

        [Test]
        public void DuplicateTerminalWithNoCopyPasswordWithNoAcquirerNotificationToCustomerLocation()
        {
            View.NumberOfTerminals = "3";
            View.CopyPassword = false;
            View.AcquirerNotification = false;
            // TerminalDuplicate.Location = "";
            View.InstallationMessage =
                "DuplicateTerminalWithCopyPasswordWithAcquirerNotificationToLocation";
            View.DulpicateButton.Click();
        }
    }
}