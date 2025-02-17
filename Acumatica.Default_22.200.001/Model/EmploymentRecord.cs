using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class EmploymentRecord : Entity_v4
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue Active { get; set; }

		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue EndDate { get; set; }

		[DataMember(Name="FinalPayment", EmitDefaultValue=false)]
		public GuidValue FinalPayment { get; set; }

		[DataMember(Name="Position", EmitDefaultValue=false)]
		public StringValue Position { get; set; }

		[DataMember(Name="RehireEligible", EmitDefaultValue=false)]
		public BooleanValue RehireEligible { get; set; }

		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue StartDate { get; set; }

		[DataMember(Name="StartReason", EmitDefaultValue=false)]
		public StringValue StartReason { get; set; }

		[DataMember(Name="Terminated", EmitDefaultValue=false)]
		public BooleanValue Terminated { get; set; }

		[DataMember(Name="TerminationReason", EmitDefaultValue=false)]
		public StringValue TerminationReason { get; set; }

	}
}