using System.Collections.ObjectModel;
using Six.Scs.Test.UI.AcquirerExchange;
using Six.Scs.Test.UI.Terminal.Dashboard.Portlets.Brand;
using Six.Scs.Test.Workflow.Helper;

namespace Six.Scs.Test.Workflow
{
    public abstract class AcquirerExchange : Perform
    {
        public override void Do()
        {
            BrandPortlet.AcuirerExchange.Click();
            SetupBrands();
            View.Save.Click();
        }

        protected abstract Collection<string> SetupBrands();
    }
}