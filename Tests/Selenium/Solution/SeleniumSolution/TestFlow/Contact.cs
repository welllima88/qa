using NUnit.Framework;
using Six.Scs.Test.Model;
using Six.Scs.Test.UI.Common;
using Six.Scs.Test.UI.Common.Menu;
using Six.Scs.Test.UI.Customer;
using Six.Test.Selenium.WebDriver;
using Lobby = Six.Scs.Test.Workflow.Lobby;

namespace Six.Scs.Test
{
    public static class Contact
    {
        public static Person Create(Model.Customer customer)
        {
            Customer.Open(customer);
            View.ContactCreate.Click();
            return CreateAndSave();
        }

        private static Person CreateAndSave()
        {
            var person = Factory.Person.Create();
            Workflow.Contact.Create(person);
            Check(person);
            Lobby.OpenLatestElement();
            Check(person);
            return person;
        }

        public static Person Create(Model.Location location)
        {
            Location.Open(location);
            UI.Location.View.ContactCreate.Click();
            return CreateAndSave();
        }

        public static Person Edit(Person _person)
        {
            Open(_person);
            ContactMenu.ContactEdit.Click();
            var person = Factory.Person.Edit();

            Workflow.Contact.Edit(person);
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
            Assert.AreEqual(c.Salutation, UI.Person.View.Salutation);
            Assert.AreEqual(c.FirstName, UI.Person.View.FirstName);
            Assert.AreEqual(c.Name, UI.Person.View.Name);
            Assert.AreEqual(c.Contact.Language, UI.Person.View.Language);
            StringAssert.Contains(c.Contact.Telephone, UI.Person.View.Telephone);
            StringAssert.Contains(c.Contact.Mobile, UI.Person.View.Mobile);
            StringAssert.Contains(c.Contact.Fax, UI.Person.View.Fax);
            Assert.AreEqual(c.Contact.Email, UI.Person.View.Email);
            Assert.AreEqual(c.Adress.Po, UI.Person.View.Po);
            Assert.AreEqual(c.Adress.StreetNo, UI.Person.View.StreetNo);
            Assert.AreEqual(c.Adress.Zip, UI.Person.View.Zip);
            Assert.AreEqual(c.Adress.City, UI.Person.View.City);
            StringAssert.Contains(c.Adress.Region, UI.Person.View.Region);
            Assert.AreEqual(c.Adress.Country, UI.Person.View.Country);
            Assert.AreEqual(c.Contact.Web, UI.Person.View.Web);
            Assert.AreEqual(c.Adress.AdressAddition, UI.Person.View.AddressAddition);
        }

        public static void Delete(Person person)
        {
            Open(person);
            UI.Person.View.DeleteButton.Click();
            UI.Person.View.DeleteConfirm();

            Open(person);
            StringAssert.IsMatch("Element .*(not|nicht).*!", SiteContent.Header);
        }
    }
}