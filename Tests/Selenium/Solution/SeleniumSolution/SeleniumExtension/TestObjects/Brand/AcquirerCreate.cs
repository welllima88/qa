using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Brand
{
    public class AcquirerCreate : WebObject
    {
        public String SetActivationDate
        {
            get
            {
                return
                    WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_dtpSetupDate")).GetAttribute(
                        "value");
            }
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_dtpSetupDate"))
                         .TextBox().TypeText(value);
            }
            //Check date format at this point? -> NOOO! In test method is right place
            //    Assert.IsTrue(Regex.IsMatch(WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_dtpSetupDate")).GetAttribute("value"), "[0-9]{2}.[0-9]{2}.[0-9]{4}"));
        }

        public String SetRemark
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_inpComment"))
                         .TextBox()
                         .TypeText(value);
            }
        }

        /// <summary>
        ///     Sets for each acquirer, if the message (ticket, COI etc.) should be created or not
        /// </summary>
        /// <param name="acquirer">The name for acquirer e.g. "SIX Payment Services" or "American Express"</param>
        /// <param name="messageToAcquirer">set message should be created and send or not</param>
        public void SetMessageToAcquirer(String acquirer, bool messageToAcquirer)
        {
            //Example: By.XPath("//span/div/label[text()='American Express']/preceding-sibling::input")).
            WebDriver.FindAdaptedElement(By.XPath("//span/div/label[text()='" + acquirer + "']/preceding-sibling::input"))
                     .CheckBox().Set(messageToAcquirer);
        }

        /// <summary>
        ///     Sets for all acquirer, if the message (ticket, COI etc.) should be created or not
        /// </summary>
        /// <param name="messageToAcquirers">set message should be created and send or not</param>
        public void SetMessageToAllAcquirers(bool messageToAcquirers)
        {
            ReadOnlyCollection<IWebElement> acquirers =
                WebDriver.FindElements(By.CssSelector("input[id*='cbxAcquirerMessages'].check"));
            foreach (IWebElementAdapter acquirer in acquirers)
            {
                acquirer.CheckBox().Set(messageToAcquirers);
            }
        }

        public void ConfirmAcquirerData()
        {
            WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_lwpBrandsNextButton")).Click();
        }

        public void SaveAndCreate()
        {
            new ContractCreate().SaveAndCreate();
        }
    }
}