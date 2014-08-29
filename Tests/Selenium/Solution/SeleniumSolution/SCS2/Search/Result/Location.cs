namespace Six.Scs.QA.Selenium.Search.Result
{
    public class Location : SearchDivLocator
    {
        public override string ResultId
        {
            get { return "locationResult"; }
        }

        public override string LinkPart
        {
            get { return "/Location/"; }
        }

        public override string Section
        {
            get { return "locationDiv"; }
        }
    }
}