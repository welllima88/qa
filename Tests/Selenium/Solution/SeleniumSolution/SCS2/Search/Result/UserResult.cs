namespace Six.Scs.QA.Selenium.Search.Result
{
    public class UserResult : SearchDivLocator
    {
        public override string ResultId
        {
            get { return "userResult"; }
        }

        public override string LinkPart
        {
            get { return "/User/Index?UserName="; }
        }

        public override string Section
        {
            get { return "userResult"; }
        }
    }
}