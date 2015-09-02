using Six.Scs.Test.Model;
using Six.Scs.Test.UI.Common.Menu;
using Six.Scs.Test.UI.Customer;

namespace Six.Scs.Test.Workflow.Builder
{
    public abstract class CustomerBuilder : Helper.Builder
    {
        public CustomerBuilder(Customer customer)
        {
            Customer = customer;
        }

        public Customer Customer { get; private set; }

        public override void Create()
        {
            ClickCreate();
            SelectTenant();
            Confirm();
            SetCustomerData();
            CreateButton();
            ReadInfo();
        }

        public override void Edit()
        {
            ReadInfo();
            ClickEdit();
            EditCustomerData();
            EnterChangeData();
            SaveButton();
        }

        private static void SaveButton()
        {
            UI.Customer.Edit.SaveButton.Click();
        }

        protected void ClickCreate()
        {
            CustomerMenu.CustomerCreate.Click();
        }

        private void ClickEdit()
        {
            View.CustomerEdit.Click();
        }

        protected abstract void EditCustomerData();

        protected virtual void ReadInfo()
        {
            Customer.CustomerNumber = View.CustomerNumber;
        }

        protected static void Confirm()
        {
            UI.Customer.Create.Confirm.Click();
        }

        protected void SelectTenant()
        {
            UI.Customer.Create.Supplier = Customer.Supplier;
        }

        protected static void CreateButton()
        {
            UI.Customer.Create.SaveButton.Click();
        }

        protected abstract void SetCustomerData();

        public void Quit()
        {
            View.Quit.Click();
            View.ConfirmQuit.Click();
        }

        public void Activate()
        {
            View.Activate.Click();
            View.ConfirmActivate.Click();
        }

        public void Move(Customer toCustomer)
        {
            View.MoveButton.Click();
            UI.Customer.Move.TargetCustomerId = toCustomer.CustomerNumber;
            UI.Customer.Move.Execute();
        }
    }
}