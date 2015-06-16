using System;
using System.Collections.Generic;
using NUnit.Framework;
using Six.Scs.Test.Workflow.Helper;

// http://stackoverflow.com/questions/2834717/nunit-is-it-possible-to-continue-executing-test-after-assert-fails

namespace Six.Scs.Test.Helper
{
    public class Verify : ICheck
    {
        private readonly Action[] _verify;

        private Verify(Action[] verify)
        {
            _verify = verify;
        }

        /// <summary>
        ///     provides access to all exceptions which have occured
        /// </summary>
        public static List<Exception> Errors { get; private set; }

        public void Check()
        {
            VerifyAll(_verify);
        }

        /// <summary>
        ///     The given actions allow continues exection without stopping on any error
        /// </summary>
        /// <param name="assertions">actions which should be assertions/checks</param>
        /// <returns></returns>
        public static Verify With(Action[] assertions)
        {
            return new Verify(assertions);
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

        public static void WriteErrors()
        {
            if (!ErrorOccured()) return;
            foreach (var error in Errors)
            {
                Console.Error.WriteLine("Message: {0}\t-\tStacktrace: {1}", error.Message, error.StackTrace);
            }
            throw new AssertionException(string.Format("{0} verifies have failed during testing", Errors.Count));
        }
    }
}