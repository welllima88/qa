using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Terminal.Dashboard.Portlets.TroubleTicket
{
    public class Priority : WebObject
    {
        private void SetPriority(string priority)
        {
            WebDriver.FindAdaptedElement(
                By.CssSelector(string.Format("form#troubleTicketForm input#Prio[value='{0}']", priority)))
                .Click();
        }

        public void High()
        {
            // form#troubleTicketForm input#Prio[value='High']
            SetPriority("High");
        }

        public void Low()
        {
            SetPriority("Low");
        }

        public void Normal()
        {
            SetPriority("Normal");
        }
    }
}