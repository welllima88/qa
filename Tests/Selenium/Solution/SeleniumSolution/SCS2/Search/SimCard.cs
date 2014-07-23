namespace Six.Scs.QA.Selenium.Search
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
            get { return "simCardDiv"; }
        }
    }
}