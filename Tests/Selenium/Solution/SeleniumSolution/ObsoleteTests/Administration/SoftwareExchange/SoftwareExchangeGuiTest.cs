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
            Assert.IsTrue(SoftwareExchangeCreate.SelectedTerminalType.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void IncludeDeactivated()
        {
            Assert.IsTrue(SoftwareExchangeCreate.IncludeDeactivated.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void IncludeCanceled()
        {
            Assert.IsTrue(SoftwareExchangeCreate.IncludeCanceled.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void SelectedCurrentRelease()
        {
            Assert.IsTrue(SoftwareExchangeCreate.SelectedCurrentRelease.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void SelectedNewRelease()
        {
            Assert.IsTrue(SoftwareExchangeCreate.SelectedNewRelease.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void SelectedNetType()
        {
            Assert.IsTrue(SoftwareExchangeCreate.SelectedNetType.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void TidRangeStart()
        {
            Assert.IsTrue(SoftwareExchangeCreate.TidRangeStart.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void TidRangeEnd()
        {
            Assert.IsTrue(SoftwareExchangeCreate.TidRangeEnd.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void TerminalIdSelection()
        {
            Assert.IsTrue(SoftwareExchangeCreate.TerminalIdSelection.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void RecallNextFrom()
        {
            Assert.IsTrue(SoftwareExchangeCreate.RecallNextFrom.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void RecallNextUntil()
        {
            Assert.IsTrue(SoftwareExchangeCreate.RecallNextUntil.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void SelectedSupplierMandant()
        {
            Assert.IsTrue(SoftwareExchangeCreate.SelectedSupplierMandant.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void IncludeKeyAccounts()
        {
            Assert.IsTrue(SoftwareExchangeCreate.IncludeKeyAccounts.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void CustomerIds()
        {
            Assert.IsTrue(SoftwareExchangeCreate.CustomerIds.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void Zips()
        {
            Assert.IsTrue(SoftwareExchangeCreate.Zips.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void SelectedCountry()
        {
            Assert.IsTrue(SoftwareExchangeCreate.SelectedCountry.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void ResultLimit()
        {
            Assert.IsTrue(SoftwareExchangeCreate.ResultLimit.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void RefreshButton()
        {
            Assert.IsTrue(SoftwareExchangeCreate.RefreshButton.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void BatchTitle()
        {
            Assert.IsTrue(SoftwareExchangeCreate.BatchTitle.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void SelectAllSwitch()
        {
            Assert.IsTrue(SoftwareExchangeCreate.SelectAllSwitch.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void SelectOddEvenSwitch()
        {
            Assert.IsTrue(SoftwareExchangeCreate.SelectOddEvenSwitch.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void StartDateTime()
        {
            Assert.IsTrue(SoftwareExchangeCreate.StartDateTime.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void BatchCreateButton()
        {
            Assert.IsTrue(SoftwareExchangeCreate.BatchCreateButton.Displayed);
        }

        [TestMethod]
        [TestCategory("SoftwareExchange")]
        public void SelectedNewTargetRelease()
        {
            Assert.IsTrue(SoftwareExchangeCreate.SelectedNewTargetRelease.Displayed);
        }
    }
}