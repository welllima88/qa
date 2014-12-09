using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Location.BillingAddress;

namespace Six.Scs.QA.Workflow
{
    public static class BillingAdress
    {
        public static void Create(TestData.ValueObjects.BillingAddress b)
        {
            CustomerMenu.BillingAdressCreate.Click();

            Selenium.Location.BillingAddress.Create.CompanyName = b.CompanyName;
            Selenium.Location.BillingAddress.Create.StreetNo = b.Adress.StreetNo;
            Selenium.Location.BillingAddress.Create.Zip = b.Adress.Zip;
            Selenium.Location.BillingAddress.Create.City = b.Adress.City;
            Selenium.Location.BillingAddress.Create.Po = b.Adress.Po;
            Selenium.Location.BillingAddress.Create.AdressAddition = b.Adress.AdressAddition; // ??
            Selenium.Location.BillingAddress.Create.Region = b.Adress.Region;

            Selenium.Location.BillingAddress.Create.Language = b.Contact.Language;
            Selenium.Location.BillingAddress.Create.Country = b.Adress.Country;
            Selenium.Location.BillingAddress.Create.Email = b.Contact.Email;
            Selenium.Location.BillingAddress.Create.Telephone = b.Contact.Telephone;
            Selenium.Location.BillingAddress.Create.Mobile = b.Contact.Mobile;
            Selenium.Location.BillingAddress.Create.Fax = b.Contact.Fax;
            Selenium.Location.BillingAddress.Create.Web = b.Contact.Web;

            Selenium.Location.BillingAddress.Create.SaveButton.Click();

            b.SbsDebitNumber = View.SbsDebitNumber;
        }

        /// <summary>
        ///     Edits billing address
        /// </summary>
        /// <param name="b">given location data</param>
        public static void Edit(TestData.ValueObjects.BillingAddress b)
        {
            b.SbsDebitNumber = View.SbsDebitNumber;

            View.EditButton.Click();

            Selenium.Location.BillingAddress.Edit.CompanyName = b.CompanyName;
            Selenium.Location.BillingAddress.Edit.StreetNo = b.Adress.StreetNo;
            Selenium.Location.BillingAddress.Edit.Zip = b.Adress.Zip;
            Selenium.Location.BillingAddress.Edit.City = b.Adress.City;
            Selenium.Location.BillingAddress.Edit.Po = b.Adress.Po;
            Selenium.Location.BillingAddress.Edit.Region = b.Adress.Region;
            Selenium.Location.BillingAddress.Edit.AdressAddition = b.Adress.AdressAddition; //

            Selenium.Location.BillingAddress.Edit.Email = b.Contact.Email;
            Selenium.Location.BillingAddress.Edit.Telephone = b.Contact.Telephone;
            Selenium.Location.BillingAddress.Edit.Mobile = b.Contact.Mobile;
            Selenium.Location.BillingAddress.Edit.Fax = b.Contact.Fax;
            Selenium.Location.BillingAddress.Edit.Web = b.Contact.Web;

            Selenium.Location.BillingAddress.Edit.Language = b.Contact.Language;
            Selenium.Location.BillingAddress.Edit.Country = b.Adress.Country;

            Selenium.Location.BillingAddress.Edit.SaveButton.Click();
        }
    }
}