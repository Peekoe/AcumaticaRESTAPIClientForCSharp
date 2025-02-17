using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class AppTaxDetails : Entity_v4
	{

		[DataMember(Name="AppointmentNbr", EmitDefaultValue=false)]
		public StringValue AppointmentNbr { get; set; }

		[DataMember(Name="IncludeinVATExemptTotal", EmitDefaultValue=false)]
		public BooleanValue IncludeinVATExemptTotal { get; set; }

		[DataMember(Name="PendingVAT", EmitDefaultValue=false)]
		public BooleanValue PendingVAT { get; set; }

		[DataMember(Name="RecordID", EmitDefaultValue=false)]
		public IntValue RecordID { get; set; }

		[DataMember(Name="ReverseVAT", EmitDefaultValue=false)]
		public BooleanValue ReverseVAT { get; set; }

		[DataMember(Name="ServiceOrderType", EmitDefaultValue=false)]
		public StringValue ServiceOrderType { get; set; }

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