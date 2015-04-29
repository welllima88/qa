using NUnit.Framework;
using Six.Scs.Test.Model.Factory;
using Six.Scs.Test.Workflow;

namespace Six.Scs.Test.Tickets
{
    public class TroubleTicket
    {
        public static Model.ValueObjects.TroubleTicket Create(Model.ValueObjects.Terminal terminal)
        {
            Terminal.Open(terminal);
            var troubleTicket = Ticket.TroubleTicket();
            Trouble.Create(troubleTicket);
            Open(troubleTicket);

            Check(troubleTicket);

            return troubleTicket;
        }

        private static void Check(Model.ValueObjects.TroubleTicket troubleTicket)
        {
            Assert.That(View.Tickets.Trouble.View.Header, Is.StringMatching(troubleTicket.Id));
        }

        private static void Open(Model.ValueObjects.TroubleTicket troubleTicket)
        {
            Search.TicketCanBeFoundById(troubleTicket.Id);
        }

        public static void Edit(Model.ValueObjects.TroubleTicket troubleTicket)
        {
            // TODO: implement
        }
    }
}