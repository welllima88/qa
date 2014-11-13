using Six.Scs.QA.Selenium.Brand;
using Six.Scs.QA.Selenium.Terminal;
using Six.Scs.QA.Selenium.Terminal.Dashboard;

namespace Six.Scs.QA.Workflow.Builder
{
    public abstract class TerminalBuilder : IBuilder
    {
        private ContractBuilder _contractBuilder;

        protected TerminalBuilder(ContractBuilder contractBuilder)
        {
            _contractBuilder = contractBuilder;
        }

        protected TerminalBuilder()
        {
            _contractBuilder = null;
        }

        public TestData.ValueObjects.Terminal Terminal { get; set; }

        public virtual void Create()
        {
            ChooseArticle();
            SetBasics();
            Continue();
            SetDetails();
            Save();
            AddContracts();
            ReadInfo();
        }

        /// <summary>
        ///     Abstract method to edit anything of the terminal
        /// </summary>
        public abstract void Edit();

        public abstract void Check();

        protected void ReadInfo()
        {
            Terminal.Id = TerminalInfo.TerminalId;
        }

        private void Continue()
        {
            ConfigCreate.ContinueButton.Click();
        }

        protected abstract void ChooseArticle();

        protected abstract void SetBasics();

        protected abstract void SetDetails();

        /// <summary>
        ///     Method for adding contracts. Default behaviour is, that this step is skipped/cancelled if not overridden.
        /// </summary>
        protected void AddContracts()
        {
            if (_contractBuilder == null)
            {
                Selection.CancelButton().Click(); // implies that the tree view is displayed
            }
            else
            {
                _contractBuilder.Create();
                _contractBuilder.Check();
            }
        }

        protected static void Save()
        {
            ConfigDetailsCreate.SaveButton.Click();
        }

        public TerminalBuilder With(ContractBuilder contractBuilder)
        {
            _contractBuilder = contractBuilder;
            return this;
        }
    }
}