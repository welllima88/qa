using NUnit.Framework;
using Six.Scs.Test.Model.Factory;
using Six.Scs.Test.Workflow.Builder;

namespace Six.Scs.Test.Builder.Customer.Nsp
{
    public class SixNsp : CustomerBuilder
    {
        public SixNsp(Model.Customer customer) : base(customer)
        {
        }

        public override void Create()
        {
            Customer.CustomerName = "SYR AUTO NSP" + Factory.GenerateTestId();
            Customer.Supplier = "SIX Payment Services (NSP)";

            ClickCreate();
            SelectTenant();
            Confirm();
            SetCustomerData();
            CreateButton();
            ReadInfo();
        }

        protected override void SetCustomerData()
        {
            View.Customer.Create.CustomerName = Customer.CustomerName;
            View.Customer.Create.StreetNo = Customer.Location.Adress.StreetNo;
            View.Customer.Create.Zip = Customer.Location.Adress.Zip;
            View.Customer.Create.City = Customer.Location.Adress.City;
            View.Customer.Create.Po = Customer.Location.Adress.Po;
            View.Customer.Create.AdressAddition = Customer.Location.Adress.AdressAddition;
            View.Customer.Create.Region = Customer.Location.Adress.Region;
            View.Customer.Create.Language = Customer.Location.Contact.Language;
            View.Customer.Create.Country = Customer.Location.Adress.Country;
            View.Customer.Create.Email = Customer.Location.Contact.Email;
            View.Customer.Create.Telephone = Customer.Location.Contact.Telephone;
            View.Customer.Create.Mobile = Customer.Location.Contact.Mobile;
            View.Customer.Create.Fax = Customer.Location.Contact.Fax;
            View.Customer.Create.Web = Customer.Location.Contact.Web;
        }

        public override void Check()
        {
            Assert.AreEqual(Customer.CustomerNumber, View.Customer.View.CustomerNumber);
            Assert.AreEqual(Customer.CustomerName, View.Customer.View.CustomerName);
            Assert.AreEqual(Customer.Supplier, View.Customer.View.Supplier);

            Assert.AreEqual(Customer.Location.Adress.Po, View.Customer.View.Po);
            Assert.AreEqual(Customer.Location.Adress.AdressAddition, View.Customer.View.AdressAddition);
            StringAssert.Contains(Customer.Location.Adress.Region, View.Customer.View.Region);
            Assert.AreEqual(Customer.Location.Adress.StreetNo, View.Customer.View.StreetNo);
            Assert.AreEqual(Customer.Location.Adress.Zip, View.Customer.View.Zip);
            Assert.AreEqual(Customer.Location.Adress.City, View.Customer.View.City);
            Assert.AreEqual(Customer.Location.Contact.Language, View.Customer.View.Language);
            Assert.AreEqual(Customer.Location.Adress.Country, View.Customer.View.Country);
            Assert.AreEqual(Customer.Location.Contact.Email, View.Customer.View.Email);
            StringAssert.Contains(Customer.Location.Contact.Telephone, View.Customer.View.Telephone);
            StringAssert.Contains(Customer.Location.Contact.Mobile, View.Customer.View.Mobile);
            StringAssert.Contains(Customer.Location.Contact.Fax, View.Customer.View.Fax);
            Assert.AreEqual(Customer.Location.Contact.Web, View.Customer.View.Web);
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
            View.Customer.Edit.Language = Customer.Location.Contact.Language;
            View.Customer.Edit.Country = Customer.Location.Adress.Country;
            View.Customer.Edit.Email = Customer.Location.Contact.Email;
            View.Customer.Edit.Telephone = Customer.Location.Contact.Telephone;
            View.Customer.Edit.Mobile = Customer.Location.Contact.Mobile;
            View.Customer.Edit.Fax = Customer.Location.Contact.Fax;
            View.Customer.Edit.Web = Customer.Location.Contact.Web;
        }
    }
}