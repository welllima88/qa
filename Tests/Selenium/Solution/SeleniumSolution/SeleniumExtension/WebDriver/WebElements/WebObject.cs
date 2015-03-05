using OpenQA.Selenium;

namespace Six.QA.Selenium.Extension.WebDriver.WebElements
{
    /// <summary>
    ///     This abstract WebObject bundles features for all test objects, like WebDriver Reference and locator information
    /// </summary>
    public abstract class WebObject : IWebObject
    {
        protected string Prefix = "";
        protected string Suffix = "";

        public By Locator { get; set; }

        /// <summary>
        ///     provides a public WebDriver reference for global use (should be set initially and externally)
        /// </summary>
        public static IWebDriverAdapter WebDriver { get; set; }
    }
}