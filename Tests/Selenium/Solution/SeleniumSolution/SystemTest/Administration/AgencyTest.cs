using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.TestData.ValueObjects;

namespace Six.Scs.QA.Selenium.SystemTest.Administration
{
    [TestFixture]
    public class AgencyTest
    {
        private Agency _agency;

        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate("Agency/List");
        }

        [Test]
        [Category("Agency"), Category("Create"), Category("Edit"), Category("Deactivate")]
        public void Manage()
        {
            _agency = Testlogic.Administration.Agency.Create();
            _agency = Testlogic.Administration.Agency.Edit(_agency);
            Testlogic.Administration.Agency.Deactivate(_agency);
        }
    }
}