using Six.Scs.QA.Selenium.Terminal.Dashboard.Portlets.TroubleTicket;
using Six.Scs.QA.TestData.ValueObjects;

namespace Six.Scs.QA.Workflow
{
    public class Trouble
    {
        public static void Create(TroubleTicket trouble)
        {
            TroubleTickets.New.Click();

            TroubleTickets.MyTeam = trouble.MyTeam;
            TroubleTickets.Forward = trouble.Forward;
            TroubleTickets.Contact = trouble.Contact;
            TroubleTickets.AvailableTime = trouble.AvailableTime;
            TroubleTickets.Phone = trouble.Phone;
            TroubleTickets.Fax = trouble.Fax;
            TroubleTickets.Email = trouble.Email;
            TroubleTickets.Mobile = trouble.Mobile;
            TroubleTickets.Category = trouble.Category;
            TroubleTickets.Solution = trouble.Solution;
            TroubleTickets.Priority.High();
            TroubleTickets.Priority.Low();
            TroubleTickets.Priority.Normal();

            TroubleTickets.Description = trouble.Description;

            TroubleTickets.Save.Click();
            TroubleTickets.SaveAndClose.Click();
        }
    }
}