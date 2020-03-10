using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public partial class ProjectBillingProcess : EntityAction<ProjectBilling>
	{
		public ProjectBillingProcess(ProjectBilling entity) : base(entity)
		{ }
		public ProjectBillingProcess() : base()
		{ }
	}
}
