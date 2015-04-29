using NUnit.Framework;
using Six.Scs.Test.View.Terminal;
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
            Test.View.Terminal.Dashboard.Portlets.SalesContract.Replace.Click();
            ArticleChooser.Select = "xentissimo MOBILE WLAN, TCP/IP";
        }

        [Test]
        [Category("Terminal Replace")]
        public void Contactless()
        {
            Assert.That(Test.View.Terminal.Replace.Contactless, Is.Not.Empty);
        }

        [Test]
        [Category("Terminal Replace")]
        public void ContractPeriodMinimum()
        {
            Assert.That(Test.View.Terminal.Replace.ContractPeriodMinimum, Is.Not.Null);
            Assert.That(Test.View.Terminal.Replace.ContractPeriodMinimum, Is.Empty);
        }

        [Test]
        [Category("Terminal Replace")]
        public void DeliveryDate()
        {
            Assert.That(Test.View.Terminal.Replace.DeliveryDate, Is.Not.Empty);
        }

        [Test]
        [Category("Terminal Replace")]
        public void Infotext()
        {
            Assert.That(Test.View.Terminal.Replace.Infotext, Is.Not.Null);
            Assert.That(Test.View.Terminal.Replace.Infotext, Is.Empty);
        }

        [Test]
        [Category("Terminal Replace")]
        public void InstallationRemark()
        {
            Assert.That(Test.View.Terminal.Replace.InstallationRemark, Is.Not.Null);
            Assert.That(Test.View.Terminal.Replace.InstallationRemark, Is.Empty);
        }

        [Test]
        [Category("Terminal Replace")]
        public void InstallationType()
        {
            Assert.That(Test.View.Terminal.Replace.InstallationType, Is.Not.Empty);
        }

        [Test]
        [Category("Terminal Replace")]
        public void SalesContract()
        {
            Assert.That(Test.View.Terminal.Replace.SalesContract, Is.Not.Empty);
        }

        [Test]
        [Category("Terminal Replace")]
        public void SaveButton()
        {
            Assert.That(Test.View.Terminal.Replace.SaveButton.Displayed);
        }

        [Test]
        [Category("Terminal Replace")]
        public void SendNotifiaction()
        {
            Assert.That(Test.View.Terminal.Replace.SendNotifiaction, Is.False);
        }

        [Test]
        [Category("Terminal Replace")]
        public void SupportContract()
        {
            Assert.That(Test.View.Terminal.Replace.SupportContract, Is.Not.Empty);
        }
    }
}