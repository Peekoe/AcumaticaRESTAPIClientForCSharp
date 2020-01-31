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
    /// TimeActivity
    /// </summary>
    [DataContract]
    public partial class TimeActivity : Entity,  IEquatable<TimeActivity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeActivity" /> class.
        /// </summary>
        /// <param name="approver">approver.</param>
        /// <param name="billable">billable.</param>
        /// <param name="billableOvertime">billableOvertime.</param>
        /// <param name="billableTime">billableTime.</param>
        /// <param name="costCode">costCode.</param>
        /// <param name="earningType">earningType.</param>
        /// <param name="overtime">overtime.</param>
        /// <param name="project">project.</param>
        /// <param name="projectTask">projectTask.</param>
        /// <param name="referenceNbr">referenceNbr.</param>
        /// <param name="released">released.</param>
        /// <param name="status">status.</param>
        /// <param name="timeSpent">timeSpent.</param>
        /// <param name="trackTime">trackTime.</param>
        public TimeActivity(StringValue approver = default(StringValue), BooleanValue billable = default(BooleanValue), StringValue billableOvertime = default(StringValue), StringValue billableTime = default(StringValue), StringValue costCode = default(StringValue), StringValue earningType = default(StringValue), StringValue overtime = default(StringValue), StringValue project = default(StringValue), StringValue projectTask = default(StringValue), StringValue referenceNbr = default(StringValue), BooleanValue released = default(BooleanValue), StringValue status = default(StringValue), StringValue timeSpent = default(StringValue), BooleanValue trackTime = default(BooleanValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Approver = approver;
            this.Billable = billable;
            this.BillableOvertime = billableOvertime;
            this.BillableTime = billableTime;
            this.CostCode = costCode;
            this.EarningType = earningType;
            this.Overtime = overtime;
            this.Project = project;
            this.ProjectTask = projectTask;
            this.ReferenceNbr = referenceNbr;
            this.Released = released;
            this.Status = status;
            this.TimeSpent = timeSpent;
            this.TrackTime = trackTime;
        }
        
        /// <summary>
        /// Gets or Sets Approver
        /// </summary>
        [DataMember(Name="Approver", EmitDefaultValue=false)]
        public StringValue Approver { get; set; }

        /// <summary>
        /// Gets or Sets Billable
        /// </summary>
        [DataMember(Name="Billable", EmitDefaultValue=false)]
        public BooleanValue Billable { get; set; }

        /// <summary>
        /// Gets or Sets BillableOvertime
        /// </summary>
        [DataMember(Name="BillableOvertime", EmitDefaultValue=false)]
        public StringValue BillableOvertime { get; set; }

        /// <summary>
        /// Gets or Sets BillableTime
        /// </summary>
        [DataMember(Name="BillableTime", EmitDefaultValue=false)]
        public StringValue BillableTime { get; set; }

        /// <summary>
        /// Gets or Sets CostCode
        /// </summary>
        [DataMember(Name="CostCode", EmitDefaultValue=false)]
        public StringValue CostCode { get; set; }

        /// <summary>
        /// Gets or Sets EarningType
        /// </summary>
        [DataMember(Name="EarningType", EmitDefaultValue=false)]
        public StringValue EarningType { get; set; }

        /// <summary>
        /// Gets or Sets Overtime
        /// </summary>
        [DataMember(Name="Overtime", EmitDefaultValue=false)]
        public StringValue Overtime { get; set; }

        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name="Project", EmitDefaultValue=false)]
        public StringValue Project { get; set; }

        /// <summary>
        /// Gets or Sets ProjectTask
        /// </summary>
        [DataMember(Name="ProjectTask", EmitDefaultValue=false)]
        public StringValue ProjectTask { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceNbr
        /// </summary>
        [DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
        public StringValue ReferenceNbr { get; set; }

        /// <summary>
        /// Gets or Sets Released
        /// </summary>
        [DataMember(Name="Released", EmitDefaultValue=false)]
        public BooleanValue Released { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StringValue Status { get; set; }

        /// <summary>
        /// Gets or Sets TimeSpent
        /// </summary>
        [DataMember(Name="TimeSpent", EmitDefaultValue=false)]
        public StringValue TimeSpent { get; set; }

        /// <summary>
        /// Gets or Sets TrackTime
        /// </summary>
        [DataMember(Name="TrackTime", EmitDefaultValue=false)]
        public BooleanValue TrackTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeActivity {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Approver: ").Append(Approver).Append("\n");
            sb.Append("  Billable: ").Append(Billable).Append("\n");
            sb.Append("  BillableOvertime: ").Append(BillableOvertime).Append("\n");
            sb.Append("  BillableTime: ").Append(BillableTime).Append("\n");
            sb.Append("  CostCode: ").Append(CostCode).Append("\n");
            sb.Append("  EarningType: ").Append(EarningType).Append("\n");
            sb.Append("  Overtime: ").Append(Overtime).Append("\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  ProjectTask: ").Append(ProjectTask).Append("\n");
            sb.Append("  ReferenceNbr: ").Append(ReferenceNbr).Append("\n");
            sb.Append("  Released: ").Append(Released).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TimeSpent: ").Append(TimeSpent).Append("\n");
            sb.Append("  TrackTime: ").Append(TrackTime).Append("\n");
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
            return this.Equals(input as TimeActivity);
        }

        /// <summary>
        /// Returns true if TimeActivity instances are equal
        /// </summary>
        /// <param name="input">Instance of TimeActivity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeActivity input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Approver == input.Approver ||
                    (this.Approver != null &&
                    this.Approver.Equals(input.Approver))
                ) && base.Equals(input) && 
                (
                    this.Billable == input.Billable ||
                    (this.Billable != null &&
                    this.Billable.Equals(input.Billable))
                ) && base.Equals(input) && 
                (
                    this.BillableOvertime == input.BillableOvertime ||
                    (this.BillableOvertime != null &&
                    this.BillableOvertime.Equals(input.BillableOvertime))
                ) && base.Equals(input) && 
                (
                    this.BillableTime == input.BillableTime ||
                    (this.BillableTime != null &&
                    this.BillableTime.Equals(input.BillableTime))
                ) && base.Equals(input) && 
                (
                    this.CostCode == input.CostCode ||
                    (this.CostCode != null &&
                    this.CostCode.Equals(input.CostCode))
                ) && base.Equals(input) && 
                (
                    this.EarningType == input.EarningType ||
                    (this.EarningType != null &&
                    this.EarningType.Equals(input.EarningType))
                ) && base.Equals(input) && 
                (
                    this.Overtime == input.Overtime ||
                    (this.Overtime != null &&
                    this.Overtime.Equals(input.Overtime))
                ) && base.Equals(input) && 
                (
                    this.Project == input.Project ||
                    (this.Project != null &&
                    this.Project.Equals(input.Project))
                ) && base.Equals(input) && 
                (
                    this.ProjectTask == input.ProjectTask ||
                    (this.ProjectTask != null &&
                    this.ProjectTask.Equals(input.ProjectTask))
                ) && base.Equals(input) && 
                (
                    this.ReferenceNbr == input.ReferenceNbr ||
                    (this.ReferenceNbr != null &&
                    this.ReferenceNbr.Equals(input.ReferenceNbr))
                ) && base.Equals(input) && 
                (
                    this.Released == input.Released ||
                    (this.Released != null &&
                    this.Released.Equals(input.Released))
                ) && base.Equals(input) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && base.Equals(input) && 
                (
                    this.TimeSpent == input.TimeSpent ||
                    (this.TimeSpent != null &&
                    this.TimeSpent.Equals(input.TimeSpent))
                ) && base.Equals(input) && 
                (
                    this.TrackTime == input.TrackTime ||
                    (this.TrackTime != null &&
                    this.TrackTime.Equals(input.TrackTime))
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
                if (this.Approver != null)
                    hashCode = hashCode * 59 + this.Approver.GetHashCode();
                if (this.Billable != null)
                    hashCode = hashCode * 59 + this.Billable.GetHashCode();
                if (this.BillableOvertime != null)
                    hashCode = hashCode * 59 + this.BillableOvertime.GetHashCode();
                if (this.BillableTime != null)
                    hashCode = hashCode * 59 + this.BillableTime.GetHashCode();
                if (this.CostCode != null)
                    hashCode = hashCode * 59 + this.CostCode.GetHashCode();
                if (this.EarningType != null)
                    hashCode = hashCode * 59 + this.EarningType.GetHashCode();
                if (this.Overtime != null)
                    hashCode = hashCode * 59 + this.Overtime.GetHashCode();
                if (this.Project != null)
                    hashCode = hashCode * 59 + this.Project.GetHashCode();
                if (this.ProjectTask != null)
                    hashCode = hashCode * 59 + this.ProjectTask.GetHashCode();
                if (this.ReferenceNbr != null)
                    hashCode = hashCode * 59 + this.ReferenceNbr.GetHashCode();
                if (this.Released != null)
                    hashCode = hashCode * 59 + this.Released.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TimeSpent != null)
                    hashCode = hashCode * 59 + this.TimeSpent.GetHashCode();
                if (this.TrackTime != null)
                    hashCode = hashCode * 59 + this.TrackTime.GetHashCode();
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
