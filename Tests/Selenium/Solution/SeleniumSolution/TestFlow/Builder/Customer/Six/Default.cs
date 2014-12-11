using NUnit.Framework;
using Six.Scs.QA.Selenium.Customer;
using Six.Scs.QA.Selenium.Extension;
using Six.Scs.QA.Workflow.Builder;

namespace Six.Scs.QA.Testlogic.Builder.Customer.Six
{
    public class Default : CustomerBuilder
    {
        protected override void SetCustomerData()
        {
            Selenium.Customer.Create.SbsCurrency = Customer.SbsCurrency;
            Selenium.Customer.Create.SbsBillingTenant = Customer.SbsBillingTenant;
            Selenium.Customer.Create.SbsSegment = Customer.SbsSegment;
            Selenium.Customer.Create.CustomerName = Customer.CustomerName;

            Selenium.Customer.Create.StreetNo = Customer.Location.Adress.StreetNo;
            Selenium.Customer.Create.Zip = Customer.Location.Adress.Zip;
            Selenium.Customer.Create.City = Customer.Location.Adress.City;
            Selenium.Customer.Create.Po = Customer.Location.Adress.Po;
            Selenium.Customer.Create.AdressAddition = Customer.Location.Adress.AdressAddition;
            Selenium.Customer.Create.Region = Customer.Location.Adress.Region;
            Selenium.Customer.Create.Agency = Customer.Location.Agency;
            Selenium.Customer.Create.Language = Customer.Location.Contact.Language;
            Selenium.Customer.Create.Country = Customer.Location.Adress.Country;
            Selenium.Customer.Create.Email = Customer.Location.Contact.Email;
            Selenium.Customer.Create.Telephone = Customer.Location.Contact.Telephone;
            Selenium.Customer.Create.Mobile = Customer.Location.Contact.Mobile;
            Selenium.Customer.Create.Fax = Customer.Location.Contact.Fax;
            Selenium.Customer.Create.Web = Customer.Location.Contact.Web;
            Selenium.Customer.Create.CategoryCode = Customer.CategoryCode;
            Selenium.Customer.Create.SupportContract = Customer.SupportContract;
            Selenium.Customer.Create.CashIntegrator = Customer.CashIntegrator;
            Selenium.Customer.Create.WesMandant = Customer.WesMandant;
        }

        public override void Check()
        {
            Assert.AreEqual(Customer.CustomerNumber, View.CustomerNumber);
            Assert.AreEqual(Customer.CustomerName, View.CustomerName);
            Assert.AreEqual(Customer.Supplier, View.Supplier);
            Assert.AreEqual(Customer.SbsBillingTenant, View.SbsBillingTenant);
            Assert.AreEqual(Customer.SbsCurrency, View.SbsCurrency);
            Assert.AreEqual(Customer.Location.SbsDebitNumber, View.SbsDebitNumber);
            // Todo: not reliable check: 
            // Assert.AreEqual(Customer.SbsAdressNumber, CustomerView.SbsAdressNumber);
            StringAssert.IsMatch(TestRegExpPatterns.Ep2MerchantId, View.Ep2MerchantId);
            Assert.AreEqual(Customer.Location.Adress.Po, View.Po);
            Assert.AreEqual(Customer.Location.Adress.AdressAddition, View.AdressAddition);
            StringAssert.Contains(Customer.Location.Adress.Region, View.Region);
            Assert.AreEqual(Customer.Location.Adress.StreetNo, View.StreetNo);
            Assert.AreEqual(Customer.Location.Adress.Zip, View.Zip);
            Assert.AreEqual(Customer.Location.Adress.City, View.City);
            StringAssert.Contains(Customer.Location.Agency, View.Agency);
            Assert.AreEqual(Customer.Location.Contact.Language, View.Language);
            Assert.AreEqual(Customer.Location.Adress.Country, View.Country);
            Assert.AreEqual(Customer.Location.Contact.Email, View.Email);
            StringAssert.Contains(Customer.Location.Contact.Telephone, View.Telephone);
            StringAssert.Contains(Customer.Location.Contact.Mobile, View.Mobile);
            StringAssert.Contains(Customer.Location.Contact.Fax, View.Fax);
            Assert.AreEqual(Customer.Location.Contact.Web, View.Web);
        }

        protected override void EditCustomerData()
        {
            Selenium.Customer.Edit.CustomerName = Customer.CustomerName;
            Selenium.Customer.Edit.StreetNo = Customer.Location.Adress.StreetNo;
            Selenium.Customer.Edit.Zip = Customer.Location.Adress.Zip;
            Selenium.Customer.Edit.City = Customer.Location.Adress.City;
            Selenium.Customer.Edit.Po = Customer.Location.Adress.Po;
            Selenium.Customer.Edit.AdressAddition = Customer.Location.Adress.AdressAddition;
            Selenium.Customer.Edit.Region = Customer.Location.Adress.Region;
            Selenium.Customer.Edit.Agency = Customer.Location.Agency;
            Selenium.Customer.Edit.Language = Customer.Location.Contact.Language;
            Selenium.Customer.Edit.Country = Customer.Location.Adress.Country;
            Selenium.Customer.Edit.Email = Customer.Location.Contact.Email;
            Selenium.Customer.Edit.Telephone = Customer.Location.Contact.Telephone;
            Selenium.Customer.Edit.Mobile = Customer.Location.Contact.Mobile;
            Selenium.Customer.Edit.Fax = Customer.Location.Contact.Fax;
            Selenium.Customer.Edit.Web = Customer.Location.Contact.Web;
        }

        protected override void ReadInfo()
        {
            base.ReadInfo();
            Customer.SbsCurrency = View.SbsCurrency;
            Customer.SbsBillingTenant = View.SbsBillingTenant;
            Customer.Supplier = View.Supplier;
            Customer.Location.SbsDebitNumber = View.SbsDebitNumber;
            // Customer.Location.SbsAdressNumber = CustomerView.SbsAdressNumber;
        }
    }
}