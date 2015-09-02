using System;
using NUnit.Framework;
using Six.Scs.Test.Helper;
using Six.Scs.Test.Workflow.Builder;
using Six.Test.Selenium;

namespace Six.Scs.Test.Builder.Location
{
    public class Default : LocationBuilder
    {
        public Default(Model.Location location) : base(location)
        {
        }

        protected override void SetData()
        {
            View.Location.Create.CompanyName = Location.CompanyName;
            View.Location.Create.StreetNo = Location.Adress.StreetNo;
            View.Location.Create.Zip = Location.Adress.Zip;
            View.Location.Create.City = Location.Adress.City;
            View.Location.Create.Po = Location.Adress.Po;
            View.Location.Create.AdressAddition = Location.Adress.AdressAddition;
            View.Location.Create.Region = Location.Adress.Region;
            View.Location.Create.Agency = Location.Agency;
            View.Location.Create.Language = Location.Contact.Language;
            View.Location.Create.Country = Location.Adress.Country;
            View.Location.Create.Email = Location.Contact.Email;
            View.Location.Create.Telephone = Location.Contact.Telephone;
            View.Location.Create.Mobile = Location.Contact.Mobile;
            View.Location.Create.Fax = Location.Contact.Fax;
            View.Location.Create.Web = Location.Contact.Web;
        }

        public override void Check()
        {
            Verify.With(new Action[]
            {
                () => Assert.AreEqual(Location.CompanyName, View.Location.View.CompanyName),
                () => StringAssert.IsMatch(TestRegExpPatterns.SbsDebitorNo, View.Location.View.SbsDebitNumber),
                () => StringAssert.IsMatch(TestRegExpPatterns.Ep2MerchantId, View.Location.View.Ep2MerchantId),
                () => Assert.AreEqual(Location.Adress.StreetNo, View.Location.View.StreetNo),
                () => Assert.AreEqual(Location.Adress.Po, View.Location.View.Po),
                () => Assert.AreEqual(Location.Adress.Zip, View.Location.View.Zip),
                () => Assert.AreEqual(Location.Adress.City, View.Location.View.City),
                () => StringAssert.Contains(Location.Adress.Region, View.Location.View.Region),
                () => Assert.AreEqual(Location.Adress.AdressAddition, View.Location.View.AdressAddition),
                () => Assert.AreEqual(Location.Contact.Language, View.Location.View.Language),
                () => Assert.AreEqual(Location.Adress.Country, View.Location.View.Country),
                () => Assert.AreEqual(Location.Contact.Email, View.Location.View.Email),
                () => Assert.That(View.Customer.View.Telephone, Is.StringEnding(Location.Contact.Telephone)),
                () => Assert.That(View.Customer.View.Mobile, Is.StringEnding(Location.Contact.Mobile)),
                () => Assert.That(View.Customer.View.Fax, Is.StringEnding(Location.Contact.Fax)),
                () => Assert.AreEqual(Location.Contact.Web, View.Location.View.Web),
                () => Assert.AreEqual(Location.Agency, View.Location.View.Agency)
            }).Check();
        }

        protected override void EditData()
        {
            View.Location.Edit.Agency = Location.Agency;
            View.Location.Edit.CompanyName = Location.CompanyName;
            View.Location.Edit.StreetNo = Location.Adress.StreetNo;
            View.Location.Edit.Zip = Location.Adress.Zip;
            View.Location.Edit.City = Location.Adress.City;
            View.Location.Edit.Po = Location.Adress.Po;
            View.Location.Edit.Region = Location.Adress.Region;
            View.Location.Edit.AdressAddition = Location.Adress.AdressAddition;
            View.Location.Edit.Email = Location.Contact.Email;
            View.Location.Edit.Telephone = Location.Contact.Telephone;
            View.Location.Edit.Mobile = Location.Contact.Mobile;
            View.Location.Edit.Fax = Location.Contact.Fax;
            View.Location.Edit.Web = Location.Contact.Web;
            View.Location.Edit.Language = Location.Contact.Language;
            View.Location.Edit.Country = Location.Adress.Country;
        }

        protected override void ReadInfo()
        {
            base.ReadInfo();
            Location.LocationNumber = View.Location.View.LocationNumber;
            Location.Ep2MerchantId = View.Location.View.Ep2MerchantId;
            Location.SbsDebitNumber = View.Location.View.SbsDebitNumber;
            // Customer.Location.SbsAdressNumber = CustomerView.SbsAdressNumber;
        }
    }
}