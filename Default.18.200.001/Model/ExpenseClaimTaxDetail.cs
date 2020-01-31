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
    /// ExpenseClaimTaxDetail
    /// </summary>
    [DataContract]
    public partial class ExpenseClaimTaxDetail : Entity,  IEquatable<ExpenseClaimTaxDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpenseClaimTaxDetail" /> class.
        /// </summary>
        /// <param name="deductibleTaxRate">deductibleTaxRate.</param>
        /// <param name="expenseAmount">expenseAmount.</param>
        /// <param name="includeinVATExemptTotal">includeinVATExemptTotal.</param>
        /// <param name="pendingVAT">pendingVAT.</param>
        /// <param name="reverseVAT">reverseVAT.</param>
        /// <param name="statisticalVAT">statisticalVAT.</param>
        /// <param name="taxableAmount">taxableAmount.</param>
        /// <param name="taxAmount">taxAmount.</param>
        /// <param name="taxID">taxID.</param>
        /// <param name="taxRate">taxRate.</param>
        /// <param name="taxType">taxType.</param>
        public ExpenseClaimTaxDetail(DecimalValue deductibleTaxRate = default(DecimalValue), DecimalValue expenseAmount = default(DecimalValue), BooleanValue includeinVATExemptTotal = default(BooleanValue), BooleanValue pendingVAT = default(BooleanValue), BooleanValue reverseVAT = default(BooleanValue), BooleanValue statisticalVAT = default(BooleanValue), DecimalValue taxableAmount = default(DecimalValue), DecimalValue taxAmount = default(DecimalValue), StringValue taxID = default(StringValue), DecimalValue taxRate = default(DecimalValue), StringValue taxType = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.DeductibleTaxRate = deductibleTaxRate;
            this.ExpenseAmount = expenseAmount;
            this.IncludeinVATExemptTotal = includeinVATExemptTotal;
            this.PendingVAT = pendingVAT;
            this.ReverseVAT = reverseVAT;
            this.StatisticalVAT = statisticalVAT;
            this.TaxableAmount = taxableAmount;
            this.TaxAmount = taxAmount;
            this.TaxID = taxID;
            this.TaxRate = taxRate;
            this.TaxType = taxType;
        }
        
        /// <summary>
        /// Gets or Sets DeductibleTaxRate
        /// </summary>
        [DataMember(Name="DeductibleTaxRate", EmitDefaultValue=false)]
        public DecimalValue DeductibleTaxRate { get; set; }

        /// <summary>
        /// Gets or Sets ExpenseAmount
        /// </summary>
        [DataMember(Name="ExpenseAmount", EmitDefaultValue=false)]
        public DecimalValue ExpenseAmount { get; set; }

        /// <summary>
        /// Gets or Sets IncludeinVATExemptTotal
        /// </summary>
        [DataMember(Name="IncludeinVATExemptTotal", EmitDefaultValue=false)]
        public BooleanValue IncludeinVATExemptTotal { get; set; }

        /// <summary>
        /// Gets or Sets PendingVAT
        /// </summary>
        [DataMember(Name="PendingVAT", EmitDefaultValue=false)]
        public BooleanValue PendingVAT { get; set; }

        /// <summary>
        /// Gets or Sets ReverseVAT
        /// </summary>
        [DataMember(Name="ReverseVAT", EmitDefaultValue=false)]
        public BooleanValue ReverseVAT { get; set; }

        /// <summary>
        /// Gets or Sets StatisticalVAT
        /// </summary>
        [DataMember(Name="StatisticalVAT", EmitDefaultValue=false)]
        public BooleanValue StatisticalVAT { get; set; }

        /// <summary>
        /// Gets or Sets TaxableAmount
        /// </summary>
        [DataMember(Name="TaxableAmount", EmitDefaultValue=false)]
        public DecimalValue TaxableAmount { get; set; }

        /// <summary>
        /// Gets or Sets TaxAmount
        /// </summary>
        [DataMember(Name="TaxAmount", EmitDefaultValue=false)]
        public DecimalValue TaxAmount { get; set; }

        /// <summary>
        /// Gets or Sets TaxID
        /// </summary>
        [DataMember(Name="TaxID", EmitDefaultValue=false)]
        public StringValue TaxID { get; set; }

        /// <summary>
        /// Gets or Sets TaxRate
        /// </summary>
        [DataMember(Name="TaxRate", EmitDefaultValue=false)]
        public DecimalValue TaxRate { get; set; }

        /// <summary>
        /// Gets or Sets TaxType
        /// </summary>
        [DataMember(Name="TaxType", EmitDefaultValue=false)]
        public StringValue TaxType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExpenseClaimTaxDetail {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  DeductibleTaxRate: ").Append(DeductibleTaxRate).Append("\n");
            sb.Append("  ExpenseAmount: ").Append(ExpenseAmount).Append("\n");
            sb.Append("  IncludeinVATExemptTotal: ").Append(IncludeinVATExemptTotal).Append("\n");
            sb.Append("  PendingVAT: ").Append(PendingVAT).Append("\n");
            sb.Append("  ReverseVAT: ").Append(ReverseVAT).Append("\n");
            sb.Append("  StatisticalVAT: ").Append(StatisticalVAT).Append("\n");
            sb.Append("  TaxableAmount: ").Append(TaxableAmount).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
            sb.Append("  TaxID: ").Append(TaxID).Append("\n");
            sb.Append("  TaxRate: ").Append(TaxRate).Append("\n");
            sb.Append("  TaxType: ").Append(TaxType).Append("\n");
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
            return this.Equals(input as ExpenseClaimTaxDetail);
        }

        /// <summary>
        /// Returns true if ExpenseClaimTaxDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of ExpenseClaimTaxDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExpenseClaimTaxDetail input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.DeductibleTaxRate == input.DeductibleTaxRate ||
                    (this.DeductibleTaxRate != null &&
                    this.DeductibleTaxRate.Equals(input.DeductibleTaxRate))
                ) && base.Equals(input) && 
                (
                    this.ExpenseAmount == input.ExpenseAmount ||
                    (this.ExpenseAmount != null &&
                    this.ExpenseAmount.Equals(input.ExpenseAmount))
                ) && base.Equals(input) && 
                (
                    this.IncludeinVATExemptTotal == input.IncludeinVATExemptTotal ||
                    (this.IncludeinVATExemptTotal != null &&
                    this.IncludeinVATExemptTotal.Equals(input.IncludeinVATExemptTotal))
                ) && base.Equals(input) && 
                (
                    this.PendingVAT == input.PendingVAT ||
                    (this.PendingVAT != null &&
                    this.PendingVAT.Equals(input.PendingVAT))
                ) && base.Equals(input) && 
                (
                    this.ReverseVAT == input.ReverseVAT ||
                    (this.ReverseVAT != null &&
                    this.ReverseVAT.Equals(input.ReverseVAT))
                ) && base.Equals(input) && 
                (
                    this.StatisticalVAT == input.StatisticalVAT ||
                    (this.StatisticalVAT != null &&
                    this.StatisticalVAT.Equals(input.StatisticalVAT))
                ) && base.Equals(input) && 
                (
                    this.TaxableAmount == input.TaxableAmount ||
                    (this.TaxableAmount != null &&
                    this.TaxableAmount.Equals(input.TaxableAmount))
                ) && base.Equals(input) && 
                (
                    this.TaxAmount == input.TaxAmount ||
                    (this.TaxAmount != null &&
                    this.TaxAmount.Equals(input.TaxAmount))
                ) && base.Equals(input) && 
                (
                    this.TaxID == input.TaxID ||
                    (this.TaxID != null &&
                    this.TaxID.Equals(input.TaxID))
                ) && base.Equals(input) && 
                (
                    this.TaxRate == input.TaxRate ||
                    (this.TaxRate != null &&
                    this.TaxRate.Equals(input.TaxRate))
                ) && base.Equals(input) && 
                (
                    this.TaxType == input.TaxType ||
                    (this.TaxType != null &&
                    this.TaxType.Equals(input.TaxType))
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
                if (this.DeductibleTaxRate != null)
                    hashCode = hashCode * 59 + this.DeductibleTaxRate.GetHashCode();
                if (this.ExpenseAmount != null)
                    hashCode = hashCode * 59 + this.ExpenseAmount.GetHashCode();
                if (this.IncludeinVATExemptTotal != null)
                    hashCode = hashCode * 59 + this.IncludeinVATExemptTotal.GetHashCode();
                if (this.PendingVAT != null)
                    hashCode = hashCode * 59 + this.PendingVAT.GetHashCode();
                if (this.ReverseVAT != null)
                    hashCode = hashCode * 59 + this.ReverseVAT.GetHashCode();
                if (this.StatisticalVAT != null)
                    hashCode = hashCode * 59 + this.StatisticalVAT.GetHashCode();
                if (this.TaxableAmount != null)
                    hashCode = hashCode * 59 + this.TaxableAmount.GetHashCode();
                if (this.TaxAmount != null)
                    hashCode = hashCode * 59 + this.TaxAmount.GetHashCode();
                if (this.TaxID != null)
                    hashCode = hashCode * 59 + this.TaxID.GetHashCode();
                if (this.TaxRate != null)
                    hashCode = hashCode * 59 + this.TaxRate.GetHashCode();
                if (this.TaxType != null)
                    hashCode = hashCode * 59 + this.TaxType.GetHashCode();
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
