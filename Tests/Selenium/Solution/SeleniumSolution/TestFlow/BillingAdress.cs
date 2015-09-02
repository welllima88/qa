using System;
using NUnit.Framework;
using Six.Scs.Test.Helper;
using Six.Scs.Test.Model;
using Six.Scs.Test.Workflow;
using Six.Test.Selenium;

namespace Six.Scs.Test
{
    public class BillingAdress
    {
        public static BillingAddress Create(Model.Customer customer)
        {
            Customer.Open(customer);

            var billingAddress = Factory.BillingAddress.Create();
            Workflow.BillingAdress.Create(billingAddress);

            Check(billingAddress);
            Lobby.OpenLatestElement();
            Check(billingAddress);

            return billingAddress;
        }

        private static void Check(BillingAddress b)
        {
            Verify.With(new Action[]
            {
                () => Assert.AreEqual(b.CompanyName, View.Location.BillingAddress.View.CompanyName),
                () =>
                    StringAssert.IsMatch(TestRegExpPatterns.SbsDebitorNo,
                        View.Location.BillingAddress.View.SbsDebitNumber),
                () => Assert.AreEqual(b.Adress.StreetNo, View.Location.BillingAddress.View.StreetNo),
                () => Assert.AreEqual(b.Adress.Po, View.Location.BillingAddress.View.Po),
                () => Assert.AreEqual(b.Adress.Zip, View.Location.BillingAddress.View.Zip),
                () => Assert.AreEqual(b.Adress.City, View.Location.BillingAddress.View.City),
                () => StringAssert.Contains(b.Adress.Region, View.Location.BillingAddress.View.Region),
                () => Assert.AreEqual(b.Adress.AdressAddition, View.Location.BillingAddress.View.AdressAddition),
                () => Assert.AreEqual(b.Contact.Language, View.Location.BillingAddress.View.Language),
                () => Assert.AreEqual(b.Adress.Country, View.Location.BillingAddress.View.Country),
                () => Assert.AreEqual(b.Contact.Email, View.Location.BillingAddress.View.Email),
                () => StringAssert.Contains(b.Contact.Telephone, View.Location.BillingAddress.View.Telephone),
                () => StringAssert.Contains(b.Contact.Mobile, View.Location.BillingAddress.View.Mobile),
                () => StringAssert.Contains(b.Contact.Fax, View.Location.BillingAddress.View.Fax),
                () => Assert.AreEqual(b.Contact.Web, View.Location.BillingAddress.View.Web)
            }).Check();
        }

        public static BillingAddress Edit(BillingAddress billingAddress)
        {
            Open(billingAddress);

            var billingAddressE = Factory.BillingAddress.Edit();
            Workflow.BillingAdress.Edit(billingAddressE);

            Check(billingAddressE);
            Lobby.OpenLatestElement();
            Check(billingAddressE);
            return billingAddressE;
        }

        private static void Open(BillingAddress billingAddress)
        {
            Search.BillingAddressCanBeFoundByName(billingAddress.CompanyName);
        }
    }
}