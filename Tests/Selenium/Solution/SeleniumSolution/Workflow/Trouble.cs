using Six.Scs.QA.Selenium.Terminal.Dashboard.Portlets.Support;
using Six.Scs.QA.TestData.ValueObjects;

namespace Six.Scs.QA.Workflow
{
    public class Trouble
    {
        public static TroubleTicket Create(TroubleTicket trouble)
        {
            NewTicket(trouble);
            TroubleTickets.Save.Click();
            trouble.Id = TroubleTickets.FetchIdByPopup();
            return trouble;
        }

        private static void NewTicket(TroubleTicket trouble)
        {
            TroubleTickets.New();

            TroubleTickets.MyTeam = trouble.MyTeam;
            TroubleTickets.Forward = trouble.Forward;
            TroubleTickets.Contact = trouble.Contact;
            TroubleTickets.AvailableTime = trouble.AvailableTime;
            TroubleTickets.Phone = trouble.Phone;
            TroubleTickets.Fax = trouble.Fax;
            TroubleTickets.Email = trouble.Email;
            TroubleTickets.Mobile = trouble.Mobile;
            TroubleTickets.Category = trouble.Category;
            TroubleTickets.Solution = trouble.Solutions;
            TroubleTickets.Priority.High();
            TroubleTickets.Priority.Low();
            TroubleTickets.Priority.Normal();

            TroubleTickets.Description = trouble.Description;
            TroubleTickets.ExternReferenceId = trouble.ExternReferenceId;
        }

        public static TroubleTicket CreateAndClose(TroubleTicket trouble)
        {
            NewTicket(trouble);
            TroubleTickets.SaveAndClose.Click();
            trouble.Id = TroubleTickets.FetchIdByPopup();
            return trouble;
        }
    }
}