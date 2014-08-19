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
        private static TestData.ValueObjects.SimCard _sim;

        [Test]
        [Category("Regression"), Category("Customer"), Category("Location"), Category("Terminal Duplicate"),
         Category("Terminal Quit"), Category("Infotext"), Category("Person"), Category("MPD"), Category("User"),
         Category("User from Contact"), Category("SIM Card")]
        public static void ExecuteRegressiontest()
        {
            _customer = Testlogic.Customer.Create();
            _location = Testlogic.Location.Create(_customer);
            _personOnCustomer = Contact.Create(_customer);
            _terminalCustomer = Testlogic.Terminal.Create(_customer);

            _customer = Testlogic.Customer.Edit(_customer);
            Infotext.Create(_customer);
            _mpd = Testlogic.Mpd.Create(_customer);

            // Brands.Create(_terminalCustomer);

            _terminalLocation = Testlogic.Terminal.Create(_location);
            Infotext.Create(_location);

            _location = Testlogic.Location.Edit(_location);
            Infotext.Create(_terminalLocation);

            _personOnLocation = Contact.Create(_location);

            Testlogic.Mpd.Edit(_mpd);

            Testlogic.Terminal.Quit(_terminalCustomer);
            _personOnLocation = Contact.Edit(_personOnLocation);

            _user = Testlogic.User.Create(_customer);
            _user = Testlogic.User.Edit(_user);

            _duplicatedTerminals = Testlogic.Terminal.Duplicate(_terminalLocation);
            Testlogic.User.Create(_personOnLocation);
            Contact.Delete(_personOnLocation);
            
            Testlogic.User.AddService(_user);

            // Brands.Create(_duplicatedTerminals[1]); // {0,1,..} means create brands on second terminal

            _sim = Testlogic.SimCard.Create();
            SimCard.Edit(_sim);
        }
    }
}