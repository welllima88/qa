using NUnit.Framework;
using Six.Scs.Test.Workflow.Builder;

namespace Six.Scs.Test.Builder.Location
{
    public class Gicc : LocationBuilder
    {
        protected override void SetData()
        {
            Test.View.Location.Create.CompanyName = Location.CompanyName;
            Test.View.Location.Create.StreetNo = Location.Adress.StreetNo;
            Test.View.Location.Create.Zip = Location.Adress.Zip;
            Test.View.Location.Create.City = Location.Adress.City;
            Test.View.Location.Create.Po = Location.Adress.Po;
            Test.View.Location.Create.AdressAddition = Location.Adress.AdressAddition;
            Test.View.Location.Create.Region = Location.Adress.Region;
            Test.View.Location.Create.Language = Location.Contact.Language;
            Test.View.Location.Create.Country = Location.Adress.Country;
            Test.View.Location.Create.Email = Location.Contact.Email;
            Test.View.Location.Create.Telephone = Location.Contact.Telephone;
            Test.View.Location.Create.Mobile = Location.Contact.Mobile;
            Test.View.Location.Create.Fax = Location.Contact.Fax;
            Test.View.Location.Create.Web = Location.Contact.Web;
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
            Test.View.Location.Edit.CompanyName = Location.CompanyName;
            Test.View.Location.Edit.StreetNo = Location.Adress.StreetNo;
            Test.View.Location.Edit.Zip = Location.Adress.Zip;
            Test.View.Location.Edit.City = Location.Adress.City;
            Test.View.Location.Edit.Po = Location.Adress.Po;
            Test.View.Location.Edit.Region = Location.Adress.Region;
            Test.View.Location.Edit.AdressAddition = Location.Adress.AdressAddition;
            Test.View.Location.Edit.Email = Location.Contact.Email;
            Test.View.Location.Edit.Telephone = Location.Contact.Telephone;
            Test.View.Location.Edit.Mobile = Location.Contact.Mobile;
            Test.View.Location.Edit.Fax = Location.Contact.Fax;
            Test.View.Location.Edit.Web = Location.Contact.Web;
            Test.View.Location.Edit.Language = Location.Contact.Language;
            Test.View.Location.Edit.Country = Location.Adress.Country;
        }

    }
}