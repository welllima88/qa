using System.Text.RegularExpressions;

namespace SIX.SCS.QA.Selenium.Extension
{
    /// <summary>
    ///     add @ to double escape the patterns for regular expressions
    ///     compile error of any Regex will cause exception in general because of static declaration
    ///     http://msdn.microsoft.com/en-us/library/s1wwdcbf
    ///     http://stackoverflow.com/questions/1473506/error-parsing-regex-pattern
    /// </summary>
    public static class TestRegExpPatterns
    {
        public static Regex ZebraTitle = new Regex(@"^Lobby[\s\S]*Service Center System$");
        public static Regex ZebraUrl = new Regex(@"^https://[\s\S]*zebra[\s\S]*/[dD]efault\.aspx$");
        public static Regex WesHeadLine = new Regex(@"^SIX [\s\S]* - WES.*");

        public static Regex WesLogoutInfo =
            new Regex(@"Sie haben sich erfolgreich abgemeldet\.\r\nBitte schliessen Sie jetzt Ihren Browser!");

        public static Regex CustomerNo = new Regex("[0-9]{1,7}");
        public static Regex SbsAdressNo = new Regex("[0-9]{1,7}");
        public static Regex SbsAdressNoOpt = new Regex("[0-9]{1,7}|");
        public static Regex SbsDebitorNo = new Regex("[0-9]{1,7}");
        public static Regex Ep2MerchantId = new Regex("[a-zA-Z0-9]{0,7}[0-9]{0,8}");
        public static Regex Guid = new Regex(@"[\w]{8}-[\w]{4}-[\w]{4}-[\w]{4}-[\w]{12}");
        public static Regex Date = new Regex("[0-9]{2}.[0-9]{2}.[0-9]{4}");
        public static Regex Time = new Regex("[0-9]{2}:[0-9]{2}:[0-9]{2}");
        public static Regex DateTime = new Regex(Date + " " + Time);
        public static Regex TerminalPassword = new Regex("[0-9]{5,8}");
        public static Regex WesInputLabelLogout = new Regex("Logout");
        public static Regex WesInputLabelLogin = new Regex("WES SecurID-Login");
        public static Regex UserName = new Regex(@"\w{5}");
    }

    public static class TestConstances
    {
        public static string QaLSuffix = "qa-l";
        public static string QaKSuffix = "qa-k";
        public static string ProdSuffix = "";
        public static string ZebraPrefix = "zebra";
        public static string ScsPrefix = "scs";
    }
}