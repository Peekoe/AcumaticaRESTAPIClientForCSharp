using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class CompanyFinancialPeriod : Entity_v4
	{

		[DataMember(Name="Company", EmitDefaultValue=false)]
		public StringValue Company { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<FinancialPeriodDetail> Details { get; set; }

		[DataMember(Name="FinancialYear", EmitDefaultValue=false)]
		public StringValue FinancialYear { get; set; }

		[DataMember(Name="NbrOfPeriods", EmitDefaultValue=false)]
		public ShortValue NbrOfPeriods { get; set; }

		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue StartDate { get; set; }

	}
}