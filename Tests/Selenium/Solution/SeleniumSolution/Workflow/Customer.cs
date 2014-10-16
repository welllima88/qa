using System;
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

            Selenium.Customer.Create.Supplier = c.Supplier;
            Selenium.Customer.Create.Confirm.Click();
            
            Selenium.Customer.Create.SbsCurrency = c.SbsCurrency;
            Selenium.Customer.Create.SbsBillingTenant = c.SbsBillingTenant;
            Selenium.Customer.Create.CustomerName = c.CustomerName;

            Selenium.Customer.Create.StreetNo = c.Location.Adress.StreetNo;
            Selenium.Customer.Create.Zip = c.Location.Adress.Zip;
            Selenium.Customer.Create.City = c.Location.Adress.City;
            Selenium.Customer.Create.Po = c.Location.Adress.Po;
            Selenium.Customer.Create.AdressAddition = c.Location.Adress.AdressAddition;
            Selenium.Customer.Create.Region = c.Location.Adress.Region;
            
            Selenium.Customer.Create.Ep2MerchantId = c.Location.Ep2MerchantId; // may be don't set anything?
            Selenium.Customer.Create.Agency = c.Location.Agency;
            Selenium.Customer.Create.Language = c.Location.Contact.Language;
            Selenium.Customer.Create.Country = c.Location.Adress.Country;
            Selenium.Customer.Create.Email = c.Location.Contact.Email;
            Selenium.Customer.Create.Telephone = c.Location.Contact.Telephone;
            Selenium.Customer.Create.Mobile = c.Location.Contact.Mobile;
            Selenium.Customer.Create.Fax = c.Location.Contact.Fax;
            Selenium.Customer.Create.Web = c.Location.Contact.Web;
            Selenium.Customer.Create.CategoryCode = c.CategoryCode;

            Selenium.Customer.Create.SaveButton.Click();

            c.CustomerNumber = View.CustomerNumber;
            c.Location.SbsDebitNumber = View.SbsDebitNumber;
            // c.Location.SbsAdressNumber = CustomerView.SbsAdressNumber;
        }

        public static void Edit(TestData.ValueObjects.Customer c)
        {
            c.CustomerNumber = View.CustomerNumber;
            c.Location.SbsDebitNumber = View.SbsDebitNumber;
            // c.Location.SbsAdressNumber = CustomerView.SbsAdressNumber;
            c.SbsCurrency = View.SbsCurrency;
            c.SbsBillingTenant = View.SbsBillingTenant;
            c.Supplier = View.Supplier;

            CustomerMenu.CustomerEdit.Click();

            Selenium.Customer.Edit.CustomerName = c.CustomerName;
            Selenium.Customer.Edit.StreetNo = c.Location.Adress.StreetNo;
            Selenium.Customer.Edit.Zip = c.Location.Adress.Zip;
            Selenium.Customer.Edit.City = c.Location.Adress.City;
            Selenium.Customer.Edit.Po = c.Location.Adress.Po;
            Selenium.Customer.Edit.AdressAddition = c.Location.Adress.AdressAddition;
            Selenium.Customer.Edit.Region = c.Location.Adress.Region;
            
            Selenium.Customer.Edit.Agency = c.Location.Agency;
            Selenium.Customer.Edit.Language = c.Location.Contact.Language;
            Selenium.Customer.Edit.Country = c.Location.Adress.Country;
            Selenium.Customer.Edit.Email = c.Location.Contact.Email;
            Selenium.Customer.Edit.Telephone = c.Location.Contact.Telephone;
            Selenium.Customer.Edit.Mobile = c.Location.Contact.Mobile;
            Selenium.Customer.Edit.Fax = c.Location.Contact.Fax;
            Selenium.Customer.Edit.Web = c.Location.Contact.Web;

            ChangeForm.Reason = "Adressänderung";
            ChangeForm.Remark = "SYR " + Factory.GenerateTestId() + " customer change remark";
            // ChangeForm.DelayTime(new TimeSpan().Add(TimeSpan.FromMinutes(1)));

            Selenium.Customer.Edit.SaveButton.Click();
        }
    }
}