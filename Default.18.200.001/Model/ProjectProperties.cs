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
    /// ProjectProperties
    /// </summary>
    [DataContract]
    public partial class ProjectProperties : Entity,  IEquatable<ProjectProperties>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectProperties" /> class.
        /// </summary>
        /// <param name="certifiedJob">certifiedJob.</param>
        /// <param name="changeOrderWorkflow">changeOrderWorkflow.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="lastRevenueChangeNbr">lastRevenueChangeNbr.</param>
        /// <param name="projectManager">projectManager.</param>
        /// <param name="restrictEmployees">restrictEmployees.</param>
        /// <param name="restrictEquipment">restrictEquipment.</param>
        /// <param name="revenueBudgetLevel">revenueBudgetLevel.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="trackProductionData">trackProductionData.</param>
        public ProjectProperties(BooleanValue certifiedJob = default(BooleanValue), BooleanValue changeOrderWorkflow = default(BooleanValue), DateTimeValue endDate = default(DateTimeValue), StringValue lastRevenueChangeNbr = default(StringValue), StringValue projectManager = default(StringValue), BooleanValue restrictEmployees = default(BooleanValue), BooleanValue restrictEquipment = default(BooleanValue), StringValue revenueBudgetLevel = default(StringValue), DateTimeValue startDate = default(DateTimeValue), BooleanValue trackProductionData = default(BooleanValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.CertifiedJob = certifiedJob;
            this.ChangeOrderWorkflow = changeOrderWorkflow;
            this.EndDate = endDate;
            this.LastRevenueChangeNbr = lastRevenueChangeNbr;
            this.ProjectManager = projectManager;
            this.RestrictEmployees = restrictEmployees;
            this.RestrictEquipment = restrictEquipment;
            this.RevenueBudgetLevel = revenueBudgetLevel;
            this.StartDate = startDate;
            this.TrackProductionData = trackProductionData;
        }
        
        /// <summary>
        /// Gets or Sets CertifiedJob
        /// </summary>
        [DataMember(Name="CertifiedJob", EmitDefaultValue=false)]
        public BooleanValue CertifiedJob { get; set; }

        /// <summary>
        /// Gets or Sets ChangeOrderWorkflow
        /// </summary>
        [DataMember(Name="ChangeOrderWorkflow", EmitDefaultValue=false)]
        public BooleanValue ChangeOrderWorkflow { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="EndDate", EmitDefaultValue=false)]
        public DateTimeValue EndDate { get; set; }

        /// <summary>
        /// Gets or Sets LastRevenueChangeNbr
        /// </summary>
        [DataMember(Name="LastRevenueChangeNbr", EmitDefaultValue=false)]
        public StringValue LastRevenueChangeNbr { get; set; }

        /// <summary>
        /// Gets or Sets ProjectManager
        /// </summary>
        [DataMember(Name="ProjectManager", EmitDefaultValue=false)]
        public StringValue ProjectManager { get; set; }

        /// <summary>
        /// Gets or Sets RestrictEmployees
        /// </summary>
        [DataMember(Name="RestrictEmployees", EmitDefaultValue=false)]
        public BooleanValue RestrictEmployees { get; set; }

        /// <summary>
        /// Gets or Sets RestrictEquipment
        /// </summary>
        [DataMember(Name="RestrictEquipment", EmitDefaultValue=false)]
        public BooleanValue RestrictEquipment { get; set; }

        /// <summary>
        /// Gets or Sets RevenueBudgetLevel
        /// </summary>
        [DataMember(Name="RevenueBudgetLevel", EmitDefaultValue=false)]
        public StringValue RevenueBudgetLevel { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="StartDate", EmitDefaultValue=false)]
        public DateTimeValue StartDate { get; set; }

        /// <summary>
        /// Gets or Sets TrackProductionData
        /// </summary>
        [DataMember(Name="TrackProductionData", EmitDefaultValue=false)]
        public BooleanValue TrackProductionData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectProperties {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  CertifiedJob: ").Append(CertifiedJob).Append("\n");
            sb.Append("  ChangeOrderWorkflow: ").Append(ChangeOrderWorkflow).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  LastRevenueChangeNbr: ").Append(LastRevenueChangeNbr).Append("\n");
            sb.Append("  ProjectManager: ").Append(ProjectManager).Append("\n");
            sb.Append("  RestrictEmployees: ").Append(RestrictEmployees).Append("\n");
            sb.Append("  RestrictEquipment: ").Append(RestrictEquipment).Append("\n");
            sb.Append("  RevenueBudgetLevel: ").Append(RevenueBudgetLevel).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  TrackProductionData: ").Append(TrackProductionData).Append("\n");
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
            return this.Equals(input as ProjectProperties);
        }

        /// <summary>
        /// Returns true if ProjectProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectProperties input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.CertifiedJob == input.CertifiedJob ||
                    (this.CertifiedJob != null &&
                    this.CertifiedJob.Equals(input.CertifiedJob))
                ) && base.Equals(input) && 
                (
                    this.ChangeOrderWorkflow == input.ChangeOrderWorkflow ||
                    (this.ChangeOrderWorkflow != null &&
                    this.ChangeOrderWorkflow.Equals(input.ChangeOrderWorkflow))
                ) && base.Equals(input) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && base.Equals(input) && 
                (
                    this.LastRevenueChangeNbr == input.LastRevenueChangeNbr ||
                    (this.LastRevenueChangeNbr != null &&
                    this.LastRevenueChangeNbr.Equals(input.LastRevenueChangeNbr))
                ) && base.Equals(input) && 
                (
                    this.ProjectManager == input.ProjectManager ||
                    (this.ProjectManager != null &&
                    this.ProjectManager.Equals(input.ProjectManager))
                ) && base.Equals(input) && 
                (
                    this.RestrictEmployees == input.RestrictEmployees ||
                    (this.RestrictEmployees != null &&
                    this.RestrictEmployees.Equals(input.RestrictEmployees))
                ) && base.Equals(input) && 
                (
                    this.RestrictEquipment == input.RestrictEquipment ||
                    (this.RestrictEquipment != null &&
                    this.RestrictEquipment.Equals(input.RestrictEquipment))
                ) && base.Equals(input) && 
                (
                    this.RevenueBudgetLevel == input.RevenueBudgetLevel ||
                    (this.RevenueBudgetLevel != null &&
                    this.RevenueBudgetLevel.Equals(input.RevenueBudgetLevel))
                ) && base.Equals(input) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && base.Equals(input) && 
                (
                    this.TrackProductionData == input.TrackProductionData ||
                    (this.TrackProductionData != null &&
                    this.TrackProductionData.Equals(input.TrackProductionData))
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
                if (this.CertifiedJob != null)
                    hashCode = hashCode * 59 + this.CertifiedJob.GetHashCode();
                if (this.ChangeOrderWorkflow != null)
                    hashCode = hashCode * 59 + this.ChangeOrderWorkflow.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.LastRevenueChangeNbr != null)
                    hashCode = hashCode * 59 + this.LastRevenueChangeNbr.GetHashCode();
                if (this.ProjectManager != null)
                    hashCode = hashCode * 59 + this.ProjectManager.GetHashCode();
                if (this.RestrictEmployees != null)
                    hashCode = hashCode * 59 + this.RestrictEmployees.GetHashCode();
                if (this.RestrictEquipment != null)
                    hashCode = hashCode * 59 + this.RestrictEquipment.GetHashCode();
                if (this.RevenueBudgetLevel != null)
                    hashCode = hashCode * 59 + this.RevenueBudgetLevel.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.TrackProductionData != null)
                    hashCode = hashCode * 59 + this.TrackProductionData.GetHashCode();
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
