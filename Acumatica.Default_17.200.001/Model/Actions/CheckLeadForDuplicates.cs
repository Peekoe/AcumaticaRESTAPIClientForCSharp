using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public partial class CheckLeadForDuplicates : EntityAction<Lead>
	{
		public CheckLeadForDuplicates(Lead entity) : base(entity)
		{ }
		public CheckLeadForDuplicates() : base()
		{ }
	}
}
