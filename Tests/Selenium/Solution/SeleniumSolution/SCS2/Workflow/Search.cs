using Six.Scs.Test.View.Common;
using Six.Scs.Test.View.Search;

namespace Six.Scs.Test.Workflow
{
    public static class Search
    {
        public static SearchResult Find(string searchString)
        {
            QuickSearch.SearchField = searchString;
            QuickSearch.HitEnter();
            return new SearchResult();
        }
    }
}