using Six.Scs.QA.Selenium.Model.ValueObjects;
using Six.Scs.QA.Selenium.View.Common.Menu;

namespace Six.Scs.QA.Selenium.Workflow
{
    public static class Contact
    {
        public static void Create(Person c)
        {
            View.Person.Create.Salutation = c.Salutation;
            View.Person.Create.FirstName = c.FirstName;
            View.Person.Create.Name = c.Name;
            View.Person.Create.Language = c.Contact.Language;
            View.Person.Create.Telephone = c.Contact.Telephone;
            View.Person.Create.Mobile = c.Contact.Mobile;
            View.Person.Create.Fax = c.Contact.Fax;
            View.Person.Create.Email = c.Contact.Email;
            View.Person.Create.Po = c.Adress.Po;
            View.Person.Create.StreetNo = c.Adress.StreetNo;
            View.Person.Create.Zip = c.Adress.Zip;
            View.Person.Create.City = c.Adress.City;
            View.Person.Create.Region = c.Adress.Region;
            View.Person.Create.Country = c.Adress.Country;
            View.Person.Create.AdressAddition = c.Adress.AdressAddition;
            View.Person.Create.Web = c.Contact.Web;

            View.Person.Create.SaveButton.Click();

            c.Id = View.Person.View.Id;
        }

        public static void Edit(Person c)
        {
            ContactMenu.ContactEdit.Click();

            View.Person.Edit.Salutation = c.Salutation;
            View.Person.Edit.FirstName = c.FirstName;
            View.Person.Edit.Name = c.Name;
            View.Person.Edit.Language = c.Contact.Language;
            View.Person.Edit.Telephone = c.Contact.Telephone;
            View.Person.Edit.Mobile = c.Contact.Mobile;
            View.Person.Edit.Fax = c.Contact.Fax;
            View.Person.Edit.Email = c.Contact.Email;
            View.Person.Edit.Po = c.Adress.Po;
            View.Person.Edit.StreetNo = c.Adress.StreetNo;
            View.Person.Edit.Zip = c.Adress.Zip;
            View.Person.Edit.City = c.Adress.City;
            View.Person.Edit.Region = c.Adress.Region;
            View.Person.Edit.Country = c.Adress.Country;
            View.Person.Edit.AdressAddition = c.Adress.AdressAddition;
            View.Person.Edit.Web = c.Contact.Web;

            View.Person.Edit.SaveButton.Click();

            c.Id = View.Person.View.Id;
        }
    }
}