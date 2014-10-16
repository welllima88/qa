using System.Collections.Generic;
using NUnit.Framework;
using Six.Scs.QA.Testlogic;
using Contact = Six.Scs.QA.Testlogic.Contact;
using SimCard = Six.Scs.QA.TestData.ValueObjects.SimCard;

namespace Six.Scs.QA.Selenium.SystemTest
{
    [TestFixture]
    public class RegressionTest
    {
        private static TestData.ValueObjects.Terminal _terminalLocation;
        private static TestData.ValueObjects.Terminal _terminalCustomer;
        private static TestData.ValueObjects.Customer _customer;
        private static TestData.ValueObjects.Location _location1;
        private static TestData.ValueObjects.Person _personOnCustomer;
        private static TestData.ValueObjects.Person _personOnLocation;
        private static TestData.ValueObjects.User _user;
        private static List<TestData.ValueObjects.Terminal> _duplicatedTerminals;
        private static TestData.ValueObjects.Mpd _mpd;
        private static SimCard _sim;
        private static TestData.ValueObjects.Location _location2;

        [Test]
        [Category("Regression"), Category("Customer"), Category("Location"), Category("Terminal"),
         Category("Terminal Duplicate"), Category("Terminal Quit"), Category("Infotext"), Category("Person"),
         Category("MPD"), Category("User"), Category("User from Contact"), Category("SIM Card")]
        public static void ExecuteRegressiontest()
        {
            _customer = Testlogic.Customer.Create();
            _location1 = Testlogic.Location.Create(_customer);
            _personOnCustomer = Contact.Create(_customer);
            _terminalCustomer = Testlogic.Terminal.Create(_customer);

            _customer = Testlogic.Customer.Edit(_customer);

            Brands.Create(_terminalCustomer);

            Infotext.Create(_customer);

            _mpd = Testlogic.Mpd.Create(_customer);
            Testlogic.Terminal.Assign(_mpd, _terminalCustomer);

            _terminalLocation = Testlogic.Terminal.Create(_location1);
            // TroubleTicket.Create(_terminalLocation);
            Infotext.Create(_location1);

            _location1 = Testlogic.Location.Edit(_location1);
            Infotext.Create(_terminalLocation);

            _personOnLocation = Contact.Create(_location1);

            Testlogic.Mpd.Edit(_mpd);

            // Testlogic.Terminal.ArticleChange(_terminalCustomer);
            Testlogic.Terminal.Quit(_terminalCustomer);
            _personOnLocation = Contact.Edit(_personOnLocation);
            Contact.Delete(_personOnCustomer);

            _user = Testlogic.User.Create(_customer);
            _user = Testlogic.User.Edit(_user);

            _duplicatedTerminals = Testlogic.Terminal.Duplicate(_terminalLocation);
            Testlogic.User.Create(_personOnLocation);

            Testlogic.User.AddService(_user);

            Brands.Create(_duplicatedTerminals[1]); // {0,1,..} means create brands on second terminal

            Testlogic.Terminal.Replace(_terminalLocation);
            _location2 = Testlogic.Location.Create(_customer);
            Testlogic.Terminal.Move(_terminalLocation, _location2);

            _sim = Testlogic.SimCard.Create();

            _sim = Testlogic.SimCard.Edit(_sim);
            _sim = Testlogic.SimCard.Link(_sim, _duplicatedTerminals[0]);

            Testlogic.SimCard.Lock(_sim);
            Testlogic.SimCard.Unlink(_sim);
        }
    }
}