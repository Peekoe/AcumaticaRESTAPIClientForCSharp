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
    /// CaseRelatedCase
    /// </summary>
    [DataContract]
    public partial class CaseRelatedCase : Entity,  IEquatable<CaseRelatedCase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CaseRelatedCase" /> class.
        /// </summary>
        /// <param name="caseID">caseID.</param>
        /// <param name="owner">owner.</param>
        /// <param name="parentCaseID">parentCaseID.</param>
        /// <param name="relationType">relationType.</param>
        /// <param name="status">status.</param>
        /// <param name="subject">subject.</param>
        /// <param name="workgroup">workgroup.</param>
        public CaseRelatedCase(StringValue caseID = default(StringValue), StringValue owner = default(StringValue), IntValue parentCaseID = default(IntValue), StringValue relationType = default(StringValue), StringValue status = default(StringValue), StringValue subject = default(StringValue), StringValue workgroup = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.CaseID = caseID;
            this.Owner = owner;
            this.ParentCaseID = parentCaseID;
            this.RelationType = relationType;
            this.Status = status;
            this.Subject = subject;
            this.Workgroup = workgroup;
        }
        
        /// <summary>
        /// Gets or Sets CaseID
        /// </summary>
        [DataMember(Name="CaseID", EmitDefaultValue=false)]
        public StringValue CaseID { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name="Owner", EmitDefaultValue=false)]
        public StringValue Owner { get; set; }

        /// <summary>
        /// Gets or Sets ParentCaseID
        /// </summary>
        [DataMember(Name="ParentCaseID", EmitDefaultValue=false)]
        public IntValue ParentCaseID { get; set; }

        /// <summary>
        /// Gets or Sets RelationType
        /// </summary>
        [DataMember(Name="RelationType", EmitDefaultValue=false)]
        public StringValue RelationType { get; set; }

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
            sb.Append("class CaseRelatedCase {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  CaseID: ").Append(CaseID).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  ParentCaseID: ").Append(ParentCaseID).Append("\n");
            sb.Append("  RelationType: ").Append(RelationType).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
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
            return this.Equals(input as CaseRelatedCase);
        }

        /// <summary>
        /// Returns true if CaseRelatedCase instances are equal
        /// </summary>
        /// <param name="input">Instance of CaseRelatedCase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CaseRelatedCase input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.CaseID == input.CaseID ||
                    (this.CaseID != null &&
                    this.CaseID.Equals(input.CaseID))
                ) && base.Equals(input) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && base.Equals(input) && 
                (
                    this.ParentCaseID == input.ParentCaseID ||
                    (this.ParentCaseID != null &&
                    this.ParentCaseID.Equals(input.ParentCaseID))
                ) && base.Equals(input) && 
                (
                    this.RelationType == input.RelationType ||
                    (this.RelationType != null &&
                    this.RelationType.Equals(input.RelationType))
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
                if (this.CaseID != null)
                    hashCode = hashCode * 59 + this.CaseID.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.ParentCaseID != null)
                    hashCode = hashCode * 59 + this.ParentCaseID.GetHashCode();
                if (this.RelationType != null)
                    hashCode = hashCode * 59 + this.RelationType.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
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
