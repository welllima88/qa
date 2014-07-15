using System.Collections.Generic;
using NUnit.Framework;
using Six.Scs.QA.TestData.ValueObjects;
using Six.Scs.QA.Testlogic;

namespace Six.Scs.QA.Selenium.SystemTest
{
    [TestFixture]
    public class RegressionTest
    {
        private static TerminalData _terminalLocation;
        private static TerminalData _terminalCustomer;
        private static CustomerData _customer;
        private static LocationData _location;
        private static ContactPersonData _personOnCustomer;
        private static ContactPersonData _personOnLocation;
        private static UserData _user;
        private static List<string> _duplicatedTerminals;

        /* [TestFixtureTearDown]
        public static void CleanRegressionTest()
        {
            DeleteCustomer();
            DeleteLocation();
            DeletePersons();
            DeleteTerminals();            
            DeleteMpd();            
            DeleteUser();            
        }

        [TestFixtureSetUp]
        public static void PrepareRegressionTest()
        {            
        }
         
        [Test]
        [Ignore]
        [Category("Regression")]
        public void BrandsOnTerminalAreCreated()
        {
            Terminal.Open(_terminalLocation);
            StringAssert.Contains("[283]", BrandPortlet.Brand("283").Text);
            StringAssert.Contains("[332]", BrandPortlet.Brand("332").Text);
            StringAssert.Contains("[361]", BrandPortlet.Brand("361").Text);
            StringAssert.Contains("[363]", BrandPortlet.Brand("363").Text);
            StringAssert.Contains("[811]", BrandPortlet.Brand("811").Text);
        }
        */

        [Test]
        public static void ExecuteRegressiontest()
        {
            _customer = Testlogic.Customer.Create();
            _location = Testlogic.Location.Create(_customer);
            _personOnCustomer = Contact.Create(_customer);
            _terminalCustomer = Testlogic.Terminal.Create(_customer);

            _customer = Testlogic.Customer.Edit(_customer);
            Infotext.Create(_customer);
            Testlogic.Mpd.Create(_customer);

            Brands.Create(_terminalCustomer);

            _terminalLocation = Testlogic.Terminal.Create(_location);
            Infotext.Create(_location);

            _location = Testlogic.Location.Edit(_location);
            Infotext.Create(_terminalLocation);

            _personOnLocation = Contact.Create(_location);
            _personOnLocation = Contact.Edit(_personOnLocation);

            _user = Testlogic.User.Create(_customer);
            _user = Testlogic.User.Edit(_user);

            _duplicatedTerminals = Testlogic.Terminal.Duplicate(_terminalLocation);

            Brands.Create(_duplicatedTerminals[1]);
        }
    }
}