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
    /// ProjectBillingDetails
    /// </summary>
    [DataContract]
    public partial class ProjectBillingDetails : Entity,  IEquatable<ProjectBillingDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectBillingDetails" /> class.
        /// </summary>
        /// <param name="customerID">customerID.</param>
        /// <param name="customerName">customerName.</param>
        /// <param name="description">description.</param>
        /// <param name="from">from.</param>
        /// <param name="lastBillingDate">lastBillingDate.</param>
        /// <param name="projectID">projectID.</param>
        /// <param name="selected">selected.</param>
        /// <param name="to">to.</param>
        public ProjectBillingDetails(StringValue customerID = default(StringValue), StringValue customerName = default(StringValue), StringValue description = default(StringValue), DateTimeValue from = default(DateTimeValue), DateTimeValue lastBillingDate = default(DateTimeValue), StringValue projectID = default(StringValue), BooleanValue selected = default(BooleanValue), DateTimeValue to = default(DateTimeValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.CustomerID = customerID;
            this.CustomerName = customerName;
            this.Description = description;
            this.From = from;
            this.LastBillingDate = lastBillingDate;
            this.ProjectID = projectID;
            this.Selected = selected;
            this.To = to;
        }
        
        /// <summary>
        /// Gets or Sets CustomerID
        /// </summary>
        [DataMember(Name="CustomerID", EmitDefaultValue=false)]
        public StringValue CustomerID { get; set; }

        /// <summary>
        /// Gets or Sets CustomerName
        /// </summary>
        [DataMember(Name="CustomerName", EmitDefaultValue=false)]
        public StringValue CustomerName { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name="From", EmitDefaultValue=false)]
        public DateTimeValue From { get; set; }

        /// <summary>
        /// Gets or Sets LastBillingDate
        /// </summary>
        [DataMember(Name="LastBillingDate", EmitDefaultValue=false)]
        public DateTimeValue LastBillingDate { get; set; }

        /// <summary>
        /// Gets or Sets ProjectID
        /// </summary>
        [DataMember(Name="ProjectID", EmitDefaultValue=false)]
        public StringValue ProjectID { get; set; }

        /// <summary>
        /// Gets or Sets Selected
        /// </summary>
        [DataMember(Name="Selected", EmitDefaultValue=false)]
        public BooleanValue Selected { get; set; }

        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name="To", EmitDefaultValue=false)]
        public DateTimeValue To { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectBillingDetails {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  CustomerID: ").Append(CustomerID).Append("\n");
            sb.Append("  CustomerName: ").Append(CustomerName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  LastBillingDate: ").Append(LastBillingDate).Append("\n");
            sb.Append("  ProjectID: ").Append(ProjectID).Append("\n");
            sb.Append("  Selected: ").Append(Selected).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
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
            return this.Equals(input as ProjectBillingDetails);
        }

        /// <summary>
        /// Returns true if ProjectBillingDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectBillingDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectBillingDetails input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.CustomerID == input.CustomerID ||
                    (this.CustomerID != null &&
                    this.CustomerID.Equals(input.CustomerID))
                ) && base.Equals(input) && 
                (
                    this.CustomerName == input.CustomerName ||
                    (this.CustomerName != null &&
                    this.CustomerName.Equals(input.CustomerName))
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && base.Equals(input) && 
                (
                    this.LastBillingDate == input.LastBillingDate ||
                    (this.LastBillingDate != null &&
                    this.LastBillingDate.Equals(input.LastBillingDate))
                ) && base.Equals(input) && 
                (
                    this.ProjectID == input.ProjectID ||
                    (this.ProjectID != null &&
                    this.ProjectID.Equals(input.ProjectID))
                ) && base.Equals(input) && 
                (
                    this.Selected == input.Selected ||
                    (this.Selected != null &&
                    this.Selected.Equals(input.Selected))
                ) && base.Equals(input) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
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
                if (this.CustomerID != null)
                    hashCode = hashCode * 59 + this.CustomerID.GetHashCode();
                if (this.CustomerName != null)
                    hashCode = hashCode * 59 + this.CustomerName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.LastBillingDate != null)
                    hashCode = hashCode * 59 + this.LastBillingDate.GetHashCode();
                if (this.ProjectID != null)
                    hashCode = hashCode * 59 + this.ProjectID.GetHashCode();
                if (this.Selected != null)
                    hashCode = hashCode * 59 + this.Selected.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
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
