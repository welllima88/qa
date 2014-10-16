using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Location;
using Six.Scs.QA.TestData.Factory;

namespace Six.Scs.QA.Workflow
{
    public static class Location
    {
        public static void Create(TestData.ValueObjects.Location l)
        {
            CustomerMenu.Customer.Click();

            CustomerMenu.LocationCreate.Click();

            Selenium.Location.Create.CompanyName = l.CompanyName;
            Selenium.Location.Create.StreetNo = l.Adress.StreetNo;
            Selenium.Location.Create.Zip = l.Adress.Zip;
            Selenium.Location.Create.City = l.Adress.City;
            Selenium.Location.Create.Po = l.Adress.Po;
            Selenium.Location.Create.AdressAddition = l.Adress.AdressAddition;
            Selenium.Location.Create.Region = l.Adress.Region;
            Selenium.Location.Create.Agency = l.Agency;
            
            Selenium.Location.Create.Language = l.Contact.Language;
            Selenium.Location.Create.Country = l.Adress.Country;
            Selenium.Location.Create.Email = l.Contact.Email;
            Selenium.Location.Create.Telephone = l.Contact.Telephone;
            Selenium.Location.Create.Mobile = l.Contact.Mobile;
            Selenium.Location.Create.Fax = l.Contact.Fax;
            Selenium.Location.Create.Web = l.Contact.Web;

            Selenium.Location.Create.SaveButton.Click();

            l.Guid = View.Guid;
            l.LocationNumber = View.LocationNumber;
            l.Ep2MerchantId = View.Ep2MerchantId;
            l.SbsDebitNumber = View.SbsDebitNumber;
            // l.SbsAdressNumber = LocationView.SbsAdressNumber;
        }

        /// <summary>
        ///     Edits location
        /// </summary>
        /// <param name="l">given location data</param>
        public static void Edit(TestData.ValueObjects.Location l)
        {
            l.Guid = View.Guid;
            l.Ep2MerchantId = View.Ep2MerchantId;
            l.SbsDebitNumber = View.SbsDebitNumber;
            // l.SbsAdressNumber = LocationView.SbsAdressNumber;

            View.EditButton.Click();

            Selenium.Location.Edit.Agency = l.Agency;
            Selenium.Location.Edit.CompanyName = l.CompanyName;
            Selenium.Location.Edit.StreetNo = l.Adress.StreetNo;
            Selenium.Location.Edit.Zip = l.Adress.Zip;
            Selenium.Location.Edit.City = l.Adress.City;
            Selenium.Location.Edit.Po = l.Adress.Po;
            Selenium.Location.Edit.Region = l.Adress.Region;
            Selenium.Location.Edit.AdressAddition = l.Adress.AdressAddition;
            
            Selenium.Location.Edit.Email = l.Contact.Email;
            Selenium.Location.Edit.Telephone = l.Contact.Telephone;
            Selenium.Location.Edit.Mobile = l.Contact.Mobile;
            Selenium.Location.Edit.Fax = l.Contact.Fax;
            Selenium.Location.Edit.Web = l.Contact.Web;

            Selenium.Location.Edit.Language = l.Contact.Language;
            Selenium.Location.Edit.Country = l.Adress.Country;

            Selenium.Location.Edit.Reason = "Daten Korrektur (ohne Versand)";
            ChangeForm.Reason = "Adressänderung";
            ChangeForm.Remark = "SYR " + Factory.GenerateTestId() + " location change remark";

            Selenium.Location.Edit.SaveButton.Click();
        }
    }
}