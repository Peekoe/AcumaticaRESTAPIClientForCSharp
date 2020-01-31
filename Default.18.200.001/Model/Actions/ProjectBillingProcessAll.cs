
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class ProjectBillingProcessAll : EntityAction<ProjectBilling>
    {
 public ProjectBillingProcessAll(ProjectBilling entity) : base(entity)
        { }

[DataMember(Name = "entity", EmitDefaultValue = false)]
        public ProjectBilling Entity
        {
            get
            {
                return _Entity;
            }
            set
            {
                _Entity = value;
            }
        }
    }
}
