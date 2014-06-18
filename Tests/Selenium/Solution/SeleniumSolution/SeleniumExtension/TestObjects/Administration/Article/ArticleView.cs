using System.Collections.Generic;
using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Extension.TestObjects.Administration.Article
{
    public class ArticleView : WebObject
    {
        public static IWebElement SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input.button[type='submit']")); }
        }

        public static string Name
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#ArticleName")).Text; }
        }

        public static bool Status
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#Article_IsActive")).Selected; }
        }

        public static string NetType
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#NetType")).Text; }
        }

        public static string SbsArticleNumber
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#ArticleSbsNumber")).Text; }
        }

        public static string CardReaderType
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#CardReaderType")).Text; }
        }

        public static string ContactlessIndicator
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#ContactlessInd")).Text; }
        }

        public static string PosInterface
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#PosInterface")).Text; }
        }

        public static string Color
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#Color")).Text; }
        }

        public static string SoftwareId
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#SoftwareId")).Text; }
        }

        public static string TrxSubmLim
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#TrxSubmLim")).Text; }
        }

        public static string TrxTransLim
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#TrxTransLim")).Text; }
        }

        public static List<string> Supplier
        {
            get
            {
                return
                    WebDriver.WebElementsAsStringList(
                        WebDriver.FindElements(By.CssSelector("td#content form div table#tenants.dataTable tbody tr td")));
            }
        }

        public static string RecallInterval
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#RecallInterval")).Text; }
        }
    }
}