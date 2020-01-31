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
    /// ItemClass
    /// </summary>
    [DataContract]
    public partial class ItemClass : Entity,  IEquatable<ItemClass>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemClass" /> class.
        /// </summary>
        /// <param name="attributes">attributes.</param>
        /// <param name="availabilityCalculationRule">availabilityCalculationRule.</param>
        /// <param name="baseUOM">baseUOM.</param>
        /// <param name="classID">classID.</param>
        /// <param name="defaultWarehouseID">defaultWarehouseID.</param>
        /// <param name="description">description.</param>
        /// <param name="itemType">itemType.</param>
        /// <param name="lastModifiedDateTime">lastModifiedDateTime.</param>
        /// <param name="lotSerialClass">lotSerialClass.</param>
        /// <param name="postingClass">postingClass.</param>
        /// <param name="priceClass">priceClass.</param>
        /// <param name="purchaseUOM">purchaseUOM.</param>
        /// <param name="salesUOM">salesUOM.</param>
        /// <param name="stockItem">stockItem.</param>
        /// <param name="taxCategoryID">taxCategoryID.</param>
        /// <param name="valuationMethod">valuationMethod.</param>
        public ItemClass(List<ItemClassAtrribute> attributes = default(List<ItemClassAtrribute>), StringValue availabilityCalculationRule = default(StringValue), StringValue baseUOM = default(StringValue), StringValue classID = default(StringValue), StringValue defaultWarehouseID = default(StringValue), StringValue description = default(StringValue), StringValue itemType = default(StringValue), DateTimeValue lastModifiedDateTime = default(DateTimeValue), StringValue lotSerialClass = default(StringValue), StringValue postingClass = default(StringValue), StringValue priceClass = default(StringValue), StringValue purchaseUOM = default(StringValue), StringValue salesUOM = default(StringValue), BooleanValue stockItem = default(BooleanValue), StringValue taxCategoryID = default(StringValue), StringValue valuationMethod = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Attributes = attributes;
            this.AvailabilityCalculationRule = availabilityCalculationRule;
            this.BaseUOM = baseUOM;
            this.ClassID = classID;
            this.DefaultWarehouseID = defaultWarehouseID;
            this.Description = description;
            this.ItemType = itemType;
            this.LastModifiedDateTime = lastModifiedDateTime;
            this.LotSerialClass = lotSerialClass;
            this.PostingClass = postingClass;
            this.PriceClass = priceClass;
            this.PurchaseUOM = purchaseUOM;
            this.SalesUOM = salesUOM;
            this.StockItem = stockItem;
            this.TaxCategoryID = taxCategoryID;
            this.ValuationMethod = valuationMethod;
        }
        
        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name="Attributes", EmitDefaultValue=false)]
        public List<ItemClassAtrribute> Attributes { get; set; }

        /// <summary>
        /// Gets or Sets AvailabilityCalculationRule
        /// </summary>
        [DataMember(Name="AvailabilityCalculationRule", EmitDefaultValue=false)]
        public StringValue AvailabilityCalculationRule { get; set; }

        /// <summary>
        /// Gets or Sets BaseUOM
        /// </summary>
        [DataMember(Name="BaseUOM", EmitDefaultValue=false)]
        public StringValue BaseUOM { get; set; }

        /// <summary>
        /// Gets or Sets ClassID
        /// </summary>
        [DataMember(Name="ClassID", EmitDefaultValue=false)]
        public StringValue ClassID { get; set; }

        /// <summary>
        /// Gets or Sets DefaultWarehouseID
        /// </summary>
        [DataMember(Name="DefaultWarehouseID", EmitDefaultValue=false)]
        public StringValue DefaultWarehouseID { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets ItemType
        /// </summary>
        [DataMember(Name="ItemType", EmitDefaultValue=false)]
        public StringValue ItemType { get; set; }

        /// <summary>
        /// Gets or Sets LastModifiedDateTime
        /// </summary>
        [DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
        public DateTimeValue LastModifiedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets LotSerialClass
        /// </summary>
        [DataMember(Name="LotSerialClass", EmitDefaultValue=false)]
        public StringValue LotSerialClass { get; set; }

        /// <summary>
        /// Gets or Sets PostingClass
        /// </summary>
        [DataMember(Name="PostingClass", EmitDefaultValue=false)]
        public StringValue PostingClass { get; set; }

        /// <summary>
        /// Gets or Sets PriceClass
        /// </summary>
        [DataMember(Name="PriceClass", EmitDefaultValue=false)]
        public StringValue PriceClass { get; set; }

        /// <summary>
        /// Gets or Sets PurchaseUOM
        /// </summary>
        [DataMember(Name="PurchaseUOM", EmitDefaultValue=false)]
        public StringValue PurchaseUOM { get; set; }

        /// <summary>
        /// Gets or Sets SalesUOM
        /// </summary>
        [DataMember(Name="SalesUOM", EmitDefaultValue=false)]
        public StringValue SalesUOM { get; set; }

        /// <summary>
        /// Gets or Sets StockItem
        /// </summary>
        [DataMember(Name="StockItem", EmitDefaultValue=false)]
        public BooleanValue StockItem { get; set; }

        /// <summary>
        /// Gets or Sets TaxCategoryID
        /// </summary>
        [DataMember(Name="TaxCategoryID", EmitDefaultValue=false)]
        public StringValue TaxCategoryID { get; set; }

        /// <summary>
        /// Gets or Sets ValuationMethod
        /// </summary>
        [DataMember(Name="ValuationMethod", EmitDefaultValue=false)]
        public StringValue ValuationMethod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemClass {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  AvailabilityCalculationRule: ").Append(AvailabilityCalculationRule).Append("\n");
            sb.Append("  BaseUOM: ").Append(BaseUOM).Append("\n");
            sb.Append("  ClassID: ").Append(ClassID).Append("\n");
            sb.Append("  DefaultWarehouseID: ").Append(DefaultWarehouseID).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ItemType: ").Append(ItemType).Append("\n");
            sb.Append("  LastModifiedDateTime: ").Append(LastModifiedDateTime).Append("\n");
            sb.Append("  LotSerialClass: ").Append(LotSerialClass).Append("\n");
            sb.Append("  PostingClass: ").Append(PostingClass).Append("\n");
            sb.Append("  PriceClass: ").Append(PriceClass).Append("\n");
            sb.Append("  PurchaseUOM: ").Append(PurchaseUOM).Append("\n");
            sb.Append("  SalesUOM: ").Append(SalesUOM).Append("\n");
            sb.Append("  StockItem: ").Append(StockItem).Append("\n");
            sb.Append("  TaxCategoryID: ").Append(TaxCategoryID).Append("\n");
            sb.Append("  ValuationMethod: ").Append(ValuationMethod).Append("\n");
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
            return this.Equals(input as ItemClass);
        }

        /// <summary>
        /// Returns true if ItemClass instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemClass to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemClass input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
                ) && base.Equals(input) && 
                (
                    this.AvailabilityCalculationRule == input.AvailabilityCalculationRule ||
                    (this.AvailabilityCalculationRule != null &&
                    this.AvailabilityCalculationRule.Equals(input.AvailabilityCalculationRule))
                ) && base.Equals(input) && 
                (
                    this.BaseUOM == input.BaseUOM ||
                    (this.BaseUOM != null &&
                    this.BaseUOM.Equals(input.BaseUOM))
                ) && base.Equals(input) && 
                (
                    this.ClassID == input.ClassID ||
                    (this.ClassID != null &&
                    this.ClassID.Equals(input.ClassID))
                ) && base.Equals(input) && 
                (
                    this.DefaultWarehouseID == input.DefaultWarehouseID ||
                    (this.DefaultWarehouseID != null &&
                    this.DefaultWarehouseID.Equals(input.DefaultWarehouseID))
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.ItemType == input.ItemType ||
                    (this.ItemType != null &&
                    this.ItemType.Equals(input.ItemType))
                ) && base.Equals(input) && 
                (
                    this.LastModifiedDateTime == input.LastModifiedDateTime ||
                    (this.LastModifiedDateTime != null &&
                    this.LastModifiedDateTime.Equals(input.LastModifiedDateTime))
                ) && base.Equals(input) && 
                (
                    this.LotSerialClass == input.LotSerialClass ||
                    (this.LotSerialClass != null &&
                    this.LotSerialClass.Equals(input.LotSerialClass))
                ) && base.Equals(input) && 
                (
                    this.PostingClass == input.PostingClass ||
                    (this.PostingClass != null &&
                    this.PostingClass.Equals(input.PostingClass))
                ) && base.Equals(input) && 
                (
                    this.PriceClass == input.PriceClass ||
                    (this.PriceClass != null &&
                    this.PriceClass.Equals(input.PriceClass))
                ) && base.Equals(input) && 
                (
                    this.PurchaseUOM == input.PurchaseUOM ||
                    (this.PurchaseUOM != null &&
                    this.PurchaseUOM.Equals(input.PurchaseUOM))
                ) && base.Equals(input) && 
                (
                    this.SalesUOM == input.SalesUOM ||
                    (this.SalesUOM != null &&
                    this.SalesUOM.Equals(input.SalesUOM))
                ) && base.Equals(input) && 
                (
                    this.StockItem == input.StockItem ||
                    (this.StockItem != null &&
                    this.StockItem.Equals(input.StockItem))
                ) && base.Equals(input) && 
                (
                    this.TaxCategoryID == input.TaxCategoryID ||
                    (this.TaxCategoryID != null &&
                    this.TaxCategoryID.Equals(input.TaxCategoryID))
                ) && base.Equals(input) && 
                (
                    this.ValuationMethod == input.ValuationMethod ||
                    (this.ValuationMethod != null &&
                    this.ValuationMethod.Equals(input.ValuationMethod))
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
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.AvailabilityCalculationRule != null)
                    hashCode = hashCode * 59 + this.AvailabilityCalculationRule.GetHashCode();
                if (this.BaseUOM != null)
                    hashCode = hashCode * 59 + this.BaseUOM.GetHashCode();
                if (this.ClassID != null)
                    hashCode = hashCode * 59 + this.ClassID.GetHashCode();
                if (this.DefaultWarehouseID != null)
                    hashCode = hashCode * 59 + this.DefaultWarehouseID.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ItemType != null)
                    hashCode = hashCode * 59 + this.ItemType.GetHashCode();
                if (this.LastModifiedDateTime != null)
                    hashCode = hashCode * 59 + this.LastModifiedDateTime.GetHashCode();
                if (this.LotSerialClass != null)
                    hashCode = hashCode * 59 + this.LotSerialClass.GetHashCode();
                if (this.PostingClass != null)
                    hashCode = hashCode * 59 + this.PostingClass.GetHashCode();
                if (this.PriceClass != null)
                    hashCode = hashCode * 59 + this.PriceClass.GetHashCode();
                if (this.PurchaseUOM != null)
                    hashCode = hashCode * 59 + this.PurchaseUOM.GetHashCode();
                if (this.SalesUOM != null)
                    hashCode = hashCode * 59 + this.SalesUOM.GetHashCode();
                if (this.StockItem != null)
                    hashCode = hashCode * 59 + this.StockItem.GetHashCode();
                if (this.TaxCategoryID != null)
                    hashCode = hashCode * 59 + this.TaxCategoryID.GetHashCode();
                if (this.ValuationMethod != null)
                    hashCode = hashCode * 59 + this.ValuationMethod.GetHashCode();
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
