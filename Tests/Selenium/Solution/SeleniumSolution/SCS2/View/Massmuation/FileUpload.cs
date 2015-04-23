using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.View.Massmuation
{
    public class FileUpload : WebObject

    {
        public static string Title
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#content>h1")).Text; }
        }

        public static string Description
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#content form>p")).Text; }
        }

        public static IWebElementAdapter FileChooser
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#content input[name='batchfile']")); }
        }

        public static IWebElementAdapter FileUploadButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("button#upload")); }
        }

        public static string DownloadTemplate
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#content form div a[href$='/Download']"))
                        .Text;
            }
        }
    }
}