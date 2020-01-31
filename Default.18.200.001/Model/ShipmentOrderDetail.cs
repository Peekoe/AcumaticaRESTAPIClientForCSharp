/* 
 * Default/18.200.001
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * OpenAPI spec version: 3
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using Acumatica.RESTClient.Model;

namespace Acumatica.Default_18_200_001.Model
{
    /// <summary>
    /// ShipmentOrderDetail
    /// </summary>
    [DataContract]
    public partial class ShipmentOrderDetail : Entity,  IEquatable<ShipmentOrderDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentOrderDetail" /> class.
        /// </summary>
        /// <param name="inventoryDocType">inventoryDocType.</param>
        /// <param name="inventoryRefNbr">inventoryRefNbr.</param>
        /// <param name="invoiceNbr">invoiceNbr.</param>
        /// <param name="invoiceType">invoiceType.</param>
        /// <param name="orderNbr">orderNbr.</param>
        /// <param name="orderType">orderType.</param>
        /// <param name="shipmentNbr">shipmentNbr.</param>
        /// <param name="shipmentType">shipmentType.</param>
        /// <param name="shippedQty">shippedQty.</param>
        /// <param name="shippedVolume">shippedVolume.</param>
        /// <param name="shippedWeight">shippedWeight.</param>
        public ShipmentOrderDetail(StringValue inventoryDocType = default(StringValue), StringValue inventoryRefNbr = default(StringValue), StringValue invoiceNbr = default(StringValue), StringValue invoiceType = default(StringValue), StringValue orderNbr = default(StringValue), StringValue orderType = default(StringValue), StringValue shipmentNbr = default(StringValue), StringValue shipmentType = default(StringValue), DecimalValue shippedQty = default(DecimalValue), DecimalValue shippedVolume = default(DecimalValue), DecimalValue shippedWeight = default(DecimalValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.InventoryDocType = inventoryDocType;
            this.InventoryRefNbr = inventoryRefNbr;
            this.InvoiceNbr = invoiceNbr;
            this.InvoiceType = invoiceType;
            this.OrderNbr = orderNbr;
            this.OrderType = orderType;
            this.ShipmentNbr = shipmentNbr;
            this.ShipmentType = shipmentType;
            this.ShippedQty = shippedQty;
            this.ShippedVolume = shippedVolume;
            this.ShippedWeight = shippedWeight;
        }
        
        /// <summary>
        /// Gets or Sets InventoryDocType
        /// </summary>
        [DataMember(Name="InventoryDocType", EmitDefaultValue=false)]
        public StringValue InventoryDocType { get; set; }

        /// <summary>
        /// Gets or Sets InventoryRefNbr
        /// </summary>
        [DataMember(Name="InventoryRefNbr", EmitDefaultValue=false)]
        public StringValue InventoryRefNbr { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceNbr
        /// </summary>
        [DataMember(Name="InvoiceNbr", EmitDefaultValue=false)]
        public StringValue InvoiceNbr { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceType
        /// </summary>
        [DataMember(Name="InvoiceType", EmitDefaultValue=false)]
        public StringValue InvoiceType { get; set; }

        /// <summary>
        /// Gets or Sets OrderNbr
        /// </summary>
        [DataMember(Name="OrderNbr", EmitDefaultValue=false)]
        public StringValue OrderNbr { get; set; }

        /// <summary>
        /// Gets or Sets OrderType
        /// </summary>
        [DataMember(Name="OrderType", EmitDefaultValue=false)]
        public StringValue OrderType { get; set; }

        /// <summary>
        /// Gets or Sets ShipmentNbr
        /// </summary>
        [DataMember(Name="ShipmentNbr", EmitDefaultValue=false)]
        public StringValue ShipmentNbr { get; set; }

        /// <summary>
        /// Gets or Sets ShipmentType
        /// </summary>
        [DataMember(Name="ShipmentType", EmitDefaultValue=false)]
        public StringValue ShipmentType { get; set; }

        /// <summary>
        /// Gets or Sets ShippedQty
        /// </summary>
        [DataMember(Name="ShippedQty", EmitDefaultValue=false)]
        public DecimalValue ShippedQty { get; set; }

        /// <summary>
        /// Gets or Sets ShippedVolume
        /// </summary>
        [DataMember(Name="ShippedVolume", EmitDefaultValue=false)]
        public DecimalValue ShippedVolume { get; set; }

        /// <summary>
        /// Gets or Sets ShippedWeight
        /// </summary>
        [DataMember(Name="ShippedWeight", EmitDefaultValue=false)]
        public DecimalValue ShippedWeight { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShipmentOrderDetail {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  InventoryDocType: ").Append(InventoryDocType).Append("\n");
            sb.Append("  InventoryRefNbr: ").Append(InventoryRefNbr).Append("\n");
            sb.Append("  InvoiceNbr: ").Append(InvoiceNbr).Append("\n");
            sb.Append("  InvoiceType: ").Append(InvoiceType).Append("\n");
            sb.Append("  OrderNbr: ").Append(OrderNbr).Append("\n");
            sb.Append("  OrderType: ").Append(OrderType).Append("\n");
            sb.Append("  ShipmentNbr: ").Append(ShipmentNbr).Append("\n");
            sb.Append("  ShipmentType: ").Append(ShipmentType).Append("\n");
            sb.Append("  ShippedQty: ").Append(ShippedQty).Append("\n");
            sb.Append("  ShippedVolume: ").Append(ShippedVolume).Append("\n");
            sb.Append("  ShippedWeight: ").Append(ShippedWeight).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShipmentOrderDetail);
        }

        /// <summary>
        /// Returns true if ShipmentOrderDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of ShipmentOrderDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipmentOrderDetail input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.InventoryDocType == input.InventoryDocType ||
                    (this.InventoryDocType != null &&
                    this.InventoryDocType.Equals(input.InventoryDocType))
                ) && base.Equals(input) && 
                (
                    this.InventoryRefNbr == input.InventoryRefNbr ||
                    (this.InventoryRefNbr != null &&
                    this.InventoryRefNbr.Equals(input.InventoryRefNbr))
                ) && base.Equals(input) && 
                (
                    this.InvoiceNbr == input.InvoiceNbr ||
                    (this.InvoiceNbr != null &&
                    this.InvoiceNbr.Equals(input.InvoiceNbr))
                ) && base.Equals(input) && 
                (
                    this.InvoiceType == input.InvoiceType ||
                    (this.InvoiceType != null &&
                    this.InvoiceType.Equals(input.InvoiceType))
                ) && base.Equals(input) && 
                (
                    this.OrderNbr == input.OrderNbr ||
                    (this.OrderNbr != null &&
                    this.OrderNbr.Equals(input.OrderNbr))
                ) && base.Equals(input) && 
                (
                    this.OrderType == input.OrderType ||
                    (this.OrderType != null &&
                    this.OrderType.Equals(input.OrderType))
                ) && base.Equals(input) && 
                (
                    this.ShipmentNbr == input.ShipmentNbr ||
                    (this.ShipmentNbr != null &&
                    this.ShipmentNbr.Equals(input.ShipmentNbr))
                ) && base.Equals(input) && 
                (
                    this.ShipmentType == input.ShipmentType ||
                    (this.ShipmentType != null &&
                    this.ShipmentType.Equals(input.ShipmentType))
                ) && base.Equals(input) && 
                (
                    this.ShippedQty == input.ShippedQty ||
                    (this.ShippedQty != null &&
                    this.ShippedQty.Equals(input.ShippedQty))
                ) && base.Equals(input) && 
                (
                    this.ShippedVolume == input.ShippedVolume ||
                    (this.ShippedVolume != null &&
                    this.ShippedVolume.Equals(input.ShippedVolume))
                ) && base.Equals(input) && 
                (
                    this.ShippedWeight == input.ShippedWeight ||
                    (this.ShippedWeight != null &&
                    this.ShippedWeight.Equals(input.ShippedWeight))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                if (this.InventoryDocType != null)
                    hashCode = hashCode * 59 + this.InventoryDocType.GetHashCode();
                if (this.InventoryRefNbr != null)
                    hashCode = hashCode * 59 + this.InventoryRefNbr.GetHashCode();
                if (this.InvoiceNbr != null)
                    hashCode = hashCode * 59 + this.InvoiceNbr.GetHashCode();
                if (this.InvoiceType != null)
                    hashCode = hashCode * 59 + this.InvoiceType.GetHashCode();
                if (this.OrderNbr != null)
                    hashCode = hashCode * 59 + this.OrderNbr.GetHashCode();
                if (this.OrderType != null)
                    hashCode = hashCode * 59 + this.OrderType.GetHashCode();
                if (this.ShipmentNbr != null)
                    hashCode = hashCode * 59 + this.ShipmentNbr.GetHashCode();
                if (this.ShipmentType != null)
                    hashCode = hashCode * 59 + this.ShipmentType.GetHashCode();
                if (this.ShippedQty != null)
                    hashCode = hashCode * 59 + this.ShippedQty.GetHashCode();
                if (this.ShippedVolume != null)
                    hashCode = hashCode * 59 + this.ShippedVolume.GetHashCode();
                if (this.ShippedWeight != null)
                    hashCode = hashCode * 59 + this.ShippedWeight.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            foreach(var x in base.BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }

}
