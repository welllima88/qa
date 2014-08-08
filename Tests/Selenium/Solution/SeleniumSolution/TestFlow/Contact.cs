using NUnit.Framework;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Person;
using Six.Scs.QA.TestData.ValueObjects;

namespace Six.Scs.QA.Testlogic
{
    public class Contact
    {
        public static Person Create(TestData.ValueObjects.Customer customer)
        {
            Customer.Open(customer);
            CustomerMenu.ContactCreate.Click();
            return CreateAndSave();
        }

        private static Person CreateAndSave()
        {
            Person person = TestData.Factory.Person.Create();
            Workflow.Contact.Create(person);
            Check(person);
            Workflow.Lobby.OpenLatestElement();
            Check(person);
            return person;
        }

        public static Person Create(TestData.ValueObjects.Location location)
        {
            Location.Open(location);
            LocationMenu.ContactCreate.Click();
            return CreateAndSave();
        }

        public static Person Edit(Person _person)
        {
            Open(_person);
            ContactMenu.ContactEdit.Click();
            Person person = TestData.Factory.Person.Edit();

            Workflow.Contact.Edit(person);
            Check(person);

            Workflow.Lobby.OpenLatestElement();
            Check(person);
            return person;
        }

        private static void Open(Person person)
        {
            // cannot directly open a contact by search, 
            // so it might fail the following step:
            TestDirector.Navigate("/Person?PersonId=" + person.Id);
        }

        public static void Check(Person c)
        {
            Assert.AreEqual(c.Salutation, ContactPersonView.Salutation);
            Assert.AreEqual(c.FirstName, ContactPersonView.FirstName);
            Assert.AreEqual(c.Name, ContactPersonView.Name);
            Assert.AreEqual(c.Contact.Language, ContactPersonView.Language);
            StringAssert.Contains(c.Contact.Telephone, ContactPersonView.Telephone);
            StringAssert.Contains(c.Contact.Mobile, ContactPersonView.Mobile);
            StringAssert.Contains(c.Contact.Fax, ContactPersonView.Fax);
            Assert.AreEqual(c.Contact.Email, ContactPersonView.Email);
            Assert.AreEqual(c.Adress.Po, ContactPersonView.Po);
            Assert.AreEqual(c.Adress.StreetNo, ContactPersonView.StreetNo);
            Assert.AreEqual(c.Adress.Zip, ContactPersonView.Zip);
            Assert.AreEqual(c.Adress.City, ContactPersonView.City);
            StringAssert.Contains(c.Adress.Region, ContactPersonView.Region);
            Assert.AreEqual(c.Adress.Country, ContactPersonView.Country);
            Assert.AreEqual(c.Contact.Web, ContactPersonView.Web);
            Assert.AreEqual(c.Adress.AdressAddition, ContactPersonView.AddressAddition);
        }
    }
}