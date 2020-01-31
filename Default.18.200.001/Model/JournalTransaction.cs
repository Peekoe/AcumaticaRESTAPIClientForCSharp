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
    /// JournalTransaction
    /// </summary>
    [DataContract]
    public partial class JournalTransaction : Entity,  IEquatable<JournalTransaction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JournalTransaction" /> class.
        /// </summary>
        /// <param name="batchNbr">batchNbr.</param>
        /// <param name="branchID">branchID.</param>
        /// <param name="createdDateTime">createdDateTime.</param>
        /// <param name="currencyID">currencyID.</param>
        /// <param name="description">description.</param>
        /// <param name="details">details.</param>
        /// <param name="hold">hold.</param>
        /// <param name="lastModifiedDateTime">lastModifiedDateTime.</param>
        /// <param name="ledgerID">ledgerID.</param>
        /// <param name="module">module.</param>
        /// <param name="postPeriod">postPeriod.</param>
        /// <param name="status">status.</param>
        /// <param name="transactionDate">transactionDate.</param>
        public JournalTransaction(StringValue batchNbr = default(StringValue), StringValue branchID = default(StringValue), DateTimeValue createdDateTime = default(DateTimeValue), StringValue currencyID = default(StringValue), StringValue description = default(StringValue), List<JournalTransactionDetail> details = default(List<JournalTransactionDetail>), BooleanValue hold = default(BooleanValue), DateTimeValue lastModifiedDateTime = default(DateTimeValue), StringValue ledgerID = default(StringValue), StringValue module = default(StringValue), StringValue postPeriod = default(StringValue), StringValue status = default(StringValue), DateTimeValue transactionDate = default(DateTimeValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.BatchNbr = batchNbr;
            this.BranchID = branchID;
            this.CreatedDateTime = createdDateTime;
            this.CurrencyID = currencyID;
            this.Description = description;
            this.Details = details;
            this.Hold = hold;
            this.LastModifiedDateTime = lastModifiedDateTime;
            this.LedgerID = ledgerID;
            this.Module = module;
            this.PostPeriod = postPeriod;
            this.Status = status;
            this.TransactionDate = transactionDate;
        }
        
        /// <summary>
        /// Gets or Sets BatchNbr
        /// </summary>
        [DataMember(Name="BatchNbr", EmitDefaultValue=false)]
        public StringValue BatchNbr { get; set; }

        /// <summary>
        /// Gets or Sets BranchID
        /// </summary>
        [DataMember(Name="BranchID", EmitDefaultValue=false)]
        public StringValue BranchID { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDateTime
        /// </summary>
        [DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
        public DateTimeValue CreatedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyID
        /// </summary>
        [DataMember(Name="CurrencyID", EmitDefaultValue=false)]
        public StringValue CurrencyID { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="Details", EmitDefaultValue=false)]
        public List<JournalTransactionDetail> Details { get; set; }

        /// <summary>
        /// Gets or Sets Hold
        /// </summary>
        [DataMember(Name="Hold", EmitDefaultValue=false)]
        public BooleanValue Hold { get; set; }

        /// <summary>
        /// Gets or Sets LastModifiedDateTime
        /// </summary>
        [DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
        public DateTimeValue LastModifiedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets LedgerID
        /// </summary>
        [DataMember(Name="LedgerID", EmitDefaultValue=false)]
        public StringValue LedgerID { get; set; }

        /// <summary>
        /// Gets or Sets Module
        /// </summary>
        [DataMember(Name="Module", EmitDefaultValue=false)]
        public StringValue Module { get; set; }

        /// <summary>
        /// Gets or Sets PostPeriod
        /// </summary>
        [DataMember(Name="PostPeriod", EmitDefaultValue=false)]
        public StringValue PostPeriod { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StringValue Status { get; set; }

        /// <summary>
        /// Gets or Sets TransactionDate
        /// </summary>
        [DataMember(Name="TransactionDate", EmitDefaultValue=false)]
        public DateTimeValue TransactionDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JournalTransaction {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  BatchNbr: ").Append(BatchNbr).Append("\n");
            sb.Append("  BranchID: ").Append(BranchID).Append("\n");
            sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
            sb.Append("  CurrencyID: ").Append(CurrencyID).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Hold: ").Append(Hold).Append("\n");
            sb.Append("  LastModifiedDateTime: ").Append(LastModifiedDateTime).Append("\n");
            sb.Append("  LedgerID: ").Append(LedgerID).Append("\n");
            sb.Append("  Module: ").Append(Module).Append("\n");
            sb.Append("  PostPeriod: ").Append(PostPeriod).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TransactionDate: ").Append(TransactionDate).Append("\n");
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
            return this.Equals(input as JournalTransaction);
        }

        /// <summary>
        /// Returns true if JournalTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of JournalTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JournalTransaction input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.BatchNbr == input.BatchNbr ||
                    (this.BatchNbr != null &&
                    this.BatchNbr.Equals(input.BatchNbr))
                ) && base.Equals(input) && 
                (
                    this.BranchID == input.BranchID ||
                    (this.BranchID != null &&
                    this.BranchID.Equals(input.BranchID))
                ) && base.Equals(input) && 
                (
                    this.CreatedDateTime == input.CreatedDateTime ||
                    (this.CreatedDateTime != null &&
                    this.CreatedDateTime.Equals(input.CreatedDateTime))
                ) && base.Equals(input) && 
                (
                    this.CurrencyID == input.CurrencyID ||
                    (this.CurrencyID != null &&
                    this.CurrencyID.Equals(input.CurrencyID))
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
                    this.Hold == input.Hold ||
                    (this.Hold != null &&
                    this.Hold.Equals(input.Hold))
                ) && base.Equals(input) && 
                (
                    this.LastModifiedDateTime == input.LastModifiedDateTime ||
                    (this.LastModifiedDateTime != null &&
                    this.LastModifiedDateTime.Equals(input.LastModifiedDateTime))
                ) && base.Equals(input) && 
                (
                    this.LedgerID == input.LedgerID ||
                    (this.LedgerID != null &&
                    this.LedgerID.Equals(input.LedgerID))
                ) && base.Equals(input) && 
                (
                    this.Module == input.Module ||
                    (this.Module != null &&
                    this.Module.Equals(input.Module))
                ) && base.Equals(input) && 
                (
                    this.PostPeriod == input.PostPeriod ||
                    (this.PostPeriod != null &&
                    this.PostPeriod.Equals(input.PostPeriod))
                ) && base.Equals(input) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && base.Equals(input) && 
                (
                    this.TransactionDate == input.TransactionDate ||
                    (this.TransactionDate != null &&
                    this.TransactionDate.Equals(input.TransactionDate))
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
                if (this.BatchNbr != null)
                    hashCode = hashCode * 59 + this.BatchNbr.GetHashCode();
                if (this.BranchID != null)
                    hashCode = hashCode * 59 + this.BranchID.GetHashCode();
                if (this.CreatedDateTime != null)
                    hashCode = hashCode * 59 + this.CreatedDateTime.GetHashCode();
                if (this.CurrencyID != null)
                    hashCode = hashCode * 59 + this.CurrencyID.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.Hold != null)
                    hashCode = hashCode * 59 + this.Hold.GetHashCode();
                if (this.LastModifiedDateTime != null)
                    hashCode = hashCode * 59 + this.LastModifiedDateTime.GetHashCode();
                if (this.LedgerID != null)
                    hashCode = hashCode * 59 + this.LedgerID.GetHashCode();
                if (this.Module != null)
                    hashCode = hashCode * 59 + this.Module.GetHashCode();
                if (this.PostPeriod != null)
                    hashCode = hashCode * 59 + this.PostPeriod.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TransactionDate != null)
                    hashCode = hashCode * 59 + this.TransactionDate.GetHashCode();
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
