namespace Six.Scs.Test.Workflow
{
    public static class TerminalType
    {
        public static void Edit(Model.ValueObjects.TerminalType terminalType)
        {
            View.Administration.TerminalType.View.EditButton.Click();

            View.Administration.TerminalType.Edit.Supplier = terminalType.Supplier;
            View.Administration.TerminalType.Edit.ReferenceSystem = terminalType.ReferenceSystem;
            View.Administration.TerminalType.Edit.DeviceType = terminalType.DeviceType;
            View.Administration.TerminalType.Edit.DefaultCapabilities = terminalType.DefaultCapabilities;
            View.Administration.TerminalType.Edit.DefaultAdditionalCapabilities =
                terminalType.DefaultAdditionalCapabilities;
            // page is BUGGY
            // SetProviders(terminalType.Providers);
            // SetSuppliers(terminalType.Suppliers);
            View.Administration.TerminalType.Edit.SaveButton.Click();
        }
    }
}