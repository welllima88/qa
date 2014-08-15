namespace Six.Scs.QA.Selenium.Search.Result
{
    public abstract class SearchDivLocator
    {
        public abstract string ResultId { get; }
        public abstract string LinkPart { get; }
        public abstract string Section { get; }
    }
}