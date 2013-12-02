using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.Selenium;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Customer;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Customer.Create
{
    [TestClass]
    public class CetrelCustomerCreateTest
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate();
        }

        [TestMethod]
        public void CreateCustomerAndSave()
        {
            CustomerMenu.CustomerCreate.Click();

            string supplier = "CETREL S.A.";
            CustomerCreate.Supplier = supplier;
            string categoryCode = "3663: HOTELES EL PRESIDENTE";
            CustomerCreate.CategoryCode = categoryCode;
            string supportContract = "SPA Servicepaket Advance";
            CustomerCreate.SupportContract = supportContract;
            string customerSegment = "07_P_CETREL";
            CustomerCreate.Segment = customerSegment;
            string customerName = "SYR Cetrel Kunde Create";
            CustomerCreate.CustomerName = customerName;
            string companyName = "SYR Cetrel Firma Create";
            CustomerCreate.CompanyName = companyName;
            string StreetNo = "Luxemburgerli 1a";
            CustomerCreate.StreetNo = StreetNo;
            string zip = "11247";
            CustomerCreate.Zip = zip;
            string city = "Luxemburg";
            CustomerCreate.City = city;
            string po = "LUX1";
            CustomerCreate.Po = po;
            string adressAddition = "ZusatzLUX";
            CustomerCreate.AdressAddition = adressAddition;
            string region = "WestLUX";
            CustomerCreate.Region = region;
            string sapNumber = "9129";
            CustomerCreate.SapNumber = sapNumber;

            string agency = "SIX LUX";
            CustomerCreate.Agency = agency;
            string language = "Französisch [fr]";
            CustomerCreate.Language = language;
            string country = "Luxemburg [LU]";
            CustomerCreate.Country = country;
            string email = "marc.siegmund@six-group.com/lux";
            CustomerCreate.Email = email;
            string telephone = "+61 58 399 6237";
            CustomerCreate.Telephone = telephone;
            string mobile = "+62 58 399 6237";
            CustomerCreate.Mobile = mobile;
            string fax = "+63 58 399 6237";
            CustomerCreate.Fax = fax;
            string web = "www.six-group.com/cetrel";
            CustomerCreate.Web = web;

            CustomerCreate.SaveButton.Click();

            Assert.AreEqual(customerName, CustomerView.CustomerName);
            string custId = CustomerView.CustomerNumber;

            NavigationBar.Lobby.Click();
            RecentElements.MostRecent.Click();

            Assert.AreEqual(custId, CustomerView.CustomerNumber);
            Assert.AreEqual(customerName, CustomerView.CustomerName);
            Assert.AreEqual(supplier, CustomerView.Supplier);
            Assert.AreEqual(sapNumber, CustomerView.SapNumber);
            Assert.AreEqual(categoryCode, CustomerView.CategoryCode);
            Assert.AreEqual(supportContract,
                            CustomerView.SupportContract);

            StringAssert.Matches(CustomerView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);

            Assert.AreEqual(companyName, CustomerView.CompanyName);
            Assert.AreEqual(po, CustomerView.Po);
            Assert.AreEqual(adressAddition, CustomerView.AdressAddition);
            Assert.AreEqual(region, CustomerView.Region);
            Assert.AreEqual(StreetNo, CustomerView.StreetNo);
            Assert.AreEqual(zip, CustomerView.Zip);
            Assert.AreEqual(city, CustomerView.City);
            Assert.AreEqual(agency, CustomerView.Agency);
            Assert.AreEqual(language, CustomerView.Language);
            Assert.AreEqual(country, CustomerView.Country);
            Assert.AreEqual(email, CustomerView.Email);
            Assert.AreEqual(telephone, CustomerView.Telephone);
            Assert.AreEqual(mobile, CustomerView.Mobile);
            Assert.AreEqual(fax, CustomerView.Fax);
            Assert.AreEqual(web, CustomerView.Web);
        }
    }
}