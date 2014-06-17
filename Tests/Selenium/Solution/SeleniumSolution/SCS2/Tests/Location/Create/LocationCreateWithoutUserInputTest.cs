using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.Tests.Selenium.Extension.TestObjects.Common;
using Six.Scs.Tests.Selenium.Extension.TestObjects.Location;
using Six.Scs.Tests.Selenium.Extension.WebDriver;

namespace Six.Scs.Tests.Selenium.Tests.Location.Create
{
    [TestClass]
    public class LocationCreateWithoutUserInputTest
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate("Location/New?CUSTOMERID=401858");

            LocationCreate.SaveButton.Click();
        }

        [TestMethod]
        public void NumberOfAlerts()
        {
            Assert.AreEqual(4, FormAlert.FormAlertList.Count);
        }

        [TestMethod]
        public void CompanyMissing()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Firmenname: Dies ist ein Pflichtfeld! Zu kurze Eingabe!");
        }

        [TestMethod]
        public void StreetAndNumberMissing()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Strasse / Nr: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void ZipMissing()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "PLZ: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void CityMissing()
        {
            CollectionAssert.Contains(FormAlert.FormAlertList, "Ort: Dies ist ein Pflichtfeld!");
        }
    }
}