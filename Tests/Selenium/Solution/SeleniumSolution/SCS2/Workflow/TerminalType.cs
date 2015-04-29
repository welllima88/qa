using System.Collections.Generic;
using System.Linq;

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
            SetProviders(terminalType.Providers);
            SetSuppliers(terminalType.Suppliers);

            // View.Administration.TerminalType.Edit.SaveButton.Click();
        }

        private static void SetSuppliers(IEnumerable<string> suppliers)
        {
            var needed = suppliers.Intersect(View.Administration.TerminalType.Edit.AvailableSuppliers);
            View.Administration.TerminalType.Edit.AvailableSuppliers = needed;

            var not_needed = suppliers.Where(s => !View.Administration.TerminalType.Edit.SelectedSuppliers.Contains(s));
            View.Administration.TerminalType.Edit.SelectedSuppliers = not_needed;
        }

        private static void SetProviders(IEnumerable<string> providers)
        {
            var needed = View.Administration.TerminalType.Edit.AvailableProviders.Intersect(providers);
            View.Administration.TerminalType.Edit.AvailableProviders = needed;

            var not_needed = providers.Where(s => !View.Administration.TerminalType.Edit.SelectedProviders.Contains(s));
            View.Administration.TerminalType.Edit.SelectedProviders = not_needed;
        }
    }
}