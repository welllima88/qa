using NUnit.Framework;
using Six.QA.Selenium.Extension;
using Six.Scs.QA.Selenium.View.Customer;
using Six.Scs.QA.Selenium.Workflow.Builder;

namespace Six.Scs.QA.Testlogic.Builder.Customer.Six
{
    public class Default : CustomerBuilder
    {
        protected override void SetCustomerData()
        {
            Selenium.View.Customer.Create.SbsCurrency = Customer.SbsCurrency;
            Selenium.View.Customer.Create.SbsBillingTenant = Customer.SbsBillingTenant;
            Selenium.View.Customer.Create.SbsSegment = Customer.SbsSegment;
            Selenium.View.Customer.Create.CustomerName = Customer.CustomerName;

            Selenium.View.Customer.Create.StreetNo = Customer.Location.Adress.StreetNo;
            Selenium.View.Customer.Create.Zip = Customer.Location.Adress.Zip;
            Selenium.View.Customer.Create.City = Customer.Location.Adress.City;
            Selenium.View.Customer.Create.Po = Customer.Location.Adress.Po;
            Selenium.View.Customer.Create.AdressAddition = Customer.Location.Adress.AdressAddition;
            Selenium.View.Customer.Create.Region = Customer.Location.Adress.Region;
            Selenium.View.Customer.Create.Agency = Customer.Location.Agency;
            Selenium.View.Customer.Create.Language = Customer.Location.Contact.Language;
            Selenium.View.Customer.Create.Country = Customer.Location.Adress.Country;
            Selenium.View.Customer.Create.Email = Customer.Location.Contact.Email;
            Selenium.View.Customer.Create.Telephone = Customer.Location.Contact.Telephone;
            Selenium.View.Customer.Create.Mobile = Customer.Location.Contact.Mobile;
            Selenium.View.Customer.Create.Fax = Customer.Location.Contact.Fax;
            Selenium.View.Customer.Create.Web = Customer.Location.Contact.Web;
            Selenium.View.Customer.Create.CategoryCode = Customer.CategoryCode;
            Selenium.View.Customer.Create.SupportContract = Customer.SupportContract;
            Selenium.View.Customer.Create.CashIntegrator = Customer.CashIntegrator;
            Selenium.View.Customer.Create.WesMandant = Customer.WesMandant;
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
            Selenium.View.Customer.Edit.CustomerName = Customer.CustomerName;
            Selenium.View.Customer.Edit.StreetNo = Customer.Location.Adress.StreetNo;
            Selenium.View.Customer.Edit.Zip = Customer.Location.Adress.Zip;
            Selenium.View.Customer.Edit.City = Customer.Location.Adress.City;
            Selenium.View.Customer.Edit.Po = Customer.Location.Adress.Po;
            Selenium.View.Customer.Edit.AdressAddition = Customer.Location.Adress.AdressAddition;
            Selenium.View.Customer.Edit.Region = Customer.Location.Adress.Region;
            Selenium.View.Customer.Edit.Agency = Customer.Location.Agency;
            Selenium.View.Customer.Edit.Language = Customer.Location.Contact.Language;
            Selenium.View.Customer.Edit.Country = Customer.Location.Adress.Country;
            Selenium.View.Customer.Edit.Email = Customer.Location.Contact.Email;
            Selenium.View.Customer.Edit.Telephone = Customer.Location.Contact.Telephone;
            Selenium.View.Customer.Edit.Mobile = Customer.Location.Contact.Mobile;
            Selenium.View.Customer.Edit.Fax = Customer.Location.Contact.Fax;
            Selenium.View.Customer.Edit.Web = Customer.Location.Contact.Web;
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