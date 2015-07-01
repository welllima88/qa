using OpenQA.Selenium;

namespace Six.Test.Selenium.WebDriver.WebElements
{
    /// <summary>
    ///     This abstract WebObject bundles features for all test objects, like WebDriver Reference and locator information
    /// </summary>
    public abstract class WebObject : IWebObject
    {
        protected static string Prefix = "";
        protected static string Suffix = "";
        public By Locator { get; set; }

        /// <summary>
        ///     provides a public WebDriver reference for global use (should be set initially and externally)
        /// </summary>
        public static IWebDriver WebDriver { get; set; }
    }
}