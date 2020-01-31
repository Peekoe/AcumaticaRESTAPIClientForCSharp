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
    /// AccountDetailsInquiry
    /// </summary>
    [DataContract]
    public partial class AccountDetailsInquiry : Entity,  IEquatable<AccountDetailsInquiry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDetailsInquiry" /> class.
        /// </summary>
        /// <param name="account">account.</param>
        /// <param name="beginingBalance">beginingBalance.</param>
        /// <param name="branch">branch.</param>
        /// <param name="endingBalance">endingBalance.</param>
        /// <param name="fromDate">fromDate.</param>
        /// <param name="fromPeriod">fromPeriod.</param>
        /// <param name="includeReclassified">includeReclassified.</param>
        /// <param name="includeUnposted">includeUnposted.</param>
        /// <param name="includeUnreleased">includeUnreleased.</param>
        /// <param name="ledger">ledger.</param>
        /// <param name="periodEndDate">periodEndDate.</param>
        /// <param name="periodStartDate">periodStartDate.</param>
        /// <param name="results">results.</param>
        /// <param name="subaccount">subaccount.</param>
        /// <param name="toDate">toDate.</param>
        /// <param name="toPeriod">toPeriod.</param>
        /// <param name="turnover">turnover.</param>
        public AccountDetailsInquiry(StringValue account = default(StringValue), DecimalValue beginingBalance = default(DecimalValue), StringValue branch = default(StringValue), DecimalValue endingBalance = default(DecimalValue), DateTimeValue fromDate = default(DateTimeValue), StringValue fromPeriod = default(StringValue), BooleanValue includeReclassified = default(BooleanValue), BooleanValue includeUnposted = default(BooleanValue), BooleanValue includeUnreleased = default(BooleanValue), StringValue ledger = default(StringValue), DateTimeValue periodEndDate = default(DateTimeValue), DateTimeValue periodStartDate = default(DateTimeValue), List<AccountDetailsRow> results = default(List<AccountDetailsRow>), StringValue subaccount = default(StringValue), DateTimeValue toDate = default(DateTimeValue), StringValue toPeriod = default(StringValue), DecimalValue turnover = default(DecimalValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Account = account;
            this.BeginingBalance = beginingBalance;
            this.Branch = branch;
            this.EndingBalance = endingBalance;
            this.FromDate = fromDate;
            this.FromPeriod = fromPeriod;
            this.IncludeReclassified = includeReclassified;
            this.IncludeUnposted = includeUnposted;
            this.IncludeUnreleased = includeUnreleased;
            this.Ledger = ledger;
            this.PeriodEndDate = periodEndDate;
            this.PeriodStartDate = periodStartDate;
            this.Results = results;
            this.Subaccount = subaccount;
            this.ToDate = toDate;
            this.ToPeriod = toPeriod;
            this.Turnover = turnover;
        }
        
        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name="Account", EmitDefaultValue=false)]
        public StringValue Account { get; set; }

        /// <summary>
        /// Gets or Sets BeginingBalance
        /// </summary>
        [DataMember(Name="BeginingBalance", EmitDefaultValue=false)]
        public DecimalValue BeginingBalance { get; set; }

        /// <summary>
        /// Gets or Sets Branch
        /// </summary>
        [DataMember(Name="Branch", EmitDefaultValue=false)]
        public StringValue Branch { get; set; }

        /// <summary>
        /// Gets or Sets EndingBalance
        /// </summary>
        [DataMember(Name="EndingBalance", EmitDefaultValue=false)]
        public DecimalValue EndingBalance { get; set; }

        /// <summary>
        /// Gets or Sets FromDate
        /// </summary>
        [DataMember(Name="FromDate", EmitDefaultValue=false)]
        public DateTimeValue FromDate { get; set; }

        /// <summary>
        /// Gets or Sets FromPeriod
        /// </summary>
        [DataMember(Name="FromPeriod", EmitDefaultValue=false)]
        public StringValue FromPeriod { get; set; }

        /// <summary>
        /// Gets or Sets IncludeReclassified
        /// </summary>
        [DataMember(Name="IncludeReclassified", EmitDefaultValue=false)]
        public BooleanValue IncludeReclassified { get; set; }

        /// <summary>
        /// Gets or Sets IncludeUnposted
        /// </summary>
        [DataMember(Name="IncludeUnposted", EmitDefaultValue=false)]
        public BooleanValue IncludeUnposted { get; set; }

        /// <summary>
        /// Gets or Sets IncludeUnreleased
        /// </summary>
        [DataMember(Name="IncludeUnreleased", EmitDefaultValue=false)]
        public BooleanValue IncludeUnreleased { get; set; }

        /// <summary>
        /// Gets or Sets Ledger
        /// </summary>
        [DataMember(Name="Ledger", EmitDefaultValue=false)]
        public StringValue Ledger { get; set; }

        /// <summary>
        /// Gets or Sets PeriodEndDate
        /// </summary>
        [DataMember(Name="PeriodEndDate", EmitDefaultValue=false)]
        public DateTimeValue PeriodEndDate { get; set; }

        /// <summary>
        /// Gets or Sets PeriodStartDate
        /// </summary>
        [DataMember(Name="PeriodStartDate", EmitDefaultValue=false)]
        public DateTimeValue PeriodStartDate { get; set; }

        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name="Results", EmitDefaultValue=false)]
        public List<AccountDetailsRow> Results { get; set; }

        /// <summary>
        /// Gets or Sets Subaccount
        /// </summary>
        [DataMember(Name="Subaccount", EmitDefaultValue=false)]
        public StringValue Subaccount { get; set; }

        /// <summary>
        /// Gets or Sets ToDate
        /// </summary>
        [DataMember(Name="ToDate", EmitDefaultValue=false)]
        public DateTimeValue ToDate { get; set; }

        /// <summary>
        /// Gets or Sets ToPeriod
        /// </summary>
        [DataMember(Name="ToPeriod", EmitDefaultValue=false)]
        public StringValue ToPeriod { get; set; }

        /// <summary>
        /// Gets or Sets Turnover
        /// </summary>
        [DataMember(Name="Turnover", EmitDefaultValue=false)]
        public DecimalValue Turnover { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountDetailsInquiry {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  BeginingBalance: ").Append(BeginingBalance).Append("\n");
            sb.Append("  Branch: ").Append(Branch).Append("\n");
            sb.Append("  EndingBalance: ").Append(EndingBalance).Append("\n");
            sb.Append("  FromDate: ").Append(FromDate).Append("\n");
            sb.Append("  FromPeriod: ").Append(FromPeriod).Append("\n");
            sb.Append("  IncludeReclassified: ").Append(IncludeReclassified).Append("\n");
            sb.Append("  IncludeUnposted: ").Append(IncludeUnposted).Append("\n");
            sb.Append("  IncludeUnreleased: ").Append(IncludeUnreleased).Append("\n");
            sb.Append("  Ledger: ").Append(Ledger).Append("\n");
            sb.Append("  PeriodEndDate: ").Append(PeriodEndDate).Append("\n");
            sb.Append("  PeriodStartDate: ").Append(PeriodStartDate).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  Subaccount: ").Append(Subaccount).Append("\n");
            sb.Append("  ToDate: ").Append(ToDate).Append("\n");
            sb.Append("  ToPeriod: ").Append(ToPeriod).Append("\n");
            sb.Append("  Turnover: ").Append(Turnover).Append("\n");
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
            return this.Equals(input as AccountDetailsInquiry);
        }

        /// <summary>
        /// Returns true if AccountDetailsInquiry instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountDetailsInquiry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountDetailsInquiry input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && base.Equals(input) && 
                (
                    this.BeginingBalance == input.BeginingBalance ||
                    (this.BeginingBalance != null &&
                    this.BeginingBalance.Equals(input.BeginingBalance))
                ) && base.Equals(input) && 
                (
                    this.Branch == input.Branch ||
                    (this.Branch != null &&
                    this.Branch.Equals(input.Branch))
                ) && base.Equals(input) && 
                (
                    this.EndingBalance == input.EndingBalance ||
                    (this.EndingBalance != null &&
                    this.EndingBalance.Equals(input.EndingBalance))
                ) && base.Equals(input) && 
                (
                    this.FromDate == input.FromDate ||
                    (this.FromDate != null &&
                    this.FromDate.Equals(input.FromDate))
                ) && base.Equals(input) && 
                (
                    this.FromPeriod == input.FromPeriod ||
                    (this.FromPeriod != null &&
                    this.FromPeriod.Equals(input.FromPeriod))
                ) && base.Equals(input) && 
                (
                    this.IncludeReclassified == input.IncludeReclassified ||
                    (this.IncludeReclassified != null &&
                    this.IncludeReclassified.Equals(input.IncludeReclassified))
                ) && base.Equals(input) && 
                (
                    this.IncludeUnposted == input.IncludeUnposted ||
                    (this.IncludeUnposted != null &&
                    this.IncludeUnposted.Equals(input.IncludeUnposted))
                ) && base.Equals(input) && 
                (
                    this.IncludeUnreleased == input.IncludeUnreleased ||
                    (this.IncludeUnreleased != null &&
                    this.IncludeUnreleased.Equals(input.IncludeUnreleased))
                ) && base.Equals(input) && 
                (
                    this.Ledger == input.Ledger ||
                    (this.Ledger != null &&
                    this.Ledger.Equals(input.Ledger))
                ) && base.Equals(input) && 
                (
                    this.PeriodEndDate == input.PeriodEndDate ||
                    (this.PeriodEndDate != null &&
                    this.PeriodEndDate.Equals(input.PeriodEndDate))
                ) && base.Equals(input) && 
                (
                    this.PeriodStartDate == input.PeriodStartDate ||
                    (this.PeriodStartDate != null &&
                    this.PeriodStartDate.Equals(input.PeriodStartDate))
                ) && base.Equals(input) && 
                (
                    this.Results == input.Results ||
                    this.Results != null &&
                    this.Results.SequenceEqual(input.Results)
                ) && base.Equals(input) && 
                (
                    this.Subaccount == input.Subaccount ||
                    (this.Subaccount != null &&
                    this.Subaccount.Equals(input.Subaccount))
                ) && base.Equals(input) && 
                (
                    this.ToDate == input.ToDate ||
                    (this.ToDate != null &&
                    this.ToDate.Equals(input.ToDate))
                ) && base.Equals(input) && 
                (
                    this.ToPeriod == input.ToPeriod ||
                    (this.ToPeriod != null &&
                    this.ToPeriod.Equals(input.ToPeriod))
                ) && base.Equals(input) && 
                (
                    this.Turnover == input.Turnover ||
                    (this.Turnover != null &&
                    this.Turnover.Equals(input.Turnover))
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
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.BeginingBalance != null)
                    hashCode = hashCode * 59 + this.BeginingBalance.GetHashCode();
                if (this.Branch != null)
                    hashCode = hashCode * 59 + this.Branch.GetHashCode();
                if (this.EndingBalance != null)
                    hashCode = hashCode * 59 + this.EndingBalance.GetHashCode();
                if (this.FromDate != null)
                    hashCode = hashCode * 59 + this.FromDate.GetHashCode();
                if (this.FromPeriod != null)
                    hashCode = hashCode * 59 + this.FromPeriod.GetHashCode();
                if (this.IncludeReclassified != null)
                    hashCode = hashCode * 59 + this.IncludeReclassified.GetHashCode();
                if (this.IncludeUnposted != null)
                    hashCode = hashCode * 59 + this.IncludeUnposted.GetHashCode();
                if (this.IncludeUnreleased != null)
                    hashCode = hashCode * 59 + this.IncludeUnreleased.GetHashCode();
                if (this.Ledger != null)
                    hashCode = hashCode * 59 + this.Ledger.GetHashCode();
                if (this.PeriodEndDate != null)
                    hashCode = hashCode * 59 + this.PeriodEndDate.GetHashCode();
                if (this.PeriodStartDate != null)
                    hashCode = hashCode * 59 + this.PeriodStartDate.GetHashCode();
                if (this.Results != null)
                    hashCode = hashCode * 59 + this.Results.GetHashCode();
                if (this.Subaccount != null)
                    hashCode = hashCode * 59 + this.Subaccount.GetHashCode();
                if (this.ToDate != null)
                    hashCode = hashCode * 59 + this.ToDate.GetHashCode();
                if (this.ToPeriod != null)
                    hashCode = hashCode * 59 + this.ToPeriod.GetHashCode();
                if (this.Turnover != null)
                    hashCode = hashCode * 59 + this.Turnover.GetHashCode();
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
