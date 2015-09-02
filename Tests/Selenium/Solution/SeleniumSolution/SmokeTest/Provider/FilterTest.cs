using System.Linq;
using NUnit.Framework;
using Six.Test.Selenium.WebDriver;
using List = Six.Scs.Test.UI.Administration.Provider.List;

namespace Six.Scs.Test.Provider
{
    [TestFixture]
    public class FilterTest
    {
        [SetUp]
        public void ResetFilter()
        {
            List.FilterReset.Click();
        }

        [TestFixtureSetUp]
        public void Navigate()
        {
            TestDirector.Navigate("Admin/Provider");
        }

        [Test]
        public void AcquirerId()
        {
        }

        [Test]
        public void ById()
        {
            List.Filter = "281";
            Assert.That(List.Providers, Has.All.Contains("281").IgnoreCase);
            Assert.That(List.Providers, Has.Exactly(1).Contains("SIX Payment Services ep2"));
            Assert.That(List.Providers, Has.Exactly(1).Contains("DKV Euro Service MOC IFSF"));
            Assert.That(List.Providers.Count(), Is.EqualTo(2));
        }

        [Test]
        public void ByName()
        {
            List.Filter = "Postcard";
            Assert.That(List.Providers, Has.All.Contains("Postcard").IgnoreCase);
            Assert.That(List.Providers, Has.Exactly(1).Contains("Postcard ep2"));
            Assert.That(List.Providers.Count(), Is.EqualTo(3));
        }

        [Test]
        public void ByReference()
        {
        }

        [Test]
        public void CardType()
        {
        }

        [Test]
        public void Protocol()
        {
        }
    }
}