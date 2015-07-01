using NUnit.Framework;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test.Provider
{
    [TestFixture]
    public class ViewTest
    {
        [TestFixtureSetUp]
        public void Navigate()
        {
            TestDirector.Navigate("Admin/Provider/Detail?providerId=281");
        }

        [Test]
        public void AcquirerId()
        {
            Assert.That(View.Administration.Provider.View.AcquirerId, Is.EqualTo("2"));
        }

        [Test]
        public void AcquirerName()
        {
            Assert.That(View.Administration.Provider.View.Acquirer, Is.EqualTo("SIX Payment Services"));
        }

        [Test]
        public void CardType()
        {
            Assert.That(View.Administration.Provider.View.CardType, Is.EqualTo("600080"));
        }

        [Test]
        public void DefaultCurrency()
        {
            Assert.That(View.Administration.Provider.View.DefaultCurrency, Is.EqualTo("CHF"));
        }

        [Test]
        public void ExternId()
        {
            Assert.That(View.Administration.Provider.View.ExternId, Is.EqualTo("T"));
        }

        [Test]
        public void IgnoreMpiCache()
        {
            Assert.That(View.Administration.Provider.View.IgnoreMpiCache, Is.EqualTo("Ja"));
        }

        [Test]
        public void ProviderId()
        {
            Assert.That(View.Administration.Provider.View.ProviderId, Is.EqualTo("281"));
        }

        [Test]
        public void Service()
        {
            Assert.That(View.Administration.Provider.View.Service, Is.EqualTo("ep2:ACQ"));
        }

        [Test]
        public void Softwares()
        {
            Assert.That(View.Administration.Provider.View.Softwares, Is.EqualTo(Provider.Softwares.Provider281()));
        }
    }
}