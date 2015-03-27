using NUnit.Framework;
using Six.QA.Selenium.Extension;
using Six.Scs.QA.Selenium.Location;
using Six.Scs.QA.Workflow.Builder;

namespace Six.Scs.QA.Testlogic.Builder.Location
{
    public class Gicc : LocationBuilder
    {
        protected override void SetData()
        {
            Selenium.Location.Create.CompanyName = Location.CompanyName;
            Selenium.Location.Create.StreetNo = Location.Adress.StreetNo;
            Selenium.Location.Create.Zip = Location.Adress.Zip;
            Selenium.Location.Create.City = Location.Adress.City;
            Selenium.Location.Create.Po = Location.Adress.Po;
            Selenium.Location.Create.AdressAddition = Location.Adress.AdressAddition;
            Selenium.Location.Create.Region = Location.Adress.Region;
            Selenium.Location.Create.Language = Location.Contact.Language;
            Selenium.Location.Create.Country = Location.Adress.Country;
            Selenium.Location.Create.Email = Location.Contact.Email;
            Selenium.Location.Create.Telephone = Location.Contact.Telephone;
            Selenium.Location.Create.Mobile = Location.Contact.Mobile;
            Selenium.Location.Create.Fax = Location.Contact.Fax;
            Selenium.Location.Create.Web = Location.Contact.Web;
        }

        public override void Check()
        {
            Assert.AreEqual(Location.CompanyName, View.CompanyName);
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
        }

        protected override void EditData()
        {
            Selenium.Location.Edit.CompanyName = Location.CompanyName;
            Selenium.Location.Edit.StreetNo = Location.Adress.StreetNo;
            Selenium.Location.Edit.Zip = Location.Adress.Zip;
            Selenium.Location.Edit.City = Location.Adress.City;
            Selenium.Location.Edit.Po = Location.Adress.Po;
            Selenium.Location.Edit.Region = Location.Adress.Region;
            Selenium.Location.Edit.AdressAddition = Location.Adress.AdressAddition;
            Selenium.Location.Edit.Email = Location.Contact.Email;
            Selenium.Location.Edit.Telephone = Location.Contact.Telephone;
            Selenium.Location.Edit.Mobile = Location.Contact.Mobile;
            Selenium.Location.Edit.Fax = Location.Contact.Fax;
            Selenium.Location.Edit.Web = Location.Contact.Web;
            Selenium.Location.Edit.Language = Location.Contact.Language;
            Selenium.Location.Edit.Country = Location.Adress.Country;
        }

    }
}