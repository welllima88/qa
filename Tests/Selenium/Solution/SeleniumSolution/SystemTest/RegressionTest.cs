using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Six.Scs.Test.Builder.Acquirer;
using Six.Scs.Test.Builder.Brand.Ep2;
using Six.Scs.Test.Builder.Terminal.Ep2;
using Six.Scs.Test.Builder.Terminal.Ifsf;
using Six.Scs.Test.Massmutation;
using Six.Scs.Test.Model;
using Six.Scs.Test.Tickets;
using Six.Scs.Test.Workflow.Builder;
using Six.Test.Selenium.WebDriver;
using Default = Six.Scs.Test.Builder.Customer.Six.Default;
using TroubleTicket = Six.Scs.Test.Model.TroubleTicket;

namespace Six.Scs.Test
{
    [TestFixture]
    public class RegressionTest
    {
        private static Model.Terminal _terminalOnLocation2;
        private static Model.Terminal _terminalOnLocation1;
        private static CustomerBuilder _customerBuilder;
        private static LocationBuilder _locationBuilder;
        private static Person _personOnCustomer;
        private static Person _personOnLocation;
        private static Model.User _user;
        private static IEnumerable<Model.Terminal> _duplicatedTerminals;
        private static Model.Mpd _mpd;
        private static Model.SimCard _sim;
        private static Model.Location _location;
        private static TroubleTicket _troubleTicket;
        private static BillingAddress _billingAddress;
        private static Model.Terminal _terminalOnLocation;

        [TestFixtureSetUp]
        public void Home()
        {
            TestDirector.Navigate();
        }

        [Test]
        [Category("Regression")]
        /*
         [Category("Customer"), Category("Location"), Category("BillingAddress"),
         Category("Terminal"), Category("Search"),
         Category("Terminal Duplicate"), Category("Terminal Quit"), Category("Infotext"), Category("Person"),
         Category("MPD"), Category("User"), Category("User"), Category("User from Contact"), Category("SIM Card")]
         */
        public static void ExecuteRegressiontest()
        {
            _customerBuilder = Customer.Create(new Default(Factory.Customer.Create()));
            Customer.Quit(_customerBuilder);
            Customer.Activate(_customerBuilder);

            _locationBuilder = Location.Create(_customerBuilder.Customer,
                new Builder.Location.Default(Factory.Location.Create()));
            Location.Quit(_locationBuilder);
            Location.Activate(_locationBuilder);

            Customer.Quit(_customerBuilder);
            Customer.Activate(_customerBuilder);
            Location.Activate(_locationBuilder);

            _personOnCustomer = Contact.Create(_customerBuilder.Customer);

            var contracts = new Builder.Brand.Ep2.Default();

            _terminalOnLocation1 = Terminal.Create(_locationBuilder.Location, new Yomani().With(contracts));

            Process.Activate(_terminalOnLocation1);

            _customerBuilder = Customer.Edit(_customerBuilder.Customer, new Default(Factory.Customer.Edit()));

            Infotext.Create(_customerBuilder.Customer);
            _billingAddress = BillingAdress.Create(_customerBuilder.Customer);
            BillingAdress.Edit(_billingAddress);

            _mpd = Mpd.Create(_customerBuilder.Customer);
            Terminal.Assign(_mpd, _terminalOnLocation1);

            _terminalOnLocation2 = Terminal.Create(_locationBuilder.Location, new Xentissimo());
            _location = Location.CreateFromCustomer(_customerBuilder.Customer).Location;
            Terminal.Move(_terminalOnLocation2, _location);

            Brands.Create(_terminalOnLocation2, new Builder.Brand.Ep2.Default());
            Infotext.Create(_locationBuilder.Location);

            _terminalOnLocation = Terminal.Create(_locationBuilder.Location, new Davinci2());
            Brands.Create(_terminalOnLocation, new Builder.Brand.Ifsf.Default());
            _locationBuilder = Location.Edit(_locationBuilder.Location,
                new Builder.Location.Default(Factory.Location.Edit()));
            Infotext.Create(_terminalOnLocation1);

            _personOnLocation = Contact.Create(_locationBuilder.Location);

            Mpd.Edit(_mpd);

            Terminal.ArticleChange(_terminalOnLocation1, new Yoximo());
            Terminal.Quit(_terminalOnLocation1);
            _personOnLocation = Contact.Edit(_personOnLocation);
            Contact.Delete(_personOnCustomer);

            _user = User.Create(_customerBuilder.Customer);
            _user = User.Edit(_user);

            _duplicatedTerminals = Terminal.Duplicate(_terminalOnLocation2);
            BusinessTemplate.Change(_duplicatedTerminals);
            User.Create(_personOnLocation);

            User.AddService(_user);
            User.AssignRoles(_user);

            Brands.Create(_duplicatedTerminals.ElementAt(1),
                new Additional());
            // {0,1,..} means create brands on second terminal
            // check again already existing contracts:
            contracts.Check();

            User.Delete(_user);
            BillingAdress.Delete(_billingAddress);

            Terminal.Replace(_terminalOnLocation2);
            Acquirer.Exchange(_terminalOnLocation2, new SixEurope());

            _troubleTicket = Tickets.TroubleTicket.Create(_duplicatedTerminals.ElementAt(1));
            // Tickets.TroubleTicket.Edit(_troubleTicket);

            Terminal.Return(_duplicatedTerminals.ElementAt(1));

            _sim = SimCard.Create();

            _sim = SimCard.Edit(_sim);
            _sim = SimCard.Link(_sim,
                _duplicatedTerminals.ElementAt(0));

            SimCard.Lock(_sim);
            SimCard.Unlink(_sim);
        }
    }
}