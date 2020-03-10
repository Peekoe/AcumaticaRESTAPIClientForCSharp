using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public partial class VoidPayment : EntityAction<Payment>
	{
		public VoidPayment(Payment entity) : base(entity)
		{ }
		public VoidPayment() : base()
		{ }
	}
}
