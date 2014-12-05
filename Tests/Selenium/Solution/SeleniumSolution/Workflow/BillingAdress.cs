using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Location.BillingAddress;

namespace Six.Scs.QA.Workflow
{
    public static class BillingAdress
    {
        public static void Create(TestData.ValueObjects.Location l)
        {
            CustomerMenu.Customer.Click(); //??

            CustomerMenu.BillingAdressCreate.Click();

            Selenium.Location.BillingAddress.Create.CompanyName = l.CompanyName;
            Selenium.Location.BillingAddress.Create.StreetNo = l.Adress.StreetNo;
            Selenium.Location.BillingAddress.Create.Zip = l.Adress.Zip;
            Selenium.Location.BillingAddress.Create.City = l.Adress.City;
            Selenium.Location.BillingAddress.Create.Po = l.Adress.Po;
            Selenium.Location.BillingAddress.Create.AdressAddition = l.Adress.AdressAddition; // ??
            Selenium.Location.BillingAddress.Create.Region = l.Adress.Region;

            Selenium.Location.BillingAddress.Create.Language = l.Contact.Language;
            Selenium.Location.BillingAddress.Create.Country = l.Adress.Country;
            Selenium.Location.BillingAddress.Create.Email = l.Contact.Email;
            Selenium.Location.BillingAddress.Create.Telephone = l.Contact.Telephone;
            Selenium.Location.BillingAddress.Create.Mobile = l.Contact.Mobile;
            Selenium.Location.BillingAddress.Create.Fax = l.Contact.Fax;
            Selenium.Location.BillingAddress.Create.Web = l.Contact.Web;

            Selenium.Location.BillingAddress.Create.SaveButton.Click();

            l.SbsDebitNumber = View.SbsDebitNumber;
            // l.SbsAdressNumber = LocationView.SbsAdressNumber;
        }

        /// <summary>
        ///     Edits location
        /// </summary>
        /// <param name="l">given location data</param>
        public static void Edit(TestData.ValueObjects.Location l)
        {
            l.SbsDebitNumber = View.SbsDebitNumber;
            // l.SbsAdressNumber = LocationView.SbsAdressNumber;

            View.EditButton.Click();

            Selenium.Location.BillingAddress.Edit.CompanyName = l.CompanyName;
            Selenium.Location.BillingAddress.Edit.StreetNo = l.Adress.StreetNo;
            Selenium.Location.BillingAddress.Edit.Zip = l.Adress.Zip;
            Selenium.Location.BillingAddress.Edit.City = l.Adress.City;
            Selenium.Location.BillingAddress.Edit.Po = l.Adress.Po;
            Selenium.Location.BillingAddress.Edit.Region = l.Adress.Region;
            Selenium.Location.BillingAddress.Edit.AdressAddition = l.Adress.AdressAddition; //

            Selenium.Location.BillingAddress.Edit.Email = l.Contact.Email;
            Selenium.Location.BillingAddress.Edit.Telephone = l.Contact.Telephone;
            Selenium.Location.BillingAddress.Edit.Mobile = l.Contact.Mobile;
            Selenium.Location.BillingAddress.Edit.Fax = l.Contact.Fax;
            Selenium.Location.BillingAddress.Edit.Web = l.Contact.Web;

            Selenium.Location.BillingAddress.Edit.Language = l.Contact.Language;
            Selenium.Location.BillingAddress.Edit.Country = l.Adress.Country;

            Selenium.Location.BillingAddress.Edit.SaveButton.Click();
        }
    }
}