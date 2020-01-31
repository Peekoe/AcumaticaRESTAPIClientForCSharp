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
    /// CaseActivityDetail
    /// </summary>
    [DataContract]
    public partial class CaseActivityDetail : Entity,  IEquatable<CaseActivityDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CaseActivityDetail" /> class.
        /// </summary>
        /// <param name="billable">billable.</param>
        /// <param name="billableOvertime">billableOvertime.</param>
        /// <param name="billableTime">billableTime.</param>
        /// <param name="category">category.</param>
        /// <param name="classIcon">classIcon.</param>
        /// <param name="costCode">costCode.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="isCompleteIcon">isCompleteIcon.</param>
        /// <param name="noteID">noteID.</param>
        /// <param name="overtime">overtime.</param>
        /// <param name="owner">owner.</param>
        /// <param name="priorityIcon">priorityIcon.</param>
        /// <param name="project">project.</param>
        /// <param name="projectTask">projectTask.</param>
        /// <param name="refNoteID">refNoteID.</param>
        /// <param name="released">released.</param>
        /// <param name="reminderIcon">reminderIcon.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="status">status.</param>
        /// <param name="summary">summary.</param>
        /// <param name="timeSpent">timeSpent.</param>
        /// <param name="type">type.</param>
        /// <param name="workgroup">workgroup.</param>
        public CaseActivityDetail(BooleanValue billable = default(BooleanValue), StringValue billableOvertime = default(StringValue), StringValue billableTime = default(StringValue), StringValue category = default(StringValue), StringValue classIcon = default(StringValue), StringValue costCode = default(StringValue), DateTimeValue createdAt = default(DateTimeValue), StringValue createdBy = default(StringValue), StringValue isCompleteIcon = default(StringValue), GuidValue noteID = default(GuidValue), StringValue overtime = default(StringValue), StringValue owner = default(StringValue), StringValue priorityIcon = default(StringValue), StringValue project = default(StringValue), StringValue projectTask = default(StringValue), GuidValue refNoteID = default(GuidValue), BooleanValue released = default(BooleanValue), StringValue reminderIcon = default(StringValue), DateTimeValue startDate = default(DateTimeValue), StringValue status = default(StringValue), StringValue summary = default(StringValue), StringValue timeSpent = default(StringValue), StringValue type = default(StringValue), StringValue workgroup = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Billable = billable;
            this.BillableOvertime = billableOvertime;
            this.BillableTime = billableTime;
            this.Category = category;
            this.ClassIcon = classIcon;
            this.CostCode = costCode;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.IsCompleteIcon = isCompleteIcon;
            this.NoteID = noteID;
            this.Overtime = overtime;
            this.Owner = owner;
            this.PriorityIcon = priorityIcon;
            this.Project = project;
            this.ProjectTask = projectTask;
            this.RefNoteID = refNoteID;
            this.Released = released;
            this.ReminderIcon = reminderIcon;
            this.StartDate = startDate;
            this.Status = status;
            this.Summary = summary;
            this.TimeSpent = timeSpent;
            this.Type = type;
            this.Workgroup = workgroup;
        }
        
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
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="Category", EmitDefaultValue=false)]
        public StringValue Category { get; set; }

        /// <summary>
        /// Gets or Sets ClassIcon
        /// </summary>
        [DataMember(Name="ClassIcon", EmitDefaultValue=false)]
        public StringValue ClassIcon { get; set; }

        /// <summary>
        /// Gets or Sets CostCode
        /// </summary>
        [DataMember(Name="CostCode", EmitDefaultValue=false)]
        public StringValue CostCode { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="CreatedAt", EmitDefaultValue=false)]
        public DateTimeValue CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="CreatedBy", EmitDefaultValue=false)]
        public StringValue CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets IsCompleteIcon
        /// </summary>
        [DataMember(Name="IsCompleteIcon", EmitDefaultValue=false)]
        public StringValue IsCompleteIcon { get; set; }

        /// <summary>
        /// Gets or Sets NoteID
        /// </summary>
        [DataMember(Name="NoteID", EmitDefaultValue=false)]
        public GuidValue NoteID { get; set; }

        /// <summary>
        /// Gets or Sets Overtime
        /// </summary>
        [DataMember(Name="Overtime", EmitDefaultValue=false)]
        public StringValue Overtime { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name="Owner", EmitDefaultValue=false)]
        public StringValue Owner { get; set; }

        /// <summary>
        /// Gets or Sets PriorityIcon
        /// </summary>
        [DataMember(Name="PriorityIcon", EmitDefaultValue=false)]
        public StringValue PriorityIcon { get; set; }

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
        /// Gets or Sets RefNoteID
        /// </summary>
        [DataMember(Name="RefNoteID", EmitDefaultValue=false)]
        public GuidValue RefNoteID { get; set; }

        /// <summary>
        /// Gets or Sets Released
        /// </summary>
        [DataMember(Name="Released", EmitDefaultValue=false)]
        public BooleanValue Released { get; set; }

        /// <summary>
        /// Gets or Sets ReminderIcon
        /// </summary>
        [DataMember(Name="ReminderIcon", EmitDefaultValue=false)]
        public StringValue ReminderIcon { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="StartDate", EmitDefaultValue=false)]
        public DateTimeValue StartDate { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StringValue Status { get; set; }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name="Summary", EmitDefaultValue=false)]
        public StringValue Summary { get; set; }

        /// <summary>
        /// Gets or Sets TimeSpent
        /// </summary>
        [DataMember(Name="TimeSpent", EmitDefaultValue=false)]
        public StringValue TimeSpent { get; set; }

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
            sb.Append("class CaseActivityDetail {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Billable: ").Append(Billable).Append("\n");
            sb.Append("  BillableOvertime: ").Append(BillableOvertime).Append("\n");
            sb.Append("  BillableTime: ").Append(BillableTime).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  ClassIcon: ").Append(ClassIcon).Append("\n");
            sb.Append("  CostCode: ").Append(CostCode).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  IsCompleteIcon: ").Append(IsCompleteIcon).Append("\n");
            sb.Append("  NoteID: ").Append(NoteID).Append("\n");
            sb.Append("  Overtime: ").Append(Overtime).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  PriorityIcon: ").Append(PriorityIcon).Append("\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  ProjectTask: ").Append(ProjectTask).Append("\n");
            sb.Append("  RefNoteID: ").Append(RefNoteID).Append("\n");
            sb.Append("  Released: ").Append(Released).Append("\n");
            sb.Append("  ReminderIcon: ").Append(ReminderIcon).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  TimeSpent: ").Append(TimeSpent).Append("\n");
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
            return this.Equals(input as CaseActivityDetail);
        }

        /// <summary>
        /// Returns true if CaseActivityDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of CaseActivityDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CaseActivityDetail input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
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
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && base.Equals(input) && 
                (
                    this.ClassIcon == input.ClassIcon ||
                    (this.ClassIcon != null &&
                    this.ClassIcon.Equals(input.ClassIcon))
                ) && base.Equals(input) && 
                (
                    this.CostCode == input.CostCode ||
                    (this.CostCode != null &&
                    this.CostCode.Equals(input.CostCode))
                ) && base.Equals(input) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && base.Equals(input) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && base.Equals(input) && 
                (
                    this.IsCompleteIcon == input.IsCompleteIcon ||
                    (this.IsCompleteIcon != null &&
                    this.IsCompleteIcon.Equals(input.IsCompleteIcon))
                ) && base.Equals(input) && 
                (
                    this.NoteID == input.NoteID ||
                    (this.NoteID != null &&
                    this.NoteID.Equals(input.NoteID))
                ) && base.Equals(input) && 
                (
                    this.Overtime == input.Overtime ||
                    (this.Overtime != null &&
                    this.Overtime.Equals(input.Overtime))
                ) && base.Equals(input) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && base.Equals(input) && 
                (
                    this.PriorityIcon == input.PriorityIcon ||
                    (this.PriorityIcon != null &&
                    this.PriorityIcon.Equals(input.PriorityIcon))
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
                    this.RefNoteID == input.RefNoteID ||
                    (this.RefNoteID != null &&
                    this.RefNoteID.Equals(input.RefNoteID))
                ) && base.Equals(input) && 
                (
                    this.Released == input.Released ||
                    (this.Released != null &&
                    this.Released.Equals(input.Released))
                ) && base.Equals(input) && 
                (
                    this.ReminderIcon == input.ReminderIcon ||
                    (this.ReminderIcon != null &&
                    this.ReminderIcon.Equals(input.ReminderIcon))
                ) && base.Equals(input) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && base.Equals(input) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && base.Equals(input) && 
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
                ) && base.Equals(input) && 
                (
                    this.TimeSpent == input.TimeSpent ||
                    (this.TimeSpent != null &&
                    this.TimeSpent.Equals(input.TimeSpent))
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
                if (this.Billable != null)
                    hashCode = hashCode * 59 + this.Billable.GetHashCode();
                if (this.BillableOvertime != null)
                    hashCode = hashCode * 59 + this.BillableOvertime.GetHashCode();
                if (this.BillableTime != null)
                    hashCode = hashCode * 59 + this.BillableTime.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.ClassIcon != null)
                    hashCode = hashCode * 59 + this.ClassIcon.GetHashCode();
                if (this.CostCode != null)
                    hashCode = hashCode * 59 + this.CostCode.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.IsCompleteIcon != null)
                    hashCode = hashCode * 59 + this.IsCompleteIcon.GetHashCode();
                if (this.NoteID != null)
                    hashCode = hashCode * 59 + this.NoteID.GetHashCode();
                if (this.Overtime != null)
                    hashCode = hashCode * 59 + this.Overtime.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.PriorityIcon != null)
                    hashCode = hashCode * 59 + this.PriorityIcon.GetHashCode();
                if (this.Project != null)
                    hashCode = hashCode * 59 + this.Project.GetHashCode();
                if (this.ProjectTask != null)
                    hashCode = hashCode * 59 + this.ProjectTask.GetHashCode();
                if (this.RefNoteID != null)
                    hashCode = hashCode * 59 + this.RefNoteID.GetHashCode();
                if (this.Released != null)
                    hashCode = hashCode * 59 + this.Released.GetHashCode();
                if (this.ReminderIcon != null)
                    hashCode = hashCode * 59 + this.ReminderIcon.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Summary != null)
                    hashCode = hashCode * 59 + this.Summary.GetHashCode();
                if (this.TimeSpent != null)
                    hashCode = hashCode * 59 + this.TimeSpent.GetHashCode();
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
