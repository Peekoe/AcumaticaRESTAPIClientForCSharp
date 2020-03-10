using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public partial class RestoreArchivedEmail : EntityAction<Email>
	{
		public RestoreArchivedEmail(Email entity) : base(entity)
		{ }
		public RestoreArchivedEmail() : base()
		{ }
	}
}
