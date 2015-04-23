using NUnit.Framework;
using Six.QA.Selenium.Extension;
using Six.Scs.QA.Selenium.View.Location;
using Six.Scs.QA.Selenium.Workflow.Builder;

namespace Six.Scs.QA.Testlogic.Builder.Location
{
    public class Default : LocationBuilder
    {
        protected override void SetData()
        {
            Selenium.View.Location.Create.CompanyName = Location.CompanyName;
            Selenium.View.Location.Create.StreetNo = Location.Adress.StreetNo;
            Selenium.View.Location.Create.Zip = Location.Adress.Zip;
            Selenium.View.Location.Create.City = Location.Adress.City;
            Selenium.View.Location.Create.Po = Location.Adress.Po;
            Selenium.View.Location.Create.AdressAddition = Location.Adress.AdressAddition;
            Selenium.View.Location.Create.Region = Location.Adress.Region;
            Selenium.View.Location.Create.Agency = Location.Agency;
            Selenium.View.Location.Create.Language = Location.Contact.Language;
            Selenium.View.Location.Create.Country = Location.Adress.Country;
            Selenium.View.Location.Create.Email = Location.Contact.Email;
            Selenium.View.Location.Create.Telephone = Location.Contact.Telephone;
            Selenium.View.Location.Create.Mobile = Location.Contact.Mobile;
            Selenium.View.Location.Create.Fax = Location.Contact.Fax;
            Selenium.View.Location.Create.Web = Location.Contact.Web;
        }

        public override void Check()
        {
            Assert.AreEqual(Location.CompanyName, View.CompanyName);
            StringAssert.IsMatch(TestRegExpPatterns.SbsDebitorNo, View.SbsDebitNumber);
            StringAssert.IsMatch(TestRegExpPatterns.Ep2MerchantId, View.Ep2MerchantId);
            Assert.AreEqual(Location.Adress.StreetNo, View.StreetNo);
            Assert.AreEqual(Location.Adress.Po, View.Po);
            Assert.AreEqual(Location.Adress.Zip, View.Zip);
            Assert.AreEqual(Location.Adress.City, View.City);
            StringAssert.Contains(Location.Adress.Region, View.Region);
            Assert.AreEqual(Location.Adress.AdressAddition, View.AdressAddition);
            Assert.AreEqual(Location.Contact.Language, View.Language);
            Assert.AreEqual(Location.Adress.Country, View.Country);
            Assert.AreEqual(Location.Contact.Email, View.Email);
            StringAssert.Contains(Location.Contact.Telephone, View.Telephone);
            StringAssert.Contains(Location.Contact.Mobile, View.Mobile);
            StringAssert.Contains(Location.Contact.Fax, View.Fax);
            Assert.AreEqual(Location.Contact.Web, View.Web);
            Assert.AreEqual(Location.Agency, View.Agency);
        }

        protected override void EditData()
        {
            Selenium.View.Location.Edit.Agency = Location.Agency;
            Selenium.View.Location.Edit.CompanyName = Location.CompanyName;
            Selenium.View.Location.Edit.StreetNo = Location.Adress.StreetNo;
            Selenium.View.Location.Edit.Zip = Location.Adress.Zip;
            Selenium.View.Location.Edit.City = Location.Adress.City;
            Selenium.View.Location.Edit.Po = Location.Adress.Po;
            Selenium.View.Location.Edit.Region = Location.Adress.Region;
            Selenium.View.Location.Edit.AdressAddition = Location.Adress.AdressAddition;
            Selenium.View.Location.Edit.Email = Location.Contact.Email;
            Selenium.View.Location.Edit.Telephone = Location.Contact.Telephone;
            Selenium.View.Location.Edit.Mobile = Location.Contact.Mobile;
            Selenium.View.Location.Edit.Fax = Location.Contact.Fax;
            Selenium.View.Location.Edit.Web = Location.Contact.Web;
            Selenium.View.Location.Edit.Language = Location.Contact.Language;
            Selenium.View.Location.Edit.Country = Location.Adress.Country;
        }

        protected override void ReadInfo()
        {
            base.ReadInfo();
            Location.LocationNumber = View.LocationNumber;
            Location.Ep2MerchantId = View.Ep2MerchantId;
            Location.SbsDebitNumber = View.SbsDebitNumber;
            // Customer.Location.SbsAdressNumber = CustomerView.SbsAdressNumber;
        }
    }
}