using Six.Scs.QA.TestData.Factory;
using Six.Scs.QA.Workflow;

namespace Six.Scs.QA.Testlogic.Tickets
{
    public class TroubleTicket
    {
        public static TestData.ValueObjects.TroubleTicket Create(TestData.ValueObjects.Terminal terminal)
        {
            Terminal.Open(terminal);
            TestData.ValueObjects.TroubleTicket troubleTicket = Ticket.TroubleTicket();
            Trouble.Create(troubleTicket);
            Open(troubleTicket);
            // TODO : Add checks
            return troubleTicket;
        }

        private static void Open(TestData.ValueObjects.TroubleTicket troubleTicket)
        {
            Search.TicketCanBeFoundById(troubleTicket.Id);
        }

        public static void Edit(TestData.ValueObjects.TroubleTicket troubleTicket)
        {
            // TODO: implement
        }
    }
}