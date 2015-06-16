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
            TestDirector.Navigate("Provider/Detail?providerId=281");
        }

        [Test]
        public void Name()
        {
            Assert.That(true);
        }
    }
}