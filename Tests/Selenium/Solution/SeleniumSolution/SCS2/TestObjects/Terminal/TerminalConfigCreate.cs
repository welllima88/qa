using System;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal
{
    //STEP 1
    public class TerminalConfigCreate : WebObject
    {
        public TerminalConfigCreate(IWebDriverAdapter driver) : base(driver)
        {
        }

        public String Status
        {
            set
            {
                Driver.FindAdaptedElement(
                    By.CssSelector("#ctl00_bodyContentPlaceHolder_terminalAttribute_ddTerminalStatus")).Selector().
                    SelectByText(value);
            }
        }

        public String Infotext
        {
            set
            {
                Driver.FindAdaptedElement(
                    By.CssSelector("#ctl00_bodyContentPlaceHolder_terminalAttribute_inpTerminalInfoText"))
                    .TypeText(value);
            }
        }

        public String TerminalType
        {
            get
            {
                return Driver.FindElement(
                    By.CssSelector(
                        "span#ctl00_bodyContentPlaceHolder_terminalAttribute_lblTerminalTypeValue>span")).Text;
            }
        }

        public String Protocol
        {
            get
            {
                return Driver.FindElement(
                    By.CssSelector(
                        "span#ctl00_bodyContentPlaceHolder_terminalAttribute_lblRefSystemValue>span")).Text;
            }
        }

        public String NetType
        {
            get
            {
                return Driver.FindElement(
                    By.CssSelector(
                        "span#ctl00_bodyContentPlaceHolder_terminalAttribute_lblNetTypeValue>span")).Text;
            }
        }

        public String CreateDateTime
        {
            get
            {
                return Driver.FindElement(
                    By.CssSelector("#ctl00_bodyContentPlaceHolder_terminalAttribute_dtpCreateDate")).Text;
            }
        }

        public String ServiceCenter
        {
            set
            {
                Driver.FindAdaptedElement(
                    By.CssSelector("#ctl00_bodyContentPlaceHolder_terminalAttribute_ddNewServiceCenter")).Selector().
                    SelectByText(value);
            }
        }

        public String Pms
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_terminalAttribute_ddNewPMS")).
                    Selector().SelectByText(value);
            }
        }

        public string SubStatus
        {
            set
            {
                Driver.FindAdaptedElement(
                    By.CssSelector("#ctl00_bodyContentPlaceHolder_terminalAttribute_ddTerminalSubStatus")).Selector().
                    SelectByText(value);
            }
        }

        public IWebElement ContinueButton
        {
            get { return Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_wzNewTerminalNextButton")); }
        }

        public IWebElement SaveButton
        {
            get { return Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_wzNewTerminalFinishButton")); }
        }
    }
}