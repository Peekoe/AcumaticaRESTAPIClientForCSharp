using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public partial class KitSpecification : Entity
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue Active { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="IsNonStock", EmitDefaultValue=false)]
		public BooleanValue IsNonStock { get; set; }

		[DataMember(Name="KitInventoryID", EmitDefaultValue=false)]
		public StringValue KitInventoryID { get; set; }

		[DataMember(Name="NonStockComponents", EmitDefaultValue=false)]
		public List<KitNonStockComponent> NonStockComponents { get; set; }

		[DataMember(Name="RevisionID", EmitDefaultValue=false)]
		public StringValue RevisionID { get; set; }

		[DataMember(Name="StockComponents", EmitDefaultValue=false)]
		public List<KitStockComponent> StockComponents { get; set; }

	}
}