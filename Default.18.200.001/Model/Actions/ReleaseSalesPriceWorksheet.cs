
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class ReleaseSalesPriceWorksheet : EntityAction<SalesPriceWorksheet>
    {
 public ReleaseSalesPriceWorksheet(SalesPriceWorksheet entity) : base(entity)
        { }

[DataMember(Name = "entity", EmitDefaultValue = false)]
        public SalesPriceWorksheet Entity
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
