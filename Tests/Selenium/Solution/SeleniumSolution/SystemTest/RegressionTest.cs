﻿using System.Collections.Generic;
using NUnit.Framework;
using Six.Scs.QA.Testlogic;
using Six.Scs.QA.Testlogic.Builder.Brand.Ep2;
using Six.Scs.QA.Testlogic.Builder.Terminal.Ep2;
using Six.Scs.QA.Workflow.Builder;
using Contact = Six.Scs.QA.Testlogic.Contact;
using Default = Six.Scs.QA.Testlogic.Builder.Customer.Six.Default;
using SimCard = Six.Scs.QA.TestData.ValueObjects.SimCard;

namespace Six.Scs.QA.Selenium.SystemTest
{
    [TestFixture]
    public class RegressionTest
    {
        private static TestData.ValueObjects.Terminal _terminalLocation;
        private static TestData.ValueObjects.Terminal _terminalCustomer;
        private static CustomerBuilder _six;
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
         Category("MPD"), Category("User"), Category("User"), Category("User from Contact"), Category("SIM Card")]
        public static void ExecuteRegressiontest()
        {
            _six = Testlogic.Customer.Create(new Default());
            _location1 = Testlogic.Location.Create(_six.Customer);
            _personOnCustomer = Contact.Create(_six.Customer);
            _terminalCustomer = Testlogic.Terminal.Create(_six.Customer, new Yomani());

            Testlogic.Customer.Edit(_six);

            Brands.Create(_terminalCustomer, new Testlogic.Builder.Brand.Ep2.Default());

            Infotext.Create(_six.Customer);

            _mpd = Testlogic.Mpd.Create(_six.Customer);
            Testlogic.Terminal.Assign(_mpd, _terminalCustomer);

            _terminalLocation = Testlogic.Terminal.Create(_location1,
                new Xentissimo().With(new Testlogic.Builder.Brand.Ep2.Default()));
            // TroubleTicket.Create(_terminalLocation);
            Infotext.Create(_location1);

            _location1 = Testlogic.Location.Edit(_location1);
            Infotext.Create(_terminalLocation);

            _personOnLocation = Contact.Create(_location1);

            Testlogic.Mpd.Edit(_mpd);

            // Ep2.ArticleChange(_terminalCustomer);
            Testlogic.Terminal.Quit(_terminalCustomer);
            _personOnLocation = Contact.Edit(_personOnLocation);
            Contact.Delete(_personOnCustomer);

            _user = Testlogic.User.Create(_six.Customer);
            _user = Testlogic.User.Edit(_user);

            _duplicatedTerminals = Testlogic.Terminal.Duplicate(_terminalLocation);
            Testlogic.User.Create(_personOnLocation);

            Testlogic.User.AddService(_user);

            Brands.Create(_duplicatedTerminals[1], new Additional());
            // {0,1,..} means create brands on second terminal

            Testlogic.Terminal.Replace(_terminalLocation);
            _location2 = Testlogic.Location.Create(_six.Customer);
            Testlogic.Terminal.Move(_terminalLocation, _location2);

            _sim = Testlogic.SimCard.Create();

            _sim = Testlogic.SimCard.Edit(_sim);
            _sim = Testlogic.SimCard.Link(_sim, _duplicatedTerminals[0]);

            Testlogic.SimCard.Lock(_sim);
            Testlogic.SimCard.Unlink(_sim);
        }
    }
}