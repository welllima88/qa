﻿using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.SearchResult
{
    internal class LocationResult : AbstractSearchResult
    {
        public LocationResult(IWebDriverAdapter driver)
            : base(driver)
        {
            Prefix = "div#locationDiv.container ";
        }
    }
}