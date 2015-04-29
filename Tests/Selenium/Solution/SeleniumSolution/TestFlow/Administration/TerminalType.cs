using NUnit.Framework;

namespace Six.Scs.Test.Administration
{
    public class TerminalType
    {
        public static Model.ValueObjects.TerminalType Edit(Model.ValueObjects.TerminalType terminalType)
        {
            Workflow.TerminalType.Edit(terminalType);
            Check(terminalType);
            return new Model.ValueObjects.TerminalType();
        }

        private static void Check(Model.ValueObjects.TerminalType terminalType)
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

            Assert.That(Test.View.Administration.TerminalType.View.SoftwareIds, Contains.Item(terminalType.SoftwareIds));
            Assert.That(Test.View.Administration.TerminalType.View.Providers, Contains.Item(terminalType.Providers));
            Assert.That(Test.View.Administration.TerminalType.View.Suppliers, Contains.Item(terminalType.Suppliers));
        }

        public static Model.ValueObjects.TerminalType View()
        {
            return new Model.ValueObjects.TerminalType
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