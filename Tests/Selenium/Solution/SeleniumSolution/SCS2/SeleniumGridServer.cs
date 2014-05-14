namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium
{
    public static class SeleniumGridServer
    {
        public static string Build
        {
            get { return "http://wkbuild03:4488/wd/hub"; }
        }

        public static string Local
        {
            get { return "http://localhost:4488/wd/hub"; }
        }
    }
}