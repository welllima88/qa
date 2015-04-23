using Six.QA.Selenium.Extension.Helper;
using Six.Scs.QA.Selenium.Model.ValueObjects.Brand;
using Six.Scs.QA.Selenium.View.Brand;
using Six.Scs.QA.Selenium.View.Terminal.Dashboard;

namespace Six.Scs.QA.Selenium.Workflow.Builder
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