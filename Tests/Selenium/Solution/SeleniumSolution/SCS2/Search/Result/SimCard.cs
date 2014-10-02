namespace Six.Scs.QA.Selenium.Search.Result
{
    public class SimCard : SearchDivLocator
    {
        public override string ResultId
        {
            get { return "simCardResult"; }
        }

        public override string LinkPart
        {
            get { return "/SIMCard/Details/?SIMCardId="; }
        }

        public override string Section
        {
            get { return "simcardDiv"; }
        }
    }
}