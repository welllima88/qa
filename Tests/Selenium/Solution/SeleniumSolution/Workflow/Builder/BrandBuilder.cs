using Six.Scs.QA.Selenium.Brand;
using Six.Scs.QA.Selenium.Terminal.Dashboard;
using Six.Scs.QA.TestData.ValueObjects.Brand;

namespace Six.Scs.QA.Workflow.Builder
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