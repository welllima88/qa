using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.TestData.Factory;
using Six.Scs.QA.TestData.ValueObjects;
using Six.Scs.QA.Workflow;

namespace Six.Scs.QA.Selenium.SystemTest
{
    public class Contact
    {
        public static ContactPersonData Create(CustomerData customer)
        {
            Customer.Open(customer);
            CustomerMenu.ContactCreate.Click();
            return CreateAndSave();
        }

        private static ContactPersonData CreateAndSave()
        {
            ContactPersonData person = ContactPersonFactory.Create();
            ContactService.Create(person);
            ContactService.Check(person);
            LobbyService.OpenLatestElement();
            ContactService.Check(person);
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

            ContactService.Edit(contactPersonData);
            ContactService.Check(contactPersonData);

            LobbyService.OpenLatestElement();
            ContactService.Check(contactPersonData);
            return contactPersonData;
        }

        private static void Open(ContactPersonData person)
        {
            // cannot directly open a contact by search, 
            // so it might fail the following step:
            TestDirector.Navigate("/Person?PersonId=" + person.Id);
        }
    }
}