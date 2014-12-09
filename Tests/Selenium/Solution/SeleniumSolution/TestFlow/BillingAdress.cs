using NUnit.Framework;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Extension;
using Six.Scs.QA.Selenium.Location;
using Six.Scs.QA.TestData.ValueObjects;

namespace Six.Scs.QA.Testlogic
{
    public class BillingAdress
    {
        public static void Create(TestData.ValueObjects.Customer customer)
        {
            Customer.Open(customer);

            CustomerMenu.BillingAdressCreate.Click();
            BillingAddress billingAddress = TestData.Factory.BillingAddress.Create();

            Workflow.BillingAdress.Create(billingAddress);
            Check(billingAddress);
        }

        private static void Check(BillingAddress b)
        {
            Assert.AreEqual(b.CompanyName, View.CompanyName);
            StringAssert.IsMatch(TestRegExpPatterns.SbsDebitorNo, View.SbsDebitNumber);
            Assert.AreEqual(b.Adress.StreetNo, View.StreetNo);
            Assert.AreEqual(b.Adress.Po, View.Po);
            Assert.AreEqual(b.Adress.Zip, View.Zip);
            Assert.AreEqual(b.Adress.City, View.City);
            StringAssert.Contains(b.Adress.Region, View.Region);
            Assert.AreEqual(b.Adress.AdressAddition, View.AdressAddition);
            Assert.AreEqual(b.Contact.Language, View.Language);
            Assert.AreEqual(b.Adress.Country, View.Country);
            Assert.AreEqual(b.Contact.Email, View.Email);
            StringAssert.Contains(b.Contact.Telephone, View.Telephone);
            StringAssert.Contains(b.Contact.Mobile, View.Mobile);
            StringAssert.Contains(b.Contact.Fax, View.Fax);
            Assert.AreEqual(b.Contact.Web, View.Web);
        }

        public static void Edit(TestData.ValueObjects.Customer customer, BillingAddress BillingAddress)
        {
            Customer.Open(customer);
            CustomerMenu.BillingAdresses.Click();
            Selenium.Location.BillingAddress.View.List(BillingAddress).Click(); // choose the first match

            BillingAddress billingAddress = TestData.Factory.BillingAddress.Create();

            Workflow.BillingAdress.Edit(billingAddress);
            Check(billingAddress);
        }
    }
}