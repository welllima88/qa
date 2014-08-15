using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Customer;
using Six.Scs.QA.Selenium.Extension;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Customer.Create
{
    [TestClass]
    public class Cetrel
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
            Selenium.Customer.Create.Supplier = supplier;
            string categoryCode = "3663: HOTELES EL PRESIDENTE";
            Selenium.Customer.Create.CategoryCode = categoryCode;
            string supportContract = "SPA Servicepaket Advance";
            Selenium.Customer.Create.SupportContract = supportContract;
            string customerSegment = "07_P_CETREL";
            Selenium.Customer.Create.Segment = customerSegment;
            string customerName = "SYR Cetrel Kunde Create";
            Selenium.Customer.Create.CustomerName = customerName;
            string companyName = "SYR Cetrel Firma Create";
            Selenium.Customer.Create.CompanyName = companyName;
            string StreetNo = "Luxemburgerli 1a";
            Selenium.Customer.Create.StreetNo = StreetNo;
            string zip = "11247";
            Selenium.Customer.Create.Zip = zip;
            string city = "Luxemburg";
            Selenium.Customer.Create.City = city;
            string po = "LUX1";
            Selenium.Customer.Create.Po = po;
            string adressAddition = "ZusatzLUX";
            Selenium.Customer.Create.AdressAddition = adressAddition;
            string region = "WestLUX";
            Selenium.Customer.Create.Region = region;
            string sapNumber = "9129";
            Selenium.Customer.Create.SapNumber = sapNumber;

            string agency = "SIX LUX";
            Selenium.Customer.Create.Agency = agency;
            string language = "Französisch [fr]";
            Selenium.Customer.Create.Language = language;
            string country = "Luxemburg [LU]";
            Selenium.Customer.Create.Country = country;
            string email = "marc.siegmund@six-group.com/lux";
            Selenium.Customer.Create.Email = email;
            string telephone = "+61 58 399 6237";
            Selenium.Customer.Create.Telephone = telephone;
            string mobile = "+62 58 399 6237";
            Selenium.Customer.Create.Mobile = mobile;
            string fax = "+63 58 399 6237";
            Selenium.Customer.Create.Fax = fax;
            string web = "www.six-group.com/cetrel";
            Selenium.Customer.Create.Web = web;

            Selenium.Customer.Create.SaveButton.Click();

            Assert.AreEqual(customerName, View.CustomerName);
            string custId = View.CustomerNumber;

            NavigationBar.Lobby.Click();
            RecentElements.Latest.Click();

            Assert.AreEqual(custId, View.CustomerNumber);
            Assert.AreEqual(customerName, View.CustomerName);
            Assert.AreEqual(supplier, View.Supplier);
            Assert.AreEqual(sapNumber, View.SapNumber);
            Assert.AreEqual(categoryCode, View.CategoryCode);
            Assert.AreEqual(supportContract,
                View.SupportContract);

            StringAssert.Matches(View.Ep2MerchantId, new Regex(TestRegExpPatterns.Ep2MerchantId));

            Assert.AreEqual(companyName, View.CompanyName);
            Assert.AreEqual(po, View.Po);
            Assert.AreEqual(adressAddition, View.AdressAddition);
            Assert.AreEqual(region, View.Region);
            Assert.AreEqual(StreetNo, View.StreetNo);
            Assert.AreEqual(zip, View.Zip);
            Assert.AreEqual(city, View.City);
            Assert.AreEqual(agency, View.Agency);
            Assert.AreEqual(language, View.Language);
            Assert.AreEqual(country, View.Country);
            Assert.AreEqual(email, View.Email);
            Assert.AreEqual(telephone, View.Telephone);
            Assert.AreEqual(mobile, View.Mobile);
            Assert.AreEqual(fax, View.Fax);
            Assert.AreEqual(web, View.Web);
        }
    }
}