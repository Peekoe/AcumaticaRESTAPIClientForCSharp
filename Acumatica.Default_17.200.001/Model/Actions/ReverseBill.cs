using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public partial class ReverseBill : EntityAction<Bill>
	{
		public ReverseBill(Bill entity) : base(entity)
		{ }
		public ReverseBill() : base()
		{ }
	}
}
