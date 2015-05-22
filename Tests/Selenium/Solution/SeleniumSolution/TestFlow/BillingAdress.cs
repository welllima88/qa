using NUnit.Framework;
using Six.Scs.Test.Model.ValueObjects;
using Six.Scs.Test.View.Common.Menu;
using Six.Test.Selenium;

namespace Six.Scs.Test
{
    public class BillingAdress
    {
        public static BillingAddress Create(Model.ValueObjects.Customer customer)
        {
            Customer.Open(customer);

            CustomerMenu.BillingAdressCreate.Click();
            var billingAddress = Model.Factory.BillingAddress.Create();

            Workflow.BillingAdress.Create(billingAddress);
            Check(billingAddress);

            return billingAddress;
        }

        private static void Check(BillingAddress b)
        {
            Assert.AreEqual(b.CompanyName, View.Location.BillingAddress.View.CompanyName);
            StringAssert.IsMatch(TestRegExpPatterns.SbsDebitorNo, View.Location.BillingAddress.View.SbsDebitNumber);
            Assert.AreEqual(b.Adress.StreetNo, View.Location.BillingAddress.View.StreetNo);
            Assert.AreEqual(b.Adress.Po, View.Location.BillingAddress.View.Po);
            Assert.AreEqual(b.Adress.Zip, View.Location.BillingAddress.View.Zip);
            Assert.AreEqual(b.Adress.City, View.Location.BillingAddress.View.City);
            StringAssert.Contains(b.Adress.Region, View.Location.BillingAddress.View.Region);
            Assert.AreEqual(b.Adress.AdressAddition, View.Location.BillingAddress.View.AdressAddition);
            Assert.AreEqual(b.Contact.Language, View.Location.BillingAddress.View.Language);
            Assert.AreEqual(b.Adress.Country, View.Location.BillingAddress.View.Country);
            Assert.AreEqual(b.Contact.Email, View.Location.BillingAddress.View.Email);
            StringAssert.Contains(b.Contact.Telephone, View.Location.BillingAddress.View.Telephone);
            StringAssert.Contains(b.Contact.Mobile, View.Location.BillingAddress.View.Mobile);
            StringAssert.Contains(b.Contact.Fax, View.Location.BillingAddress.View.Fax);
            Assert.AreEqual(b.Contact.Web, View.Location.BillingAddress.View.Web);
        }

        public static void Edit(BillingAddress billingAddress)
        {
            Open(billingAddress);
            View.Location.BillingAddress.View.EditButton.Click();
            var billingAddressE = Model.Factory.BillingAddress.Edit();

            Workflow.BillingAdress.Edit(billingAddressE);
            Check(billingAddressE);
        }

        private static void Open(BillingAddress billingAddress)
        {
            Search.BillingAddressCanBeFoundByName(billingAddress.CompanyName);
        }
    }
}