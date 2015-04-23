using NUnit.Framework;
using Six.QA.Selenium.Extension;
using Six.Scs.QA.Selenium.Model.ValueObjects;
using Six.Scs.QA.Selenium.View.Common.Menu;
using Six.Scs.QA.Selenium.View.Location.BillingAddress;

namespace Six.Scs.QA.Testlogic
{
    public class BillingAdress
    {
        public static void Create(Selenium.Model.ValueObjects.Customer customer)
        {
            Customer.Open(customer);

            CustomerMenu.BillingAdressCreate.Click();
            BillingAddress billingAddress = Selenium.Model.Factory.BillingAddress.Create();

            Selenium.Workflow.BillingAdress.Create(billingAddress);
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

        public static void Edit(Selenium.Model.ValueObjects.Customer customer, BillingAddress BillingAddress)
        {
            Customer.Open(customer);
            CustomerMenu.BillingAdresses.Click();
            View.List(BillingAddress).Click(); // choose the first match

            BillingAddress billingAddress = Selenium.Model.Factory.BillingAddress.Create();

            Selenium.Workflow.BillingAdress.Edit(billingAddress);
            Check(billingAddress);
        }
    }
}