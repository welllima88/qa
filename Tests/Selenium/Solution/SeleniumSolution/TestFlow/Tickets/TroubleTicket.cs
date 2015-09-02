using NUnit.Framework;
using Six.Scs.Test.Factory;
using Six.Scs.Test.UI.Tickets.Trouble;
using Six.Scs.Test.Workflow;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test.Tickets
{
    public class TroubleTicket
    {
        public static Model.TroubleTicket Create(Model.Terminal terminal)
        {
            Terminal.Open(terminal);
            var troubleTicket = Ticket.TroubleTicket();
            Trouble.Create(troubleTicket);
            Open(troubleTicket);

            Check(troubleTicket);

            return troubleTicket;
        }

        private static void Check(Model.TroubleTicket troubleTicket)
        {
            Assert.That(View.Header, Is.StringMatching(troubleTicket.Id));
        }

        private static void Open(Model.TroubleTicket troubleTicket)
        {
            Search.TicketCanBeFoundById(troubleTicket.Id);
            Assert.That(View.Header, Is.StringMatching(troubleTicket.Id));
        }

        public static void Edit(Model.TroubleTicket troubleTicket)
        {
            Open(troubleTicket);
            var troubleTicketE = Trouble.Edit(troubleTicket);
            Check(troubleTicketE);
            TestDirector.Navigate();
        }
    }
}