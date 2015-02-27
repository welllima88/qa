using System.Collections.Generic;
using SIX.EP2.Core.ContentHandling;
using SIX.EP2.Core.ContentHandling.Common;
using SIX.EP2.Core.ContentHandling.Serialization;
using SIX.SCS.EP2.SIConfig.Host.Messages.Containers;

namespace SIX.SCS.EP2.SIConfig.Host.Messages.MsgOut
{
	public abstract class ConfigDataNotificationBase : IMessageWithNum, IamSIMessage
	{
		protected ConfigDataNotificationBase()
		{
			Aisd = new List<aisd>();
		}

		public int? MsgNum { get; set; }

		[Ep2DataElement(TagName = "TrmID", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true)]
		public string TrmID { get; set; }

		[Ep2DataElement(TagName = "SCID", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true)]
		public long SCID { get; set; }

		[Ep2DataElement(TagName = "aisd")]
		public IList<aisd> Aisd { get; set; }


	


		public abstract void Accept(IConfigNotificationVisitor visitor);

	}
}