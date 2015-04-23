using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.SmokeTest.Terminal
{
    [TestFixture]
    [Category("Portlets")]
    public class Portlets
    {
        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate("TerminalDashboard/?TerminalId=30092755");
        }

        [Test]
        [Category("Brand")]
        public void BrandPortlet()
        {
            Assert.That(View.Terminal.Dashboard.Portlets.Brand.BrandPortlet.NewBrandButton.Displayed);
        }

        [Test]
        [Category("BusinessViewpoint")]
        public void BusinessViewpoint()
        {
            Assert.That(View.Terminal.Dashboard.Portlets.BusinessViewpoint.Status, Is.Not.Empty);
        }

        [Test]
        [Category("Contacts")]
        public void Contacts()
        {
            Assert.That(View.Terminal.Dashboard.Portlets.Contacts.CustomerContacts, Is.Not.Empty);
        }

        [Test]
        [Category("SalesContract")]
        public void SalesContract()
        {
            Assert.That(View.Terminal.Dashboard.Portlets.SalesContract.TerminalDuplicate.Displayed);
        }

        [Test]
        [Category("TechnicalView")]
        public void TechnicalView()
        {
            Assert.That(View.Terminal.Dashboard.Portlets.TechnicalView.TerminalId, Is.Not.Empty);
        }

        [Test]
        [Category("TerminalTexts")]
        public void TerminalTexts()
        {
            Assert.That(View.Terminal.Dashboard.Portlets.TerminalTexts.CreateInfotext, Is.Not.Null);
        }

        [Test]
        [Category("TroubleTickets")]
        public void TroubleTickets()
        {
            Assert.That(View.Terminal.Dashboard.Portlets.Support.TroubleTickets.SupportContract, Is.Not.Empty);
        }
    }
}