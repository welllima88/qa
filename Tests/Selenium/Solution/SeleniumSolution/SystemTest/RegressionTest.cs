using System.Collections.Generic;
using NUnit.Framework;
using Six.Scs.QA.Testlogic;

namespace Six.Scs.QA.Selenium.SystemTest
{
    [TestFixture]
    public class RegressionTest
    {
        private static TestData.ValueObjects.Terminal _terminalLocation;
        private static TestData.ValueObjects.Terminal _terminalCustomer;
        private static TestData.ValueObjects.Customer _customer;
        private static TestData.ValueObjects.Location _location;
        private static TestData.ValueObjects.Person _personOnCustomer;
        private static TestData.ValueObjects.Person _personOnLocation;
        private static TestData.ValueObjects.User _user;
        private static List<string> _duplicatedTerminals;
        private static TestData.ValueObjects.Mpd _mpd;

        [Test]
        public static void ExecuteRegressiontest()
        {
            _customer = Testlogic.Customer.Create();
            _location = Testlogic.Location.Create(_customer);
            _personOnCustomer = Contact.Create(_customer);
            _terminalCustomer = Testlogic.Terminal.Create(_customer);

            _customer = Testlogic.Customer.Edit(_customer);
            Infotext.Create(_customer);
            _mpd = Testlogic.Mpd.Create(_customer);

            Brands.Create(_terminalCustomer);

            _terminalLocation = Testlogic.Terminal.Create(_location);
            Infotext.Create(_location);

            _location = Testlogic.Location.Edit(_location);
            Infotext.Create(_terminalLocation);

            _personOnLocation = Contact.Create(_location);
            _personOnLocation = Contact.Edit(_personOnLocation);

            Testlogic.Mpd.Edit(_mpd);

            _user = Testlogic.User.Create(_customer);
            _user = Testlogic.User.Edit(_user);

            _duplicatedTerminals = Testlogic.Terminal.Duplicate(_terminalLocation);

            Brands.Create(_duplicatedTerminals[1]);
        }
    }
}