using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Saferpay.QA.Selenium.Pages.Menu;

namespace Six.Saferpay.QA.Selenium.Tests.Lobby
{
    [TestFixture]
    [Category("Main")]
    public class MenuTest
    {
        private Main _menu;

        [TestFixtureSetUp]
        public void ClassInit()
        {
            TestDirector.Navigate();
            _menu = new Main();
        }

        [Test]
        [Category("Main")]
        public void Administration()
        {
            Assert.That(_menu.MySaferpay.Administration.Displayed);
        }

        [Test]
        [Category("Main")]
        public void BatchProcessing()
        {
            Assert.That(_menu.MySaferpay.BatchProcessing.Displayed);
        }

        [Test]
        [Category("Main")]
        public void ChangeEmail()
        {
            Assert.That(_menu.UserSetup.ChangeEmail.Displayed);
        }

        [Test]
        [Category("Main")]
        public void ChangePassword()
        {
            Assert.That(_menu.UserSetup.ChangePassword.Displayed);
        }

        [Test]
        [Category("Main")]
        public void OnlineSupport()
        {
            Assert.That(_menu.MySaferpay.OnlineSupport.Displayed);
        }

        [Test]
        [Category("Main")]
        public void ProductInfo()
        {
            Assert.That(_menu.FurtherProducts.ProductInfo.Displayed);
        }

        [Test]
        [Category("Main")]
        public void RiskManagement()
        {
            Assert.That(_menu.MySaferpay.RiskManagement.Displayed);
        }

        [Test]
        [Category("Main")]
        public void SecureCardData()
        {
            Assert.That(_menu.MySaferpay.SecureCardData.Displayed);
        }

        [Test]
        [Category("Main")]
        public void SecurePayGate()
        {
            Assert.That(_menu.MySaferpay.SecurePayGate.Displayed);
        }

        [Test]
        [Category("Main")]
        public void TopasPms()
        {
            Assert.That(_menu.FurtherProducts.TopasPms.Displayed);
        }

        [Test]
        [Category("Main")]
        public void Transactions()
        {
            Assert.That(_menu.MySaferpay.Transactions.Displayed);
        }
    }
}