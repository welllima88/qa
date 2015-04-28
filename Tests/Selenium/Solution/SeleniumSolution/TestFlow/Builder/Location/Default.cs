using NUnit.Framework;
using Six.QA.Selenium.Extension;
using Six.Scs.QA.Application.View.Location;
using Six.Scs.QA.Application.Workflow.Builder;

namespace Six.Scs.QA.Testlogic.Builder.Location
{
    public class Default : LocationBuilder
    {
        protected override void SetData()
        {
            Application.View.Location.Create.CompanyName = Location.CompanyName;
            Application.View.Location.Create.StreetNo = Location.Adress.StreetNo;
            Application.View.Location.Create.Zip = Location.Adress.Zip;
            Application.View.Location.Create.City = Location.Adress.City;
            Application.View.Location.Create.Po = Location.Adress.Po;
            Application.View.Location.Create.AdressAddition = Location.Adress.AdressAddition;
            Application.View.Location.Create.Region = Location.Adress.Region;
            Application.View.Location.Create.Agency = Location.Agency;
            Application.View.Location.Create.Language = Location.Contact.Language;
            Application.View.Location.Create.Country = Location.Adress.Country;
            Application.View.Location.Create.Email = Location.Contact.Email;
            Application.View.Location.Create.Telephone = Location.Contact.Telephone;
            Application.View.Location.Create.Mobile = Location.Contact.Mobile;
            Application.View.Location.Create.Fax = Location.Contact.Fax;
            Application.View.Location.Create.Web = Location.Contact.Web;
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
            Application.View.Location.Edit.Agency = Location.Agency;
            Application.View.Location.Edit.CompanyName = Location.CompanyName;
            Application.View.Location.Edit.StreetNo = Location.Adress.StreetNo;
            Application.View.Location.Edit.Zip = Location.Adress.Zip;
            Application.View.Location.Edit.City = Location.Adress.City;
            Application.View.Location.Edit.Po = Location.Adress.Po;
            Application.View.Location.Edit.Region = Location.Adress.Region;
            Application.View.Location.Edit.AdressAddition = Location.Adress.AdressAddition;
            Application.View.Location.Edit.Email = Location.Contact.Email;
            Application.View.Location.Edit.Telephone = Location.Contact.Telephone;
            Application.View.Location.Edit.Mobile = Location.Contact.Mobile;
            Application.View.Location.Edit.Fax = Location.Contact.Fax;
            Application.View.Location.Edit.Web = Location.Contact.Web;
            Application.View.Location.Edit.Language = Location.Contact.Language;
            Application.View.Location.Edit.Country = Location.Adress.Country;
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