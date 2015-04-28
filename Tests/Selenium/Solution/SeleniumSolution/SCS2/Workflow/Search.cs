using Six.Scs.QA.Application.View.Common;

namespace Six.Scs.QA.Application.Workflow
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