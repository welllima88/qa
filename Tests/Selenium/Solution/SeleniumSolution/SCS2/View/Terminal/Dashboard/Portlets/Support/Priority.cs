using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Application.View.Terminal.Dashboard.Portlets.Support
{
    public class Priority : WebObject
    {
        private void SetPriority(string priority)
        {
            string loc = string.Format("div#priorityButtons label[title='{0}']", priority);

            WebDriver.FindAdaptedElement(
                By.CssSelector(loc))
                .Click();
        }

        public void High()
        {
            // form#troubleTicketForm input#Prio[value='High']
            SetPriority("Hohe Prio");
        }

        public void Low()
        {
            SetPriority("Tiefe Prio");
        }

        public void Normal()
        {
            SetPriority("Prio zurücks.");
        }
    }
}