using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Terminal;

namespace Six.Scs.QA.Selenium.SmokeTest.Terminal
{
    [TestFixture]
    [Category("Terminal Replace")]
    public class Replace
    {
        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate("TerminalDashboard/?TerminalId=30092755");
            Selenium.Terminal.Dashboard.Portlets.SalesContract.Replace.Click();
            ArticleChooser.Select = "xentissimo MOBILE WLAN, TCP/IP";
        }

        [Test]
        [Category("Terminal Replace")]
        public void Contactless()
        {
            Assert.That(Selenium.Terminal.Replace.Contactless, Is.Not.Empty);
        }

        [Test]
        [Category("Terminal Replace")]
        public void DeliveryDate()
        {
            Assert.That(Selenium.Terminal.Replace.DeliveryDate, Is.Not.Empty);
        }

        [Test]
        [Category("Terminal Replace")]
        public void Infotext()
        {
            Assert.That(Selenium.Terminal.Replace.Infotext, Is.Not.Null);
            Assert.That(Selenium.Terminal.Replace.Infotext, Is.Empty);
        }

        [Test]
        [Category("Terminal Replace")]
        public void InstallationRemark()
        {
            Assert.That(Selenium.Terminal.Replace.InstallationRemark, Is.Not.Null);
            Assert.That(Selenium.Terminal.Replace.InstallationRemark, Is.Empty);
        }

        [Test]
        [Category("Terminal Replace")]
        public void InstallationType()
        {
            Assert.That(Selenium.Terminal.Replace.InstallationType, Is.Not.Empty);
        }

        [Test]
        [Category("Terminal Replace")]
        public void SalesContract()
        {
            Assert.That(Selenium.Terminal.Replace.SalesContract, Is.Not.Empty);
        }

        [Test]
        [Category("Terminal Replace")]
        public void SupportContract()
        {
            Assert.That(Selenium.Terminal.Replace.SupportContract, Is.Not.Empty);
        }
    }
}