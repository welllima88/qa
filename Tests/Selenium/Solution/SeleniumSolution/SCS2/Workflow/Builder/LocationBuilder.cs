using Six.Scs.Test.View.Common.Menu;

namespace Six.Scs.Test.Workflow.Builder
{
    public abstract class LocationBuilder : Helper.Builder
    {
        public Model.ValueObjects.Location Location { get; protected set; }

        public override void Create()
        {
            Location = Model.Factory.Location.Create();
            ClickCreate();
            SetData();
            CreateButton();
            ReadInfo();
        }

        public override void Edit()
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