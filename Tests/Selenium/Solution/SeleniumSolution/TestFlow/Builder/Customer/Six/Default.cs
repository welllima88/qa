using System;
using NUnit.Framework;
using Six.Scs.Test.Helper;
using Six.Scs.Test.Workflow.Builder;

namespace Six.Scs.Test.Builder.Customer.Six
{
    public class Default : CustomerBuilder
    {
        protected override void SetCustomerData()
        {
            View.Customer.Create.SbsCurrency = Customer.SbsCurrency;
            View.Customer.Create.SbsBillingTenant = Customer.SbsBillingTenant;
            View.Customer.Create.SbsSegment = Customer.SbsSegment;
            View.Customer.Create.CustomerName = Customer.CustomerName;

            View.Customer.Create.StreetNo = Customer.Location.Adress.StreetNo;
            View.Customer.Create.Zip = Customer.Location.Adress.Zip;
            View.Customer.Create.City = Customer.Location.Adress.City;
            View.Customer.Create.Po = Customer.Location.Adress.Po;
            View.Customer.Create.AdressAddition = Customer.Location.Adress.AdressAddition;
            View.Customer.Create.Region = Customer.Location.Adress.Region;
            View.Customer.Create.Agency = Customer.Location.Agency;
            View.Customer.Create.Language = Customer.Location.Contact.Language;
            View.Customer.Create.Country = Customer.Location.Adress.Country;
            View.Customer.Create.Email = Customer.Location.Contact.Email;
            View.Customer.Create.Telephone = Customer.Location.Contact.Telephone;
            View.Customer.Create.Mobile = Customer.Location.Contact.Mobile;
            View.Customer.Create.Fax = Customer.Location.Contact.Fax;
            View.Customer.Create.Web = Customer.Location.Contact.Web;
            View.Customer.Create.CategoryCode = Customer.CategoryCode;
            View.Customer.Create.SupportContract = Customer.SupportContract;
            View.Customer.Create.CashIntegrator = Customer.CashIntegrator;
            View.Customer.Create.WesMandant = Customer.WesMandant;
        }

        public override void Check()
        {
            Assert.AreEqual(Customer.CustomerNumber, View.Customer.View.CustomerNumber);
            var checks = new Verifier(
                new Action[]
                {
                    () => Assert.AreEqual(Customer.CustomerName, View.Customer.View.CustomerName),
                    () => Assert.AreEqual(Customer.Supplier, View.Customer.View.Supplier),
                    () => Assert.AreEqual(Customer.SbsBillingTenant, View.Customer.View.SbsBillingTenant),
                    () => Assert.AreEqual(Customer.SbsCurrency, View.Customer.View.SbsCurrency),
                    () => Assert.AreEqual(Customer.Location.SbsDebitNumber, View.Customer.View.SbsDebitNumber),
                    () => Assert.AreEqual(Customer.Location.Adress.Po, View.Customer.View.Po),
                    () => Assert.AreEqual(Customer.Location.Adress.AdressAddition, View.Customer.View.AdressAddition),
                    () => StringAssert.Contains(Customer.Location.Adress.Region, View.Customer.View.Region),
                    () => Assert.AreEqual(Customer.Location.Adress.StreetNo, View.Customer.View.StreetNo),
                    () => Assert.AreEqual(Customer.Location.Adress.Zip, View.Customer.View.Zip),
                    () => Assert.AreEqual(Customer.Location.Adress.City, View.Customer.View.City),
                    () => StringAssert.Contains(Customer.Location.Agency, View.Customer.View.Agency),
                    () => Assert.AreEqual(Customer.Location.Contact.Language, View.Customer.View.Language),
                    () => Assert.AreEqual(Customer.Location.Adress.Country, View.Customer.View.Country),
                    () => Assert.AreEqual(Customer.Location.Contact.Email, View.Customer.View.Email),
                    () => StringAssert.Contains(Customer.Location.Contact.Telephone, View.Customer.View.Telephone),
                    () => StringAssert.Contains(Customer.Location.Contact.Mobile, View.Customer.View.Mobile),
                    () => StringAssert.Contains(Customer.Location.Contact.Fax, View.Customer.View.Fax),
                    () => Assert.AreEqual(Customer.Location.Contact.Web, View.Customer.View.Web)
                });
            checks.Check();
        }

        protected override void EditCustomerData()
        {
            View.Customer.Edit.CustomerName = Customer.CustomerName;
            View.Customer.Edit.StreetNo = Customer.Location.Adress.StreetNo;
            View.Customer.Edit.Zip = Customer.Location.Adress.Zip;
            View.Customer.Edit.City = Customer.Location.Adress.City;
            View.Customer.Edit.Po = Customer.Location.Adress.Po;
            View.Customer.Edit.AdressAddition = Customer.Location.Adress.AdressAddition;
            View.Customer.Edit.Region = Customer.Location.Adress.Region;
            View.Customer.Edit.Agency = Customer.Location.Agency;
            View.Customer.Edit.Language = Customer.Location.Contact.Language;
            View.Customer.Edit.Country = Customer.Location.Adress.Country;
            View.Customer.Edit.Email = Customer.Location.Contact.Email;
            View.Customer.Edit.Telephone = Customer.Location.Contact.Telephone;
            View.Customer.Edit.Mobile = Customer.Location.Contact.Mobile;
            View.Customer.Edit.Fax = Customer.Location.Contact.Fax;
            View.Customer.Edit.Web = Customer.Location.Contact.Web;
        }

        protected override void ReadInfo()
        {
            base.ReadInfo();
            Customer.SbsCurrency = View.Customer.View.SbsCurrency;
            Customer.SbsBillingTenant = View.Customer.View.SbsBillingTenant;
            Customer.Supplier = View.Customer.View.Supplier;
            Customer.Location.SbsDebitNumber = View.Customer.View.SbsDebitNumber;
            // Customer.Location.SbsAdressNumber = CustomerView.SbsAdressNumber;
        }
    }
}