using NUnit.Framework;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test.Administration
{
    [TestFixture]
    public class AgencyTest
    {
        private Model.Agency _agency;

        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate("Agency/List");
        }

        [Test]
        [Category("Agency"), Category("Create"), Category("Edit"), Category("Deactivate")]
        public void Manage()
        {
            _agency = Agency.Create();
            _agency = Agency.Edit(_agency);
            Agency.Deactivate(_agency);
        }
    }
}