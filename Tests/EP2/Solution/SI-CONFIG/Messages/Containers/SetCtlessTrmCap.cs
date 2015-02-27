using System.Collections.Generic;
using SIX.EP2.Core.ContentHandling.Common;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace SIX.SCS.EP2.SIConfig.Host.Messages.Containers
{
	public class SetCtlessTrmCap
	{
		public SetCtlessTrmCap()
		{
			CtlessTrmCapPerKnl = new List<CtlessTrmCapPerKnl>();
		}

		[Ep2DataElement(TagName = "CtlessTrmCapPerKnl", TagPrefix = "ep2", DataType = Ep2DataType.b, IsMandatory = false)]
		public IList<CtlessTrmCapPerKnl> CtlessTrmCapPerKnl { get; set; }
	}
}