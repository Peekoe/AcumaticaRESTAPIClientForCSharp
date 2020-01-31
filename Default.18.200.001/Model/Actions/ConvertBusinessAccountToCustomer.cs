
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class ConvertBusinessAccountToCustomer : EntityAction<BusinessAccount>
    {
 public ConvertBusinessAccountToCustomer(BusinessAccount entity) : base(entity)
        { }

[DataMember(Name = "entity", EmitDefaultValue = false)]
        public BusinessAccount Entity
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
