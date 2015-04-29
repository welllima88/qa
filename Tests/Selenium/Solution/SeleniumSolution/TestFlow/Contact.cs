using NUnit.Framework;
using Six.Scs.Test.Model.ValueObjects;
using Six.Scs.Test.View.Common;
using Six.Scs.Test.View.Common.Menu;
using Six.Test.Selenium.WebDriver;
using Lobby = Six.Scs.Test.Workflow.Lobby;

namespace Six.Scs.Test
{
    public static class Contact
    {
        public static Person Create(Test.Model.ValueObjects.Customer customer)
        {
            Customer.Open(customer);
            CustomerMenu.ContactCreate.Click();
            return CreateAndSave();
        }

        private static Person CreateAndSave()
        {
            Person person = Test.Model.Factory.Person.Create();
            Test.Workflow.Contact.Create(person);
            Check(person);
            Lobby.OpenLatestElement();
            Check(person);
            return person;
        }

        public static Person Create(Test.Model.ValueObjects.Location location)
        {
            Location.Open(location);
            LocationMenu.ContactCreate.Click();
            return CreateAndSave();
        }

        public static Person Edit(Person _person)
        {
            Open(_person);
            ContactMenu.ContactEdit.Click();
            Person person = Test.Model.Factory.Person.Edit();

            Test.Workflow.Contact.Edit(person);
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
            Assert.AreEqual(c.Salutation, View.Person.View.Salutation);
            Assert.AreEqual(c.FirstName, View.Person.View.FirstName);
            Assert.AreEqual(c.Name, View.Person.View.Name);
            Assert.AreEqual(c.Contact.Language, View.Person.View.Language);
            StringAssert.Contains(c.Contact.Telephone, View.Person.View.Telephone);
            StringAssert.Contains(c.Contact.Mobile, View.Person.View.Mobile);
            StringAssert.Contains(c.Contact.Fax, View.Person.View.Fax);
            Assert.AreEqual(c.Contact.Email, View.Person.View.Email);
            Assert.AreEqual(c.Adress.Po, View.Person.View.Po);
            Assert.AreEqual(c.Adress.StreetNo, View.Person.View.StreetNo);
            Assert.AreEqual(c.Adress.Zip, View.Person.View.Zip);
            Assert.AreEqual(c.Adress.City, View.Person.View.City);
            StringAssert.Contains(c.Adress.Region, View.Person.View.Region);
            Assert.AreEqual(c.Adress.Country, View.Person.View.Country);
            Assert.AreEqual(c.Contact.Web, View.Person.View.Web);
            Assert.AreEqual(c.Adress.AdressAddition, View.Person.View.AddressAddition);
        }

        public static void Delete(Person person)
        {
            Open(person);
            View.Person.View.DeleteButton.Click();
            View.Person.View.DeleteConfirm();

            Open(person);
            StringAssert.IsMatch("Element .*(not|nicht).*!", SiteContent.Header);
        }
    }
}