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
    /// InvoiceDiscountDetail
    /// </summary>
    [DataContract]
    public partial class InvoiceDiscountDetail : Entity,  IEquatable<InvoiceDiscountDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceDiscountDetail" /> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="discountableAmount">discountableAmount.</param>
        /// <param name="discountableQty">discountableQty.</param>
        /// <param name="discountAmount">discountAmount.</param>
        /// <param name="discountCode">discountCode.</param>
        /// <param name="discountPercent">discountPercent.</param>
        /// <param name="externalDiscountCode">externalDiscountCode.</param>
        /// <param name="manualDiscount">manualDiscount.</param>
        /// <param name="orderNbr">orderNbr.</param>
        /// <param name="orderType">orderType.</param>
        /// <param name="retainedDiscount">retainedDiscount.</param>
        /// <param name="sequenceID">sequenceID.</param>
        /// <param name="skipDiscount">skipDiscount.</param>
        /// <param name="type">type.</param>
        public InvoiceDiscountDetail(StringValue description = default(StringValue), DecimalValue discountableAmount = default(DecimalValue), DecimalValue discountableQty = default(DecimalValue), DecimalValue discountAmount = default(DecimalValue), StringValue discountCode = default(StringValue), DecimalValue discountPercent = default(DecimalValue), StringValue externalDiscountCode = default(StringValue), BooleanValue manualDiscount = default(BooleanValue), StringValue orderNbr = default(StringValue), StringValue orderType = default(StringValue), DecimalValue retainedDiscount = default(DecimalValue), StringValue sequenceID = default(StringValue), BooleanValue skipDiscount = default(BooleanValue), StringValue type = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Description = description;
            this.DiscountableAmount = discountableAmount;
            this.DiscountableQty = discountableQty;
            this.DiscountAmount = discountAmount;
            this.DiscountCode = discountCode;
            this.DiscountPercent = discountPercent;
            this.ExternalDiscountCode = externalDiscountCode;
            this.ManualDiscount = manualDiscount;
            this.OrderNbr = orderNbr;
            this.OrderType = orderType;
            this.RetainedDiscount = retainedDiscount;
            this.SequenceID = sequenceID;
            this.SkipDiscount = skipDiscount;
            this.Type = type;
        }
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets DiscountableAmount
        /// </summary>
        [DataMember(Name="DiscountableAmount", EmitDefaultValue=false)]
        public DecimalValue DiscountableAmount { get; set; }

        /// <summary>
        /// Gets or Sets DiscountableQty
        /// </summary>
        [DataMember(Name="DiscountableQty", EmitDefaultValue=false)]
        public DecimalValue DiscountableQty { get; set; }

        /// <summary>
        /// Gets or Sets DiscountAmount
        /// </summary>
        [DataMember(Name="DiscountAmount", EmitDefaultValue=false)]
        public DecimalValue DiscountAmount { get; set; }

        /// <summary>
        /// Gets or Sets DiscountCode
        /// </summary>
        [DataMember(Name="DiscountCode", EmitDefaultValue=false)]
        public StringValue DiscountCode { get; set; }

        /// <summary>
        /// Gets or Sets DiscountPercent
        /// </summary>
        [DataMember(Name="DiscountPercent", EmitDefaultValue=false)]
        public DecimalValue DiscountPercent { get; set; }

        /// <summary>
        /// Gets or Sets ExternalDiscountCode
        /// </summary>
        [DataMember(Name="ExternalDiscountCode", EmitDefaultValue=false)]
        public StringValue ExternalDiscountCode { get; set; }

        /// <summary>
        /// Gets or Sets ManualDiscount
        /// </summary>
        [DataMember(Name="ManualDiscount", EmitDefaultValue=false)]
        public BooleanValue ManualDiscount { get; set; }

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
        /// Gets or Sets RetainedDiscount
        /// </summary>
        [DataMember(Name="RetainedDiscount", EmitDefaultValue=false)]
        public DecimalValue RetainedDiscount { get; set; }

        /// <summary>
        /// Gets or Sets SequenceID
        /// </summary>
        [DataMember(Name="SequenceID", EmitDefaultValue=false)]
        public StringValue SequenceID { get; set; }

        /// <summary>
        /// Gets or Sets SkipDiscount
        /// </summary>
        [DataMember(Name="SkipDiscount", EmitDefaultValue=false)]
        public BooleanValue SkipDiscount { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public StringValue Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvoiceDiscountDetail {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DiscountableAmount: ").Append(DiscountableAmount).Append("\n");
            sb.Append("  DiscountableQty: ").Append(DiscountableQty).Append("\n");
            sb.Append("  DiscountAmount: ").Append(DiscountAmount).Append("\n");
            sb.Append("  DiscountCode: ").Append(DiscountCode).Append("\n");
            sb.Append("  DiscountPercent: ").Append(DiscountPercent).Append("\n");
            sb.Append("  ExternalDiscountCode: ").Append(ExternalDiscountCode).Append("\n");
            sb.Append("  ManualDiscount: ").Append(ManualDiscount).Append("\n");
            sb.Append("  OrderNbr: ").Append(OrderNbr).Append("\n");
            sb.Append("  OrderType: ").Append(OrderType).Append("\n");
            sb.Append("  RetainedDiscount: ").Append(RetainedDiscount).Append("\n");
            sb.Append("  SequenceID: ").Append(SequenceID).Append("\n");
            sb.Append("  SkipDiscount: ").Append(SkipDiscount).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as InvoiceDiscountDetail);
        }

        /// <summary>
        /// Returns true if InvoiceDiscountDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceDiscountDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceDiscountDetail input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.DiscountableAmount == input.DiscountableAmount ||
                    (this.DiscountableAmount != null &&
                    this.DiscountableAmount.Equals(input.DiscountableAmount))
                ) && base.Equals(input) && 
                (
                    this.DiscountableQty == input.DiscountableQty ||
                    (this.DiscountableQty != null &&
                    this.DiscountableQty.Equals(input.DiscountableQty))
                ) && base.Equals(input) && 
                (
                    this.DiscountAmount == input.DiscountAmount ||
                    (this.DiscountAmount != null &&
                    this.DiscountAmount.Equals(input.DiscountAmount))
                ) && base.Equals(input) && 
                (
                    this.DiscountCode == input.DiscountCode ||
                    (this.DiscountCode != null &&
                    this.DiscountCode.Equals(input.DiscountCode))
                ) && base.Equals(input) && 
                (
                    this.DiscountPercent == input.DiscountPercent ||
                    (this.DiscountPercent != null &&
                    this.DiscountPercent.Equals(input.DiscountPercent))
                ) && base.Equals(input) && 
                (
                    this.ExternalDiscountCode == input.ExternalDiscountCode ||
                    (this.ExternalDiscountCode != null &&
                    this.ExternalDiscountCode.Equals(input.ExternalDiscountCode))
                ) && base.Equals(input) && 
                (
                    this.ManualDiscount == input.ManualDiscount ||
                    (this.ManualDiscount != null &&
                    this.ManualDiscount.Equals(input.ManualDiscount))
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
                    this.RetainedDiscount == input.RetainedDiscount ||
                    (this.RetainedDiscount != null &&
                    this.RetainedDiscount.Equals(input.RetainedDiscount))
                ) && base.Equals(input) && 
                (
                    this.SequenceID == input.SequenceID ||
                    (this.SequenceID != null &&
                    this.SequenceID.Equals(input.SequenceID))
                ) && base.Equals(input) && 
                (
                    this.SkipDiscount == input.SkipDiscount ||
                    (this.SkipDiscount != null &&
                    this.SkipDiscount.Equals(input.SkipDiscount))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DiscountableAmount != null)
                    hashCode = hashCode * 59 + this.DiscountableAmount.GetHashCode();
                if (this.DiscountableQty != null)
                    hashCode = hashCode * 59 + this.DiscountableQty.GetHashCode();
                if (this.DiscountAmount != null)
                    hashCode = hashCode * 59 + this.DiscountAmount.GetHashCode();
                if (this.DiscountCode != null)
                    hashCode = hashCode * 59 + this.DiscountCode.GetHashCode();
                if (this.DiscountPercent != null)
                    hashCode = hashCode * 59 + this.DiscountPercent.GetHashCode();
                if (this.ExternalDiscountCode != null)
                    hashCode = hashCode * 59 + this.ExternalDiscountCode.GetHashCode();
                if (this.ManualDiscount != null)
                    hashCode = hashCode * 59 + this.ManualDiscount.GetHashCode();
                if (this.OrderNbr != null)
                    hashCode = hashCode * 59 + this.OrderNbr.GetHashCode();
                if (this.OrderType != null)
                    hashCode = hashCode * 59 + this.OrderType.GetHashCode();
                if (this.RetainedDiscount != null)
                    hashCode = hashCode * 59 + this.RetainedDiscount.GetHashCode();
                if (this.SequenceID != null)
                    hashCode = hashCode * 59 + this.SequenceID.GetHashCode();
                if (this.SkipDiscount != null)
                    hashCode = hashCode * 59 + this.SkipDiscount.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
