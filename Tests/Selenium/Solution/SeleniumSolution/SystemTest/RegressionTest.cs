using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Six.Scs.Test.Builder.Brand.Ep2;
using Six.Scs.Test.Builder.Terminal.Ep2;
using Six.Scs.Test.Builder.Terminal.Ifsf;
using Six.Scs.Test.Helper;
using Six.Scs.Test.Model.ValueObjects;
using Six.Scs.Test.Workflow.Builder;
using Six.Test.Selenium.WebDriver;
using Default = Six.Scs.Test.Builder.Customer.Six.Default;

namespace Six.Scs.Test
{
    [TestFixture]
    public class RegressionTest
    {
        private static Model.ValueObjects.Terminal _terminalLocation2;
        private static Model.ValueObjects.Terminal _terminalLocation1;
        private static CustomerBuilder _six;
        private static Model.ValueObjects.Location _location1;
        private static Person _personOnCustomer;
        private static Person _personOnLocation;
        private static Model.ValueObjects.User _user;
        private static IEnumerable<Model.ValueObjects.Terminal> _duplicatedTerminals;
        private static Model.ValueObjects.Mpd _mpd;
        private static Model.ValueObjects.SimCard _sim;
        private static Model.ValueObjects.Location _location2;
        private static TroubleTicket _troubleTicket;
        private static BillingAddress _billingAddress;
        private static Model.ValueObjects.Terminal _terminalLocation3;

        [TestFixtureSetUp]
        public void Home()
        {
            TestDirector.Navigate();
        }

        [TestFixtureTearDown]
        public void CheckIfErrorsOccured()
        {
            Verify.WriteErrors();
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
            _six = Customer.Create(new Default());
            _location1 = Location.Create(_six.Customer, new Builder.Location.Default()).Location;
            _personOnCustomer = Contact.Create(_six.Customer);
            var contracts = new Builder.Brand.Ep2.Default();
            _terminalLocation1 = Terminal.Create(_location1, new Yomani().With(contracts));

            Customer.Edit(_six);

            // TODO: Infotext.Create(_six.Customer);
            _billingAddress = BillingAdress.Create(_six.Customer);
            BillingAdress.Edit(_billingAddress);

            _mpd = Mpd.Create(_six.Customer);
            Terminal.Assign(_mpd, _terminalLocation1);

            _terminalLocation2 = Terminal.Create(_location1, new Xentissimo());
            _location2 = Location.Create(_six.Customer, new Builder.Location.Default()).Location;
            Terminal.Move(_terminalLocation2, _location2);

            Brands.Create(_terminalLocation2, new Builder.Brand.Ep2.Default());
            // TODO: Infotext.Create(_location1);

            _terminalLocation3 = Terminal.Create(_location1, new Davinci2());
            Brands.Create(_terminalLocation3, new Builder.Brand.Ifsf.Default());
            _location1 = Location.Edit(_location1, new Builder.Location.Default()).Location;
            // TODO: Infotext.Create(_terminalLocation2);

            _personOnLocation = Contact.Create(_location1);

            Mpd.Edit(_mpd);

            Terminal.ArticleChange(_terminalLocation1, new Yoximo());
            Terminal.Quit(_terminalLocation1);
            _personOnLocation = Contact.Edit(_personOnLocation);
            Contact.Delete(_personOnCustomer);

            _user = User.Create(_six.Customer);
            _user = User.Edit(_user);

            _duplicatedTerminals = Terminal.Duplicate(_terminalLocation2);
            User.Create(_personOnLocation);

            User.AddService(_user);
            User.AssignRoles(_user);

            Brands.Create(_duplicatedTerminals.ElementAt(1), new Additional());
            // {0,1,..} means create brands on second terminal
            // check again already existing contracts:
            contracts.Check();

            User.Delete(_user);

            Terminal.Replace(_terminalLocation2);

            _troubleTicket = Tickets.TroubleTicket.Create(_duplicatedTerminals.ElementAt(1));
            Tickets.TroubleTicket.Edit(_troubleTicket);

            Terminal.Retour(_duplicatedTerminals.ElementAt(1));

            _sim = SimCard.Create();

            _sim = SimCard.Edit(_sim);
            _sim = SimCard.Link(_sim, _duplicatedTerminals.ElementAt(0));

            SimCard.Lock(_sim);
            SimCard.Unlink(_sim);
        }
    }
}