using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Customer;
using Six.Scs.QA.TestData.ValueObjects;

namespace Six.Scs.QA.Workflow.Builder
{
    public abstract class CustomerBuilder : IBuilder
    {
        private IPerform _changeMode;
        public Customer Customer { get; protected set; }

        public virtual void Create()
        {
            Customer = TestData.Factory.Customer.Create();
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
            Customer = TestData.Factory.Customer.Edit();
            ReadInfo();
            ClickEdit();
            EditCustomerData();
            EnterChangeData();
            SaveButton();
        }

        private static void SaveButton()
        {
            Selenium.Customer.Edit.SaveButton.Click();
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
            Customer.CustomerNumber = View.CustomerNumber;
        }

        protected static void Confirm()
        {
            Selenium.Customer.Create.Confirm.Click();
        }

        protected void SelectTenant()
        {
            Selenium.Customer.Create.Supplier = Customer.Supplier;
        }

        protected static void CreateButton()
        {
            Selenium.Customer.Create.SaveButton.Click();
        }

        protected abstract void SetCustomerData();
    }
}