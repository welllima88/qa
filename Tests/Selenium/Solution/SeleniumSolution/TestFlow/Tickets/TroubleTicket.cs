using NUnit.Framework;
using Six.Scs.QA.Selenium.Model.Factory;
using Six.Scs.QA.Selenium.View.Tickets.Trouble;
using Six.Scs.QA.Selenium.Workflow;

namespace Six.Scs.QA.Testlogic.Tickets
{
    public class TroubleTicket
    {
        public static Selenium.Model.ValueObjects.TroubleTicket Create(Selenium.Model.ValueObjects.Terminal terminal)
        {
            Terminal.Open(terminal);
            Selenium.Model.ValueObjects.TroubleTicket troubleTicket = Ticket.TroubleTicket();
            Trouble.Create(troubleTicket);
            Open(troubleTicket);

            Check(troubleTicket);

            return troubleTicket;
        }

        private static void Check(Selenium.Model.ValueObjects.TroubleTicket troubleTicket)
        {
            Assert.That(View.Header, Is.StringMatching(troubleTicket.Id));
        }

        private static void Open(Selenium.Model.ValueObjects.TroubleTicket troubleTicket)
        {
            Search.TicketCanBeFoundById(troubleTicket.Id);
        }

        public static void Edit(Selenium.Model.ValueObjects.TroubleTicket troubleTicket)
        {
            // TODO: implement
        }
    }
}