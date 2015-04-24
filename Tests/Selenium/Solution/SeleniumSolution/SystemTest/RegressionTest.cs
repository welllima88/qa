using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Model.ValueObjects;
using Six.Scs.QA.Selenium.Workflow.Builder;
using Six.Scs.QA.Testlogic;
using Six.Scs.QA.Testlogic.Builder.Brand.Ep2;
using Six.Scs.QA.Testlogic.Builder.Terminal.Ep2;
using Contact = Six.Scs.QA.Testlogic.Contact;
using Customer = Six.Scs.QA.Testlogic.Customer;
using Default = Six.Scs.QA.Testlogic.Builder.Customer.Six.Default;
using Location = Six.Scs.QA.Selenium.Model.ValueObjects.Location;
using Mpd = Six.Scs.QA.Selenium.Model.ValueObjects.Mpd;
using SimCard = Six.Scs.QA.Selenium.Model.ValueObjects.SimCard;
using Terminal = Six.Scs.QA.Selenium.Model.ValueObjects.Terminal;
using User = Six.Scs.QA.Selenium.Model.ValueObjects.User;

namespace Six.Scs.QA.Selenium.SystemTest
{
    [TestFixture]
    public class RegressionTest
    {
        private static Terminal _terminalLocation2;
        private static Terminal _terminalLocation1;
        private static CustomerBuilder _six;
        private static Location _location1;
        private static Person _personOnCustomer;
        private static Person _personOnLocation;
        private static User _user;
        private static IEnumerable<Terminal> _duplicatedTerminals;
        private static Mpd _mpd;
        private static SimCard _sim;
        private static Location _location2;
        private static TroubleTicket _troubleTicket;

        [TestFixtureSetUp]
        public void Home()
        {
            TestDirector.Navigate();
        }

        [Test]
        [Category("Regression"), Category("Customer"), Category("Location"), Category("BillingAddress"),
         Category("Terminal"),Category("Search"),
         Category("Terminal Duplicate"), Category("Terminal Quit"), Category("Infotext"), Category("Person"),
         Category("MPD"), Category("User"), Category("User"), Category("User from Contact"), Category("SIM Card")]
        public static void ExecuteRegressiontest()
        {
            _six = Customer.Create(new Default());
            _location1 = Testlogic.Location.Create(_six.Customer, new Testlogic.Builder.Location.Default()).Location;
            _personOnCustomer = Contact.Create(_six.Customer);
            var contracts = new Testlogic.Builder.Brand.Ep2.Default();
            _terminalLocation1 = Testlogic.Terminal.Create(_location1, new Yomani().With(contracts));

            Customer.Edit(_six);

            Infotext.Create(_six.Customer);
            BillingAdress.Create(_six.Customer);

            _mpd = Testlogic.Mpd.Create(_six.Customer);
            Testlogic.Terminal.Assign(_mpd, _terminalLocation1);

            _terminalLocation2 = Testlogic.Terminal.Create(_location1, new Xentissimo());
            _location2 = Testlogic.Location.Create(_six.Customer, new Testlogic.Builder.Location.Default()).Location;
            Testlogic.Terminal.Move(_terminalLocation2, _location2);

            Brands.Create(_terminalLocation2, new Testlogic.Builder.Brand.Ep2.Default());
            Infotext.Create(_location1);

            _location1 = Testlogic.Location.Edit(_location1, new Testlogic.Builder.Location.Default()).Location;
            Infotext.Create(_terminalLocation2);

            _personOnLocation = Contact.Create(_location1);

            Testlogic.Mpd.Edit(_mpd);

            Testlogic.Terminal.ArticleChange(_terminalLocation1, new Yoximo());
            Testlogic.Terminal.Quit(_terminalLocation1);
            _personOnLocation = Contact.Edit(_personOnLocation);
            Contact.Delete(_personOnCustomer);

            _user = Testlogic.User.Create(_six.Customer);
            _user = Testlogic.User.Edit(_user);

            _duplicatedTerminals = Testlogic.Terminal.Duplicate(_terminalLocation2);
            Testlogic.User.Create(_personOnLocation);

            Testlogic.User.AddService(_user);
            // Testlogic.User.AssignRoles(_user);

            Brands.Create(_duplicatedTerminals.ElementAt(1), new Additional());
            // {0,1,..} means create brands on second terminal
            // check again already existing contracts:
            contracts.Check();
            
            Testlogic.User.Delete(_user);

            Testlogic.Terminal.Replace(_terminalLocation2);

            _troubleTicket = Testlogic.Tickets.TroubleTicket.Create(_duplicatedTerminals.ElementAt(1));
            Testlogic.Tickets.TroubleTicket.Edit(_troubleTicket);

            Testlogic.Terminal.Retour(_duplicatedTerminals.ElementAt(1));

            _sim = Testlogic.SimCard.Create();

            _sim = Testlogic.SimCard.Edit(_sim);
            _sim = Testlogic.SimCard.Link(_sim, _duplicatedTerminals.ElementAt(0));

            Testlogic.SimCard.Lock(_sim);
            Testlogic.SimCard.Unlink(_sim);
        }
    }
}