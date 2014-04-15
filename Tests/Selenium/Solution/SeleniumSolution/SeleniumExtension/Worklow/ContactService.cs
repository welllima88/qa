using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.TestData;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Definitions;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Person;

namespace SIX.SCS.QA.Selenium.Extension.Worklow
{
    public class ContactService
    {
        public static void Create(ContactPersonData c)
        {
            ContactMenu.ContactEdit.Click();

            ContactPersonCreate.Salutation = c.Salutation;
            ContactPersonCreate.FirstName = c.FirstName;
            ContactPersonCreate.Name = c.Name;
            ContactPersonCreate.Language = c.Contact.Language;
            ContactPersonCreate.Telephone = c.Contact.Telephone;
            ContactPersonCreate.Mobile = c.Contact.Mobile;
            ContactPersonCreate.Fax = c.Contact.Fax;
            ContactPersonCreate.Email = c.Contact.Email;
            ContactPersonCreate.Po = c.Adress.Po;
            ContactPersonCreate.StreetNo = c.Adress.StreetNo;
            ContactPersonCreate.Zip = c.Adress.Zip;
            ContactPersonCreate.City = c.Adress.City;
            ContactPersonCreate.Region = c.Adress.Region;
            ContactPersonCreate.Country = c.Adress.Country;
            ContactPersonCreate.AdressAddition = c.Adress.AdressAddition;
            ContactPersonCreate.Web = c.Contact.Web;

            ContactPersonEdit.SaveButton.Click();
        }

        public static void Edit(ContactPersonData c)
        {
            ContactMenu.ContactEdit.Click();

            ContactPersonEdit.Salutation = c.Salutation;
            ContactPersonEdit.FirstName = c.FirstName;
            ContactPersonEdit.Name = c.Name;
            ContactPersonEdit.Language = c.Contact.Language;
            ContactPersonEdit.Telephone = c.Contact.Telephone;
            ContactPersonEdit.Mobile = c.Contact.Mobile;
            ContactPersonEdit.Fax = c.Contact.Fax;
            ContactPersonEdit.Email = c.Contact.Email;
            ContactPersonEdit.Po = c.Adress.Po;
            ContactPersonEdit.StreetNo = c.Adress.StreetNo;
            ContactPersonEdit.Zip = c.Adress.Zip;
            ContactPersonEdit.City = c.Adress.City;
            ContactPersonEdit.Region = c.Adress.Region;
            ContactPersonEdit.Country = c.Adress.Country;
            ContactPersonEdit.AdressAddition = c.Adress.AdressAddition;
            ContactPersonEdit.Web = c.Contact.Web;

            ContactPersonEdit.SaveButton.Click();
        }

        public static void Check(ContactPersonData c)
        {
            Assert.AreEqual(c.Salutation, ContactPersonView.Salutation);
            Assert.AreEqual(c.FirstName, ContactPersonView.FirstName);
            Assert.AreEqual(c.Name, ContactPersonView.Name);
            Assert.AreEqual(c.Contact.Language, ContactPersonView.Language);
            Assert.AreEqual(c.Contact.Telephone, ContactPersonView.Telephone);
            Assert.AreEqual(c.Contact.Mobile, ContactPersonView.Mobile);
            Assert.AreEqual(c.Contact.Fax, ContactPersonView.Fax);
            Assert.AreEqual(c.Contact.Email, ContactPersonView.Email);
            Assert.AreEqual(c.Adress.Po, ContactPersonView.Po);
            Assert.AreEqual(c.Adress.StreetNo, ContactPersonView.StreetNo);
            Assert.AreEqual(c.Adress.Zip, ContactPersonView.Zip);
            Assert.AreEqual(c.Adress.City, ContactPersonView.City);
            Assert.AreEqual(c.Adress.Region, ContactPersonView.Region);
            Assert.AreEqual(c.Adress.Country, ContactPersonView.Country);
            Assert.AreEqual(c.Contact.Web, ContactPersonView.Web);
            Assert.AreEqual(c.Adress.AdressAddition, ContactPersonView.AddressAddition);
        }
    }
}