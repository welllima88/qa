using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.TestData;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Customer;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Definitions;

namespace SIX.SCS.QA.Selenium.Extension.Worklow
{
    public class CustomerService
    {
        public static void Create(CustomerData c)
        {
            CustomerMenu.CustomerCreate.Click();

            CustomerCreate.Supplier = c.Supplier;
            CustomerCreate.SbsCurrency = c.SbsCurrency;
            CustomerCreate.SbsBillingTenant = c.SbsBillingTenant;
            CustomerCreate.CustomerName = c.CustomerName;

            CustomerCreate.StreetNo = c.StreetNo;
            CustomerCreate.Zip = c.Zip;
            CustomerCreate.City = c.City;
            CustomerCreate.Po = c.Po;
            CustomerCreate.AdressAddition = c.AdressAddition;
            CustomerCreate.Region = c.Region;
            CustomerCreate.SapNumber = c.SapNumber;
            CustomerCreate.Ep2MerchantId = c.Ep2MerchantId; // may be dont set anything?
            CustomerCreate.Agency = c.Agency;
            CustomerCreate.Language = c.Language;
            CustomerCreate.Country = c.Country;
            CustomerCreate.Email = c.Email;
            CustomerCreate.Telephone = c.Telephone;
            CustomerCreate.Mobile = c.Mobile;
            CustomerCreate.Fax = c.Fax;
            CustomerCreate.Web = c.Web;
            CustomerCreate.CategoryCode = c.CategoryCode;

            CustomerCreate.SaveButton.Click();

            c.CustomerNumber = CustomerView.CustomerNumber;
            c.SbsDebitNumber = CustomerView.SbsDebitNumber;
            c.SbsAdressNumber = CustomerView.SbsAdressNumber;
        }

        public static void Edit(CustomerData c)
        {
            c.CustomerNumber = CustomerView.CustomerNumber;
            c.SbsDebitNumber = CustomerView.SbsDebitNumber;
            c.SbsAdressNumber = CustomerView.SbsAdressNumber;
            c.SbsCurrency = CustomerView.SbsCurrency;
            c.SbsBillingTenant = CustomerView.SbsBillingTenant;
            c.Supplier = CustomerView.Supplier;

            CustomerMenu.CustomerEdit.Click();

            CustomerEdit.CustomerName = c.CustomerName;
            // CustomerEdit.CompanyName = c.CompanyName;
            CustomerEdit.StreetNo = c.StreetNo;
            CustomerEdit.Zip = c.Zip;
            CustomerEdit.City = c.City;
            CustomerEdit.Po = c.Po;
            CustomerEdit.AdressAddition = c.AdressAddition;
            CustomerEdit.Region = c.Region;
            CustomerEdit.SapNumber = c.SapNumber;

            CustomerEdit.Agency = c.Agency;
            CustomerEdit.Language = c.Language;
            CustomerEdit.Country = c.Country;
            CustomerEdit.Email = c.Email;
            CustomerEdit.Telephone = c.Telephone;
            CustomerEdit.Mobile = c.Mobile;
            CustomerEdit.Fax = c.Fax;
            CustomerEdit.Web = c.Web;

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
            Assert.AreEqual(c.SbsDebitNumber, CustomerView.SbsDebitNumber);
            // Todo: not reliable check: 
            // Assert.AreEqual(c.SbsAdressNumber, CustomerView.SbsAdressNumber);
            Assert.AreEqual(c.SapNumber, CustomerView.SapNumber);
            Assert.AreEqual(c.Supplier, CustomerView.Supplier);
            Assert.AreEqual(c.SbsBillingTenant, CustomerView.SbsBillingTenant);
            StringAssert.Contains(CustomerView.SbsCurrency, c.SbsCurrency);

            StringAssert.Matches(CustomerView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);
            StringAssert.Matches(CustomerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);
            StringAssert.Matches(CustomerView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);

            Assert.AreEqual(c.Po, CustomerView.Po);
            Assert.AreEqual(c.AdressAddition, CustomerView.AdressAddition);
            Assert.AreEqual(c.Region, CustomerView.Region);
            Assert.AreEqual(c.StreetNo, CustomerView.StreetNo);
            Assert.AreEqual(c.Zip, CustomerView.Zip);
            Assert.AreEqual(c.City, CustomerView.City);
            StringAssert.Contains(CustomerView.Agency, c.Agency);
            Assert.AreEqual(c.Language, CustomerView.Language);
            Assert.AreEqual(c.Country, CustomerView.Country);
            Assert.AreEqual(c.Email, CustomerView.Email);
            Assert.AreEqual(c.Telephone, CustomerView.Telephone);
            Assert.AreEqual(c.Mobile, CustomerView.Mobile);
            Assert.AreEqual(c.Fax, CustomerView.Fax);
            Assert.AreEqual(c.Web, CustomerView.Web);
        }
    }
}