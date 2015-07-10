using Six.Scs.Test.Model.ValueObjects;
using Six.Scs.Test.View.Common.Menu;

namespace Six.Scs.Test.Workflow.Builder
{
    public abstract class CustomerBuilder : Helper.Builder
    {
        public Customer Customer { get; protected set; }

        public override void Create()
        {
            Customer = Model.Factory.Customer.Create();
            ClickCreate();
            SelectTenant();
            Confirm();
            SetCustomerData();
            CreateButton();
            ReadInfo();
        }

        public override void Edit()
        {
            Customer = Model.Factory.Customer.Edit();
            ReadInfo();
            ClickEdit();
            EditCustomerData();
            EnterChangeData();
            SaveButton();
        }

        private static void SaveButton()
        {
            View.Customer.Edit.SaveButton.Click();
        }

        protected void ClickCreate()
        {
            CustomerMenu.CustomerCreate.Click();
        }

        private void ClickEdit()
        {
            View.Customer.View.CustomerEdit.Click();
        }

        protected abstract void EditCustomerData();

        protected virtual void ReadInfo()
        {
            Customer.CustomerNumber = View.Customer.View.CustomerNumber;
        }

        protected static void Confirm()
        {
            View.Customer.Create.Confirm.Click();
        }

        protected void SelectTenant()
        {
            View.Customer.Create.Supplier = Customer.Supplier;
        }

        protected static void CreateButton()
        {
            View.Customer.Create.SaveButton.Click();
        }

        protected abstract void SetCustomerData();

        public void Quit()
        {
            View.Customer.View.Quit.Click();
            View.Customer.View.ConfirmQuit.Click();
        }

        public void Activate()
        {
            View.Customer.View.Activate.Click();
            View.Customer.View.ConfirmActivate.Click();
        }
    }
}