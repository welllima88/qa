using NUnit.Framework;
using Six.Scs.Test.UI.Terminal;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test.Terminal
{
    [TestFixture]
    [Category("Terminal Replace")]
    public class Replace
    {
        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate("TerminalDashboard/?TerminalId=30092755");
            UI.Terminal.Dashboard.Portlets.SalesContract.Replace.Click();
            ArticleChooser.Select = "xentissimo MOBILE WLAN, TCP/IP";
        }

        [Test]
        [Category("Terminal Replace")]
        public void Contactless()
        {
            Assert.That(UI.Terminal.Replace.Contactless, Is.Not.Empty);
        }

        [Test]
        [Category("Terminal Replace")]
        public void ContractPeriodMinimum()
        {
            Assert.That(UI.Terminal.Replace.ContractPeriodMinimum, Is.Not.Null);
            Assert.That(UI.Terminal.Replace.ContractPeriodMinimum, Is.Empty);
        }

        [Test]
        [Category("Terminal Replace")]
        public void DeliveryDate()
        {
            Assert.That(UI.Terminal.Replace.DeliveryDate, Is.Not.Empty);
        }

        [Test]
        [Category("Terminal Replace")]
        public void Infotext()
        {
            Assert.That(UI.Terminal.Replace.Infotext, Is.Not.Null);
            Assert.That(UI.Terminal.Replace.Infotext, Is.Empty);
        }

        [Test]
        [Category("Terminal Replace")]
        public void InstallationRemark()
        {
            Assert.That(UI.Terminal.Replace.InstallationRemark, Is.Not.Null);
            Assert.That(UI.Terminal.Replace.InstallationRemark, Is.Empty);
        }

        [Test]
        [Category("Terminal Replace")]
        public void InstallationType()
        {
            Assert.That(UI.Terminal.Replace.InstallationType, Is.Not.Empty);
        }

        [Test]
        [Category("Terminal Replace")]
        public void SalesContract()
        {
            Assert.That(UI.Terminal.Replace.SalesContract, Is.Not.Empty);
        }

        [Test]
        [Category("Terminal Replace")]
        public void SaveButton()
        {
            Assert.That(UI.Terminal.Replace.SaveButton.Displayed);
        }

        [Test]
        [Category("Terminal Replace")]
        public void SendNotifiaction()
        {
            Assert.That(UI.Terminal.Replace.SendNotifiaction, Is.False);
        }

        [Test]
        [Category("Terminal Replace")]
        public void SupportContract()
        {
            Assert.That(UI.Terminal.Replace.SupportContract, Is.Not.Empty);
        }
    }
}