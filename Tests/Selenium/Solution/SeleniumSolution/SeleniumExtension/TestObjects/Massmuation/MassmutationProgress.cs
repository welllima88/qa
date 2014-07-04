using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Extension.TestObjects.Massmuation
{
    public class MassmutationProgress : WebObject
    {
        public static string Failed
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Massmutation_Failed")).Text; }
        }

        public static string Type
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Massmutation_BatchType")).Text; }
        }

        public static string Done
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Massmutation_Done")).Text; }
        }

        public static string Total
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Massmutation_All")).Text; }
        }

        public static bool HasFinished()
        {
            return string.Equals(Total, Done);
        }
    }
}