using System;
using NUnit.Framework;
using Six.Scs.Test.Helper;
using Six.Scs.Test.UI.Customer;
using Six.Scs.Test.Workflow.Builder;

namespace Six.Scs.Test.Builder.Customer.Six
{
    public class Default : CustomerBuilder
    {
        public Default(Model.Customer customer) : base(customer)
        {
        }

        protected override void SetCustomerData()
        {
            UI.Customer.Create.SbsCurrency = Customer.SbsCurrency;
            UI.Customer.Create.SbsBillingTenant = Customer.SbsBillingTenant;
            UI.Customer.Create.SbsSegment = Customer.SbsSegment;
            UI.Customer.Create.CustomerName = Customer.CustomerName;

            UI.Customer.Create.StreetNo = Customer.Location.Adress.StreetNo;
            UI.Customer.Create.Zip = Customer.Location.Adress.Zip;
            UI.Customer.Create.City = Customer.Location.Adress.City;
            UI.Customer.Create.Po = Customer.Location.Adress.Po;
            UI.Customer.Create.AdressAddition = Customer.Location.Adress.AdressAddition;
            UI.Customer.Create.Region = Customer.Location.Adress.Region;
            UI.Customer.Create.Agency = Customer.Location.Agency;
            UI.Customer.Create.Language = Customer.Location.Contact.Language;
            UI.Customer.Create.Country = Customer.Location.Adress.Country;
            UI.Customer.Create.Email = Customer.Location.Contact.Email;
            UI.Customer.Create.Telephone = Customer.Location.Contact.Telephone;
            UI.Customer.Create.Mobile = Customer.Location.Contact.Mobile;
            UI.Customer.Create.Fax = Customer.Location.Contact.Fax;
            UI.Customer.Create.Web = Customer.Location.Contact.Web;
            UI.Customer.Create.CategoryCode = Customer.CategoryCode;
            UI.Customer.Create.SupportContract = Customer.SupportContract;
            UI.Customer.Create.CashIntegrator = Customer.CashIntegrator;
            UI.Customer.Create.WesMandant = Customer.WesMandant;
        }

        public override void Check()
        {
            Assert.AreEqual(Customer.CustomerNumber, View.CustomerNumber);
            Verify.With(
                new Action[]
                {
                    () => Assert.AreEqual(Customer.CustomerName, View.CustomerName),
                    () => Assert.AreEqual(Customer.Supplier, View.Supplier),
                    () => Assert.AreEqual(Customer.SbsBillingTenant, View.SbsBillingTenant),
                    () => Assert.AreEqual(Customer.SbsCurrency, View.SbsCurrency),
                    () => Assert.AreEqual(Customer.SbsSegment, View.Segment),
                    () => Assert.AreEqual(Customer.Location.SbsDebitNumber, View.SbsDebitNumber),
                    () => Assert.AreEqual(Customer.Location.Adress.Po, View.Po),
                    () => Assert.AreEqual(Customer.Location.Adress.AdressAddition, View.AdressAddition),
                    () => StringAssert.Contains(Customer.Location.Adress.Region, View.Region),
                    () => Assert.AreEqual(Customer.Location.Adress.StreetNo, View.StreetNo),
                    () => Assert.AreEqual(Customer.Location.Adress.Zip, View.Zip),
                    () => Assert.AreEqual(Customer.Location.Adress.City, View.City),
                    () => StringAssert.Contains(Customer.Location.Agency, View.Agency),
                    () => Assert.AreEqual(Customer.Location.Contact.Language, View.Language),
                    () => Assert.AreEqual(Customer.Location.Adress.Country, View.Country),
                    () => Assert.AreEqual(Customer.Location.Contact.Email, View.Email),
                    () => Assert.That(View.Telephone, Is.StringEnding(Customer.Location.Contact.Telephone)),
                    () => Assert.That(View.Mobile, Is.StringEnding(Customer.Location.Contact.Mobile)),
                    () => Assert.That(View.Fax, Is.StringEnding(Customer.Location.Contact.Fax)),
                    () => Assert.AreEqual(Customer.Location.Contact.Web, View.Web)
                }).Check();
        }

        protected override void EditCustomerData()
        {
            UI.Customer.Edit.CustomerName = Customer.CustomerName;
            UI.Customer.Edit.StreetNo = Customer.Location.Adress.StreetNo;
            UI.Customer.Edit.Zip = Customer.Location.Adress.Zip;
            UI.Customer.Edit.City = Customer.Location.Adress.City;
            UI.Customer.Edit.Po = Customer.Location.Adress.Po;
            UI.Customer.Edit.AdressAddition = Customer.Location.Adress.AdressAddition;
            UI.Customer.Edit.Region = Customer.Location.Adress.Region;
            UI.Customer.Edit.Agency = Customer.Location.Agency;
            UI.Customer.Edit.Language = Customer.Location.Contact.Language;
            UI.Customer.Edit.Country = Customer.Location.Adress.Country;
            UI.Customer.Edit.Email = Customer.Location.Contact.Email;
            UI.Customer.Edit.Telephone = Customer.Location.Contact.Telephone;
            UI.Customer.Edit.Mobile = Customer.Location.Contact.Mobile;
            UI.Customer.Edit.Fax = Customer.Location.Contact.Fax;
            UI.Customer.Edit.Web = Customer.Location.Contact.Web;
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