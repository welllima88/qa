using Six.Scs.Test.Model.ValueObjects.Brand;
using Six.Scs.Test.View.Brand;
using Six.Scs.Test.View.Terminal.Dashboard;
using Six.Test.Selenium.Helper;

namespace Six.Scs.Test.Workflow.Builder
{
    public abstract class BrandBuilder : IBuilder
    {
        public Contract Contract { get; protected set; }

        public void Create()
        {
            ChooseBrands();
            ConfirmSelection();
            SetBrandDetails();
            ClickCreate();
        }

        public abstract void Edit();
        public abstract void Check();

        private void ConfirmSelection()
        {
            Selection.ConfirmButton().Click();
        }

        private void ClickCreate()
        {
            AcquirerCreate.SaveAndCreate();
            PortletViewBase.AllHasBeenLoaded();
        }

        protected abstract void SetBrandDetails();
        protected abstract void ChooseBrands();
    }
}