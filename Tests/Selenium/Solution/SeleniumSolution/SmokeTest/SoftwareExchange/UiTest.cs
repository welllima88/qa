using NUnit.Framework;
using Six.Scs.Test.UI.Administration.SoftwareExchange;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test.SoftwareExchange
{
    [TestFixture]
    public class UiTest
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
            Assert.That(Create.BatchCreateButton.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void BatchTitle()
        {
            Assert.That(Create.BatchTitle.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void CustomerIds()
        {
            Assert.That(Create.CustomerIds.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void IncludeCanceled()
        {
            Assert.That(Create.IncludeCanceled.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void IncludeDeactivated()
        {
            Assert.That(Create.IncludeDeactivated.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void IncludeKeyAccounts()
        {
            Assert.That(Create.IncludeKeyAccounts.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void RecallNextFrom()
        {
            Assert.That(Create.RecallNextFrom.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void RecallNextUntil()
        {
            Assert.That(Create.RecallNextUntil.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void RefreshButton()
        {
            Assert.That(Create.RefreshButton.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void ResultLimit()
        {
            Assert.That(Create.ResultLimit.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void SelectAllSwitch()
        {
            Assert.That(Create.SelectAllSwitch.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void SelectedCountry()
        {
            Assert.That(Create.SelectedCountry.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void SelectedCurrentRelease()
        {
            Assert.That(Create.SelectedCurrentRelease.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void SelectedNetType()
        {
            Assert.That(Create.SelectedNetType.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void SelectedNewRelease()
        {
            Assert.That(Create.SelectedNewRelease.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void SelectedNewTargetRelease()
        {
            Assert.That(Create.SelectedNewTargetRelease.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void SelectedSupplierMandant()
        {
            Assert.That(Create.SelectedSupplierMandant.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void SelectedTerminalType()
        {
            Assert.That(Create.SelectedTerminalType.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void SelectOddEvenSwitch()
        {
            Assert.That(Create.SelectOddEvenSwitch.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void StartDateTime()
        {
            Assert.That(Create.StartDateTime.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void TerminalIdSelection()
        {
            Assert.That(Create.TerminalIdSelection.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void TidRangeEnd()
        {
            Assert.That(Create.TidRangeEnd.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void TidRangeStart()
        {
            Assert.That(Create.TidRangeStart.Displayed);
        }

        [Test]
        [Category("SoftwareExchange")]
        public void Zips()
        {
            Assert.That(Create.Zips.Displayed);
        }
    }
}