using Six.Scs.Test.Model.ValueObjects;
using Six.Scs.Test.View.Common.Menu;
using Six.Test.Selenium.Helper;

namespace Six.Scs.Test.Workflow.Builder
{
    public abstract class CustomerBuilder : IBuilder
    {
        private IPerform _changeMode;
        public Customer Customer { get; protected set; }

        public virtual void Create()
        {
            Customer = Model.Factory.Customer.Create();
            ClickCreate();
            SelectTenant();
            Confirm();
            SetCustomerData();
            CreateButton();
            ReadInfo();
        }

        public abstract void Check();

        public virtual void Edit()
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
            CustomerMenu.CustomerEdit.Click();
        }

        public CustomerBuilder Change(IPerform changeMode)
        {
            _changeMode = changeMode;
            return this;
        }

        private void EnterChangeData()
        {
            if (_changeMode == null)
            {
                new DefaultChange().Do();
            }
            else
            {
                _changeMode.Do();
            }
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
    }
}