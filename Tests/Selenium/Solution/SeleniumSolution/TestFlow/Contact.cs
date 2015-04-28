using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Application.Model.ValueObjects;
using Six.Scs.QA.Application.View.Common;
using Six.Scs.QA.Application.View.Common.Menu;
using Six.Scs.QA.Application.View.Person;
using Lobby = Six.Scs.QA.Application.Workflow.Lobby;

namespace Six.Scs.QA.Testlogic
{
    public static class Contact
    {
        public static Person Create(Application.Model.ValueObjects.Customer customer)
        {
            Customer.Open(customer);
            CustomerMenu.ContactCreate.Click();
            return CreateAndSave();
        }

        private static Person CreateAndSave()
        {
            Person person = Application.Model.Factory.Person.Create();
            Application.Workflow.Contact.Create(person);
            Check(person);
            Lobby.OpenLatestElement();
            Check(person);
            return person;
        }

        public static Person Create(Application.Model.ValueObjects.Location location)
        {
            Location.Open(location);
            LocationMenu.ContactCreate.Click();
            return CreateAndSave();
        }

        public static Person Edit(Person _person)
        {
            Open(_person);
            ContactMenu.ContactEdit.Click();
            Person person = Application.Model.Factory.Person.Edit();

            Application.Workflow.Contact.Edit(person);
            Check(person);

            Lobby.OpenLatestElement();
            Check(person);
            return person;
        }

        public static void Open(Person person)
        {
            // cannot directly open a contact by search, 
            // so it might fail the following step:
            TestDirector.Navigate("Person/?PersonId=" + person.Id);
        }

        public static void Check(Person c)
        {
            Assert.AreEqual(c.Salutation, View.Salutation);
            Assert.AreEqual(c.FirstName, View.FirstName);
            Assert.AreEqual(c.Name, View.Name);
            Assert.AreEqual(c.Contact.Language, View.Language);
            StringAssert.Contains(c.Contact.Telephone, View.Telephone);
            StringAssert.Contains(c.Contact.Mobile, View.Mobile);
            StringAssert.Contains(c.Contact.Fax, View.Fax);
            Assert.AreEqual(c.Contact.Email, View.Email);
            Assert.AreEqual(c.Adress.Po, View.Po);
            Assert.AreEqual(c.Adress.StreetNo, View.StreetNo);
            Assert.AreEqual(c.Adress.Zip, View.Zip);
            Assert.AreEqual(c.Adress.City, View.City);
            StringAssert.Contains(c.Adress.Region, View.Region);
            Assert.AreEqual(c.Adress.Country, View.Country);
            Assert.AreEqual(c.Contact.Web, View.Web);
            Assert.AreEqual(c.Adress.AdressAddition, View.AddressAddition);
        }

        public static void Delete(Person person)
        {
            Open(person);
            View.DeleteButton.Click();
            View.DeleteConfirm();

            Open(person);
            StringAssert.IsMatch("Element .*(not|nicht).*!", SiteContent.Header);
        }
    }
}