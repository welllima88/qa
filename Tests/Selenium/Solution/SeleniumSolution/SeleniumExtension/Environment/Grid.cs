namespace Six.Test.Selenium.Environment
{
    public static class Grid
    {
        public static string Build
        {
            get { return "http://build:4488/wd/hub"; }
        }

        public static string NoGrid
        {
            get { return string.Empty; }
        }
    }
}