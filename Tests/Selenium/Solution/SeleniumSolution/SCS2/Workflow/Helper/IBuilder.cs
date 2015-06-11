using Six.Scs.Test.Workflow.Builder;

namespace Six.Scs.Test.Workflow.Helper
{
    public abstract class Builder : ICreate, IEdit, ICheck
    {
        private IPerform _changeMode;

        public Builder Change(IPerform changeMode)
        {
            _changeMode = changeMode;
            return this;
        }

        protected void EnterChangeData()
        {
            if (_changeMode == null)
            {
                new DefaultChange().Do();
            }
            else
            {
                _changeMode.Do();
            }
        }

        public abstract void Create();
        public abstract void Edit();
        public abstract void Check();
    }
}