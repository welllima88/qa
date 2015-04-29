using NUnit.Framework;
using Six.Scs.Test.Workflow.Builder;

namespace Six.Scs.Test.Builder.Location
{
    public class Gicc : LocationBuilder
    {
        protected override void SetData()
        {
            View.Location.Create.CompanyName = Location.CompanyName;
            View.Location.Create.StreetNo = Location.Adress.StreetNo;
            View.Location.Create.Zip = Location.Adress.Zip;
            View.Location.Create.City = Location.Adress.City;
            View.Location.Create.Po = Location.Adress.Po;
            View.Location.Create.AdressAddition = Location.Adress.AdressAddition;
            View.Location.Create.Region = Location.Adress.Region;
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
            Assert.AreEqual(Location.CompanyName, View.Location.View.CompanyName);
            Assert.AreEqual(Location.Adress.StreetNo, View.Location.View.StreetNo);
            Assert.AreEqual(Location.Adress.Po, View.Location.View.Po);
            Assert.AreEqual(Location.Adress.Zip, View.Location.View.Zip);
            Assert.AreEqual(Location.Adress.City, View.Location.View.City);
            StringAssert.Contains(Location.Adress.Region, View.Location.View.Region);
            Assert.AreEqual(Location.Adress.AdressAddition, View.Location.View.AdressAddition);
            Assert.AreEqual(Location.Contact.Language, View.Location.View.Language);
            Assert.AreEqual(Location.Adress.Country, View.Location.View.Country);
            Assert.AreEqual(Location.Contact.Email, View.Location.View.Email);
            StringAssert.Contains(Location.Contact.Telephone, View.Location.View.Telephone);
            StringAssert.Contains(Location.Contact.Mobile, View.Location.View.Mobile);
            StringAssert.Contains(Location.Contact.Fax, View.Location.View.Fax);
            Assert.AreEqual(Location.Contact.Web, View.Location.View.Web);
        }

        protected override void EditData()
        {
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
    }
}