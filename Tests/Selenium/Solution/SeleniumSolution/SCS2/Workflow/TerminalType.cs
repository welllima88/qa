using Six.Scs.Test.UI.Administration.TerminalType;

namespace Six.Scs.Test.Workflow
{
    public static class TerminalType
    {
        public static void Edit(Model.TerminalType terminalType)
        {
            View.EditButton.Click();

            UI.Administration.TerminalType.Edit.Supplier = terminalType.Supplier;
            UI.Administration.TerminalType.Edit.ReferenceSystem = terminalType.ReferenceSystem;
            UI.Administration.TerminalType.Edit.DeviceType = terminalType.DeviceType;
            UI.Administration.TerminalType.Edit.DefaultCapabilities = terminalType.DefaultCapabilities;
            UI.Administration.TerminalType.Edit.DefaultAdditionalCapabilities =
                terminalType.DefaultAdditionalCapabilities;
            // page is BUGGY
            // SetProviders(terminalType.Providers);
            // SetSuppliers(terminalType.Suppliers);
            UI.Administration.TerminalType.Edit.SaveButton.Click();
        }
    }
}