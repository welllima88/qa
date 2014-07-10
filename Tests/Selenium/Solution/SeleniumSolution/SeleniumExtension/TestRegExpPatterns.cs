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
        public static readonly string WesHeadline = @"^SIX [\s\S]* - WES.*";

        public const string CustomerNo = "[0-9]{1,7}";
        public const string SbsAdressNo = "[0-9]{1,7}";
        public const string SbsAdressNoOpt = "[0-9]{1,7}|";
        public const string SbsDebitorNo = "[0-9]{1,7}";
        public const string Ep2MerchantId = "[a-zA-Z0-9]{0,7}[0-9]{0,8}";
        public const string Guid = @"[\w]{8}-[\w]{4}-[\w]{4}-[\w]{4}-[\w]{12}";
        public const string Date = "[0-9]{2}.[0-9]{2}.[0-9]{4}";
        public const string Time = "[0-9]{2}:[0-9]{2}:[0-9]{2}";
        public const string DateTime = Date + " " + Time;
        public const string TerminalPassword = "[0-9]{5,8}";
        public const string UserName = @"\w{5}";
        public const string NotEmpty = @"\w";
        public const string UserPassword = @"[\w]{4,10}|";
    }
}