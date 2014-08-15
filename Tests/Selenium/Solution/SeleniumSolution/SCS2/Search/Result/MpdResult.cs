namespace Six.Scs.QA.Selenium.Search.Result
{
    public class MpdResult : SearchDivLocator
    {
        public override string ResultId
        {
            get { return "mpdResult"; }
        }

        public override string LinkPart
        {
            get { return "/Mpd/?mpdId="; }
        }

        public override string Section
        {
            get { return "mpdDiv"; }
        }
    }
}