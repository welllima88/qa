using System;
using Six.Scs.QA.Selenium.Model.ValueObjects;
using Six.Scs.QA.Selenium.View.Terminal.Dashboard.Portlets.Support;

namespace Six.Scs.QA.Selenium.Workflow
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
            throw new NotImplementedException();
        }
    }
}