using Six.Scs.Test.View.Common.Menu;
using Six.Test.Selenium.Helper;

namespace Six.Scs.Test.Workflow.Builder
{
    public abstract class LocationBuilder : IBuilder
    {
        private IPerform _changeMode;
        public Model.ValueObjects.Location Location { get; protected set; }

        public virtual void Create()
        {
            Location = Model.Factory.Location.Create();
            ClickCreate();
            SetData();
            CreateButton();
            ReadInfo();
        }

        public abstract void Check();

        public virtual void Edit()
        {
            Location = Model.Factory.Location.Edit();
            ReadInfo();
            ClickEdit();
            EditData();
            EnterChangeData();
            SaveButton();
        }

        private static void SaveButton()
        {
            View.Location.Edit.SaveButton.Click();
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
            Location.Guid = View.Location.View.Guid;
        }

        protected static void CreateButton()
        {
            View.Customer.Create.SaveButton.Click();
        }

        protected abstract void SetData();
    }
}