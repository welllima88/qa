using NUnit.Framework;
using Six.Scs.QA.Selenium.Administration.SoftwareExchange;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.SmokeTest.SoftwareExchange
{
    [TestFixture]
    public class SoftwareExchangeGuiTest
    {
        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate("MasterSoftwareExchange/");
        }

        [Test]
        [Category("SoftwareExchange")]
        public void BatchCreateButton()
        {
            Assert.IsTrue(SoftwareExchangeCreate.BatchCreateButton.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void BatchTitle()
        {
            Assert.IsTrue(SoftwareExchangeCreate.BatchTitle.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void CustomerIds()
        {
            Assert.IsTrue(SoftwareExchangeCreate.CustomerIds.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void IncludeCanceled()
        {
            Assert.IsTrue(SoftwareExchangeCreate.IncludeCanceled.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void IncludeDeactivated()
        {
            Assert.IsTrue(SoftwareExchangeCreate.IncludeDeactivated.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void IncludeKeyAccounts()
        {
            Assert.IsTrue(SoftwareExchangeCreate.IncludeKeyAccounts.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void RecallNextFrom()
        {
            Assert.IsTrue(SoftwareExchangeCreate.RecallNextFrom.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void RecallNextUntil()
        {
            Assert.IsTrue(SoftwareExchangeCreate.RecallNextUntil.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void RefreshButton()
        {
            Assert.IsTrue(SoftwareExchangeCreate.RefreshButton.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void ResultLimit()
        {
            Assert.IsTrue(SoftwareExchangeCreate.ResultLimit.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void SelectAllSwitch()
        {
            Assert.IsTrue(SoftwareExchangeCreate.SelectAllSwitch.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void SelectOddEvenSwitch()
        {
            Assert.IsTrue(SoftwareExchangeCreate.SelectOddEvenSwitch.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void SelectedCountry()
        {
            Assert.IsTrue(SoftwareExchangeCreate.SelectedCountry.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void SelectedCurrentRelease()
        {
            Assert.IsTrue(SoftwareExchangeCreate.SelectedCurrentRelease.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void SelectedNetType()
        {
            Assert.IsTrue(SoftwareExchangeCreate.SelectedNetType.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void SelectedNewRelease()
        {
            Assert.IsTrue(SoftwareExchangeCreate.SelectedNewRelease.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void SelectedNewTargetRelease()
        {
            Assert.IsTrue(SoftwareExchangeCreate.SelectedNewTargetRelease.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void SelectedSupplierMandant()
        {
            Assert.IsTrue(SoftwareExchangeCreate.SelectedSupplierMandant.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void SelectedTerminalType()
        {
            Assert.IsTrue(SoftwareExchangeCreate.SelectedTerminalType.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void StartDateTime()
        {
            Assert.IsTrue(SoftwareExchangeCreate.StartDateTime.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void TerminalIdSelection()
        {
            Assert.IsTrue(SoftwareExchangeCreate.TerminalIdSelection.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void TidRangeEnd()
        {
            Assert.IsTrue(SoftwareExchangeCreate.TidRangeEnd.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void TidRangeStart()
        {
            Assert.IsTrue(SoftwareExchangeCreate.TidRangeStart.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void Zips()
        {
            Assert.IsTrue(SoftwareExchangeCreate.Zips.Displayed);
        }
    }
}