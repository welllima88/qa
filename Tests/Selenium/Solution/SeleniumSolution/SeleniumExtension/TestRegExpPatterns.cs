using System.Text.RegularExpressions;

namespace Six.Scs.QA.Selenium.Extension
{
    /// <summary>
    ///     add @ to double escape the patterns for regular expressions
    ///     compile error of any Regex will cause exception in general because of static declaration
    ///     http://msdn.microsoft.com/en-us/library/s1wwdcbf
    ///     http://stackoverflow.com/questions/1473506/error-parsing-regex-pattern
    /// </summary>
    public static class TestRegExpPatterns
    {
        public static readonly Regex WesHeadline = new Regex(@"^SIX [\s\S]* - WES.*");

        public static readonly Regex CustomerNo = new Regex("[0-9]{1,7}");
        public static readonly Regex SbsAdressNo = new Regex("[0-9]{1,7}");
        public static readonly Regex SbsAdressNoOpt = new Regex("[0-9]{1,7}|");
        public static readonly Regex SbsDebitorNo = new Regex("[0-9]{1,7}");
        public static readonly Regex Ep2MerchantId = new Regex("[a-zA-Z0-9]{0,7}[0-9]{0,8}");
        public static readonly Regex Guid = new Regex(@"[\w]{8}-[\w]{4}-[\w]{4}-[\w]{4}-[\w]{12}");
        public static readonly Regex Date = new Regex("[0-9]{2}.[0-9]{2}.[0-9]{4}");
        public static readonly Regex Time = new Regex("[0-9]{2}:[0-9]{2}:[0-9]{2}");
        public static readonly Regex DateTime = new Regex(Date + " " + Time);
        public static readonly Regex TerminalPassword = new Regex("[0-9]{5,8}");
        public static readonly Regex UserName = new Regex(@"\w{5}");
        public static readonly Regex NotEmpty = new Regex(@"\w");
        public static readonly Regex UserPassword = new Regex(@"[\w]{4,10}|");
    }
}