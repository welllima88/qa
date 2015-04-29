using NUnit.Framework;
using Six.Scs.Test.View.Administration.SoftwareExchange;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test.SoftwareExchange
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
            Assert.IsTrue(Create.BatchCreateButton.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void BatchTitle()
        {
            Assert.IsTrue(Create.BatchTitle.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void CustomerIds()
        {
            Assert.IsTrue(Create.CustomerIds.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void IncludeCanceled()
        {
            Assert.IsTrue(Create.IncludeCanceled.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void IncludeDeactivated()
        {
            Assert.IsTrue(Create.IncludeDeactivated.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void IncludeKeyAccounts()
        {
            Assert.IsTrue(Create.IncludeKeyAccounts.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void RecallNextFrom()
        {
            Assert.IsTrue(Create.RecallNextFrom.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void RecallNextUntil()
        {
            Assert.IsTrue(Create.RecallNextUntil.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void RefreshButton()
        {
            Assert.IsTrue(Create.RefreshButton.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void ResultLimit()
        {
            Assert.IsTrue(Create.ResultLimit.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void SelectAllSwitch()
        {
            Assert.IsTrue(Create.SelectAllSwitch.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void SelectedCountry()
        {
            Assert.IsTrue(Create.SelectedCountry.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void SelectedCurrentRelease()
        {
            Assert.IsTrue(Create.SelectedCurrentRelease.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void SelectedNetType()
        {
            Assert.IsTrue(Create.SelectedNetType.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void SelectedNewRelease()
        {
            Assert.IsTrue(Create.SelectedNewRelease.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void SelectedNewTargetRelease()
        {
            Assert.IsTrue(Create.SelectedNewTargetRelease.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void SelectedSupplierMandant()
        {
            Assert.IsTrue(Create.SelectedSupplierMandant.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void SelectedTerminalType()
        {
            Assert.IsTrue(Create.SelectedTerminalType.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void SelectOddEvenSwitch()
        {
            Assert.IsTrue(Create.SelectOddEvenSwitch.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void StartDateTime()
        {
            Assert.IsTrue(Create.StartDateTime.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void TerminalIdSelection()
        {
            Assert.IsTrue(Create.TerminalIdSelection.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void TidRangeEnd()
        {
            Assert.IsTrue(Create.TidRangeEnd.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void TidRangeStart()
        {
            Assert.IsTrue(Create.TidRangeStart.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void Zips()
        {
            Assert.IsTrue(Create.Zips.Displayed);
        }
    }
}