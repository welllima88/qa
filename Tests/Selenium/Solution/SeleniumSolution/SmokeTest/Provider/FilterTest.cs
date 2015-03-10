using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.SmokeTest.Provider
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
        }

        [Test]
        public void ByReference()
        {
        }
    }
}