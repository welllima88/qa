using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Administration.SoftwareExchange;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Administration.SoftwareExchange
{
    [TestClass]
    public class SoftwareExchangeGuiTest
    {
        private static SoftwareExchangeCreate _softwareExchangeCreate;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestLauncher.Navigate("/MasterSoftwareExchange/");
            _softwareExchangeCreate = new SoftwareExchangeCreate();
        }

        [TestMethod]
        public void SelectedTerminalType()
        {
            Assert.IsTrue(_softwareExchangeCreate.SelectedTerminalType.Displayed);
        }

        [TestMethod]
        public void IncludeDeactivated()
        {
            Assert.IsTrue(_softwareExchangeCreate.IncludeDeactivated.Displayed);
        }

        [TestMethod]
        public void IncludeCancelled()
        {
            Assert.IsTrue(_softwareExchangeCreate.IncludeCancelled.Displayed);
        }

        [TestMethod]
        public void SelectedCurrentRelease()
        {
            Assert.IsTrue(_softwareExchangeCreate.SelectedCurrentRelease.Displayed);
        }

        [TestMethod]
        public void AllowTerminalsWithNoCurrentRelease()
        {
            Assert.IsTrue(_softwareExchangeCreate.AllowTerminalsWithNoCurrentRelease.Displayed);
        }

        [TestMethod]
        public void SelectedNetType()
        {
            Assert.IsTrue(_softwareExchangeCreate.SelectedNetType.Displayed);
        }

        [TestMethod]
        public void TidRangeStart()
        {
            Assert.IsTrue(_softwareExchangeCreate.TidRangeStart.Displayed);
        }

        [TestMethod]
        public void TidRangeEnd()
        {
            Assert.IsTrue(_softwareExchangeCreate.TidRangeEnd.Displayed);
        }

        [TestMethod]
        public void TerminalIdSelection()
        {
            Assert.IsTrue(_softwareExchangeCreate.TerminalIdSelection.Displayed);
        }

        [TestMethod]
        public void RecallNextFrom()
        {
            Assert.IsTrue(_softwareExchangeCreate.RecallNextFrom.Displayed);
        }

        [TestMethod]
        public void RecallNextUntil()
        {
            Assert.IsTrue(_softwareExchangeCreate.RecallNextUntil.Displayed);
        }

        [TestMethod]
        public void SelectedSupplierMandant()
        {
            Assert.IsTrue(_softwareExchangeCreate.SelectedSupplierMandant.Displayed);
        }

        [TestMethod]
        public void IncludeKeyAccounts()
        {
            Assert.IsTrue(_softwareExchangeCreate.IncludeKeyAccounts.Displayed);
        }

        [TestMethod]
        public void CustomerIds()
        {
            Assert.IsTrue(_softwareExchangeCreate.CustomerIds.Displayed);
        }

        [TestMethod]
        public void Zips()
        {
            Assert.IsTrue(_softwareExchangeCreate.Zips.Displayed);
        }

        [TestMethod]
        public void SelectedCountry()
        {
            Assert.IsTrue(_softwareExchangeCreate.SelectedCountry.Displayed);
        }

        [TestMethod]
        public void ResultLimit()
        {
            Assert.IsTrue(_softwareExchangeCreate.ResultLimit.Displayed);
        }

        [TestMethod]
        public void RefreshButton()
        {
            Assert.IsTrue(_softwareExchangeCreate.RefreshButton.Displayed);
        }

        [TestMethod]
        public void BatchTitle()
        {
            Assert.IsTrue(_softwareExchangeCreate.BatchTitle.Displayed);
        }

        [TestMethod]
        public void SelectAllSwitch()
        {
            Assert.IsTrue(_softwareExchangeCreate.SelectAllSwitch.Displayed);
        }

        [TestMethod]
        public void SelectOddEvenSwitch()
        {
            Assert.IsTrue(_softwareExchangeCreate.SelectOddEvenSwitch.Displayed);
        }

        [TestMethod]
        public void SelectedNewRelease()
        {
            Assert.IsTrue(_softwareExchangeCreate.SelectedNewRelease.Displayed);
        }

        [TestMethod]
        public void StartDateTime()
        {
            Assert.IsTrue(_softwareExchangeCreate.StartDateTime.Displayed);
        }

        [TestMethod]
        public void BatchCreateButton()
        {
            Assert.IsTrue(_softwareExchangeCreate.BatchCreateButton.Displayed);
        }
    }
}