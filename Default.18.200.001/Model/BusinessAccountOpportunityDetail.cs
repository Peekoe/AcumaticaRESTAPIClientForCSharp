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
    /// BusinessAccountOpportunityDetail
    /// </summary>
    [DataContract]
    public partial class BusinessAccountOpportunityDetail : Entity,  IEquatable<BusinessAccountOpportunityDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessAccountOpportunityDetail" /> class.
        /// </summary>
        /// <param name="businessAccountID">businessAccountID.</param>
        /// <param name="businessAccountName">businessAccountName.</param>
        /// <param name="currencyID">currencyID.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="estimation">estimation.</param>
        /// <param name="owner">owner.</param>
        /// <param name="probability">probability.</param>
        /// <param name="stage">stage.</param>
        /// <param name="status">status.</param>
        /// <param name="subject">subject.</param>
        /// <param name="total">total.</param>
        /// <param name="workgroup">workgroup.</param>
        public BusinessAccountOpportunityDetail(StringValue businessAccountID = default(StringValue), StringValue businessAccountName = default(StringValue), StringValue currencyID = default(StringValue), StringValue displayName = default(StringValue), DateTimeValue estimation = default(DateTimeValue), StringValue owner = default(StringValue), IntValue probability = default(IntValue), StringValue stage = default(StringValue), StringValue status = default(StringValue), StringValue subject = default(StringValue), DecimalValue total = default(DecimalValue), StringValue workgroup = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.BusinessAccountID = businessAccountID;
            this.BusinessAccountName = businessAccountName;
            this.CurrencyID = currencyID;
            this.DisplayName = displayName;
            this.Estimation = estimation;
            this.Owner = owner;
            this.Probability = probability;
            this.Stage = stage;
            this.Status = status;
            this.Subject = subject;
            this.Total = total;
            this.Workgroup = workgroup;
        }
        
        /// <summary>
        /// Gets or Sets BusinessAccountID
        /// </summary>
        [DataMember(Name="BusinessAccountID", EmitDefaultValue=false)]
        public StringValue BusinessAccountID { get; set; }

        /// <summary>
        /// Gets or Sets BusinessAccountName
        /// </summary>
        [DataMember(Name="BusinessAccountName", EmitDefaultValue=false)]
        public StringValue BusinessAccountName { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyID
        /// </summary>
        [DataMember(Name="CurrencyID", EmitDefaultValue=false)]
        public StringValue CurrencyID { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="DisplayName", EmitDefaultValue=false)]
        public StringValue DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Estimation
        /// </summary>
        [DataMember(Name="Estimation", EmitDefaultValue=false)]
        public DateTimeValue Estimation { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name="Owner", EmitDefaultValue=false)]
        public StringValue Owner { get; set; }

        /// <summary>
        /// Gets or Sets Probability
        /// </summary>
        [DataMember(Name="Probability", EmitDefaultValue=false)]
        public IntValue Probability { get; set; }

        /// <summary>
        /// Gets or Sets Stage
        /// </summary>
        [DataMember(Name="Stage", EmitDefaultValue=false)]
        public StringValue Stage { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StringValue Status { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name="Subject", EmitDefaultValue=false)]
        public StringValue Subject { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="Total", EmitDefaultValue=false)]
        public DecimalValue Total { get; set; }

        /// <summary>
        /// Gets or Sets Workgroup
        /// </summary>
        [DataMember(Name="Workgroup", EmitDefaultValue=false)]
        public StringValue Workgroup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessAccountOpportunityDetail {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  BusinessAccountID: ").Append(BusinessAccountID).Append("\n");
            sb.Append("  BusinessAccountName: ").Append(BusinessAccountName).Append("\n");
            sb.Append("  CurrencyID: ").Append(CurrencyID).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Estimation: ").Append(Estimation).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Probability: ").Append(Probability).Append("\n");
            sb.Append("  Stage: ").Append(Stage).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Workgroup: ").Append(Workgroup).Append("\n");
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
            return this.Equals(input as BusinessAccountOpportunityDetail);
        }

        /// <summary>
        /// Returns true if BusinessAccountOpportunityDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessAccountOpportunityDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessAccountOpportunityDetail input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.BusinessAccountID == input.BusinessAccountID ||
                    (this.BusinessAccountID != null &&
                    this.BusinessAccountID.Equals(input.BusinessAccountID))
                ) && base.Equals(input) && 
                (
                    this.BusinessAccountName == input.BusinessAccountName ||
                    (this.BusinessAccountName != null &&
                    this.BusinessAccountName.Equals(input.BusinessAccountName))
                ) && base.Equals(input) && 
                (
                    this.CurrencyID == input.CurrencyID ||
                    (this.CurrencyID != null &&
                    this.CurrencyID.Equals(input.CurrencyID))
                ) && base.Equals(input) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && base.Equals(input) && 
                (
                    this.Estimation == input.Estimation ||
                    (this.Estimation != null &&
                    this.Estimation.Equals(input.Estimation))
                ) && base.Equals(input) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && base.Equals(input) && 
                (
                    this.Probability == input.Probability ||
                    (this.Probability != null &&
                    this.Probability.Equals(input.Probability))
                ) && base.Equals(input) && 
                (
                    this.Stage == input.Stage ||
                    (this.Stage != null &&
                    this.Stage.Equals(input.Stage))
                ) && base.Equals(input) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && base.Equals(input) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && base.Equals(input) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && base.Equals(input) && 
                (
                    this.Workgroup == input.Workgroup ||
                    (this.Workgroup != null &&
                    this.Workgroup.Equals(input.Workgroup))
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
                if (this.BusinessAccountID != null)
                    hashCode = hashCode * 59 + this.BusinessAccountID.GetHashCode();
                if (this.BusinessAccountName != null)
                    hashCode = hashCode * 59 + this.BusinessAccountName.GetHashCode();
                if (this.CurrencyID != null)
                    hashCode = hashCode * 59 + this.CurrencyID.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Estimation != null)
                    hashCode = hashCode * 59 + this.Estimation.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Probability != null)
                    hashCode = hashCode * 59 + this.Probability.GetHashCode();
                if (this.Stage != null)
                    hashCode = hashCode * 59 + this.Stage.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Workgroup != null)
                    hashCode = hashCode * 59 + this.Workgroup.GetHashCode();
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
