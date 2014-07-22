using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Person;
using Six.Scs.QA.TestData.ValueObjects;

namespace Six.Scs.QA.Workflow
{
    public static class Contact
    {
        public static void Create(Person c)
        {
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

            // c.Id = ContactPersonView.Id;
        }

        public static void Edit(Person c)
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
    }
}