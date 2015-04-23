using System.Collections.Generic;

namespace Six.Scs.QA.Selenium.Model.ValueObjects
{
    public class TroubleTicket
    {
        public string MyTeam { get; set; }
        public string Forward { get; set; }
        public string Contact { get; set; }
        public string AvailableTime { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Category { get; set; }
        public IEnumerable<string> Solutions { get; set; }
        public string Description { get; set; }
        public string ExternReferenceId { get; set; }
        public string Id { get; set; }
    }
}