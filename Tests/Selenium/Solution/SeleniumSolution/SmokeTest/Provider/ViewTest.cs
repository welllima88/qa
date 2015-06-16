using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.SmokeTest.Provider
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