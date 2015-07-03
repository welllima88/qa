using Six.Scs.Test.View.Common.Menu;

namespace Six.Scs.Test.Workflow.Builder
{
    public abstract class LocationBuilder : Helper.Builder
    {
        public Model.ValueObjects.Location Location { get; set; }

        public override void Create()
        {
            ClickCreate();
            SetData();
            CreateButton();
            ReadInfo();
        }

        public override void Edit()
        {
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