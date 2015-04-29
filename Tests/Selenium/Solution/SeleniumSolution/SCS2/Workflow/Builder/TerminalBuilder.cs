using Six.Scs.Test.View.Brand;
using Six.Scs.Test.View.Terminal;
using Six.Scs.Test.View.Terminal.Dashboard;
using Six.Test.Selenium.Helper;

namespace Six.Scs.Test.Workflow.Builder
{
    public abstract class TerminalBuilder : IBuilder
    {
        private BrandBuilder _brandBuilder;

        protected TerminalBuilder(BrandBuilder brandBuilder)
        {
            _brandBuilder = brandBuilder;
        }

        protected TerminalBuilder()
        {
            _brandBuilder = null;
            Terminal = new Model.ValueObjects.Terminal();
        }

        public Model.ValueObjects.Terminal Terminal { get; set; }

        public virtual void Create()
        {
            ChooseArticle();
            SetBasics();
            ConfigCreate.Continue();
            SetDetails();
            ConfigDetailsCreate.Save();
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

        protected abstract void ChooseArticle();
        protected abstract void SetBasics();
        protected abstract void SetDetails();

        /// <summary>
        ///     Method for adding contracts. Default behaviour is, that this step is skipped/cancelled if not overridden.
        /// </summary>
        protected void AddContracts()
        {
            if (_brandBuilder == null)
            {
                Selection.CancelButton().Click(); // implies that the tree view is displayed
            }
            else
            {
                _brandBuilder.Create();
                _brandBuilder.Check();
            }
        }

        /// <summary>
        ///     The call of the 'with(..)' method sets a BrandBuilder. If set the brands will be created and checked directly after
        ///     the creation of the Terminals.
        /// </summary>
        /// <param name="brandBuilder">A BrandBuilder which is used for creation and checks of Brands.</param>
        /// <returns></returns>
        public TerminalBuilder With(BrandBuilder brandBuilder)
        {
            _brandBuilder = brandBuilder;
            return this;
        }
    }
}