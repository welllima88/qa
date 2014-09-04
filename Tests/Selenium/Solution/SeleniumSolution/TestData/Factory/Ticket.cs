using Six.Scs.QA.TestData.ValueObjects;

namespace Six.Scs.QA.TestData.Factory
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
                Category = "",
                Solution = "",
                Description = "SYR Trouble Ticket" + Factory.GenerateTestId()
            };
        }
    }
}