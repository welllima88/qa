using NUnit.Framework;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test.Provider
{
    [TestFixture]
    public class FilterTest
    {
        [TestFixtureSetUp]
        public void Navigate()
        {
            TestDirector.Navigate("Provider/");
        }

        [Test]
        public void ByName()
        {
            // six payment services ep2
        }

        [Test]
        public void ByReference()
        {
        }
    }
}