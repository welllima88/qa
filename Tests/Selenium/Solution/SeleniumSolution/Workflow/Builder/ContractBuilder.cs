using Six.Scs.QA.Selenium.Brand;
using Six.Scs.QA.TestData.ValueObjects.Brand;

namespace Six.Scs.QA.Workflow.Builder
{
    public abstract class ContractBuilder : IBuilder
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
        }

        protected abstract void SetBrandDetails();

        protected abstract void ChooseBrands();
    }
}