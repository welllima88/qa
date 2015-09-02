using NUnit.Framework;
using Six.Scs.Test.UI.Customer;
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
            Customer.CustomerName = "SYR AUTO NSP" + Factory.Base.GenerateTestId();
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
            UI.Customer.Create.CustomerName = Customer.CustomerName;
            UI.Customer.Create.StreetNo = Customer.Location.Adress.StreetNo;
            UI.Customer.Create.Zip = Customer.Location.Adress.Zip;
            UI.Customer.Create.City = Customer.Location.Adress.City;
            UI.Customer.Create.Po = Customer.Location.Adress.Po;
            UI.Customer.Create.AdressAddition = Customer.Location.Adress.AdressAddition;
            UI.Customer.Create.Region = Customer.Location.Adress.Region;
            UI.Customer.Create.Language = Customer.Location.Contact.Language;
            UI.Customer.Create.Country = Customer.Location.Adress.Country;
            UI.Customer.Create.Email = Customer.Location.Contact.Email;
            UI.Customer.Create.Telephone = Customer.Location.Contact.Telephone;
            UI.Customer.Create.Mobile = Customer.Location.Contact.Mobile;
            UI.Customer.Create.Fax = Customer.Location.Contact.Fax;
            UI.Customer.Create.Web = Customer.Location.Contact.Web;
        }

        public override void Check()
        {
            Assert.AreEqual(Customer.CustomerNumber, View.CustomerNumber);
            Assert.AreEqual(Customer.CustomerName, View.CustomerName);
            Assert.AreEqual(Customer.Supplier, View.Supplier);

            Assert.AreEqual(Customer.Location.Adress.Po, View.Po);
            Assert.AreEqual(Customer.Location.Adress.AdressAddition, View.AdressAddition);
            StringAssert.Contains(Customer.Location.Adress.Region, View.Region);
            Assert.AreEqual(Customer.Location.Adress.StreetNo, View.StreetNo);
            Assert.AreEqual(Customer.Location.Adress.Zip, View.Zip);
            Assert.AreEqual(Customer.Location.Adress.City, View.City);
            Assert.AreEqual(Customer.Location.Contact.Language, View.Language);
            Assert.AreEqual(Customer.Location.Adress.Country, View.Country);
            Assert.AreEqual(Customer.Location.Contact.Email, View.Email);
            StringAssert.Contains(Customer.Location.Contact.Telephone, View.Telephone);
            StringAssert.Contains(Customer.Location.Contact.Mobile, View.Mobile);
            StringAssert.Contains(Customer.Location.Contact.Fax, View.Fax);
            Assert.AreEqual(Customer.Location.Contact.Web, View.Web);
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
            UI.Customer.Edit.Language = Customer.Location.Contact.Language;
            UI.Customer.Edit.Country = Customer.Location.Adress.Country;
            UI.Customer.Edit.Email = Customer.Location.Contact.Email;
            UI.Customer.Edit.Telephone = Customer.Location.Contact.Telephone;
            UI.Customer.Edit.Mobile = Customer.Location.Contact.Mobile;
            UI.Customer.Edit.Fax = Customer.Location.Contact.Fax;
            UI.Customer.Edit.Web = Customer.Location.Contact.Web;
        }
    }
}