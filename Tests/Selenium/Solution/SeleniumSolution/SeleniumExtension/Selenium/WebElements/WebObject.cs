namespace SIX.SCS.QA.Selenium.Extension.Selenium.WebElements
{
    /// <summary>
    ///     This abstract WebObject bundles features for all test objects, like WebDriver Reference and locator information
    /// </summary>
    public abstract class WebObject : IWebObject
    {
        protected string Prefix = "";
        protected string Suffix = "";

        /// <summary>
        ///     This abstract class of an WebObject defines the essential constructor for initializing the WebDriver reference.
        ///     It is also used for adding features to all test objects
        /// </summary>
        /// <param name="driver"></param>
        protected WebObject(IWebDriverAdapter driver)
        {
            WebDriver = driver;
        }

        protected WebObject()
        {
        }

        // /// <summary>
        // /// override the default constructor to prevent initializing without a WebDriver reference
        // /// </summary>
        // private WebObject()
        //{
        //   throw new NotSupportedException("The default constructor is not allowed to be used to avoid missing webdriver reference");
        //}

        /// <summary>
        ///     overrides the acessor for this public WebDriver reference, so that the constructor can set (internally usually by the constructor)
        /// </summary>
        public static IWebDriverAdapter WebDriver { get; set; }
    }
}