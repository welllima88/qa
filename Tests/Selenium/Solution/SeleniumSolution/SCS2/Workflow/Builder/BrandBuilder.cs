using Six.Scs.Test.Model.Brand;
using Six.Scs.Test.UI.Contract;
using Six.Scs.Test.UI.Terminal.Dashboard;

namespace Six.Scs.Test.Workflow.Builder
{
    public abstract class BrandBuilder : Helper.Builder
    {
        public Contract Contract { get; protected set; }

        public override void Create()
        {
            ChooseBrands();
            ConfirmSelection();
            SetBrandDetails();
            ClickCreate();
        }

        private void ConfirmSelection()
        {
            Selection.ConfirmButton().Click();
        }

        private void ClickCreate()
        {
            UI.Contract.Acquirer.Create.SaveAndCreate();
            PortletViewBase.AllHasBeenLoaded();
        }

        protected abstract void SetBrandDetails();
        protected abstract void ChooseBrands();
    }
}