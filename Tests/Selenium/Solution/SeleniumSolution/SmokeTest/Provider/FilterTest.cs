using NUnit.Framework;
using Six.Test.Selenium.WebDriver;

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