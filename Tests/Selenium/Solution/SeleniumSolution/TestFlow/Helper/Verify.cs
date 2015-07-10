﻿using System;
using System.Collections.Generic;
using NUnit.Framework;
using Six.Scs.Test.Workflow.Helper;

// http://stackoverflow.com/questions/2834717/nunit-is-it-possible-to-continue-executing-test-after-assert-fails

namespace Six.Scs.Test.Helper
{
    public class Verify : ICheck
    {
        /// <summary>
        ///     provides access to all exceptions which have occured
        /// </summary>
        private static List<Exception> Exceptions = new List<Exception>();

        private readonly Action[] _verify;

        private Verify(Action[] verify)
        {
            _verify = verify;
        }

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
            return Exceptions.Count > 0;
        }

        private void VerifyAll(params Action[] assertions)
        {
            if (assertions == null) return;
            Exceptions = new List<Exception>();

            foreach (var assertion in assertions)
                try
                {
                    assertion();
                }
                catch (Exception ex)
                {
                    Exceptions.Add(ex);
                    Console.Error.WriteLine("Message:\n{0}\nStacktrace:\n{1}", ex.Message, ex.StackTrace);
                }
        }

        public static void WriteErrors()
        {
            if (!ErrorOccured()) return;
            Console.Error.WriteLine("---ERROR---SUMMARY---START---");
            foreach (var exception in Exceptions)
            {
                Console.Error.WriteLine("Message: {0} Source:{1}", exception.Message, exception.StackTrace);
            }
            Console.Error.WriteLine("---ERROR---SUMMARY---END----");
            throw new AssertionException(string.Format("{0} verifies failed during testing", Exceptions.Count));
        }
    }
}