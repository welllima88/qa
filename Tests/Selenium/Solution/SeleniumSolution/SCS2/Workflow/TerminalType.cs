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
            var needed = View.Administration.TerminalType.Edit.AvailableSuppliers.Intersect(suppliers);
            View.Administration.TerminalType.Edit.AvailableSuppliers = needed;

            var not_needed = suppliers.Where(s => !View.Administration.TerminalType.Edit.SelectedSuppliers.Contains(s));
            View.Administration.TerminalType.Edit.SelectedSuppliers = not_needed;
        }

        // BUG: Enumerable problems with intersect and except due to long webdriver execution
        private static void SetProviders1(IEnumerable<string> providers)
        {
            var needed = View.Administration.TerminalType.Edit.AvailableProviders.Intersect(providers);
            View.Administration.TerminalType.Edit.AvailableProviders = needed;

            var not_needed = View.Administration.TerminalType.Edit.AvailableProviders.Except(providers);
            View.Administration.TerminalType.Edit.SelectedProviders = not_needed;
        }

        private static void SetProviders(IEnumerable<string> providers)
        {
            // alle löschen = clicken
            View.Administration.TerminalType.Edit.SelectedProviders =
                View.Administration.TerminalType.Edit.SelectedProviders;

            View.Administration.TerminalType.Edit.AvailableProviders = providers;
        }
    }
}