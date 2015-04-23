using Six.Scs.QA.Selenium.View.Common;

namespace Six.Scs.QA.Selenium.Workflow
{
    public static class Search
    {
        public static void Find(string searchString)
        {
            QuickSearch.SearchField = searchString;
            QuickSearch.HitEnter();
        }
    }
}