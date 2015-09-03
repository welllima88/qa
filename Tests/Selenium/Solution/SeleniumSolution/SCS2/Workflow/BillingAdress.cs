using Six.Scs.Test.Model;
using Six.Scs.Test.UI.Common.Menu;
using Six.Scs.Test.UI.Location.BillingAddress;

namespace Six.Scs.Test.Workflow
{
    public static class BillingAdress
    {
        public static void Create(BillingAddress b)
        {
            CustomerMenu.BillingAdresses.Click();
            List.BillingAdressCreate.Click();

            UI.Location.BillingAddress.Create.CompanyName = b.CompanyName;
            UI.Location.BillingAddress.Create.StreetNo = b.Adress.StreetNo;
            UI.Location.BillingAddress.Create.Zip = b.Adress.Zip;
            UI.Location.BillingAddress.Create.City = b.Adress.City;
            UI.Location.BillingAddress.Create.Po = b.Adress.Po;
            UI.Location.BillingAddress.Create.AdressAddition = b.Adress.AdressAddition;
            UI.Location.BillingAddress.Create.Region = b.Adress.Region;

            UI.Location.BillingAddress.Create.Language = b.Contact.Language;
            UI.Location.BillingAddress.Create.Country = b.Adress.Country;
            UI.Location.BillingAddress.Create.Email = b.Contact.Email;
            UI.Location.BillingAddress.Create.Telephone = b.Contact.Telephone;
            UI.Location.BillingAddress.Create.Mobile = b.Contact.Mobile;
            UI.Location.BillingAddress.Create.Fax = b.Contact.Fax;
            UI.Location.BillingAddress.Create.Web = b.Contact.Web;

            UI.Location.BillingAddress.Create.SaveButton.Click();

            b.SbsDebitNumber = View.SbsDebitNumber;
        }

        /// <summary>
        ///     Edits billing address
        /// </summary>
        /// <param name="b">given location data</param>
        public static void Edit(BillingAddress b)
        {
            View.EditButton.Click();

            UI.Location.BillingAddress.Edit.CompanyName = b.CompanyName;
            UI.Location.BillingAddress.Edit.StreetNo = b.Adress.StreetNo;
            UI.Location.BillingAddress.Edit.Zip = b.Adress.Zip;
            UI.Location.BillingAddress.Edit.City = b.Adress.City;
            UI.Location.BillingAddress.Edit.Po = b.Adress.Po;
            UI.Location.BillingAddress.Edit.Region = b.Adress.Region;
            UI.Location.BillingAddress.Edit.AdressAddition = b.Adress.AdressAddition; //

            UI.Location.BillingAddress.Edit.Email = b.Contact.Email;
            UI.Location.BillingAddress.Edit.Telephone = b.Contact.Telephone;
            UI.Location.BillingAddress.Edit.Mobile = b.Contact.Mobile;
            UI.Location.BillingAddress.Edit.Fax = b.Contact.Fax;
            UI.Location.BillingAddress.Edit.Web = b.Contact.Web;

            UI.Location.BillingAddress.Edit.Language = b.Contact.Language;
            UI.Location.BillingAddress.Edit.Country = b.Adress.Country;

            UI.Location.BillingAddress.Edit.SaveButton.Click();
        }

        public static void Delete()
        {
            View.DeleteButton.Click();
            View.DeleteDialogConfirm();
        }
    }
}