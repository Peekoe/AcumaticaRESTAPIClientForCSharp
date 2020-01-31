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
    /// PhysicalInventoryReviewDetail
    /// </summary>
    [DataContract]
    public partial class PhysicalInventoryReviewDetail : Entity,  IEquatable<PhysicalInventoryReviewDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicalInventoryReviewDetail" /> class.
        /// </summary>
        /// <param name="bookQty">bookQty.</param>
        /// <param name="description">description.</param>
        /// <param name="expirationDate">expirationDate.</param>
        /// <param name="extendedVarianceCost">extendedVarianceCost.</param>
        /// <param name="inventoryID">inventoryID.</param>
        /// <param name="lineNbr">lineNbr.</param>
        /// <param name="locationID">locationID.</param>
        /// <param name="lotSerialNbr">lotSerialNbr.</param>
        /// <param name="physicalQty">physicalQty.</param>
        /// <param name="reasonCode">reasonCode.</param>
        /// <param name="status">status.</param>
        /// <param name="subitem">subitem.</param>
        /// <param name="tagNbr">tagNbr.</param>
        /// <param name="unitCost">unitCost.</param>
        /// <param name="varianceQty">varianceQty.</param>
        public PhysicalInventoryReviewDetail(DecimalValue bookQty = default(DecimalValue), StringValue description = default(StringValue), DateTimeValue expirationDate = default(DateTimeValue), DecimalValue extendedVarianceCost = default(DecimalValue), StringValue inventoryID = default(StringValue), IntValue lineNbr = default(IntValue), StringValue locationID = default(StringValue), StringValue lotSerialNbr = default(StringValue), DecimalValue physicalQty = default(DecimalValue), StringValue reasonCode = default(StringValue), StringValue status = default(StringValue), StringValue subitem = default(StringValue), IntValue tagNbr = default(IntValue), DecimalValue unitCost = default(DecimalValue), DecimalValue varianceQty = default(DecimalValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.BookQty = bookQty;
            this.Description = description;
            this.ExpirationDate = expirationDate;
            this.ExtendedVarianceCost = extendedVarianceCost;
            this.InventoryID = inventoryID;
            this.LineNbr = lineNbr;
            this.LocationID = locationID;
            this.LotSerialNbr = lotSerialNbr;
            this.PhysicalQty = physicalQty;
            this.ReasonCode = reasonCode;
            this.Status = status;
            this.Subitem = subitem;
            this.TagNbr = tagNbr;
            this.UnitCost = unitCost;
            this.VarianceQty = varianceQty;
        }
        
        /// <summary>
        /// Gets or Sets BookQty
        /// </summary>
        [DataMember(Name="BookQty", EmitDefaultValue=false)]
        public DecimalValue BookQty { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        [DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
        public DateTimeValue ExpirationDate { get; set; }

        /// <summary>
        /// Gets or Sets ExtendedVarianceCost
        /// </summary>
        [DataMember(Name="ExtendedVarianceCost", EmitDefaultValue=false)]
        public DecimalValue ExtendedVarianceCost { get; set; }

        /// <summary>
        /// Gets or Sets InventoryID
        /// </summary>
        [DataMember(Name="InventoryID", EmitDefaultValue=false)]
        public StringValue InventoryID { get; set; }

        /// <summary>
        /// Gets or Sets LineNbr
        /// </summary>
        [DataMember(Name="LineNbr", EmitDefaultValue=false)]
        public IntValue LineNbr { get; set; }

        /// <summary>
        /// Gets or Sets LocationID
        /// </summary>
        [DataMember(Name="LocationID", EmitDefaultValue=false)]
        public StringValue LocationID { get; set; }

        /// <summary>
        /// Gets or Sets LotSerialNbr
        /// </summary>
        [DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
        public StringValue LotSerialNbr { get; set; }

        /// <summary>
        /// Gets or Sets PhysicalQty
        /// </summary>
        [DataMember(Name="PhysicalQty", EmitDefaultValue=false)]
        public DecimalValue PhysicalQty { get; set; }

        /// <summary>
        /// Gets or Sets ReasonCode
        /// </summary>
        [DataMember(Name="ReasonCode", EmitDefaultValue=false)]
        public StringValue ReasonCode { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StringValue Status { get; set; }

        /// <summary>
        /// Gets or Sets Subitem
        /// </summary>
        [DataMember(Name="Subitem", EmitDefaultValue=false)]
        public StringValue Subitem { get; set; }

        /// <summary>
        /// Gets or Sets TagNbr
        /// </summary>
        [DataMember(Name="TagNbr", EmitDefaultValue=false)]
        public IntValue TagNbr { get; set; }

        /// <summary>
        /// Gets or Sets UnitCost
        /// </summary>
        [DataMember(Name="UnitCost", EmitDefaultValue=false)]
        public DecimalValue UnitCost { get; set; }

        /// <summary>
        /// Gets or Sets VarianceQty
        /// </summary>
        [DataMember(Name="VarianceQty", EmitDefaultValue=false)]
        public DecimalValue VarianceQty { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhysicalInventoryReviewDetail {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  BookQty: ").Append(BookQty).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  ExtendedVarianceCost: ").Append(ExtendedVarianceCost).Append("\n");
            sb.Append("  InventoryID: ").Append(InventoryID).Append("\n");
            sb.Append("  LineNbr: ").Append(LineNbr).Append("\n");
            sb.Append("  LocationID: ").Append(LocationID).Append("\n");
            sb.Append("  LotSerialNbr: ").Append(LotSerialNbr).Append("\n");
            sb.Append("  PhysicalQty: ").Append(PhysicalQty).Append("\n");
            sb.Append("  ReasonCode: ").Append(ReasonCode).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Subitem: ").Append(Subitem).Append("\n");
            sb.Append("  TagNbr: ").Append(TagNbr).Append("\n");
            sb.Append("  UnitCost: ").Append(UnitCost).Append("\n");
            sb.Append("  VarianceQty: ").Append(VarianceQty).Append("\n");
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
            return this.Equals(input as PhysicalInventoryReviewDetail);
        }

        /// <summary>
        /// Returns true if PhysicalInventoryReviewDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of PhysicalInventoryReviewDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhysicalInventoryReviewDetail input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.BookQty == input.BookQty ||
                    (this.BookQty != null &&
                    this.BookQty.Equals(input.BookQty))
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.ExpirationDate == input.ExpirationDate ||
                    (this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(input.ExpirationDate))
                ) && base.Equals(input) && 
                (
                    this.ExtendedVarianceCost == input.ExtendedVarianceCost ||
                    (this.ExtendedVarianceCost != null &&
                    this.ExtendedVarianceCost.Equals(input.ExtendedVarianceCost))
                ) && base.Equals(input) && 
                (
                    this.InventoryID == input.InventoryID ||
                    (this.InventoryID != null &&
                    this.InventoryID.Equals(input.InventoryID))
                ) && base.Equals(input) && 
                (
                    this.LineNbr == input.LineNbr ||
                    (this.LineNbr != null &&
                    this.LineNbr.Equals(input.LineNbr))
                ) && base.Equals(input) && 
                (
                    this.LocationID == input.LocationID ||
                    (this.LocationID != null &&
                    this.LocationID.Equals(input.LocationID))
                ) && base.Equals(input) && 
                (
                    this.LotSerialNbr == input.LotSerialNbr ||
                    (this.LotSerialNbr != null &&
                    this.LotSerialNbr.Equals(input.LotSerialNbr))
                ) && base.Equals(input) && 
                (
                    this.PhysicalQty == input.PhysicalQty ||
                    (this.PhysicalQty != null &&
                    this.PhysicalQty.Equals(input.PhysicalQty))
                ) && base.Equals(input) && 
                (
                    this.ReasonCode == input.ReasonCode ||
                    (this.ReasonCode != null &&
                    this.ReasonCode.Equals(input.ReasonCode))
                ) && base.Equals(input) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && base.Equals(input) && 
                (
                    this.Subitem == input.Subitem ||
                    (this.Subitem != null &&
                    this.Subitem.Equals(input.Subitem))
                ) && base.Equals(input) && 
                (
                    this.TagNbr == input.TagNbr ||
                    (this.TagNbr != null &&
                    this.TagNbr.Equals(input.TagNbr))
                ) && base.Equals(input) && 
                (
                    this.UnitCost == input.UnitCost ||
                    (this.UnitCost != null &&
                    this.UnitCost.Equals(input.UnitCost))
                ) && base.Equals(input) && 
                (
                    this.VarianceQty == input.VarianceQty ||
                    (this.VarianceQty != null &&
                    this.VarianceQty.Equals(input.VarianceQty))
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
                if (this.BookQty != null)
                    hashCode = hashCode * 59 + this.BookQty.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ExpirationDate != null)
                    hashCode = hashCode * 59 + this.ExpirationDate.GetHashCode();
                if (this.ExtendedVarianceCost != null)
                    hashCode = hashCode * 59 + this.ExtendedVarianceCost.GetHashCode();
                if (this.InventoryID != null)
                    hashCode = hashCode * 59 + this.InventoryID.GetHashCode();
                if (this.LineNbr != null)
                    hashCode = hashCode * 59 + this.LineNbr.GetHashCode();
                if (this.LocationID != null)
                    hashCode = hashCode * 59 + this.LocationID.GetHashCode();
                if (this.LotSerialNbr != null)
                    hashCode = hashCode * 59 + this.LotSerialNbr.GetHashCode();
                if (this.PhysicalQty != null)
                    hashCode = hashCode * 59 + this.PhysicalQty.GetHashCode();
                if (this.ReasonCode != null)
                    hashCode = hashCode * 59 + this.ReasonCode.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Subitem != null)
                    hashCode = hashCode * 59 + this.Subitem.GetHashCode();
                if (this.TagNbr != null)
                    hashCode = hashCode * 59 + this.TagNbr.GetHashCode();
                if (this.UnitCost != null)
                    hashCode = hashCode * 59 + this.UnitCost.GetHashCode();
                if (this.VarianceQty != null)
                    hashCode = hashCode * 59 + this.VarianceQty.GetHashCode();
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
