using NUnit.Framework;
using Six.Scs.Test.Workflow.Builder;
using Six.Test.Selenium;

namespace Six.Scs.Test.Builder.Location
{
    public class FromCustomer : LocationBuilder
    {
        public FromCustomer(CustomerBuilder customerBuilder)
        {
            Location = customerBuilder.Customer.Location;
        }

        protected override void SetData()
        {
            View.Location.Create.CopyFromCustomer.Click();
        }

        public override void Check()
        {
            // Assert.AreEqual(Location.CompanyName, View.Location.View.CompanyName); TODO : Refactor
            StringAssert.IsMatch(TestRegExpPatterns.SbsDebitorNo, View.Location.View.SbsDebitNumber);
            StringAssert.IsMatch(TestRegExpPatterns.Ep2MerchantId, View.Location.View.Ep2MerchantId);
            Assert.AreEqual(Location.Adress.StreetNo, View.Location.View.StreetNo);
            Assert.AreEqual(Location.Adress.Po, View.Location.View.Po);
            Assert.AreEqual(Location.Adress.Zip, View.Location.View.Zip);
            Assert.AreEqual(Location.Adress.City, View.Location.View.City);
            StringAssert.Contains(Location.Adress.Region, View.Location.View.Region);
            Assert.AreEqual(Location.Adress.AdressAddition, View.Location.View.AdressAddition);
            Assert.AreEqual(Location.Contact.Language, View.Location.View.Language);
            Assert.AreEqual(Location.Adress.Country, View.Location.View.Country);
            Assert.AreEqual(Location.Contact.Email, View.Location.View.Email);
            StringAssert.Contains(Location.Contact.Telephone, View.Location.View.Telephone);
            StringAssert.Contains(Location.Contact.Mobile, View.Location.View.Mobile);
            StringAssert.Contains(Location.Contact.Fax, View.Location.View.Fax);
            Assert.AreEqual(Location.Contact.Web, View.Location.View.Web);
            Assert.AreEqual(Location.Agency, View.Location.View.Agency);
        }

        protected override void EditData()
        {
            View.Location.Create.CopyFromCustomer.Click();
        }

        protected override void ReadInfo()
        {
            base.ReadInfo();
            Location.LocationNumber = View.Location.View.LocationNumber;
            Location.Ep2MerchantId = View.Location.View.Ep2MerchantId;
            Location.SbsDebitNumber = View.Location.View.SbsDebitNumber;
            // Customer.Location.SbsAdressNumber = CustomerView.SbsAdressNumber;
        }
    }
}