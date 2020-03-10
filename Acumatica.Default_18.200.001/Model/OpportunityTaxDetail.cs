using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public partial class OpportunityTaxDetail : Entity
	{

		[DataMember(Name="IncludeInVATExemptTotal", EmitDefaultValue=false)]
		public BooleanValue IncludeInVATExemptTotal { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue LineNbr { get; set; }

		[DataMember(Name="PendingVAT", EmitDefaultValue=false)]
		public BooleanValue PendingVAT { get; set; }

		[DataMember(Name="ReverseVAT", EmitDefaultValue=false)]
		public BooleanValue ReverseVAT { get; set; }

		[DataMember(Name="StatisticalVAT", EmitDefaultValue=false)]
		public BooleanValue StatisticalVAT { get; set; }

		[DataMember(Name="TaxableAmount", EmitDefaultValue=false)]
		public DecimalValue TaxableAmount { get; set; }

		[DataMember(Name="TaxAmount", EmitDefaultValue=false)]
		public DecimalValue TaxAmount { get; set; }

		[DataMember(Name="TaxID", EmitDefaultValue=false)]
		public StringValue TaxID { get; set; }

		[DataMember(Name="TaxRate", EmitDefaultValue=false)]
		public DecimalValue TaxRate { get; set; }

		[DataMember(Name="TaxType", EmitDefaultValue=false)]
		public StringValue TaxType { get; set; }

	}
}