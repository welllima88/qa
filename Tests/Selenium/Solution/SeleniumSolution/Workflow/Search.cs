using Six.Scs.QA.Selenium.Common;

namespace Six.Scs.QA.Workflow
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