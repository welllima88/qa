using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Location;
using Six.Scs.QA.TestData.Factory;
using Six.Scs.QA.TestData.ValueObjects;

namespace Six.Scs.QA.Workflow
{
    public static class Location
    {
        public static void Create(TestData.ValueObjects.Location l)
        {
            CustomerMenu.Customer.Click();

            CustomerMenu.LocationCreate.Click();

            LocationCreate.CompanyName = l.CompanyName;
            LocationCreate.StreetNo = l.Adress.StreetNo;
            LocationCreate.Zip = l.Adress.Zip;
            LocationCreate.City = l.Adress.City;
            LocationCreate.Po = l.Adress.Po;
            LocationCreate.AdressAddition = l.Adress.AdressAddition;
            LocationCreate.Region = l.Adress.Region;
            LocationCreate.SapNumber = l.SapNumber;
            LocationCreate.Language = l.Contact.Language;
            LocationCreate.Country = l.Adress.Country;
            LocationCreate.Email = l.Contact.Email;
            LocationCreate.Telephone = l.Contact.Telephone;
            LocationCreate.Mobile = l.Contact.Mobile;
            LocationCreate.Fax = l.Contact.Fax;
            LocationCreate.Web = l.Contact.Web;

            LocationCreate.SaveButton.Click();

            l.Guid = LocationView.Guid;
            l.Ep2MerchantId = LocationView.Ep2MerchantId;
            l.SbsDebitNumber = LocationView.SbsDebitNumber;
            l.SbsAdressNumber = LocationView.SbsAdressNumber;
        }

        /// <summary>
        ///     Edits location
        /// </summary>
        /// <param name="l">given location data</param>
        public static void Edit(TestData.ValueObjects.Location l)
        {
            l.Guid = LocationView.Guid;
            l.Ep2MerchantId = LocationView.Ep2MerchantId;
            l.SbsDebitNumber = LocationView.SbsDebitNumber;
            l.SbsAdressNumber = LocationView.SbsAdressNumber;

            LocationView.EditButton.Click();

            LocationEdit.CompanyName = l.CompanyName;
            LocationEdit.StreetNo = l.Adress.StreetNo;
            LocationEdit.Zip = l.Adress.Zip;
            LocationEdit.City = l.Adress.City;
            LocationEdit.Po = l.Adress.Po;
            LocationEdit.Region = l.Adress.Region;
            LocationEdit.AdressAddition = l.Adress.AdressAddition;
            LocationEdit.SapNumber = l.SapNumber;
            LocationEdit.Email = l.Contact.Email;
            LocationEdit.Telephone = l.Contact.Telephone;
            LocationEdit.Mobile = l.Contact.Mobile;
            LocationEdit.Fax = l.Contact.Fax;
            LocationEdit.Web = l.Contact.Web;

            LocationEdit.Language = l.Contact.Language;
            LocationEdit.Country = l.Adress.Country;

            LocationEdit.Reason = "CorrectionOnly";
            ChangeForm.Reason = "MerchantAddressChange";
            ChangeForm.Remark = "SYR " + Factory.GenerateTestId() + " location change remark";

            LocationCreate.SaveButton.Click();
        }
    }
}