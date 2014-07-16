using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Extension.TestData;
using Six.Scs.QA.Selenium.Extension.TestData.Factory;
using Six.Scs.QA.Selenium.Extension.TestObjects.Administration.Agency;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.Tests.Administration.Agency
{
    [TestClass]
    public class AgencyCreateTest
    {
        private static string _nameDyn;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _nameDyn = "SYR " + Factory.GenerateTestId();

            TestDirector.Navigate("Agency/Create");

            AgencyCreate.Name = _nameDyn;
            AgencyCreate.DisplayName = _nameDyn + "D";
            AgencyCreate.StreetNo = "Agentur-Str. 12a";
            AgencyCreate.Zip = "10235";
            AgencyCreate.City = "Hamburg";
            AgencyCreate.Country = "DE";
            AgencyCreate.Language = "de";
            AgencyCreate.Telephone = "+41 58 399 6237";
            AgencyCreate.Supplier = "Alle Fremdhersteller";
            AgencyCreate.SbsAgentId = "881144";

            AgencyCreate.SaveButton.Click();
        }

        [TestMethod]
        public void Name()
        {
            Assert.AreEqual(_nameDyn, AgencyView.Name);
        }

        [TestMethod]
        public void DisplayName()
        {
            Assert.AreEqual(_nameDyn + "D", AgencyView.DisplayName);
        }

        [TestMethod]
        public void StreetNo()
        {
            Assert.AreEqual("Agentur-Str. 12a", AgencyView.StreetNo);
        }

        [TestMethod]
        public void Zip()
        {
            Assert.AreEqual("10235", AgencyView.Zip);
        }

        [TestMethod]
        public void City()
        {
            Assert.AreEqual("Hamburg", AgencyView.City);
        }

        [TestMethod]
        public void Country()
        {
            Assert.AreEqual("Deutschland", AgencyView.Country);
        }

        [TestMethod]
        public void Language()
        {
            Assert.AreEqual("Deutsch [de]", AgencyView.Language);
        }

        [TestMethod]
        public void Telephone()
        {
            Assert.AreEqual("+41 58 399 6237", AgencyView.Telephone);
        }

        [TestMethod]
        public void Supplier()
        {
            Assert.AreEqual("Alle Fremdhersteller", AgencyView.Supplier);
        }

        [TestMethod]
        public void SbsAgentId()
        {
            Assert.AreEqual("881144", AgencyView.SbsAgentId);
        }
    }
}