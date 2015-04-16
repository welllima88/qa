using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Saferpay.QA.Selenium.Pages.Menu;

namespace Six.Saferpay.QA.Selenium.Tests.Lobby
{
    [TestFixture]
    [Category("Menu")]
    public class MenuTest
    {
        private Menu _menu;

        [TestFixtureSetUp]
        public void ClassInit()
        {
            TestDirector.Navigate();
            _menu = new Menu();
        }

        [Test]
        [Category("Menu")]
        public void Administration()
        {
            Assert.That(_menu.Administration.Displayed);
        }

        [Test]
        [Category("Menu")]
        public void BatchProcessing()
        {
            Assert.That(_menu.BatchProcessing.Displayed);
        }

        [Test]
        [Category("Menu")]
        public void ChangeEmail()
        {
            Assert.That(_menu.ChangeEmail.Displayed);
        }

        [Test]
        [Category("Menu")]
        public void ChangePassword()
        {
            Assert.That(_menu.ChangePassword.Displayed);
        }

        [Test]
        [Category("Menu")]
        public void OnlineSupport()
        {
            Assert.That(_menu.OnlineSupport.Displayed);
        }

        [Test]
        [Category("Menu")]
        public void ProductInfo()
        {
            Assert.That(_menu.ProductInfo.Displayed);
        }

        [Test]
        [Category("Menu")]
        public void RiskManagement()
        {
            Assert.That(_menu.RiskManagement.Displayed);
        }

        [Test]
        [Category("Menu")]
        public void SecureCardData()
        {
            Assert.That(_menu.SecureCardData.Displayed);
        }

        [Test]
        [Category("Menu")]
        public void SecurePayGate()
        {
            Assert.That(_menu.SecurePayGate.Displayed);
        }

        [Test]
        [Category("Menu")]
        public void TopasPms()
        {
            Assert.That(_menu.TopasPms.Displayed);
        }

        [Test]
        [Category("Menu")]
        public void Transactions()
        {
            Assert.That(_menu.Transactions.Displayed);
        }
    }
}