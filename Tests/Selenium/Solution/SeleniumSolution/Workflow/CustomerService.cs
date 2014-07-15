using NUnit.Framework;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Customer;
using Six.Scs.QA.Selenium.Extension;
using Six.Scs.QA.TestData.Factory;
using Six.Scs.QA.TestData.ValueObjects;

namespace Six.Scs.QA.Workflow
{
    public static class CustomerService
    {
        public static void Create(CustomerData c)
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
            c.Location.SbsAdressNumber = CustomerView.SbsAdressNumber;
        }

        public static void Edit(CustomerData c)
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

        public static void Check(CustomerData c)
        {
            Assert.AreEqual(c.CustomerNumber, CustomerView.CustomerNumber);
            Assert.AreEqual(c.CustomerName, CustomerView.CustomerName);
            Assert.AreEqual(c.Supplier, CustomerView.Supplier);
            Assert.AreEqual(c.SbsBillingTenant, CustomerView.SbsBillingTenant);
            Assert.AreEqual(c.SbsCurrency, CustomerView.SbsCurrency);
            Assert.AreEqual(c.Location.SbsDebitNumber, CustomerView.SbsDebitNumber);
            // Todo: not reliable check: 
            // Assert.AreEqual(c.SbsAdressNumber, CustomerView.SbsAdressNumber);
            Assert.AreEqual(c.Location.SapNumber, CustomerView.SapNumber);
            Assert.AreEqual(c.Supplier, CustomerView.Supplier);
            Assert.AreEqual(c.SbsBillingTenant, CustomerView.SbsBillingTenant);
            StringAssert.Contains(c.SbsCurrency, CustomerView.SbsCurrency);

            StringAssert.IsMatch(TestRegExpPatterns.SbsDebitorNo, CustomerView.SbsDebitNumber);
            StringAssert.IsMatch(TestRegExpPatterns.SbsAdressNoOpt, CustomerView.SbsAdressNumber);
            StringAssert.IsMatch(TestRegExpPatterns.Ep2MerchantId, CustomerView.Ep2MerchantId);

            Assert.AreEqual(c.Location.Adress.Po, CustomerView.Po);
            Assert.AreEqual(c.Location.Adress.AdressAddition, CustomerView.AdressAddition);
            Assert.AreEqual(c.Location.Adress.Region, CustomerView.Region);
            Assert.AreEqual(c.Location.Adress.StreetNo, CustomerView.StreetNo);
            Assert.AreEqual(c.Location.Adress.Zip, CustomerView.Zip);
            Assert.AreEqual(c.Location.Adress.City, CustomerView.City);
            StringAssert.Contains(c.Agency, CustomerView.Agency);
            Assert.AreEqual(c.Location.Contact.Language, CustomerView.Language);
            Assert.AreEqual(c.Location.Adress.Country, CustomerView.Country);
            Assert.AreEqual(c.Location.Contact.Email, CustomerView.Email);
            Assert.AreEqual(c.Location.Contact.Telephone, CustomerView.Telephone);
            Assert.AreEqual(c.Location.Contact.Mobile, CustomerView.Mobile);
            Assert.AreEqual(c.Location.Contact.Fax, CustomerView.Fax);
            Assert.AreEqual(c.Location.Contact.Web, CustomerView.Web);
        }
    }
}