using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Administration.Agency;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Administration.Agency
{
    [TestClass]
    public class AgencyCreateTest
    {
        private static AgencyView _agencyView;
        private static AgencyCreate _agencyCreate;
        private static string _nameDyn;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _agencyCreate = new AgencyEdit();
            _agencyView = new AgencyView();

            _nameDyn = "SYR " + TestLauncher.GenerateTestId();

            TestLauncher.Navigate("/Agency/Create");

            _agencyCreate.Name = _nameDyn;
            _agencyCreate.DisplayName = _nameDyn + "D";
            _agencyCreate.StreetNo = "Agentur-Str. 12a";
            _agencyCreate.Zip = "10235";
            _agencyCreate.City = "Hamburg";
            _agencyCreate.Country = "DE";
            _agencyCreate.Language = "de";
            _agencyCreate.Telephone = "+41 58 399 6237";
            _agencyCreate.Supplier = "Alle Fremdhersteller";
            _agencyCreate.SbsAgentId = "881144";

            _agencyCreate.SaveButton.Click();
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
            Assert.AreEqual("Alle Fremdhersteller", _agencyView.Supplier);
        }

        [TestMethod]
        public void SbsAgentId()
        {
            Assert.AreEqual("881144", _agencyView.SbsAgentId);
        }
    }
}