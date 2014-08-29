namespace Six.Scs.QA.Selenium.Search.Result
{
    public class Customer : SearchDivLocator
    {
        public override string ResultId
        {
            get { return "customerResult"; }
        }

        public override string LinkPart
        {
            get { return "/Customer/?CustomerId="; }
        }

        public override string Section
        {
            get { return "customerDiv"; }
        }
    }
}