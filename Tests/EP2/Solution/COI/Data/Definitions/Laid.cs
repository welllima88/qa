using System.Collections;
using System.Collections.ObjectModel;

namespace SIX.SCS.QA.Tests.EP2.Data.Definitions
{
    public static class Laid
    {
        public static IEnumerable Six()
        {
            return new Collection<string>
            {
                "oAAAAVdEYA==",
                "oAAAAVIwEA==",
                "oAAAAVdEQw==",
                "oAAAAYhEQw==",
                "oAAAAAQQEA==",
                "oAAAAVcAIA==",
                "oAAAABAQMA==",
                "oAAAAVcAIg==",
                "oAAAAVdEUQ==",
                "oAAAAGUQEA==",
                "oAAAAVcAQA==",
                "oAAAAAQwYA==",
                "oAAAAVcAIQ==",
                "oAAAAAMQEA==",
                "oAAAAAMgEA==",
                "oAAAAVcAMA==",
                "oAAAAVcAMQ==",
                "oAAAAAMgIA==",
                "oAAAAVdEUg=="
            };
        }

        public static IEnumerable Swisscard()
        {
            return new Collection<string>
            {
                "oAAAACUB",
                "oAAAACUBAQQ=",
                "oAAAACUBBAI=",
                "oAAAAVcAEA=="
            };
        }
    }
}