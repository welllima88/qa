using System;
using NUnit.Framework;
using Six.Scs.Test.Helper;

namespace Six.Scs.Test.Validation
{
    //[TestFixture]
    [Ignore("For experiments only")]
    public class Dummy
    {
        [Test]
        public void Fail()
        {
            Verify.With(new Action[]
            {
                () => Assert.That(false)
            }).Check();
        }
    }
}