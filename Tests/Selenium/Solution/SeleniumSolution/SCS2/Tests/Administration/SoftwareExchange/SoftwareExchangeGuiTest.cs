using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.Selenium;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Administration.SoftwareExchange;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Administration.SoftwareExchange
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
        public void SelectedTerminalType()
        {
            Assert.IsTrue(SoftwareExchangeCreate.SelectedTerminalType.Displayed);
        }

        [TestMethod]
        public void IncludeDeactivated()
        {
            Assert.IsTrue(SoftwareExchangeCreate.IncludeDeactivated.Displayed);
        }

        [TestMethod]
        public void IncludeCancelled()
        {
            Assert.IsTrue(SoftwareExchangeCreate.IncludeCancelled.Displayed);
        }

        [TestMethod]
        public void SelectedCurrentRelease()
        {
            Assert.IsTrue(SoftwareExchangeCreate.SelectedCurrentRelease.Displayed);
        }

        [TestMethod]
        public void AllowTerminalsWithNoCurrentRelease()
        {
            Assert.IsTrue(SoftwareExchangeCreate.AllowTerminalsWithNoCurrentRelease.Displayed);
        }

        [TestMethod]
        public void SelectedNetType()
        {
            Assert.IsTrue(SoftwareExchangeCreate.SelectedNetType.Displayed);
        }

        [TestMethod]
        public void TidRangeStart()
        {
            Assert.IsTrue(SoftwareExchangeCreate.TidRangeStart.Displayed);
        }

        [TestMethod]
        public void TidRangeEnd()
        {
            Assert.IsTrue(SoftwareExchangeCreate.TidRangeEnd.Displayed);
        }

        [TestMethod]
        public void TerminalIdSelection()
        {
            Assert.IsTrue(SoftwareExchangeCreate.TerminalIdSelection.Displayed);
        }

        [TestMethod]
        public void RecallNextFrom()
        {
            Assert.IsTrue(SoftwareExchangeCreate.RecallNextFrom.Displayed);
        }

        [TestMethod]
        public void RecallNextUntil()
        {
            Assert.IsTrue(SoftwareExchangeCreate.RecallNextUntil.Displayed);
        }

        [TestMethod]
        public void SelectedSupplierMandant()
        {
            Assert.IsTrue(SoftwareExchangeCreate.SelectedSupplierMandant.Displayed);
        }

        [TestMethod]
        public void IncludeKeyAccounts()
        {
            Assert.IsTrue(SoftwareExchangeCreate.IncludeKeyAccounts.Displayed);
        }

        [TestMethod]
        public void CustomerIds()
        {
            Assert.IsTrue(SoftwareExchangeCreate.CustomerIds.Displayed);
        }

        [TestMethod]
        public void Zips()
        {
            Assert.IsTrue(SoftwareExchangeCreate.Zips.Displayed);
        }

        [TestMethod]
        public void SelectedCountry()
        {
            Assert.IsTrue(SoftwareExchangeCreate.SelectedCountry.Displayed);
        }

        [TestMethod]
        public void ResultLimit()
        {
            Assert.IsTrue(SoftwareExchangeCreate.ResultLimit.Displayed);
        }

        [TestMethod]
        public void RefreshButton()
        {
            Assert.IsTrue(SoftwareExchangeCreate.RefreshButton.Displayed);
        }

        [TestMethod]
        public void BatchTitle()
        {
            Assert.IsTrue(SoftwareExchangeCreate.BatchTitle.Displayed);
        }

        [TestMethod]
        public void SelectAllSwitch()
        {
            Assert.IsTrue(SoftwareExchangeCreate.SelectAllSwitch.Displayed);
        }

        [TestMethod]
        public void SelectOddEvenSwitch()
        {
            Assert.IsTrue(SoftwareExchangeCreate.SelectOddEvenSwitch.Displayed);
        }

        [TestMethod]
        public void SelectedNewRelease()
        {
            Assert.IsTrue(SoftwareExchangeCreate.SelectedNewRelease.Displayed);
        }

        [TestMethod]
        public void StartDateTime()
        {
            Assert.IsTrue(SoftwareExchangeCreate.StartDateTime.Displayed);
        }

        [TestMethod]
        public void BatchCreateButton()
        {
            Assert.IsTrue(SoftwareExchangeCreate.BatchCreateButton.Displayed);
        }
    }
}