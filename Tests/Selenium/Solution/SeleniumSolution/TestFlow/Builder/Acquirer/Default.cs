using NUnit.Framework;
using Six.Scs.Test.View.Massmuation;
using Six.Scs.Test.Workflow;

namespace Six.Scs.Test.Builder.Acquirer
{
    public class Default : AcquirerExchange
    {
        public override void Check()
        {
            Assert.That(Progress.BatchId, Is.GreaterThan(0));
        }

        protected override void SetupBrands()
        {
        
        }
    }
}