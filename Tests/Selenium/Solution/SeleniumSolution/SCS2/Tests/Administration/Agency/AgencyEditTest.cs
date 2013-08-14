using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Administration.Agency;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Definitions;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Administration.Agency
{
    [TestClass]
    public class AgencyEditTest
    {
        private static AgencyView _agency;
        private static string _nameDyn;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _agency = new AgencyView();
            _nameDyn = "SYR " + TestLauncher.GenerateTestId();

            TestLauncher.Navigate("/Agency/Edit?AgencyId=ce4c835f-7cdb-47f6-91c5-4de527703f29");

            _agency.Name = _nameDyn;
            _agency.DisplayName = _nameDyn + "D";
            _agency.StreetNo = "Agentur-Str. 12a";
            _agency.Zip = "10235";
            _agency.City = "Hamburg";
            _agency.Country = "DE";
            _agency.Language = "DE";
            _agency.Telephone = "DE";
            _agency.Supplier = "Alle Fremdhersteller";
            _agency.SbsAgentId = "881144";

            _agency.SaveButton.Click();
        }

        [TestMethod]
        public void ArticlelName()
        {
            Assert.AreEqual("yomani XR S C O PINPAD, TCP/IP (IP)", _agency.Name);
        }
    }
}