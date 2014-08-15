using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Administration.Agency;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.TestData.Factory;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Administration.Agency
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

            Create.Name = _nameDyn;
            Create.DisplayName = _nameDyn + "D";
            Create.StreetNo = "Agentur-Str. 12a";
            Create.Zip = "10235";
            Create.City = "Hamburg";
            Create.Country = "DE";
            Create.Language = "de";
            Create.Telephone = "+41 58 399 6237";
            Create.Supplier = "SIX Payment Services AG";
            Create.SbsAgentId = "001144";

            Create.SaveButton.Click();
        }

        [TestMethod]
        public void Name()
        {
            Assert.AreEqual(_nameDyn, View.Name);
        }

        [TestMethod]
        public void DisplayName()
        {
            Assert.AreEqual(_nameDyn + "D", View.DisplayName);
        }

        [TestMethod]
        public void StreetNo()
        {
            Assert.AreEqual("Agentur-Str. 12a", View.StreetNo);
        }

        [TestMethod]
        public void Zip()
        {
            Assert.AreEqual("10235", View.Zip);
        }

        [TestMethod]
        public void City()
        {
            Assert.AreEqual("Hamburg", View.City);
        }

        [TestMethod]
        public void Country()
        {
            Assert.AreEqual("Deutschland", View.Country);
        }

        [TestMethod]
        public void Language()
        {
            Assert.AreEqual("Deutsch [de]", View.Language);
        }

        [TestMethod]
        public void Telephone()
        {
            Assert.AreEqual("+41 58 399 6237", View.Telephone);
        }

        [TestMethod]
        public void Supplier()
        {
            Assert.AreEqual("SIX Payment Services AG", View.Supplier);
        }

        [TestMethod]
        public void SbsAgentId()
        {
            Assert.AreEqual("001144", View.SbsAgentId);
        }
    }
}