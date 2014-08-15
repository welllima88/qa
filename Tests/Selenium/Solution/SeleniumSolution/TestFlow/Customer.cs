using NUnit.Framework;
using Six.Scs.QA.Selenium.Customer;
using Six.Scs.QA.Selenium.Extension;

namespace Six.Scs.QA.Testlogic
{
    public class Customer
    {
        public static TestData.ValueObjects.Customer Edit(TestData.ValueObjects.Customer customer)
        {
            Open(customer);
            TestData.ValueObjects.Customer _customer = TestData.Factory.Customer.Edit();
            Workflow.Customer.Edit(_customer);
            Check(_customer);

            Workflow.Lobby.OpenLatestElement();
            Check(_customer);
            return _customer;
        }

        public static TestData.ValueObjects.Customer Create()
        {
            TestData.ValueObjects.Customer customer = TestData.Factory.Customer.Create();
            Workflow.Customer.Create(customer);
            Check(customer);
            Workflow.Lobby.OpenLatestElement();
            Check(customer);
            return customer;
        }

        public static void Open(TestData.ValueObjects.Customer customer)
        {
            Search.CustomerCanBeFoundByCustomerNumber(customer.CustomerNumber);
        }

        public static void Check(TestData.ValueObjects.Customer c)
        {
            Assert.AreEqual(c.CustomerNumber, View.CustomerNumber);
            Assert.AreEqual(c.CustomerName, View.CustomerName);
            Assert.AreEqual(c.Supplier, View.Supplier);
            Assert.AreEqual(c.SbsBillingTenant, View.SbsBillingTenant);
            Assert.AreEqual(c.SbsCurrency, View.SbsCurrency);
            Assert.AreEqual(c.Location.SbsDebitNumber, View.SbsDebitNumber);
            // Todo: not reliable check: 
            // Assert.AreEqual(c.SbsAdressNumber, CustomerView.SbsAdressNumber);
            Assert.AreEqual(c.Location.SapNumber, View.SapNumber);
            Assert.AreEqual(c.Supplier, View.Supplier);
            Assert.AreEqual(c.SbsBillingTenant, View.SbsBillingTenant);
            StringAssert.Contains(c.SbsCurrency, View.SbsCurrency);

            StringAssert.IsMatch(TestRegExpPatterns.SbsDebitorNo, View.SbsDebitNumber);
            // StringAssert.IsMatch(TestRegExpPatterns.SbsAdressNoOpt, CustomerView.SbsAdressNumber);
            StringAssert.IsMatch(TestRegExpPatterns.Ep2MerchantId, View.Ep2MerchantId);

            Assert.AreEqual(c.Location.Adress.Po, View.Po);
            Assert.AreEqual(c.Location.Adress.AdressAddition, View.AdressAddition);
            StringAssert.Contains(c.Location.Adress.Region, View.Region);
            Assert.AreEqual(c.Location.Adress.StreetNo, View.StreetNo);
            Assert.AreEqual(c.Location.Adress.Zip, View.Zip);
            Assert.AreEqual(c.Location.Adress.City, View.City);
            StringAssert.Contains(c.Agency, View.Agency);
            Assert.AreEqual(c.Location.Contact.Language, View.Language);
            Assert.AreEqual(c.Location.Adress.Country, View.Country);
            Assert.AreEqual(c.Location.Contact.Email, View.Email);
            StringAssert.Contains(c.Location.Contact.Telephone, View.Telephone);
            StringAssert.Contains(c.Location.Contact.Mobile, View.Mobile);
            StringAssert.Contains(c.Location.Contact.Fax, View.Fax);
            Assert.AreEqual(c.Location.Contact.Web, View.Web);
        }
    }
}