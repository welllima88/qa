using System.Collections.Generic;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Definitions;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Administration.Article
{
    public class ArticleView : WebObject, IArticle
    {
        public IWebElement CancelButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input.button[name='cancel']")); }
        }

        public IWebElement SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input.button[type='submit']")); }
        }

        #region IArticle Members

        public string Name
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#ArticleName")).Text; }
        }

        public bool Status
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#Article_IsActive")).Selected; }
        }

        public string NetType
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#NetType")).Text; }
        }

        public string SbsArticleNumber
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#ArticleSbsNumber")).Text; }
        }

        public string CardReaderType
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#CardReaderType")).Text; }
        }

        public string ContactlessIndicator
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#ContactlessInd")).Text; }
        }

        public string PosInterface
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#PosInterface")).Text; }
        }

        public string Color
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#Color")).Text; }
        }

        public string SoftwareId
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#SoftwareId")).Text; }
        }

        public string TrxSubmLim
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#TrxSubmLim")).Text; }
        }

        public string TrxTransLim
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#TrxTransLim")).Text; }
        }

        public List<string> Supplier
        {
            get
            {
                return
                    WebDriver.WebElementsAsStringList(
                        WebDriver.FindElements(By.CssSelector("td#content form div table.dataTable tbody tr td")));
            }
        }

        public string RecallInterval
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#RecallInterval")).Text; }
        }

        #endregion
    }
}