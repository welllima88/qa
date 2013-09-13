using System;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Terminal
{
    //STEP 1
    public class TerminalConfigCreate : WebObject
    {
        public String Status
        {
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector("#ctl00_bodyContentPlaceHolder_terminalAttribute_ddTerminalStatus")).Selector().
                          SelectByText(value);
            }
        }

        public String Infotext
        {
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector("#ctl00_bodyContentPlaceHolder_terminalAttribute_inpTerminalInfoText"))
                         .TypeText(value);
            }
        }

        public String TerminalType
        {
            get
            {
                return WebDriver.FindElement(
                    By.CssSelector(
                        "span#ctl00_bodyContentPlaceHolder_terminalAttribute_lblTerminalTypeValue>span")).Text;
            }
        }

        public String Protocol
        {
            get
            {
                return WebDriver.FindElement(
                    By.CssSelector(
                        "span#ctl00_bodyContentPlaceHolder_terminalAttribute_lblRefSystemValue>span")).Text;
            }
        }

        public String NetType
        {
            get
            {
                return WebDriver.FindElement(
                    By.CssSelector(
                        "span#ctl00_bodyContentPlaceHolder_terminalAttribute_lblNetTypeValue>span")).Text;
            }
        }

        public String CreateDateTime
        {
            get
            {
                return WebDriver.FindElement(
                    By.CssSelector("#ctl00_bodyContentPlaceHolder_terminalAttribute_dtpCreateDate")).Text;
            }
        }

        public String ServiceCenter
        {
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector("#ctl00_bodyContentPlaceHolder_terminalAttribute_ddNewServiceCenter")).Selector().
                          SelectByText(value);
            }
        }

        public String Pms
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_terminalAttribute_ddNewPMS"))
                         .
                          Selector().SelectByText(value);
            }
        }

        public string SubStatus
        {
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector("#ctl00_bodyContentPlaceHolder_terminalAttribute_ddTerminalSubStatus")).Selector().
                          SelectByText(value);
            }
        }

        public IWebElement ContinueButton
        {
            get { return WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_wzNewTerminalNextButton")); }
        }

        public IWebElement SaveButton
        {
            get { return WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_wzNewTerminalFinishButton")); }
        }
    }
}