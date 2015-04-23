using Six.Scs.QA.Selenium.Model.ValueObjects;

namespace Six.Scs.QA.Selenium.Model.Factory
{
    public class Ticket
    {
        public static TroubleTicket TroubleTicket()
        {
            return new TroubleTicket
            {
                MyTeam = "Kundendienst",
                Forward = "Werkstatt",
                Contact = "SYR",
                AvailableTime = "",
                Phone = "+31 - 58 399 6237",
                Fax = "+33 - 58 399 6237",
                Email = "marc.siegmund@six-group.proof",
                Mobile = "+32 - 58 399 6237",
                Category = "Probleme Display",
                Solutions = new[] {"", ""},
                Description = "SYR Trouble Ticket" + Factory.GenerateTestId(),
                ExternReferenceId = Factory.GenerateTestId()
            };
        }
    }
}