using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Extension.TestData;
using Six.Scs.QA.Selenium.Extension.TestObjects.Administration.Agency;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.Tests.Administration.Agency
{
    [TestClass]
    public class AgencyEditTest
    {
        private static string _nameDyn;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _nameDyn = "SYR " + Factory.GenerateTestId();

            TestDirector.Navigate("Agency/Edit?AgencyId=59ddd48b-f265-40f5-beac-9529a1d9454f");

            AgencyCreate.Name = _nameDyn;
            AgencyCreate.DisplayName = _nameDyn + "D";
            AgencyCreate.StreetNo = "Agentur-Str. 12a";
            AgencyCreate.Zip = "10235";
            AgencyCreate.City = "Hamburg";
            AgencyCreate.Country = "DE";
            AgencyCreate.Language = "de";
            AgencyCreate.Telephone = "+41 58 399 6237";
            AgencyCreate.Supplier = "SIX Payment Services AG";
            AgencyCreate.SbsAgentId = "001144";

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
            Assert.AreEqual("SIX Payment Services AG", AgencyView.Supplier);
        }

        [TestMethod]
        public void SbsAgentId()
        {
            Assert.AreEqual("001144", AgencyView.SbsAgentId);
        }
    }
}