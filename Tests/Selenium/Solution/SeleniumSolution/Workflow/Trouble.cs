using Six.Scs.QA.Selenium.Terminal.Dashboard.Portlets.Support;
using Six.Scs.QA.TestData.ValueObjects;

namespace Six.Scs.QA.Workflow
{
    public class Trouble
    {
        public static TroubleTicket Create(TroubleTicket ticket)
        {
            NewTicket(ticket);
            TroubleTickets.Save.Click();
            ticket.Id = TroubleTickets.FetchIdByPopup();
            return ticket;
        }

        private static void NewTicket(TroubleTicket ticket)
        {
            TroubleTickets.New();

            TroubleTickets.MyTeam = ticket.MyTeam;
            TroubleTickets.Forward = ticket.Forward;
            TroubleTickets.Contact = ticket.Contact;
            TroubleTickets.AvailableTime = ticket.AvailableTime;
            TroubleTickets.Phone = ticket.Phone;
            TroubleTickets.Fax = ticket.Fax;
            TroubleTickets.Email = ticket.Email;
            TroubleTickets.Mobile = ticket.Mobile;
            TroubleTickets.Category = ticket.Category;
            TroubleTickets.Solution = ticket.Solutions;
            TroubleTickets.Priority.High();
            TroubleTickets.Priority.Low();
            TroubleTickets.Priority.Normal();

            TroubleTickets.Description = ticket.Description;
            TroubleTickets.ExternReferenceId = ticket.ExternReferenceId;
        }

        public static TroubleTicket CreateAndClose(TroubleTicket trouble)
        {
            NewTicket(trouble);
            TroubleTickets.SaveAndClose.Click();
            trouble.Id = TroubleTickets.FetchIdByPopup();
            return trouble;
        }

        public static void Edit(TroubleTicket ticket)
        {
            throw new System.NotImplementedException();
        }
    }
}