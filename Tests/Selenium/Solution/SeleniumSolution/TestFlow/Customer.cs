using NUnit.Framework;
using Six.Scs.QA.Selenium.Customer;
using Six.Scs.QA.Selenium.Extension;
using Six.Scs.QA.TestData.Factory;
using Six.Scs.QA.Workflow;

namespace Six.Scs.QA.Testlogic
{
    public class Customer
    {
        public static TestData.ValueObjects.Customer Edit(TestData.ValueObjects.Customer customer)
        {
            Open(customer);
            TestData.ValueObjects.Customer _customer = CustomerFactory.Edit();
            Workflow.Customer.Edit(_customer);
            Check(_customer);

            Lobby.OpenLatestElement();
            Check(_customer);
            return _customer;
        }

        public static TestData.ValueObjects.Customer Create()
        {
            TestData.ValueObjects.Customer customer = CustomerFactory.Create();
            Workflow.Customer.Create(customer);
            Check(customer);
            Lobby.OpenLatestElement();
            Check(customer);
            return customer;
        }

        public static void Open(TestData.ValueObjects.Customer customer)
        {
            Search.CustomerCanBeFoundByCustomerNumber(customer.CustomerNumber);
        }

        public static void Check(TestData.ValueObjects.Customer c)
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