using NUnit.Framework;
using Six.Scs.QA.Selenium.Old.Common;

namespace Six.Scs.QA.Selenium.Old.Tests
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestFixture]
    public class ApplicationInfoTest
    {
        [TestFixtureSetUp]
        public static void ClassInit()
        {
            // TestDirector.Navigate();
        }

        [Test]
        public void CompanyLogo()
        {
            Assert.IsTrue(HeadMenu.CompanyLogo.Displayed);
        }

        [Test]
        public void System()
        {
            Assert.IsTrue(HeadMenu.System.Displayed);
        }
    }
}