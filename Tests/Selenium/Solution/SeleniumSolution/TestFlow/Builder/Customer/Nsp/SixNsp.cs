using NUnit.Framework;
using Six.Scs.QA.Application.Model.Factory;
using Six.Scs.QA.Application.View.Customer;
using Six.Scs.QA.Application.Workflow.Builder;

namespace Six.Scs.QA.Testlogic.Builder.Customer.Nsp
{
    public class SixNsp : CustomerBuilder
    {
        public override void Create()
        {
            Customer = Application.Model.Factory.Customer.Create();
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
            Application.View.Customer.Create.CustomerName = Customer.CustomerName;
            Application.View.Customer.Create.StreetNo = Customer.Location.Adress.StreetNo;
            Application.View.Customer.Create.Zip = Customer.Location.Adress.Zip;
            Application.View.Customer.Create.City = Customer.Location.Adress.City;
            Application.View.Customer.Create.Po = Customer.Location.Adress.Po;
            Application.View.Customer.Create.AdressAddition = Customer.Location.Adress.AdressAddition;
            Application.View.Customer.Create.Region = Customer.Location.Adress.Region;
            Application.View.Customer.Create.Language = Customer.Location.Contact.Language;
            Application.View.Customer.Create.Country = Customer.Location.Adress.Country;
            Application.View.Customer.Create.Email = Customer.Location.Contact.Email;
            Application.View.Customer.Create.Telephone = Customer.Location.Contact.Telephone;
            Application.View.Customer.Create.Mobile = Customer.Location.Contact.Mobile;
            Application.View.Customer.Create.Fax = Customer.Location.Contact.Fax;
            Application.View.Customer.Create.Web = Customer.Location.Contact.Web;
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
            Application.View.Customer.Edit.CustomerName = Customer.CustomerName;
            Application.View.Customer.Edit.StreetNo = Customer.Location.Adress.StreetNo;
            Application.View.Customer.Edit.Zip = Customer.Location.Adress.Zip;
            Application.View.Customer.Edit.City = Customer.Location.Adress.City;
            Application.View.Customer.Edit.Po = Customer.Location.Adress.Po;
            Application.View.Customer.Edit.AdressAddition = Customer.Location.Adress.AdressAddition;
            Application.View.Customer.Edit.Region = Customer.Location.Adress.Region;
            Application.View.Customer.Edit.Language = Customer.Location.Contact.Language;
            Application.View.Customer.Edit.Country = Customer.Location.Adress.Country;
            Application.View.Customer.Edit.Email = Customer.Location.Contact.Email;
            Application.View.Customer.Edit.Telephone = Customer.Location.Contact.Telephone;
            Application.View.Customer.Edit.Mobile = Customer.Location.Contact.Mobile;
            Application.View.Customer.Edit.Fax = Customer.Location.Contact.Fax;
            Application.View.Customer.Edit.Web = Customer.Location.Contact.Web;
        }
    }
}