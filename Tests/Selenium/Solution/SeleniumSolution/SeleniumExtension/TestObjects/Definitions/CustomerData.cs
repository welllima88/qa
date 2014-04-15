namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Definitions
{
    public class CustomerData : IEntity
    {
        public LocationData Location { get; set; }
        public string CustomerName { get; set; }
        public string Supplier { get; set; }
        public string CustomerNumber { get; set; }
        public string SbsCurrency { get; set; }
        public string SbsBillingTenant { get; set; }
        public string CashIntegrator { get; set; }
        public string CategoryCode { get; set; }
        public string Agency { get; set; }
        public string SupportContract { get; set; }
        public string Segment { get; set; }        
    }
}