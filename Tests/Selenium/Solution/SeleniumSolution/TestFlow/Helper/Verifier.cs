using System;
using System.Collections.Generic;
using Six.Scs.Test.Workflow.Helper;

// http://stackoverflow.com/questions/2834717/nunit-is-it-possible-to-continue-executing-test-after-assert-fails

namespace Six.Scs.Test.Helper
{
    public class Verifier : ICheck
    {
        private Action[] Verify;

        public Verifier(Action[] verify)
        {
            Verify = verify;
        }

        public static List<Exception> Errors { get; private set; }

        public void Check()
        {
            VerifyAll(Verify);
        }

        private void AssertAll(Action[] assertions)
        {
            if (assertions == null) throw new NullReferenceException("no assertions to verify");
            foreach (var assertion in assertions) assertion();
        }

        public static bool ErrorOccured()
        {
            return Errors.Count > 0;
        }

        private void VerifyAll(params Action[] assertions)
        {
            if (assertions == null) throw new NullReferenceException("no assertions to verify");
            Errors = new List<Exception>();

            foreach (var assertion in assertions)
                try
                {
                    assertion();
                }
                catch (Exception ex)
                {
                    Errors.Add(ex);
                }
        }
    }
}