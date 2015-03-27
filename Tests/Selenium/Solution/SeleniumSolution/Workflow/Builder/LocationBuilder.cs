using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Location;

namespace Six.Scs.QA.Workflow.Builder
{
    public abstract class LocationBuilder : IBuilder
    {
        private IPerform _changeMode;
        public TestData.ValueObjects.Location Location { get; protected set; }

        public virtual void Create()
        {
            Location = TestData.Factory.Location.Create();
            ClickCreate();
            SetData();
            CreateButton();
            ReadInfo();
        }

        public abstract void Check();

        public virtual void Edit()
        {
            Location = TestData.Factory.Location.Edit();
            ReadInfo();
            ClickEdit();
            EditData();
            EnterChangeData();
            SaveButton();
        }

        private static void SaveButton()
        {
            Selenium.Location.Create.SaveButton.Click();
        }

        protected void ClickCreate()
        {
            CustomerMenu.LocationCreate.Click();
        }

        private void ClickEdit()
        {
            LocationMenu.LocationEdit.Click();
        }

        public LocationBuilder Change(IPerform changeMode)
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

        protected abstract void EditData();

        protected virtual void ReadInfo()
        {
            Location.Guid = View.Guid;
        }

        protected static void CreateButton()
        {
            Selenium.Customer.Create.SaveButton.Click();
        }

        protected abstract void SetData();
    }
}