using OpenQA.Selenium;
using Six.Scs.Tests.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.Tests.Selenium.Extension.TestObjects.Massmuation
{
    public class MassmuationFileUpload : WebObject

    {
        public static string Title
        {
            get
            {
                return WebDriver.FindElement(By.CssSelector("span#ctl00_bodyContentPlaceHolder_lblMainTitle>h1")).Text;
            }
        }

        public static string Description
        {
            get { return WebDriver.FindElement(By.CssSelector("td#content>span>p")).Text; }
        }

        public static IWebElementAdapter FileChooser
        {
            get { return WebDriver.FindAdaptedElement(By.Id("ctl00_bodyContentPlaceHolder_fileUpload")); }
        }

        public static IWebElementAdapter FileUploadButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("ctl00_bodyContentPlaceHolder_btnUpload")); }
        }

        public static string DownloadTemplate
        {
            get { return WebDriver.FindElement(By.Id("ctl00_bodyContentPlaceHolder_lbDownload")).Text; }
        }
    }
}