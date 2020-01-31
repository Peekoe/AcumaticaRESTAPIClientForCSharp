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
    /// LotSerialClass
    /// </summary>
    [DataContract]
    public partial class LotSerialClass : Entity,  IEquatable<LotSerialClass>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LotSerialClass" /> class.
        /// </summary>
        /// <param name="assignmentMethod">assignmentMethod.</param>
        /// <param name="classID">classID.</param>
        /// <param name="description">description.</param>
        /// <param name="issueMethod">issueMethod.</param>
        /// <param name="segments">segments.</param>
        /// <param name="trackExpirationDate">trackExpirationDate.</param>
        /// <param name="trackingMethod">trackingMethod.</param>
        public LotSerialClass(StringValue assignmentMethod = default(StringValue), StringValue classID = default(StringValue), StringValue description = default(StringValue), StringValue issueMethod = default(StringValue), List<LotSerialClassSegment> segments = default(List<LotSerialClassSegment>), BooleanValue trackExpirationDate = default(BooleanValue), StringValue trackingMethod = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.AssignmentMethod = assignmentMethod;
            this.ClassID = classID;
            this.Description = description;
            this.IssueMethod = issueMethod;
            this.Segments = segments;
            this.TrackExpirationDate = trackExpirationDate;
            this.TrackingMethod = trackingMethod;
        }
        
        /// <summary>
        /// Gets or Sets AssignmentMethod
        /// </summary>
        [DataMember(Name="AssignmentMethod", EmitDefaultValue=false)]
        public StringValue AssignmentMethod { get; set; }

        /// <summary>
        /// Gets or Sets ClassID
        /// </summary>
        [DataMember(Name="ClassID", EmitDefaultValue=false)]
        public StringValue ClassID { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets IssueMethod
        /// </summary>
        [DataMember(Name="IssueMethod", EmitDefaultValue=false)]
        public StringValue IssueMethod { get; set; }

        /// <summary>
        /// Gets or Sets Segments
        /// </summary>
        [DataMember(Name="Segments", EmitDefaultValue=false)]
        public List<LotSerialClassSegment> Segments { get; set; }

        /// <summary>
        /// Gets or Sets TrackExpirationDate
        /// </summary>
        [DataMember(Name="TrackExpirationDate", EmitDefaultValue=false)]
        public BooleanValue TrackExpirationDate { get; set; }

        /// <summary>
        /// Gets or Sets TrackingMethod
        /// </summary>
        [DataMember(Name="TrackingMethod", EmitDefaultValue=false)]
        public StringValue TrackingMethod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LotSerialClass {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  AssignmentMethod: ").Append(AssignmentMethod).Append("\n");
            sb.Append("  ClassID: ").Append(ClassID).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IssueMethod: ").Append(IssueMethod).Append("\n");
            sb.Append("  Segments: ").Append(Segments).Append("\n");
            sb.Append("  TrackExpirationDate: ").Append(TrackExpirationDate).Append("\n");
            sb.Append("  TrackingMethod: ").Append(TrackingMethod).Append("\n");
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
            return this.Equals(input as LotSerialClass);
        }

        /// <summary>
        /// Returns true if LotSerialClass instances are equal
        /// </summary>
        /// <param name="input">Instance of LotSerialClass to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LotSerialClass input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.AssignmentMethod == input.AssignmentMethod ||
                    (this.AssignmentMethod != null &&
                    this.AssignmentMethod.Equals(input.AssignmentMethod))
                ) && base.Equals(input) && 
                (
                    this.ClassID == input.ClassID ||
                    (this.ClassID != null &&
                    this.ClassID.Equals(input.ClassID))
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.IssueMethod == input.IssueMethod ||
                    (this.IssueMethod != null &&
                    this.IssueMethod.Equals(input.IssueMethod))
                ) && base.Equals(input) && 
                (
                    this.Segments == input.Segments ||
                    this.Segments != null &&
                    this.Segments.SequenceEqual(input.Segments)
                ) && base.Equals(input) && 
                (
                    this.TrackExpirationDate == input.TrackExpirationDate ||
                    (this.TrackExpirationDate != null &&
                    this.TrackExpirationDate.Equals(input.TrackExpirationDate))
                ) && base.Equals(input) && 
                (
                    this.TrackingMethod == input.TrackingMethod ||
                    (this.TrackingMethod != null &&
                    this.TrackingMethod.Equals(input.TrackingMethod))
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
                if (this.AssignmentMethod != null)
                    hashCode = hashCode * 59 + this.AssignmentMethod.GetHashCode();
                if (this.ClassID != null)
                    hashCode = hashCode * 59 + this.ClassID.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IssueMethod != null)
                    hashCode = hashCode * 59 + this.IssueMethod.GetHashCode();
                if (this.Segments != null)
                    hashCode = hashCode * 59 + this.Segments.GetHashCode();
                if (this.TrackExpirationDate != null)
                    hashCode = hashCode * 59 + this.TrackExpirationDate.GetHashCode();
                if (this.TrackingMethod != null)
                    hashCode = hashCode * 59 + this.TrackingMethod.GetHashCode();
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
