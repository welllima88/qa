using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Extension.TestData;
using Six.Scs.QA.Selenium.Extension.TestObjects.Common;
using Six.Scs.QA.Selenium.Extension.TestObjects.Location;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.Tests.Location.Edit
{
    [TestClass]
    public class LocationEditWithoutReasonTest
    {
        [ClassInitialize]
        public void TestInit()
        {
            TestDirector.Navigate("Location/Edit?LOCATIONID=071b90c2-c8c5-42c5-87c5-d816b26b0a1a");

            LocationEdit.CompanyName = "SYR" + Factory.GenerateTestId();

            LocationCreate.SaveButton.Click();
        }

        [TestMethod]
        public void FormAlertCheck()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList,
                "Änderungsgrund - In diesem Feld wird eine Eingabe benötigt!");
        }

        [TestMethod]
        public void FormAlertNumber()
        {
            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
        }
    }
}