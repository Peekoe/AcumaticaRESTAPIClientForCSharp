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
    /// Subaccount
    /// </summary>
    [DataContract]
    public partial class Subaccount : Entity,  IEquatable<Subaccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Subaccount" /> class.
        /// </summary>
        /// <param name="active">active.</param>
        /// <param name="description">description.</param>
        /// <param name="secured">secured.</param>
        /// <param name="subaccountCD">subaccountCD.</param>
        /// <param name="subaccountID">subaccountID.</param>
        public Subaccount(BooleanValue active = default(BooleanValue), StringValue description = default(StringValue), BooleanValue secured = default(BooleanValue), StringValue subaccountCD = default(StringValue), IntValue subaccountID = default(IntValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Active = active;
            this.Description = description;
            this.Secured = secured;
            this.SubaccountCD = subaccountCD;
            this.SubaccountID = subaccountID;
        }
        
        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="Active", EmitDefaultValue=false)]
        public BooleanValue Active { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets Secured
        /// </summary>
        [DataMember(Name="Secured", EmitDefaultValue=false)]
        public BooleanValue Secured { get; set; }

        /// <summary>
        /// Gets or Sets SubaccountCD
        /// </summary>
        [DataMember(Name="SubaccountCD", EmitDefaultValue=false)]
        public StringValue SubaccountCD { get; set; }

        /// <summary>
        /// Gets or Sets SubaccountID
        /// </summary>
        [DataMember(Name="SubaccountID", EmitDefaultValue=false)]
        public IntValue SubaccountID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Subaccount {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Secured: ").Append(Secured).Append("\n");
            sb.Append("  SubaccountCD: ").Append(SubaccountCD).Append("\n");
            sb.Append("  SubaccountID: ").Append(SubaccountID).Append("\n");
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
            return this.Equals(input as Subaccount);
        }

        /// <summary>
        /// Returns true if Subaccount instances are equal
        /// </summary>
        /// <param name="input">Instance of Subaccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Subaccount input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.Secured == input.Secured ||
                    (this.Secured != null &&
                    this.Secured.Equals(input.Secured))
                ) && base.Equals(input) && 
                (
                    this.SubaccountCD == input.SubaccountCD ||
                    (this.SubaccountCD != null &&
                    this.SubaccountCD.Equals(input.SubaccountCD))
                ) && base.Equals(input) && 
                (
                    this.SubaccountID == input.SubaccountID ||
                    (this.SubaccountID != null &&
                    this.SubaccountID.Equals(input.SubaccountID))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Secured != null)
                    hashCode = hashCode * 59 + this.Secured.GetHashCode();
                if (this.SubaccountCD != null)
                    hashCode = hashCode * 59 + this.SubaccountCD.GetHashCode();
                if (this.SubaccountID != null)
                    hashCode = hashCode * 59 + this.SubaccountID.GetHashCode();
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
