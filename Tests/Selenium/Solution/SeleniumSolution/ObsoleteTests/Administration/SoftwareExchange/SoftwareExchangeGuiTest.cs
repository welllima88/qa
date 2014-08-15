using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Administration.SoftwareExchange;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Administration.SoftwareExchange
{
    [TestClass]
    public class SoftwareExchangeGuiTest
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate("MasterSoftwareExchange/");
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void SelectedTerminalType()
        {
            Assert.IsTrue(Create.SelectedTerminalType.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void IncludeDeactivated()
        {
            Assert.IsTrue(Create.IncludeDeactivated.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void IncludeCanceled()
        {
            Assert.IsTrue(Create.IncludeCanceled.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void SelectedCurrentRelease()
        {
            Assert.IsTrue(Create.SelectedCurrentRelease.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void SelectedNewRelease()
        {
            Assert.IsTrue(Create.SelectedNewRelease.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void SelectedNetType()
        {
            Assert.IsTrue(Create.SelectedNetType.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void TidRangeStart()
        {
            Assert.IsTrue(Create.TidRangeStart.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void TidRangeEnd()
        {
            Assert.IsTrue(Create.TidRangeEnd.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void TerminalIdSelection()
        {
            Assert.IsTrue(Create.TerminalIdSelection.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void RecallNextFrom()
        {
            Assert.IsTrue(Create.RecallNextFrom.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void RecallNextUntil()
        {
            Assert.IsTrue(Create.RecallNextUntil.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void SelectedSupplierMandant()
        {
            Assert.IsTrue(Create.SelectedSupplierMandant.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void IncludeKeyAccounts()
        {
            Assert.IsTrue(Create.IncludeKeyAccounts.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void CustomerIds()
        {
            Assert.IsTrue(Create.CustomerIds.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void Zips()
        {
            Assert.IsTrue(Create.Zips.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void SelectedCountry()
        {
            Assert.IsTrue(Create.SelectedCountry.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void ResultLimit()
        {
            Assert.IsTrue(Create.ResultLimit.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void RefreshButton()
        {
            Assert.IsTrue(Create.RefreshButton.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void BatchTitle()
        {
            Assert.IsTrue(Create.BatchTitle.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void SelectAllSwitch()
        {
            Assert.IsTrue(Create.SelectAllSwitch.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void SelectOddEvenSwitch()
        {
            Assert.IsTrue(Create.SelectOddEvenSwitch.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void StartDateTime()
        {
            Assert.IsTrue(Create.StartDateTime.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void BatchCreateButton()
        {
            Assert.IsTrue(Create.BatchCreateButton.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void SelectedNewTargetRelease()
        {
            Assert.IsTrue(Create.SelectedNewTargetRelease.Displayed);
        }
    }
}