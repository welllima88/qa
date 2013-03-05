namespace SIX.SCS.QA.Selenium.Extension.TestObjects
{
    /// <summary>
    /// defines interface for a test object
    /// </summary>
    public interface IWebObject
    {
        /// <summary>
        /// a WebDriver reference is necessary for all selenium test objects (initialized by constructor)
        /// </summary>
        IWebDriverAdapter Driver { get; }
    }
}