﻿namespace Six.Scs.QA.Selenium.Extension.Environment
{
    public static class SeleniumGridServer
    {
        public static string OldBuild
        {
            get { return "http://wkbuild03:4488/wd/hub"; }
        }

        public static string Build
        {
            get { return "http://build:4488/wd/hub"; }
        }

        public static string Local
        {
            get { return "http://localhost:4488/wd/hub"; }
        }

        public static string NoGrid
        {
            get { return string.Empty; }
        }
    }
}