using Six.Scs.QA.Application.View.Common.Menu;
using Six.Scs.QA.Application.Workflow.Builder;

namespace Six.Scs.QA.Application.Workflow
{
    public static class Location
    {
        public static void Create(Model.ValueObjects.Location l)
        {
            CustomerMenu.Customer.Click();

            CustomerMenu.LocationCreate.Click();

            View.Location.Create.CompanyName = l.CompanyName;
            View.Location.Create.StreetNo = l.Adress.StreetNo;
            View.Location.Create.Zip = l.Adress.Zip;
            View.Location.Create.City = l.Adress.City;
            View.Location.Create.Po = l.Adress.Po;
            View.Location.Create.AdressAddition = l.Adress.AdressAddition;
            View.Location.Create.Region = l.Adress.Region;
            View.Location.Create.Agency = l.Agency;

            View.Location.Create.Language = l.Contact.Language;
            View.Location.Create.Country = l.Adress.Country;
            View.Location.Create.Email = l.Contact.Email;
            View.Location.Create.Telephone = l.Contact.Telephone;
            View.Location.Create.Mobile = l.Contact.Mobile;
            View.Location.Create.Fax = l.Contact.Fax;
            View.Location.Create.Web = l.Contact.Web;

            View.Location.Create.SaveButton.Click();

            l.Guid = View.Location.View.Guid;
            l.LocationNumber = View.Location.View.LocationNumber;
            l.Ep2MerchantId = View.Location.View.Ep2MerchantId;
            l.SbsDebitNumber = View.Location.View.SbsDebitNumber;
            // l.SbsAdressNumber = LocationView.SbsAdressNumber;
        }

        /// <summary>
        ///     Edits location
        /// </summary>
        /// <param name="l">given location data</param>
        public static void Edit(Model.ValueObjects.Location l)
        {
            l.Guid = View.Location.View.Guid;
            l.Ep2MerchantId = View.Location.View.Ep2MerchantId;
            l.SbsDebitNumber = View.Location.View.SbsDebitNumber;
            // l.SbsAdressNumber = LocationView.SbsAdressNumber;

            View.Location.View.EditButton.Click();

            View.Location.Edit.Agency = l.Agency;
            View.Location.Edit.CompanyName = l.CompanyName;
            View.Location.Edit.StreetNo = l.Adress.StreetNo;
            View.Location.Edit.Zip = l.Adress.Zip;
            View.Location.Edit.City = l.Adress.City;
            View.Location.Edit.Po = l.Adress.Po;
            View.Location.Edit.Region = l.Adress.Region;
            View.Location.Edit.AdressAddition = l.Adress.AdressAddition;

            View.Location.Edit.Email = l.Contact.Email;
            View.Location.Edit.Telephone = l.Contact.Telephone;
            View.Location.Edit.Mobile = l.Contact.Mobile;
            View.Location.Edit.Fax = l.Contact.Fax;
            View.Location.Edit.Web = l.Contact.Web;

            View.Location.Edit.Language = l.Contact.Language;
            View.Location.Edit.Country = l.Adress.Country;

            new DefaultChange().Do();

            View.Location.Edit.SaveButton.Click();
        }
    }
}