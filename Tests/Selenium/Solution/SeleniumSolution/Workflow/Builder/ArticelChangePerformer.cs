using Six.Scs.QA.Selenium.Terminal;
using Six.Scs.QA.Selenium.Terminal.Dashboard.Portlets;

namespace Six.Scs.QA.Workflow.Builder
{
    public abstract class ArticelChangePerformer : IPerform
    {
        public abstract void Check();

        public void Do()
        {
            SelectArticle();
            CheckInfos();
            Save();
        }

        protected abstract void SelectArticle();

        protected abstract void CheckInfos();

        private void Save()
        {
            BusinessViewpoint.ArticleChange.Click();

            ArticleChange.Change.Click();
            ArticleChange.Save.Click();
        }
    }
}