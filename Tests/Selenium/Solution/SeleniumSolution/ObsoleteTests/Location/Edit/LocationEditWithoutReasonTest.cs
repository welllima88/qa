using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.TestData.Factory;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Location.Edit
{
    [TestClass]
    public class LocationEditWithoutReasonTest
    {
        [ClassInitialize]
        public static void TestInit()
        {
            TestDirector.Navigate("Location/Edit?LOCATIONID=071b90c2-c8c5-42c5-87c5-d816b26b0a1a");

            Selenium.Location.Edit.CompanyName = "SYR" + Factory.GenerateTestId();

            Selenium.Location.Create.SaveButton.Click();
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