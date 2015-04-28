namespace Six.Scs.QA.Application.Model.ValueObjects
{
    public class Customer
    {
        public Location Location { get; set; }
        public string CustomerName { get; set; }
        public string Supplier { get; set; }
        public string CustomerNumber { get; set; }
        public string SbsCurrency { get; set; }
        public string SbsBillingTenant { get; set; }
        public string CashIntegrator { get; set; }
        public string CategoryCode { get; set; }
        public string SupportContract { get; set; }
        public string SbsSegment { get; set; }
        public string WesMandant { get; set; }
    }
}