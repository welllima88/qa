using Six.Scs.Test.UI.Common;
using Six.Scs.Test.UI.Search;

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