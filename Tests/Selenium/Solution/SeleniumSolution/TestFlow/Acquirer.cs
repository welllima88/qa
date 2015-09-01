using Six.Scs.Test.Workflow;

namespace Six.Scs.Test
{
    public class Acquirer
    {
        public static void Exchange(Model.Terminal terminal, AcquirerExchange acquirerExchange)
        {
            Terminal.Open(terminal);
            acquirerExchange.Do();
            acquirerExchange.Check();
        }
    }
}