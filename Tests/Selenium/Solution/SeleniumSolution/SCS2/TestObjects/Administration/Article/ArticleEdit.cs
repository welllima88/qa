using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Definitions;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Administration.Article
{
    internal class ArticleEdit : WebObject, IArticle
    {
        public ArticleEdit(IWebDriverAdapter driver) : base(driver)
        {
        }

        public IWebElement CancelButton
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("input.button[name='cancel']")); }
        }

        public IWebElement SaveButton
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("input.button[value='Speichern']")); }
        }

        #region IArticle Members

        public string Name
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("#Article_Name")).Text; }
            set { Driver.FindAdaptedElement(By.CssSelector("#Article_Name")).TypeText(value); }
        }

        public bool Status
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("#Article_IsActive")).Selected; }
            set { Driver.FindAdaptedElement(By.CssSelector("#Article_IsActive")).SetCheckbox(value); }
        }

        public string TerminalType
        {
            get
            {
                return
                    Driver.FindAdaptedElement(By.CssSelector("#Article_TerminalTypeId")).Selector().SelectedOption.Text;
            }
            set { Driver.FindAdaptedElement(By.CssSelector("#Article_TerminalTypeId")).Selector().SelectByText(value); }
        }

        public string NetType
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("#Article_NetType")).Selector().SelectedOption.Text; }
            set { Driver.FindAdaptedElement(By.CssSelector("#Article_NetType")).Selector().SelectByText(value); }
        }

        public string SbsArticleNumber
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("#Article_SapTemplateId")).Text; }
            set { Driver.FindAdaptedElement(By.CssSelector("#Article_SapTemplateId")).TypeText(value); }
        }

        public List<string> Supplier
        {
            get
            {
                return
                    Driver.WebElementsAsStringList(
                        Driver.FindElements(By.CssSelector("td#content form div table.dataTable tbody tr td")));
            }
            set { throw new NotSupportedException("Just a List is displayed in Article-VIEW"); } //NO HTMLID
        }

        #endregion
    }
}