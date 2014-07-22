using NUnit.Framework;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Person;
using Six.Scs.QA.TestData.Factory;
using Six.Scs.QA.TestData.ValueObjects;
using Six.Scs.QA.Workflow;

namespace Six.Scs.QA.Testlogic
{
    public class Contact
    {
        public static ContactPersonData Create(TestData.ValueObjects.Customer customer)
        {
            Customer.Open(customer);
            CustomerMenu.ContactCreate.Click();
            return CreateAndSave();
        }

        private static ContactPersonData CreateAndSave()
        {
            ContactPersonData person = ContactPersonFactory.Create();
            Workflow.Contact.Create(person);
            Check(person);
            Lobby.OpenLatestElement();
            Check(person);
            return person;
        }

        public static ContactPersonData Create(LocationData location)
        {
            Location.Open(location);
            LocationMenu.ContactCreate.Click();
            return CreateAndSave();
        }

        public static ContactPersonData Edit(ContactPersonData person)
        {
            Open(person);
            ContactMenu.ContactEdit.Click();
            ContactPersonData contactPersonData = ContactPersonFactory.Edit();

            Workflow.Contact.Edit(contactPersonData);
            Check(contactPersonData);

            Lobby.OpenLatestElement();
            Check(contactPersonData);
            return contactPersonData;
        }

        private static void Open(ContactPersonData person)
        {
            // cannot directly open a contact by search, 
            // so it might fail the following step:
            TestDirector.Navigate("/Person?PersonId=" + person.Id);
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