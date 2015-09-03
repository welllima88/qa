namespace Six.Scs.Test.Workflow.Ticket
{
    public class Process
    {
        public static void Activate()
        {
            UI.Terminal.Dashboard.Portlets.Brand.BrandPortlet.ExpandAll();
            UI.Terminal.Dashboard.Portlets.Brand.BrandPortlet.Acquirer("acq_multipay").EditLink();

        }
    }
}