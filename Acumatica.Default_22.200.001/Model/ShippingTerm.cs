using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class ShippingTerm : Entity_v4
	{

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<ShippingTermDetail> Details { get; set; }

		[DataMember(Name="TermID", EmitDefaultValue=false)]
		public StringValue TermID { get; set; }

	}
}