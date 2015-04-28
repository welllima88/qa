using NUnit.Framework;
using Six.Scs.QA.Application.Model.Factory;
using Six.Scs.QA.Application.View.Tickets.Trouble;
using Six.Scs.QA.Application.Workflow;

namespace Six.Scs.QA.Testlogic.Tickets
{
    public class TroubleTicket
    {
        public static Application.Model.ValueObjects.TroubleTicket Create(Application.Model.ValueObjects.Terminal terminal)
        {
            Terminal.Open(terminal);
            Application.Model.ValueObjects.TroubleTicket troubleTicket = Ticket.TroubleTicket();
            Trouble.Create(troubleTicket);
            Open(troubleTicket);

            Check(troubleTicket);

            return troubleTicket;
        }

        private static void Check(Application.Model.ValueObjects.TroubleTicket troubleTicket)
        {
            Assert.That(View.Header, Is.StringMatching(troubleTicket.Id));
        }

        private static void Open(Application.Model.ValueObjects.TroubleTicket troubleTicket)
        {
            Search.TicketCanBeFoundById(troubleTicket.Id);
        }

        public static void Edit(Application.Model.ValueObjects.TroubleTicket troubleTicket)
        {
            // TODO: implement
        }
    }
}