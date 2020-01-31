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
    /// BusinessAccountContact
    /// </summary>
    [DataContract]
    public partial class BusinessAccountContact : Entity,  IEquatable<BusinessAccountContact>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessAccountContact" /> class.
        /// </summary>
        /// <param name="active">active.</param>
        /// <param name="city">city.</param>
        /// <param name="contactID">contactID.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="email">email.</param>
        /// <param name="jobTitle">jobTitle.</param>
        /// <param name="owner">owner.</param>
        /// <param name="phone1">phone1.</param>
        /// <param name="type">type.</param>
        /// <param name="workgroup">workgroup.</param>
        public BusinessAccountContact(BooleanValue active = default(BooleanValue), StringValue city = default(StringValue), IntValue contactID = default(IntValue), StringValue displayName = default(StringValue), StringValue email = default(StringValue), StringValue jobTitle = default(StringValue), StringValue owner = default(StringValue), StringValue phone1 = default(StringValue), StringValue type = default(StringValue), StringValue workgroup = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Active = active;
            this.City = city;
            this.ContactID = contactID;
            this.DisplayName = displayName;
            this.Email = email;
            this.JobTitle = jobTitle;
            this.Owner = owner;
            this.Phone1 = phone1;
            this.Type = type;
            this.Workgroup = workgroup;
        }
        
        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="Active", EmitDefaultValue=false)]
        public BooleanValue Active { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="City", EmitDefaultValue=false)]
        public StringValue City { get; set; }

        /// <summary>
        /// Gets or Sets ContactID
        /// </summary>
        [DataMember(Name="ContactID", EmitDefaultValue=false)]
        public IntValue ContactID { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="DisplayName", EmitDefaultValue=false)]
        public StringValue DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="Email", EmitDefaultValue=false)]
        public StringValue Email { get; set; }

        /// <summary>
        /// Gets or Sets JobTitle
        /// </summary>
        [DataMember(Name="JobTitle", EmitDefaultValue=false)]
        public StringValue JobTitle { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name="Owner", EmitDefaultValue=false)]
        public StringValue Owner { get; set; }

        /// <summary>
        /// Gets or Sets Phone1
        /// </summary>
        [DataMember(Name="Phone1", EmitDefaultValue=false)]
        public StringValue Phone1 { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public StringValue Type { get; set; }

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
            sb.Append("class BusinessAccountContact {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  ContactID: ").Append(ContactID).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  JobTitle: ").Append(JobTitle).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Phone1: ").Append(Phone1).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as BusinessAccountContact);
        }

        /// <summary>
        /// Returns true if BusinessAccountContact instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessAccountContact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessAccountContact input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && base.Equals(input) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && base.Equals(input) && 
                (
                    this.ContactID == input.ContactID ||
                    (this.ContactID != null &&
                    this.ContactID.Equals(input.ContactID))
                ) && base.Equals(input) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && base.Equals(input) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && base.Equals(input) && 
                (
                    this.JobTitle == input.JobTitle ||
                    (this.JobTitle != null &&
                    this.JobTitle.Equals(input.JobTitle))
                ) && base.Equals(input) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && base.Equals(input) && 
                (
                    this.Phone1 == input.Phone1 ||
                    (this.Phone1 != null &&
                    this.Phone1.Equals(input.Phone1))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.ContactID != null)
                    hashCode = hashCode * 59 + this.ContactID.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.JobTitle != null)
                    hashCode = hashCode * 59 + this.JobTitle.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Phone1 != null)
                    hashCode = hashCode * 59 + this.Phone1.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
