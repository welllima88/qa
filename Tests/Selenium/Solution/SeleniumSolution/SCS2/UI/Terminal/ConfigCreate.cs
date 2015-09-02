using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.UI.Terminal
{
    //STEP 1
    public class ConfigCreate : WebObject
    {
        public static string Status
        {
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector("#ctl00_bodyContentPlaceHolder_terminalAttribute_ddTerminalStatus")).Selector().
                    SelectByText(value);
            }
        }

        public static string Infotext
        {
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector("#ctl00_bodyContentPlaceHolder_terminalAttribute_inpTerminalInfoText"))
                    .TextArea().TypeText(value);
            }
        }

        public static string TerminalType
        {
            get
            {
                return WebDriver.FindAdaptedElement(
                    By.CssSelector(
                        "span#ctl00_bodyContentPlaceHolder_terminalAttribute_lblTerminalTypeValue>span")).Text;
            }
        }

        public static string Protocol
        {
            get
            {
                return WebDriver.FindAdaptedElement(
                    By.CssSelector(
                        "span#ctl00_bodyContentPlaceHolder_terminalAttribute_lblRefSystemValue>span")).Text;
            }
        }

        public static string NetType
        {
            get
            {
                return WebDriver.FindAdaptedElement(
                    By.CssSelector(
                        "span#ctl00_bodyContentPlaceHolder_terminalAttribute_lblNetTypeValue>span")).Text;
            }
        }

        public static string CreateDateTime
        {
            get
            {
                return WebDriver.FindAdaptedElement(
                    By.CssSelector("#ctl00_bodyContentPlaceHolder_terminalAttribute_dtpCreateDate")).Text;
            }
        }

        public static string ServiceCenter
        {
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector("#ctl00_bodyContentPlaceHolder_terminalAttribute_ddNewServiceCenter")).Selector().
                    SelectByText(value);
            }
        }

        public static string Pms
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_terminalAttribute_ddNewPMS"))
                    .
                    Selector().SelectByText(value);
            }
        }

        public static string SubStatus
        {
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector("#ctl00_bodyContentPlaceHolder_terminalAttribute_ddTerminalSubStatus")).Selector().
                    SelectByText(value);
            }
        }

        public static void Save()
        {
            WebDriver.FindAdaptedElement(
                By.CssSelector("#ctl00_bodyContentPlaceHolder_wzNewTerminalFinishButton")).Click();
        }

        public static void Continue()
        {
            WebDriver.FindAdaptedElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_wzNewTerminalNextButton"))
                .Click();
        }
    }
}