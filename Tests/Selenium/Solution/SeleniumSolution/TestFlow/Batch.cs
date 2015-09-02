using NUnit.Framework;
using Six.Scs.Test.Helper;
using Six.Scs.Test.View.Massmuation;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test
{
    public static class Batch
    {
        public static void WaitForBatchHasFinished()
        {
            var tries = new Try(33);
            while (!Progress.HasFinished() && tries.Again())
            {
                TestDirector.Refresh();
            }
            if (tries.TooOften())
            {
                Assert.Fail("Batch has not been processed probably due to Job Control error. BatchId:{0} JobId:{1}",
                    Progress.BatchId, Progress.JobId);
            }
            Assert.That(Progress.Failed, Is.EqualTo("0")
                , "Terminal duplicate has {0} failed jobs. BatchId:{1} JobId:{2}", Progress.Failed, Progress.BatchId,
                Progress.JobId);
        }
    }
}