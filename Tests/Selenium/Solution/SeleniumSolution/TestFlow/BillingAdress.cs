using System;
using NUnit.Framework;
using Six.Scs.Test.Helper;
using Six.Scs.Test.Model;
using Six.Scs.Test.UI.Location.BillingAddress;
using Six.Scs.Test.UI.Search;
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
                () => Assert.AreEqual(b.CompanyName, View.CompanyName),
                () =>
                    StringAssert.IsMatch(TestRegExpPatterns.SbsDebitorNo,
                        View.SbsDebitNumber),
                () => Assert.AreEqual(b.Adress.StreetNo, View.StreetNo),
                () => Assert.AreEqual(b.Adress.Po, View.Po),
                () => Assert.AreEqual(b.Adress.Zip, View.Zip),
                () => Assert.AreEqual(b.Adress.City, View.City),
                () => StringAssert.Contains(b.Adress.Region, View.Region),
                () => Assert.AreEqual(b.Adress.AdressAddition, View.AdressAddition),
                () => Assert.AreEqual(b.Contact.Language, View.Language),
                () => Assert.AreEqual(b.Adress.Country, View.Country),
                () => Assert.AreEqual(b.Contact.Email, View.Email),
                () => StringAssert.Contains(b.Contact.Telephone, View.Telephone),
                () => StringAssert.Contains(b.Contact.Mobile, View.Mobile),
                () => StringAssert.Contains(b.Contact.Fax, View.Fax),
                () => Assert.AreEqual(b.Contact.Web, View.Web)
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

        public static void Delete(BillingAddress billingAddress)
        {
            Open(billingAddress);

            Workflow.BillingAdress.Delete();

            Workflow.Search.Find(billingAddress.CompanyName);
            Assert.That(SearchResult.Result(Result.BillingAddress), Is.Not.Null);
            Assert.That(SearchResult.Result(Result.BillingAddress), Is.Empty);
        }

        private static void Open(BillingAddress billingAddress)
        {
            Search.BillingAddressCanBeFoundByName(billingAddress.CompanyName);
        }
    }
}