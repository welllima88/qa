using Six.Scs.Test.Model;
using Six.Scs.Test.UI.Common.Menu;
using Six.Scs.Test.UI.Person;

namespace Six.Scs.Test.Workflow
{
    public static class Contact
    {
        public static void Create(Person c)
        {
            UI.Person.Create.Salutation = c.Salutation;
            UI.Person.Create.FirstName = c.FirstName;
            UI.Person.Create.Name = c.Name;
            UI.Person.Create.Language = c.Contact.Language;
            UI.Person.Create.Telephone = c.Contact.Telephone;
            UI.Person.Create.Mobile = c.Contact.Mobile;
            UI.Person.Create.Fax = c.Contact.Fax;
            UI.Person.Create.Email = c.Contact.Email;
            UI.Person.Create.Po = c.Adress.Po;
            UI.Person.Create.StreetNo = c.Adress.StreetNo;
            UI.Person.Create.Zip = c.Adress.Zip;
            UI.Person.Create.City = c.Adress.City;
            UI.Person.Create.Region = c.Adress.Region;
            UI.Person.Create.Country = c.Adress.Country;
            UI.Person.Create.AdressAddition = c.Adress.AdressAddition;
            UI.Person.Create.Web = c.Contact.Web;

            UI.Person.Create.SaveButton.Click();

            c.Id = View.Id;
        }

        public static void Edit(Person c)
        {
            ContactMenu.ContactEdit.Click();

            UI.Person.Edit.Salutation = c.Salutation;
            UI.Person.Edit.FirstName = c.FirstName;
            UI.Person.Edit.Name = c.Name;
            UI.Person.Edit.Language = c.Contact.Language;
            UI.Person.Edit.Telephone = c.Contact.Telephone;
            UI.Person.Edit.Mobile = c.Contact.Mobile;
            UI.Person.Edit.Fax = c.Contact.Fax;
            UI.Person.Edit.Email = c.Contact.Email;
            UI.Person.Edit.Po = c.Adress.Po;
            UI.Person.Edit.StreetNo = c.Adress.StreetNo;
            UI.Person.Edit.Zip = c.Adress.Zip;
            UI.Person.Edit.City = c.Adress.City;
            UI.Person.Edit.Region = c.Adress.Region;
            UI.Person.Edit.Country = c.Adress.Country;
            UI.Person.Edit.AdressAddition = c.Adress.AdressAddition;
            UI.Person.Edit.Web = c.Contact.Web;

            UI.Person.Edit.SaveButton.Click();

            c.Id = View.Id;
        }
    }
}