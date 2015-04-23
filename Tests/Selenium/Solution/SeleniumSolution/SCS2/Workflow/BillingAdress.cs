using Six.Scs.QA.Selenium.Model.ValueObjects;
using Six.Scs.QA.Selenium.View.Common.Menu;

namespace Six.Scs.QA.Selenium.Workflow
{
    public static class BillingAdress
    {
        public static void Create(BillingAddress b)
        {
            CustomerMenu.BillingAdressCreate.Click();

            View.Location.BillingAddress.Create.CompanyName = b.CompanyName;
            View.Location.BillingAddress.Create.StreetNo = b.Adress.StreetNo;
            View.Location.BillingAddress.Create.Zip = b.Adress.Zip;
            View.Location.BillingAddress.Create.City = b.Adress.City;
            View.Location.BillingAddress.Create.Po = b.Adress.Po;
            View.Location.BillingAddress.Create.AdressAddition = b.Adress.AdressAddition;
            View.Location.BillingAddress.Create.Region = b.Adress.Region;

            View.Location.BillingAddress.Create.Language = b.Contact.Language;
            View.Location.BillingAddress.Create.Country = b.Adress.Country;
            View.Location.BillingAddress.Create.Email = b.Contact.Email;
            View.Location.BillingAddress.Create.Telephone = b.Contact.Telephone;
            View.Location.BillingAddress.Create.Mobile = b.Contact.Mobile;
            View.Location.BillingAddress.Create.Fax = b.Contact.Fax;
            View.Location.BillingAddress.Create.Web = b.Contact.Web;

            View.Location.BillingAddress.Create.SaveButton.Click();

            b.SbsDebitNumber = View.Location.BillingAddress.View.SbsDebitNumber;
        }

        /// <summary>
        ///     Edits billing address
        /// </summary>
        /// <param name="b">given location data</param>
        public static void Edit(BillingAddress b)
        {
            b.SbsDebitNumber = View.Location.BillingAddress.View.SbsDebitNumber;

            View.Location.BillingAddress.View.EditButton.Click();

            View.Location.BillingAddress.Edit.CompanyName = b.CompanyName;
            View.Location.BillingAddress.Edit.StreetNo = b.Adress.StreetNo;
            View.Location.BillingAddress.Edit.Zip = b.Adress.Zip;
            View.Location.BillingAddress.Edit.City = b.Adress.City;
            View.Location.BillingAddress.Edit.Po = b.Adress.Po;
            View.Location.BillingAddress.Edit.Region = b.Adress.Region;
            View.Location.BillingAddress.Edit.AdressAddition = b.Adress.AdressAddition; //

            View.Location.BillingAddress.Edit.Email = b.Contact.Email;
            View.Location.BillingAddress.Edit.Telephone = b.Contact.Telephone;
            View.Location.BillingAddress.Edit.Mobile = b.Contact.Mobile;
            View.Location.BillingAddress.Edit.Fax = b.Contact.Fax;
            View.Location.BillingAddress.Edit.Web = b.Contact.Web;

            View.Location.BillingAddress.Edit.Language = b.Contact.Language;
            View.Location.BillingAddress.Edit.Country = b.Adress.Country;

            View.Location.BillingAddress.Edit.SaveButton.Click();
        }
    }
}