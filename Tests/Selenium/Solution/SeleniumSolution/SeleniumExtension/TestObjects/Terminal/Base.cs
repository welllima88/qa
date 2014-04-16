using System;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal
{
    public class Base : WebObject
    {
        public IWebElement BaseDataTab
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(
                            "span#ctl00_bodyContentPlaceHolder_tbcTerminalData td.tab[textContent='Basisdaten']"));
            }
        }

        public String Infotext
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(
                            "#ctl00_bodyContentPlaceHolder_tbcTerminalData_TerminalAttribute_hplTerminalInfoText")).
                        Text;
            }
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector("#ctl00_bodyContentPlaceHolder_tbcTerminalData_TerminalAttribute_inpTerminalInfoText"))
                    .TextBox()
                    .TypeText(value);
            }
        }

        public String Status
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.XPath(
                            "//span[@id='ctl00_bodyContentPlaceHolder_tbcTerminalData_TerminalAttribute_lblStatusViewValue']/span"))
                        .Text;
            }
        }

        public String ArticleName
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(
                            "#ctl00_bodyContentPlaceHolder_tbcTerminalData_TerminalAttribute_lblArticleDisplayName > span"))
                        .Text;
            }
        }

        public String TerminalType
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(
                            "#ctl00_bodyContentPlaceHolder_tbcTerminalData_TerminalAttribute_lblTerminalTypeValue > span"))
                        .Text;
            }
        }

        public String ReferenceSystem
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(
                            "#ctl00_bodyContentPlaceHolder_tbcTerminalData_TerminalAttribute_lblRefSystemValue > span"))
                        .Text;
            }
        }

        public String NetType
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.XPath(
                            "//span[@id='ctl00_bodyContentPlaceHolder_tbcTerminalData_TerminalAttribute_lblNetTypeValue']/span"))
                        .Text;
            }
        }

        public String CreateDate
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector("#ctl00_bodyContentPlaceHolder_tbcTerminalData_TerminalAttribute_dtpCreateDate"))
                        .Text;
            }
        }

        public String ServiceCenter
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(
                            "#ctl00_bodyContentPlaceHolder_tbcTerminalData_TerminalAttribute_rptServiceCenter_ctl00_hplName"))
                        .Text;
            }
        }

        public String Pms
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(
                            "#ctl00_bodyContentPlaceHolder_tbcTerminalData_TerminalAttribute_rptPMS_ctl00_hplName")).
                        Text;
            }
        }

        public IWebElement EditServiceCenter
        {
            get
            {
                return WebDriver.FindElement(
                    By.CssSelector(
                        "#ctl00_bodyContentPlaceHolder_tbcTerminalData_TerminalAttribute_rptServiceCenter_ctl00_tblSCItem > tbody > tr > td"));
            }
        }

        public IWebElement EditPms
        {
            get
            {
                return WebDriver.FindElement(
                    By.CssSelector(
                        "#ctl00_bodyContentPlaceHolder_tbcTerminalData_TerminalAttribute_rptPMS_ctl00_hplName"));
            }
        }

        public IWebElement DeleteServiceCenter
        {
            get
            {
                return WebDriver.FindElement(
                    By.CssSelector(
                        "##ctl00_bodyContentPlaceHolder_tbcTerminalData_TerminalAttribute_rptServiceCenter_ctl00_imbDelete"));
            }
        }

        public IWebElement DeletePms
        {
            get
            {
                return WebDriver.FindElement(
                    By.CssSelector(
                        "#ctl00_bodyContentPlaceHolder_tbcTerminalData_TerminalAttribute_rptPMS_ctl00_hplName"));
            }
        }
    }
}