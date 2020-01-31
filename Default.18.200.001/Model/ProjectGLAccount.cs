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
    /// ProjectGLAccount
    /// </summary>
    [DataContract]
    public partial class ProjectGLAccount : Entity,  IEquatable<ProjectGLAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectGLAccount" /> class.
        /// </summary>
        /// <param name="accrualAccount">accrualAccount.</param>
        /// <param name="accrualSubaccount">accrualSubaccount.</param>
        /// <param name="defaultAccount">defaultAccount.</param>
        /// <param name="defaultSubaccount">defaultSubaccount.</param>
        /// <param name="defaultTaskForGLAccounts">defaultTaskForGLAccounts.</param>
        public ProjectGLAccount(StringValue accrualAccount = default(StringValue), StringValue accrualSubaccount = default(StringValue), StringValue defaultAccount = default(StringValue), StringValue defaultSubaccount = default(StringValue), List<DefaultTaskForGLAccount> defaultTaskForGLAccounts = default(List<DefaultTaskForGLAccount>), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.AccrualAccount = accrualAccount;
            this.AccrualSubaccount = accrualSubaccount;
            this.DefaultAccount = defaultAccount;
            this.DefaultSubaccount = defaultSubaccount;
            this.DefaultTaskForGLAccounts = defaultTaskForGLAccounts;
        }
        
        /// <summary>
        /// Gets or Sets AccrualAccount
        /// </summary>
        [DataMember(Name="AccrualAccount", EmitDefaultValue=false)]
        public StringValue AccrualAccount { get; set; }

        /// <summary>
        /// Gets or Sets AccrualSubaccount
        /// </summary>
        [DataMember(Name="AccrualSubaccount", EmitDefaultValue=false)]
        public StringValue AccrualSubaccount { get; set; }

        /// <summary>
        /// Gets or Sets DefaultAccount
        /// </summary>
        [DataMember(Name="DefaultAccount", EmitDefaultValue=false)]
        public StringValue DefaultAccount { get; set; }

        /// <summary>
        /// Gets or Sets DefaultSubaccount
        /// </summary>
        [DataMember(Name="DefaultSubaccount", EmitDefaultValue=false)]
        public StringValue DefaultSubaccount { get; set; }

        /// <summary>
        /// Gets or Sets DefaultTaskForGLAccounts
        /// </summary>
        [DataMember(Name="DefaultTaskForGLAccounts", EmitDefaultValue=false)]
        public List<DefaultTaskForGLAccount> DefaultTaskForGLAccounts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectGLAccount {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  AccrualAccount: ").Append(AccrualAccount).Append("\n");
            sb.Append("  AccrualSubaccount: ").Append(AccrualSubaccount).Append("\n");
            sb.Append("  DefaultAccount: ").Append(DefaultAccount).Append("\n");
            sb.Append("  DefaultSubaccount: ").Append(DefaultSubaccount).Append("\n");
            sb.Append("  DefaultTaskForGLAccounts: ").Append(DefaultTaskForGLAccounts).Append("\n");
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
            return this.Equals(input as ProjectGLAccount);
        }

        /// <summary>
        /// Returns true if ProjectGLAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectGLAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectGLAccount input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.AccrualAccount == input.AccrualAccount ||
                    (this.AccrualAccount != null &&
                    this.AccrualAccount.Equals(input.AccrualAccount))
                ) && base.Equals(input) && 
                (
                    this.AccrualSubaccount == input.AccrualSubaccount ||
                    (this.AccrualSubaccount != null &&
                    this.AccrualSubaccount.Equals(input.AccrualSubaccount))
                ) && base.Equals(input) && 
                (
                    this.DefaultAccount == input.DefaultAccount ||
                    (this.DefaultAccount != null &&
                    this.DefaultAccount.Equals(input.DefaultAccount))
                ) && base.Equals(input) && 
                (
                    this.DefaultSubaccount == input.DefaultSubaccount ||
                    (this.DefaultSubaccount != null &&
                    this.DefaultSubaccount.Equals(input.DefaultSubaccount))
                ) && base.Equals(input) && 
                (
                    this.DefaultTaskForGLAccounts == input.DefaultTaskForGLAccounts ||
                    this.DefaultTaskForGLAccounts != null &&
                    this.DefaultTaskForGLAccounts.SequenceEqual(input.DefaultTaskForGLAccounts)
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
                if (this.AccrualAccount != null)
                    hashCode = hashCode * 59 + this.AccrualAccount.GetHashCode();
                if (this.AccrualSubaccount != null)
                    hashCode = hashCode * 59 + this.AccrualSubaccount.GetHashCode();
                if (this.DefaultAccount != null)
                    hashCode = hashCode * 59 + this.DefaultAccount.GetHashCode();
                if (this.DefaultSubaccount != null)
                    hashCode = hashCode * 59 + this.DefaultSubaccount.GetHashCode();
                if (this.DefaultTaskForGLAccounts != null)
                    hashCode = hashCode * 59 + this.DefaultTaskForGLAccounts.GetHashCode();
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
