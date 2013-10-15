using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Location;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Location.Create
{
    [TestClass]
    public class LocationCreateWithoutUserInputTest
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate("/Pages/Customer/CustomerEdit.aspx?CustomerId=404871");
            CustomerMenu.LocationCreate.Click();

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