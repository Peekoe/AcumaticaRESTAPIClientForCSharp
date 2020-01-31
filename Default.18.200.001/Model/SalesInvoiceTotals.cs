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
    /// SalesInvoiceTotals
    /// </summary>
    [DataContract]
    public partial class SalesInvoiceTotals : Entity,  IEquatable<SalesInvoiceTotals>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesInvoiceTotals" /> class.
        /// </summary>
        /// <param name="discountTotal">discountTotal.</param>
        /// <param name="freight">freight.</param>
        /// <param name="lineTotal">lineTotal.</param>
        /// <param name="miscTotal">miscTotal.</param>
        /// <param name="paymentTotal">paymentTotal.</param>
        /// <param name="taxTotal">taxTotal.</param>
        public SalesInvoiceTotals(DecimalValue discountTotal = default(DecimalValue), DecimalValue freight = default(DecimalValue), DecimalValue lineTotal = default(DecimalValue), DecimalValue miscTotal = default(DecimalValue), DecimalValue paymentTotal = default(DecimalValue), DecimalValue taxTotal = default(DecimalValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.DiscountTotal = discountTotal;
            this.Freight = freight;
            this.LineTotal = lineTotal;
            this.MiscTotal = miscTotal;
            this.PaymentTotal = paymentTotal;
            this.TaxTotal = taxTotal;
        }
        
        /// <summary>
        /// Gets or Sets DiscountTotal
        /// </summary>
        [DataMember(Name="DiscountTotal", EmitDefaultValue=false)]
        public DecimalValue DiscountTotal { get; set; }

        /// <summary>
        /// Gets or Sets Freight
        /// </summary>
        [DataMember(Name="Freight", EmitDefaultValue=false)]
        public DecimalValue Freight { get; set; }

        /// <summary>
        /// Gets or Sets LineTotal
        /// </summary>
        [DataMember(Name="LineTotal", EmitDefaultValue=false)]
        public DecimalValue LineTotal { get; set; }

        /// <summary>
        /// Gets or Sets MiscTotal
        /// </summary>
        [DataMember(Name="MiscTotal", EmitDefaultValue=false)]
        public DecimalValue MiscTotal { get; set; }

        /// <summary>
        /// Gets or Sets PaymentTotal
        /// </summary>
        [DataMember(Name="PaymentTotal", EmitDefaultValue=false)]
        public DecimalValue PaymentTotal { get; set; }

        /// <summary>
        /// Gets or Sets TaxTotal
        /// </summary>
        [DataMember(Name="TaxTotal", EmitDefaultValue=false)]
        public DecimalValue TaxTotal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SalesInvoiceTotals {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  DiscountTotal: ").Append(DiscountTotal).Append("\n");
            sb.Append("  Freight: ").Append(Freight).Append("\n");
            sb.Append("  LineTotal: ").Append(LineTotal).Append("\n");
            sb.Append("  MiscTotal: ").Append(MiscTotal).Append("\n");
            sb.Append("  PaymentTotal: ").Append(PaymentTotal).Append("\n");
            sb.Append("  TaxTotal: ").Append(TaxTotal).Append("\n");
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
            return this.Equals(input as SalesInvoiceTotals);
        }

        /// <summary>
        /// Returns true if SalesInvoiceTotals instances are equal
        /// </summary>
        /// <param name="input">Instance of SalesInvoiceTotals to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SalesInvoiceTotals input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.DiscountTotal == input.DiscountTotal ||
                    (this.DiscountTotal != null &&
                    this.DiscountTotal.Equals(input.DiscountTotal))
                ) && base.Equals(input) && 
                (
                    this.Freight == input.Freight ||
                    (this.Freight != null &&
                    this.Freight.Equals(input.Freight))
                ) && base.Equals(input) && 
                (
                    this.LineTotal == input.LineTotal ||
                    (this.LineTotal != null &&
                    this.LineTotal.Equals(input.LineTotal))
                ) && base.Equals(input) && 
                (
                    this.MiscTotal == input.MiscTotal ||
                    (this.MiscTotal != null &&
                    this.MiscTotal.Equals(input.MiscTotal))
                ) && base.Equals(input) && 
                (
                    this.PaymentTotal == input.PaymentTotal ||
                    (this.PaymentTotal != null &&
                    this.PaymentTotal.Equals(input.PaymentTotal))
                ) && base.Equals(input) && 
                (
                    this.TaxTotal == input.TaxTotal ||
                    (this.TaxTotal != null &&
                    this.TaxTotal.Equals(input.TaxTotal))
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
                if (this.DiscountTotal != null)
                    hashCode = hashCode * 59 + this.DiscountTotal.GetHashCode();
                if (this.Freight != null)
                    hashCode = hashCode * 59 + this.Freight.GetHashCode();
                if (this.LineTotal != null)
                    hashCode = hashCode * 59 + this.LineTotal.GetHashCode();
                if (this.MiscTotal != null)
                    hashCode = hashCode * 59 + this.MiscTotal.GetHashCode();
                if (this.PaymentTotal != null)
                    hashCode = hashCode * 59 + this.PaymentTotal.GetHashCode();
                if (this.TaxTotal != null)
                    hashCode = hashCode * 59 + this.TaxTotal.GetHashCode();
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
