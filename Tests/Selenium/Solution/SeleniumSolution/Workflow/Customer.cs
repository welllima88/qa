using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Customer;
using Six.Scs.QA.TestData.Factory;

namespace Six.Scs.QA.Workflow
{
    public static class Customer
    {
        public static void Create(TestData.ValueObjects.Customer c)
        {
            CustomerMenu.CustomerCreate.Click();

            CustomerCreate.Supplier = c.Supplier;
            CustomerCreate.SbsCurrency = c.SbsCurrency;
            CustomerCreate.SbsBillingTenant = c.SbsBillingTenant;
            CustomerCreate.CustomerName = c.CustomerName;

            CustomerCreate.StreetNo = c.Location.Adress.StreetNo;
            CustomerCreate.Zip = c.Location.Adress.Zip;
            CustomerCreate.City = c.Location.Adress.City;
            CustomerCreate.Po = c.Location.Adress.Po;
            CustomerCreate.AdressAddition = c.Location.Adress.AdressAddition;
            CustomerCreate.Region = c.Location.Adress.Region;
            CustomerCreate.SapNumber = c.Location.SapNumber;
            CustomerCreate.Ep2MerchantId = c.Location.Ep2MerchantId; // may be don't set anything?
            CustomerCreate.Agency = c.Agency;
            CustomerCreate.Language = c.Location.Contact.Language;
            CustomerCreate.Country = c.Location.Adress.Country;
            CustomerCreate.Email = c.Location.Contact.Email;
            CustomerCreate.Telephone = c.Location.Contact.Telephone;
            CustomerCreate.Mobile = c.Location.Contact.Mobile;
            CustomerCreate.Fax = c.Location.Contact.Fax;
            CustomerCreate.Web = c.Location.Contact.Web;
            CustomerCreate.CategoryCode = c.CategoryCode;

            CustomerCreate.SaveButton.Click();

            c.CustomerNumber = CustomerView.CustomerNumber;
            c.Location.SbsDebitNumber = CustomerView.SbsDebitNumber;
            // c.Location.SbsAdressNumber = CustomerView.SbsAdressNumber;
        }

        public static void Edit(TestData.ValueObjects.Customer c)
        {
            c.CustomerNumber = CustomerView.CustomerNumber;
            c.Location.SbsDebitNumber = CustomerView.SbsDebitNumber;
            c.Location.SbsAdressNumber = CustomerView.SbsAdressNumber;
            c.SbsCurrency = CustomerView.SbsCurrency;
            c.SbsBillingTenant = CustomerView.SbsBillingTenant;
            c.Supplier = CustomerView.Supplier;

            CustomerMenu.CustomerEdit.Click();

            CustomerEdit.CustomerName = c.CustomerName;
            CustomerEdit.StreetNo = c.Location.Adress.StreetNo;
            CustomerEdit.Zip = c.Location.Adress.Zip;
            CustomerEdit.City = c.Location.Adress.City;
            CustomerEdit.Po = c.Location.Adress.Po;
            CustomerEdit.AdressAddition = c.Location.Adress.AdressAddition;
            CustomerEdit.Region = c.Location.Adress.Region;
            CustomerEdit.SapNumber = c.Location.SapNumber;

            CustomerEdit.Agency = c.Agency;
            CustomerEdit.Language = c.Location.Contact.Language;
            CustomerEdit.Country = c.Location.Adress.Country;
            CustomerEdit.Email = c.Location.Contact.Email;
            CustomerEdit.Telephone = c.Location.Contact.Telephone;
            CustomerEdit.Mobile = c.Location.Contact.Mobile;
            CustomerEdit.Fax = c.Location.Contact.Fax;
            CustomerEdit.Web = c.Location.Contact.Web;

            ChangeForm.Reason = "MerchantAddressChange";
            ChangeForm.Remark = "SYR " + Factory.GenerateTestId() + " customer change remark";

            CustomerEdit.SaveButton.Click();
        }
    }
}