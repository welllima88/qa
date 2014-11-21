using Six.Scs.QA.Selenium.Terminal;
using Six.Scs.QA.Selenium.Terminal.Dashboard.Portlets;

namespace Six.Scs.QA.Workflow.Builder
{
    public abstract class ArticelChangePerformer : IPerform
    {
        public abstract void Check();

        public void Do()
        {
            BusinessViewpoint.ArticleChange.Click();
            SelectArticle();
            CheckInfos();
            ArticleChange.Save.Click();
        }

        protected abstract void SelectArticle();

        protected abstract void CheckInfos();
    }
}