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
    /// ProjectTransaction
    /// </summary>
    [DataContract]
    public partial class ProjectTransaction : Entity,  IEquatable<ProjectTransaction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTransaction" /> class.
        /// </summary>
        /// <param name="createdDateTime">createdDateTime.</param>
        /// <param name="description">description.</param>
        /// <param name="details">details.</param>
        /// <param name="lastModifiedDateTime">lastModifiedDateTime.</param>
        /// <param name="module">module.</param>
        /// <param name="originalDocNbr">originalDocNbr.</param>
        /// <param name="originalDocType">originalDocType.</param>
        /// <param name="referenceNbr">referenceNbr.</param>
        /// <param name="status">status.</param>
        /// <param name="totalAmount">totalAmount.</param>
        /// <param name="totalBillableQty">totalBillableQty.</param>
        /// <param name="totalQty">totalQty.</param>
        public ProjectTransaction(DateTimeValue createdDateTime = default(DateTimeValue), StringValue description = default(StringValue), List<ProjectTransactionDetail> details = default(List<ProjectTransactionDetail>), DateTimeValue lastModifiedDateTime = default(DateTimeValue), StringValue module = default(StringValue), StringValue originalDocNbr = default(StringValue), StringValue originalDocType = default(StringValue), StringValue referenceNbr = default(StringValue), StringValue status = default(StringValue), DecimalValue totalAmount = default(DecimalValue), DecimalValue totalBillableQty = default(DecimalValue), DecimalValue totalQty = default(DecimalValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.CreatedDateTime = createdDateTime;
            this.Description = description;
            this.Details = details;
            this.LastModifiedDateTime = lastModifiedDateTime;
            this.Module = module;
            this.OriginalDocNbr = originalDocNbr;
            this.OriginalDocType = originalDocType;
            this.ReferenceNbr = referenceNbr;
            this.Status = status;
            this.TotalAmount = totalAmount;
            this.TotalBillableQty = totalBillableQty;
            this.TotalQty = totalQty;
        }
        
        /// <summary>
        /// Gets or Sets CreatedDateTime
        /// </summary>
        [DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
        public DateTimeValue CreatedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="Details", EmitDefaultValue=false)]
        public List<ProjectTransactionDetail> Details { get; set; }

        /// <summary>
        /// Gets or Sets LastModifiedDateTime
        /// </summary>
        [DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
        public DateTimeValue LastModifiedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets Module
        /// </summary>
        [DataMember(Name="Module", EmitDefaultValue=false)]
        public StringValue Module { get; set; }

        /// <summary>
        /// Gets or Sets OriginalDocNbr
        /// </summary>
        [DataMember(Name="OriginalDocNbr", EmitDefaultValue=false)]
        public StringValue OriginalDocNbr { get; set; }

        /// <summary>
        /// Gets or Sets OriginalDocType
        /// </summary>
        [DataMember(Name="OriginalDocType", EmitDefaultValue=false)]
        public StringValue OriginalDocType { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceNbr
        /// </summary>
        [DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
        public StringValue ReferenceNbr { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StringValue Status { get; set; }

        /// <summary>
        /// Gets or Sets TotalAmount
        /// </summary>
        [DataMember(Name="TotalAmount", EmitDefaultValue=false)]
        public DecimalValue TotalAmount { get; set; }

        /// <summary>
        /// Gets or Sets TotalBillableQty
        /// </summary>
        [DataMember(Name="TotalBillableQty", EmitDefaultValue=false)]
        public DecimalValue TotalBillableQty { get; set; }

        /// <summary>
        /// Gets or Sets TotalQty
        /// </summary>
        [DataMember(Name="TotalQty", EmitDefaultValue=false)]
        public DecimalValue TotalQty { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectTransaction {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  LastModifiedDateTime: ").Append(LastModifiedDateTime).Append("\n");
            sb.Append("  Module: ").Append(Module).Append("\n");
            sb.Append("  OriginalDocNbr: ").Append(OriginalDocNbr).Append("\n");
            sb.Append("  OriginalDocType: ").Append(OriginalDocType).Append("\n");
            sb.Append("  ReferenceNbr: ").Append(ReferenceNbr).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  TotalBillableQty: ").Append(TotalBillableQty).Append("\n");
            sb.Append("  TotalQty: ").Append(TotalQty).Append("\n");
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
            return this.Equals(input as ProjectTransaction);
        }

        /// <summary>
        /// Returns true if ProjectTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectTransaction input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.CreatedDateTime == input.CreatedDateTime ||
                    (this.CreatedDateTime != null &&
                    this.CreatedDateTime.Equals(input.CreatedDateTime))
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.Details == input.Details ||
                    this.Details != null &&
                    this.Details.SequenceEqual(input.Details)
                ) && base.Equals(input) && 
                (
                    this.LastModifiedDateTime == input.LastModifiedDateTime ||
                    (this.LastModifiedDateTime != null &&
                    this.LastModifiedDateTime.Equals(input.LastModifiedDateTime))
                ) && base.Equals(input) && 
                (
                    this.Module == input.Module ||
                    (this.Module != null &&
                    this.Module.Equals(input.Module))
                ) && base.Equals(input) && 
                (
                    this.OriginalDocNbr == input.OriginalDocNbr ||
                    (this.OriginalDocNbr != null &&
                    this.OriginalDocNbr.Equals(input.OriginalDocNbr))
                ) && base.Equals(input) && 
                (
                    this.OriginalDocType == input.OriginalDocType ||
                    (this.OriginalDocType != null &&
                    this.OriginalDocType.Equals(input.OriginalDocType))
                ) && base.Equals(input) && 
                (
                    this.ReferenceNbr == input.ReferenceNbr ||
                    (this.ReferenceNbr != null &&
                    this.ReferenceNbr.Equals(input.ReferenceNbr))
                ) && base.Equals(input) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && base.Equals(input) && 
                (
                    this.TotalAmount == input.TotalAmount ||
                    (this.TotalAmount != null &&
                    this.TotalAmount.Equals(input.TotalAmount))
                ) && base.Equals(input) && 
                (
                    this.TotalBillableQty == input.TotalBillableQty ||
                    (this.TotalBillableQty != null &&
                    this.TotalBillableQty.Equals(input.TotalBillableQty))
                ) && base.Equals(input) && 
                (
                    this.TotalQty == input.TotalQty ||
                    (this.TotalQty != null &&
                    this.TotalQty.Equals(input.TotalQty))
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
                if (this.CreatedDateTime != null)
                    hashCode = hashCode * 59 + this.CreatedDateTime.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.LastModifiedDateTime != null)
                    hashCode = hashCode * 59 + this.LastModifiedDateTime.GetHashCode();
                if (this.Module != null)
                    hashCode = hashCode * 59 + this.Module.GetHashCode();
                if (this.OriginalDocNbr != null)
                    hashCode = hashCode * 59 + this.OriginalDocNbr.GetHashCode();
                if (this.OriginalDocType != null)
                    hashCode = hashCode * 59 + this.OriginalDocType.GetHashCode();
                if (this.ReferenceNbr != null)
                    hashCode = hashCode * 59 + this.ReferenceNbr.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TotalAmount != null)
                    hashCode = hashCode * 59 + this.TotalAmount.GetHashCode();
                if (this.TotalBillableQty != null)
                    hashCode = hashCode * 59 + this.TotalBillableQty.GetHashCode();
                if (this.TotalQty != null)
                    hashCode = hashCode * 59 + this.TotalQty.GetHashCode();
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
