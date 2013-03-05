﻿using System;

namespace SIX.SCS.QA.Selenium.Extension
{
    public class NotCheckableElementException : Exception
    {
        private readonly string _getCssValue;
        private readonly string _tagName;

        public NotCheckableElementException(string tagName, string getCssValue)
        {
            _tagName = tagName;
            _getCssValue = getCssValue;
        }

        public override string Message
        {
            get { return _tagName + _getCssValue; }
        }
    }
}