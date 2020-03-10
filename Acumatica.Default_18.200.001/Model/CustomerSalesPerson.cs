using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public partial class CustomerSalesPerson : Entity
	{

		[DataMember(Name="Commission", EmitDefaultValue=false)]
		public DecimalValue Commission { get; set; }

		[DataMember(Name="Default", EmitDefaultValue=false)]
		public BooleanValue Default { get; set; }

		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue LocationID { get; set; }

		[DataMember(Name="LocationName", EmitDefaultValue=false)]
		public StringValue LocationName { get; set; }

		[DataMember(Name="Name", EmitDefaultValue=false)]
		public StringValue Name { get; set; }

		[DataMember(Name="SalespersonID", EmitDefaultValue=false)]
		public StringValue SalespersonID { get; set; }

	}
}