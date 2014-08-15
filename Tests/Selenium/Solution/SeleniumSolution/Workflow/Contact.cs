using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Person;
using Six.Scs.QA.TestData.ValueObjects;

namespace Six.Scs.QA.Workflow
{
    public static class Contact
    {
        public static void Create(Person c)
        {
            Selenium.Person.Create.Salutation = c.Salutation;
            Selenium.Person.Create.FirstName = c.FirstName;
            Selenium.Person.Create.Name = c.Name;
            Selenium.Person.Create.Language = c.Contact.Language;
            Selenium.Person.Create.Telephone = c.Contact.Telephone;
            Selenium.Person.Create.Mobile = c.Contact.Mobile;
            Selenium.Person.Create.Fax = c.Contact.Fax;
            Selenium.Person.Create.Email = c.Contact.Email;
            Selenium.Person.Create.Po = c.Adress.Po;
            Selenium.Person.Create.StreetNo = c.Adress.StreetNo;
            Selenium.Person.Create.Zip = c.Adress.Zip;
            Selenium.Person.Create.City = c.Adress.City;
            Selenium.Person.Create.Region = c.Adress.Region;
            Selenium.Person.Create.Country = c.Adress.Country;
            Selenium.Person.Create.AdressAddition = c.Adress.AdressAddition;
            Selenium.Person.Create.Web = c.Contact.Web;

            Selenium.Person.Create.SaveButton.Click();

            c.Id = View.Id;
        }

        public static void Edit(Person c)
        {
            ContactMenu.ContactEdit.Click();

            Selenium.Person.Edit.Salutation = c.Salutation;
            Selenium.Person.Edit.FirstName = c.FirstName;
            Selenium.Person.Edit.Name = c.Name;
            Selenium.Person.Edit.Language = c.Contact.Language;
            Selenium.Person.Edit.Telephone = c.Contact.Telephone;
            Selenium.Person.Edit.Mobile = c.Contact.Mobile;
            Selenium.Person.Edit.Fax = c.Contact.Fax;
            Selenium.Person.Edit.Email = c.Contact.Email;
            Selenium.Person.Edit.Po = c.Adress.Po;
            Selenium.Person.Edit.StreetNo = c.Adress.StreetNo;
            Selenium.Person.Edit.Zip = c.Adress.Zip;
            Selenium.Person.Edit.City = c.Adress.City;
            Selenium.Person.Edit.Region = c.Adress.Region;
            Selenium.Person.Edit.Country = c.Adress.Country;
            Selenium.Person.Edit.AdressAddition = c.Adress.AdressAddition;
            Selenium.Person.Edit.Web = c.Contact.Web;

            Selenium.Person.Edit.SaveButton.Click();
        }
    }
}