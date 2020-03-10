using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public partial class ReleaseKitAssembly : EntityAction<KitAssembly>
	{
		public ReleaseKitAssembly(KitAssembly entity) : base(entity)
		{ }
		public ReleaseKitAssembly() : base()
		{ }
	}
}
