using System;
using NUnit.Framework;
using Six.Scs.Test.Helper;
using Six.Scs.Test.UI.Location;
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
            UI.Location.Create.CompanyName = Location.CompanyName;
            UI.Location.Create.StreetNo = Location.Adress.StreetNo;
            UI.Location.Create.Zip = Location.Adress.Zip;
            UI.Location.Create.City = Location.Adress.City;
            UI.Location.Create.Po = Location.Adress.Po;
            UI.Location.Create.AdressAddition = Location.Adress.AdressAddition;
            UI.Location.Create.Region = Location.Adress.Region;
            UI.Location.Create.Agency = Location.Agency;
            UI.Location.Create.Language = Location.Contact.Language;
            UI.Location.Create.Country = Location.Adress.Country;
            UI.Location.Create.Email = Location.Contact.Email;
            UI.Location.Create.Telephone = Location.Contact.Telephone;
            UI.Location.Create.Mobile = Location.Contact.Mobile;
            UI.Location.Create.Fax = Location.Contact.Fax;
            UI.Location.Create.Web = Location.Contact.Web;
        }

        public override void Check()
        {
            Verify.With(new Action[]
            {
                () => Assert.AreEqual(Location.CompanyName, View.CompanyName),
                () => StringAssert.IsMatch(TestRegExpPatterns.SbsDebitorNo, View.SbsDebitNumber),
                () => StringAssert.IsMatch(TestRegExpPatterns.Ep2MerchantId, View.Ep2MerchantId),
                () => Assert.AreEqual(Location.Adress.StreetNo, View.StreetNo),
                () => Assert.AreEqual(Location.Adress.Po, View.Po),
                () => Assert.AreEqual(Location.Adress.Zip, View.Zip),
                () => Assert.AreEqual(Location.Adress.City, View.City),
                () => StringAssert.Contains(Location.Adress.Region, View.Region),
                () => Assert.AreEqual(Location.Adress.AdressAddition, View.AdressAddition),
                () => Assert.AreEqual(Location.Contact.Language, View.Language),
                () => Assert.AreEqual(Location.Adress.Country, View.Country),
                () => Assert.AreEqual(Location.Contact.Email, View.Email),
                () => Assert.That(UI.Customer.View.Telephone, Is.StringEnding(Location.Contact.Telephone)),
                () => Assert.That(UI.Customer.View.Mobile, Is.StringEnding(Location.Contact.Mobile)),
                () => Assert.That(UI.Customer.View.Fax, Is.StringEnding(Location.Contact.Fax)),
                () => Assert.AreEqual(Location.Contact.Web, View.Web),
                () => Assert.AreEqual(Location.Agency, View.Agency)
            }).Check();
        }

        protected override void EditData()
        {
            UI.Location.Edit.Agency = Location.Agency;
            UI.Location.Edit.CompanyName = Location.CompanyName;
            UI.Location.Edit.StreetNo = Location.Adress.StreetNo;
            UI.Location.Edit.Zip = Location.Adress.Zip;
            UI.Location.Edit.City = Location.Adress.City;
            UI.Location.Edit.Po = Location.Adress.Po;
            UI.Location.Edit.Region = Location.Adress.Region;
            UI.Location.Edit.AdressAddition = Location.Adress.AdressAddition;
            UI.Location.Edit.Email = Location.Contact.Email;
            UI.Location.Edit.Telephone = Location.Contact.Telephone;
            UI.Location.Edit.Mobile = Location.Contact.Mobile;
            UI.Location.Edit.Fax = Location.Contact.Fax;
            UI.Location.Edit.Web = Location.Contact.Web;
            UI.Location.Edit.Language = Location.Contact.Language;
            UI.Location.Edit.Country = Location.Adress.Country;
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