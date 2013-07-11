using System.Collections.Generic;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Definitions;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Administration.Article
{
    internal class ArticleView : WebObject, IArticle
    {
        public ArticleView(IWebDriverAdapter driver) : base(driver)
        {
        }

        public IWebElement CancelButton
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("input.button[name='cancel']")); }
        }

        public IWebElement SaveButton
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("input.button[type='submit']")); }
        }

        #region IArticle Members

        public string Name
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("#ArticleName")).Text; }
        }

        public bool Status
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("input#Article_IsActive")).Selected; }
        }

        public string NetType
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("#NetType")).Text; }
        }

        public string SbsArticleNumber
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("#ArticleSbsNumber")).Text; }
        }


        public string CardReaderType
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("#CardReaderType")).Text; }
        }

        public string ContactlessIndicator
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("#ContactlessInd")).Text; }
        }

        public string PosInterface
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("#PosInterface")).Text; }
        }

        public string Color
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("#Color")).Text; }
        }

        public string SoftwareId
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("#SoftwareId")).Text; }
        }

        public string TrxSubmLim
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("#TrxSubmLim")).Text; }
        }

        public string TrxTransLim
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("#TrxTransLim")).Text; }
        }

        public List<string> Supplier
        {
            get
            {
                return
                    Driver.WebElementsAsStringList(
                        Driver.FindElements(By.CssSelector("td#content form div table.dataTable tbody tr td")));
            }
        }

        public string RecallInterval
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("#RecallInterval")).Text; }
        }

        #endregion
    }
}