using NUnit.Framework;

namespace Six.Scs.Test.Administration
{
    public class TerminalType
    {
        public static void Edit(Model.TerminalType terminalType)
        {
            Workflow.TerminalType.Edit(terminalType);
            Check(terminalType);
        }

        private static void Check(Model.TerminalType terminalType)
        {
            Assert.That(Test.View.Administration.TerminalType.View.DefaultAdditionalCapabilities,
                Is.EqualTo(terminalType.DefaultAdditionalCapabilities));

            Assert.That(Test.View.Administration.TerminalType.View.DefaultCapabilities,
                Is.EqualTo(terminalType.DefaultCapabilities));
            Assert.That(Test.View.Administration.TerminalType.View.DeviceType, Is.EqualTo(terminalType.DeviceType));
            Assert.That(Test.View.Administration.TerminalType.View.Range, Is.EqualTo(terminalType.Range));
            Assert.That(Test.View.Administration.TerminalType.View.ReferenceSystem,
                Is.EqualTo(terminalType.ReferenceSystem));
            Assert.That(Test.View.Administration.TerminalType.View.Supplier, Is.EqualTo(terminalType.Supplier));
            Assert.That(Test.View.Administration.TerminalType.View.DeviceType, Is.EqualTo(terminalType.DeviceType));

            Assert.That(Test.View.Administration.TerminalType.View.SoftwareIds, Is.EqualTo(terminalType.SoftwareIds));
            Assert.That(Test.View.Administration.TerminalType.View.Providers, Is.EqualTo(terminalType.Providers));
            Assert.That(Test.View.Administration.TerminalType.View.Suppliers, Is.EqualTo(terminalType.Suppliers));
        }

        public static Model.TerminalType View()
        {
            return new Model.TerminalType
            {
                DefaultAdditionalCapabilities =
                    Test.View.Administration.TerminalType.View.DefaultAdditionalCapabilities,
                DefaultCapabilities = Test.View.Administration.TerminalType.View.DefaultCapabilities,
                DeviceType = Test.View.Administration.TerminalType.View.DeviceType,
                Range = Test.View.Administration.TerminalType.View.Range,
                ReferenceSystem = Test.View.Administration.TerminalType.View.ReferenceSystem,
                Supplier = Test.View.Administration.TerminalType.View.Supplier,
                Providers = Test.View.Administration.TerminalType.View.Providers,
                SoftwareIds = Test.View.Administration.TerminalType.View.SoftwareIds,
                Suppliers = Test.View.Administration.TerminalType.View.Suppliers
            };
        }
    }
}