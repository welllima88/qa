using Six.QA.Selenium.Extension.Helper;
using Six.Scs.QA.Selenium.View.Terminal;
using Six.Scs.QA.Selenium.View.Terminal.Dashboard.Portlets;

namespace Six.Scs.QA.Selenium.Workflow.Builder
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