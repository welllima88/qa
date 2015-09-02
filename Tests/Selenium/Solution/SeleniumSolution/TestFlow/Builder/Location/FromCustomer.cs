using System;
using NUnit.Framework;
using Six.Scs.Test.Helper;
using Six.Scs.Test.UI.Location;
using Six.Scs.Test.Workflow.Builder;
using Six.Test.Selenium;

namespace Six.Scs.Test.Builder.Location
{
    public class FromCustomer : LocationBuilder
    {
        public FromCustomer(Model.Customer customer) : base(customer.Location)
        {
            Location.CompanyName = customer.CustomerName;
        }

        protected override void SetData()
        {
            UI.Location.Create.CopyFromCustomer.Click();
        }

        public override void Check()
        {
            Verify.With(new Action[]
            {
                () => Assert.AreEqual(Location.CompanyName, View.CompanyName),
                () => StringAssert.IsMatch(TestRegExpPatterns.SbsDebitorNo, View.SbsDebitNumber),
                () => StringAssert.IsMatch(TestRegExpPatterns.Ep2MerchantId, View.Ep2MerchantId),
                () => Assert.AreEqual(Location.Adress.StreetNo, View.StreetNo),
                () => Assert.AreEqual(Location.Adress.Po, View.Po),
                () => Assert.AreEqual(Location.Adress.Zip, View.Zip),
                () => Assert.AreEqual(Location.Adress.City, View.City),
                () => StringAssert.Contains(Location.Adress.Region, View.Region),
                () => Assert.AreEqual(Location.Adress.AdressAddition, View.AdressAddition),
                () => Assert.AreEqual(Location.Contact.Language, View.Language),
                () => Assert.AreEqual(Location.Adress.Country, View.Country),
                () => Assert.AreEqual(Location.Contact.Email, View.Email),
                () => Assert.That(UI.Customer.View.Telephone, Is.StringEnding(Location.Contact.Telephone)),
                () => Assert.That(UI.Customer.View.Mobile, Is.StringEnding(Location.Contact.Mobile)),
                () => Assert.That(UI.Customer.View.Fax, Is.StringEnding(Location.Contact.Fax)),
                () => Assert.AreEqual(Location.Contact.Web, View.Web),
                () => Assert.AreEqual(Location.Agency, View.Agency)
            }).Check();
        }

        protected override void EditData()
        {
            UI.Location.Create.CopyFromCustomer.Click();
        }

        protected override void ReadInfo()
        {
            base.ReadInfo();
            Location.LocationNumber = View.LocationNumber;
            Location.Ep2MerchantId = View.Ep2MerchantId;
            Location.SbsDebitNumber = View.SbsDebitNumber;
            // Customer.Location.SbsAdressNumber = CustomerView.SbsAdressNumber;
        }
    }
}