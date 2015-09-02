using Six.Scs.Test.Model;
using Six.Scs.Test.UI.Common.Menu;
using Six.Scs.Test.UI.Location;

namespace Six.Scs.Test.Workflow.Builder
{
    public abstract class LocationBuilder : Helper.Builder
    {
        public LocationBuilder(Location location)
        {
            Location = location;
        }

        public Location Location { get; private set; }

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
            UI.Location.Edit.SaveButton.Click();
        }

        private void ClickCreate()
        {
            CustomerMenu.LocationCreate.Click();
        }

        private void ClickEdit()
        {
            View.LocationEdit.Click();
        }

        protected abstract void EditData();

        protected virtual void ReadInfo()
        {
            Location.Guid = View.Guid;
        }

        private static void CreateButton()
        {
            UI.Customer.Create.SaveButton.Click();
        }

        protected abstract void SetData();

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
    }
}