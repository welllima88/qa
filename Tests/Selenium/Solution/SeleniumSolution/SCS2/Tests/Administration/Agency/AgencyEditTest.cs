using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Administration.Agency;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Administration.Agency
{
    [TestClass]
    public class AgencyEditTest
    {
        private static AgencyView _agencyView;
        private static AgencyEdit _agencyEdit;
        private static string _nameDyn;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _agencyEdit = new AgencyEdit();
            _agencyView = new AgencyView();

            _nameDyn = "SYR " + TestLauncher.GenerateTestId();

            TestLauncher.Navigate("/Agency/Edit?AgencyId=59ddd48b-f265-40f5-beac-9529a1d9454f");

            _agencyEdit.Name = _nameDyn;
            _agencyEdit.DisplayName = _nameDyn + "D";
            _agencyEdit.StreetNo = "Agentur-Str. 12a";
            _agencyEdit.Zip = "10235";
            _agencyEdit.City = "Hamburg";
            _agencyEdit.Country = "DE";
            _agencyEdit.Language = "de";
            _agencyEdit.Telephone = "+41 58 399 6237";
            _agencyEdit.Supplier = "Alle Fremdhersteller";
            _agencyEdit.SbsAgentId = "881144";

            _agencyEdit.SaveButton.Click();
        }

        [TestMethod]
        public void Name()
        {
            Assert.AreEqual(_nameDyn, _agencyView.Name);
        }

        [TestMethod]
        public void DisplayName()
        {
            Assert.AreEqual(_nameDyn + "D", _agencyView.DisplayName);
        }

        [TestMethod]
        public void StreetNo()
        {
            Assert.AreEqual("Agentur-Str. 12a", _agencyView.StreetNo);
        }

        [TestMethod]
        public void Zip()
        {
            Assert.AreEqual("10235", _agencyView.Zip);
        }

        [TestMethod]
        public void City()
        {
            Assert.AreEqual("Hamburg", _agencyView.City);
        }

        [TestMethod]
        public void Country()
        {
            Assert.AreEqual("DE", _agencyView.Country);
        }

        [TestMethod]
        public void Language()
        {
            Assert.AreEqual("DE", _agencyView.Language);
        }

        [TestMethod]
        public void Telephone()
        {
            Assert.AreEqual("+41 58 399 6237", _agencyView.Telephone);
        }

        [TestMethod]
        public void Supplier()
        {
            Assert.AreEqual("_foreign_supplier_all", _agencyView.Supplier);
        }

        [TestMethod]
        public void SbsAgentId()
        {
            Assert.AreEqual("881144", _agencyView.SbsAgentId);
        }
    }
}