using NUnit.Framework;
using Six.Scs.Test.Model.Factory;
using Six.Scs.Test.Workflow;

namespace Six.Scs.Test.Tickets
{
    public class TroubleTicket
    {
        public static Test.Model.ValueObjects.TroubleTicket Create(Test.Model.ValueObjects.Terminal terminal)
        {
            Terminal.Open(terminal);
            Test.Model.ValueObjects.TroubleTicket troubleTicket = Ticket.TroubleTicket();
            Trouble.Create(troubleTicket);
            Open(troubleTicket);

            Check(troubleTicket);

            return troubleTicket;
        }

        private static void Check(Test.Model.ValueObjects.TroubleTicket troubleTicket)
        {
            Assert.That(View.Tickets.Trouble.View.Header, Is.StringMatching(troubleTicket.Id));
        }

        private static void Open(Test.Model.ValueObjects.TroubleTicket troubleTicket)
        {
            Search.TicketCanBeFoundById(troubleTicket.Id);
        }

        public static void Edit(Test.Model.ValueObjects.TroubleTicket troubleTicket)
        {
            // TODO: implement
        }
    }
}