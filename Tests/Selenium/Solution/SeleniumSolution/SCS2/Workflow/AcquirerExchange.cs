using Six.Scs.Test.View.Terminal.Dashboard.Portlets.Brand;
using Six.Scs.Test.Workflow.Helper;

namespace Six.Scs.Test.Workflow
{
    public abstract class AcquirerExchange : Perform
    {
        public override void Do()
        {
            BrandPortlet.AcuirerExchange.Click();
            SetupBrands();
            View.Acquirer.Exchange.Save.Click();            
        }

        protected abstract void SetupBrands();
    }
}