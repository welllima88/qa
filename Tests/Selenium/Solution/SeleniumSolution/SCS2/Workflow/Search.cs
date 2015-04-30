using Six.Scs.Test.View.Common;

namespace Six.Scs.Test.Workflow
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