using Six.Scs.Test.View.Terminal;
using Six.Scs.Test.View.Terminal.Dashboard.Portlets;
using Six.Scs.Test.Workflow.Helper;

namespace Six.Scs.Test.Workflow.Builder
{
    public abstract class ArticelChangePerformer : IPerform
    {
        private IPerform _softwareChange;
        public abstract void Check();

        public void Do()
        {
            BusinessViewpoint.ArticleChange.Click();
            SelectArticle();
            CheckInfos();
            ArticleChange.Save.Click();
            SetSoftware();
        }

        private void SetSoftware()
        {
            if (_softwareChange != null)
            {
                _softwareChange.Do();
            }
            else
            {
                SoftwareChange.Cancel.Click();
            }
        }

        protected abstract void SelectArticle();
        protected abstract void CheckInfos();

        public void Software(IPerform softwareChange)
        {
            _softwareChange = softwareChange;
        }
    }
}