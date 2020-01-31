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
    /// AttributeDefinition
    /// </summary>
    [DataContract]
    public partial class AttributeDefinition : Entity,  IEquatable<AttributeDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeDefinition" /> class.
        /// </summary>
        /// <param name="attributeID">attributeID.</param>
        /// <param name="controlType">controlType.</param>
        /// <param name="createdDateTime">createdDateTime.</param>
        /// <param name="description">description.</param>
        /// <param name="entryMask">entryMask.</param>
        /// <param name="_internal">_internal.</param>
        /// <param name="lastModifiedDateTime">lastModifiedDateTime.</param>
        /// <param name="regExp">regExp.</param>
        /// <param name="values">values.</param>
        public AttributeDefinition(StringValue attributeID = default(StringValue), StringValue controlType = default(StringValue), DateTimeValue createdDateTime = default(DateTimeValue), StringValue description = default(StringValue), StringValue entryMask = default(StringValue), BooleanValue _internal = default(BooleanValue), DateTimeValue lastModifiedDateTime = default(DateTimeValue), StringValue regExp = default(StringValue), List<AttributeDefinitionValue> values = default(List<AttributeDefinitionValue>), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.AttributeID = attributeID;
            this.ControlType = controlType;
            this.CreatedDateTime = createdDateTime;
            this.Description = description;
            this.EntryMask = entryMask;
            this.Internal = _internal;
            this.LastModifiedDateTime = lastModifiedDateTime;
            this.RegExp = regExp;
            this.Values = values;
        }
        
        /// <summary>
        /// Gets or Sets AttributeID
        /// </summary>
        [DataMember(Name="AttributeID", EmitDefaultValue=false)]
        public StringValue AttributeID { get; set; }

        /// <summary>
        /// Gets or Sets ControlType
        /// </summary>
        [DataMember(Name="ControlType", EmitDefaultValue=false)]
        public StringValue ControlType { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDateTime
        /// </summary>
        [DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
        public DateTimeValue CreatedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets EntryMask
        /// </summary>
        [DataMember(Name="EntryMask", EmitDefaultValue=false)]
        public StringValue EntryMask { get; set; }

        /// <summary>
        /// Gets or Sets Internal
        /// </summary>
        [DataMember(Name="Internal", EmitDefaultValue=false)]
        public BooleanValue Internal { get; set; }

        /// <summary>
        /// Gets or Sets LastModifiedDateTime
        /// </summary>
        [DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
        public DateTimeValue LastModifiedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets RegExp
        /// </summary>
        [DataMember(Name="RegExp", EmitDefaultValue=false)]
        public StringValue RegExp { get; set; }

        /// <summary>
        /// Gets or Sets Values
        /// </summary>
        [DataMember(Name="Values", EmitDefaultValue=false)]
        public List<AttributeDefinitionValue> Values { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttributeDefinition {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  AttributeID: ").Append(AttributeID).Append("\n");
            sb.Append("  ControlType: ").Append(ControlType).Append("\n");
            sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EntryMask: ").Append(EntryMask).Append("\n");
            sb.Append("  Internal: ").Append(Internal).Append("\n");
            sb.Append("  LastModifiedDateTime: ").Append(LastModifiedDateTime).Append("\n");
            sb.Append("  RegExp: ").Append(RegExp).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
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
            return this.Equals(input as AttributeDefinition);
        }

        /// <summary>
        /// Returns true if AttributeDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of AttributeDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttributeDefinition input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.AttributeID == input.AttributeID ||
                    (this.AttributeID != null &&
                    this.AttributeID.Equals(input.AttributeID))
                ) && base.Equals(input) && 
                (
                    this.ControlType == input.ControlType ||
                    (this.ControlType != null &&
                    this.ControlType.Equals(input.ControlType))
                ) && base.Equals(input) && 
                (
                    this.CreatedDateTime == input.CreatedDateTime ||
                    (this.CreatedDateTime != null &&
                    this.CreatedDateTime.Equals(input.CreatedDateTime))
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.EntryMask == input.EntryMask ||
                    (this.EntryMask != null &&
                    this.EntryMask.Equals(input.EntryMask))
                ) && base.Equals(input) && 
                (
                    this.Internal == input.Internal ||
                    (this.Internal != null &&
                    this.Internal.Equals(input.Internal))
                ) && base.Equals(input) && 
                (
                    this.LastModifiedDateTime == input.LastModifiedDateTime ||
                    (this.LastModifiedDateTime != null &&
                    this.LastModifiedDateTime.Equals(input.LastModifiedDateTime))
                ) && base.Equals(input) && 
                (
                    this.RegExp == input.RegExp ||
                    (this.RegExp != null &&
                    this.RegExp.Equals(input.RegExp))
                ) && base.Equals(input) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(input.Values)
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
                if (this.AttributeID != null)
                    hashCode = hashCode * 59 + this.AttributeID.GetHashCode();
                if (this.ControlType != null)
                    hashCode = hashCode * 59 + this.ControlType.GetHashCode();
                if (this.CreatedDateTime != null)
                    hashCode = hashCode * 59 + this.CreatedDateTime.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.EntryMask != null)
                    hashCode = hashCode * 59 + this.EntryMask.GetHashCode();
                if (this.Internal != null)
                    hashCode = hashCode * 59 + this.Internal.GetHashCode();
                if (this.LastModifiedDateTime != null)
                    hashCode = hashCode * 59 + this.LastModifiedDateTime.GetHashCode();
                if (this.RegExp != null)
                    hashCode = hashCode * 59 + this.RegExp.GetHashCode();
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
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
