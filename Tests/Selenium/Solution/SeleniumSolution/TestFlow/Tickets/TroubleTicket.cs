using Six.Scs.QA.TestData.Factory;
using Six.Scs.QA.Workflow;

namespace Six.Scs.QA.Testlogic.Tickets
{
    public class TroubleTicket
    {
        public static void Create(TestData.ValueObjects.Terminal terminal)
        {
            Terminal.Open(terminal);
            TestData.ValueObjects.TroubleTicket troubleTicket = Ticket.TroubleTicket();
            Trouble.Create(troubleTicket);
        }
    }
}