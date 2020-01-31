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
    /// SalesOrderDetail
    /// </summary>
    [DataContract]
    public partial class SalesOrderDetail : Entity,  IEquatable<SalesOrderDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesOrderDetail" /> class.
        /// </summary>
        /// <param name="account">account.</param>
        /// <param name="allocations">allocations.</param>
        /// <param name="alternateID">alternateID.</param>
        /// <param name="autoCreateIssue">autoCreateIssue.</param>
        /// <param name="averageCost">averageCost.</param>
        /// <param name="branch">branch.</param>
        /// <param name="calculateDiscountsOnImport">calculateDiscountsOnImport.</param>
        /// <param name="commissionable">commissionable.</param>
        /// <param name="completed">completed.</param>
        /// <param name="costCode">costCode.</param>
        /// <param name="discountAmount">discountAmount.</param>
        /// <param name="discountCode">discountCode.</param>
        /// <param name="discountedUnitPrice">discountedUnitPrice.</param>
        /// <param name="discountPercent">discountPercent.</param>
        /// <param name="extendedPrice">extendedPrice.</param>
        /// <param name="freeItem">freeItem.</param>
        /// <param name="inventoryID">inventoryID.</param>
        /// <param name="lastModifiedDate">lastModifiedDate.</param>
        /// <param name="lineDescription">lineDescription.</param>
        /// <param name="lineNbr">lineNbr.</param>
        /// <param name="lineType">lineType.</param>
        /// <param name="location">location.</param>
        /// <param name="manualDiscount">manualDiscount.</param>
        /// <param name="markForPO">markForPO.</param>
        /// <param name="openQty">openQty.</param>
        /// <param name="operation">operation.</param>
        /// <param name="orderQty">orderQty.</param>
        /// <param name="overshipThreshold">overshipThreshold.</param>
        /// <param name="pOSource">pOSource.</param>
        /// <param name="projectTask">projectTask.</param>
        /// <param name="purchasingSettings">purchasingSettings.</param>
        /// <param name="qtyOnShipments">qtyOnShipments.</param>
        /// <param name="reasonCode">reasonCode.</param>
        /// <param name="requestedOn">requestedOn.</param>
        /// <param name="salespersonID">salespersonID.</param>
        /// <param name="shipOn">shipOn.</param>
        /// <param name="shippingRule">shippingRule.</param>
        /// <param name="subitem">subitem.</param>
        /// <param name="taxCategory">taxCategory.</param>
        /// <param name="unbilledAmount">unbilledAmount.</param>
        /// <param name="undershipThreshold">undershipThreshold.</param>
        /// <param name="unitCost">unitCost.</param>
        /// <param name="unitPrice">unitPrice.</param>
        /// <param name="uOM">uOM.</param>
        /// <param name="warehouseID">warehouseID.</param>
        public SalesOrderDetail(StringValue account = default(StringValue), List<SalesOrderDetailAllocation> allocations = default(List<SalesOrderDetailAllocation>), StringValue alternateID = default(StringValue), BooleanValue autoCreateIssue = default(BooleanValue), DecimalValue averageCost = default(DecimalValue), StringValue branch = default(StringValue), BooleanValue calculateDiscountsOnImport = default(BooleanValue), BooleanValue commissionable = default(BooleanValue), BooleanValue completed = default(BooleanValue), StringValue costCode = default(StringValue), DecimalValue discountAmount = default(DecimalValue), StringValue discountCode = default(StringValue), DecimalValue discountedUnitPrice = default(DecimalValue), DecimalValue discountPercent = default(DecimalValue), DecimalValue extendedPrice = default(DecimalValue), BooleanValue freeItem = default(BooleanValue), StringValue inventoryID = default(StringValue), StringValue lastModifiedDate = default(StringValue), StringValue lineDescription = default(StringValue), IntValue lineNbr = default(IntValue), StringValue lineType = default(StringValue), StringValue location = default(StringValue), BooleanValue manualDiscount = default(BooleanValue), BooleanValue markForPO = default(BooleanValue), DecimalValue openQty = default(DecimalValue), StringValue operation = default(StringValue), DecimalValue orderQty = default(DecimalValue), DecimalValue overshipThreshold = default(DecimalValue), StringValue pOSource = default(StringValue), StringValue projectTask = default(StringValue), PurchaseSettings purchasingSettings = default(PurchaseSettings), DecimalValue qtyOnShipments = default(DecimalValue), StringValue reasonCode = default(StringValue), DateTimeValue requestedOn = default(DateTimeValue), StringValue salespersonID = default(StringValue), DateTimeValue shipOn = default(DateTimeValue), StringValue shippingRule = default(StringValue), StringValue subitem = default(StringValue), StringValue taxCategory = default(StringValue), DecimalValue unbilledAmount = default(DecimalValue), DecimalValue undershipThreshold = default(DecimalValue), DecimalValue unitCost = default(DecimalValue), DecimalValue unitPrice = default(DecimalValue), StringValue uOM = default(StringValue), StringValue warehouseID = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Account = account;
            this.Allocations = allocations;
            this.AlternateID = alternateID;
            this.AutoCreateIssue = autoCreateIssue;
            this.AverageCost = averageCost;
            this.Branch = branch;
            this.CalculateDiscountsOnImport = calculateDiscountsOnImport;
            this.Commissionable = commissionable;
            this.Completed = completed;
            this.CostCode = costCode;
            this.DiscountAmount = discountAmount;
            this.DiscountCode = discountCode;
            this.DiscountedUnitPrice = discountedUnitPrice;
            this.DiscountPercent = discountPercent;
            this.ExtendedPrice = extendedPrice;
            this.FreeItem = freeItem;
            this.InventoryID = inventoryID;
            this.LastModifiedDate = lastModifiedDate;
            this.LineDescription = lineDescription;
            this.LineNbr = lineNbr;
            this.LineType = lineType;
            this.Location = location;
            this.ManualDiscount = manualDiscount;
            this.MarkForPO = markForPO;
            this.OpenQty = openQty;
            this.Operation = operation;
            this.OrderQty = orderQty;
            this.OvershipThreshold = overshipThreshold;
            this.POSource = pOSource;
            this.ProjectTask = projectTask;
            this.PurchasingSettings = purchasingSettings;
            this.QtyOnShipments = qtyOnShipments;
            this.ReasonCode = reasonCode;
            this.RequestedOn = requestedOn;
            this.SalespersonID = salespersonID;
            this.ShipOn = shipOn;
            this.ShippingRule = shippingRule;
            this.Subitem = subitem;
            this.TaxCategory = taxCategory;
            this.UnbilledAmount = unbilledAmount;
            this.UndershipThreshold = undershipThreshold;
            this.UnitCost = unitCost;
            this.UnitPrice = unitPrice;
            this.UOM = uOM;
            this.WarehouseID = warehouseID;
        }
        
        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name="Account", EmitDefaultValue=false)]
        public StringValue Account { get; set; }

        /// <summary>
        /// Gets or Sets Allocations
        /// </summary>
        [DataMember(Name="Allocations", EmitDefaultValue=false)]
        public List<SalesOrderDetailAllocation> Allocations { get; set; }

        /// <summary>
        /// Gets or Sets AlternateID
        /// </summary>
        [DataMember(Name="AlternateID", EmitDefaultValue=false)]
        public StringValue AlternateID { get; set; }

        /// <summary>
        /// Gets or Sets AutoCreateIssue
        /// </summary>
        [DataMember(Name="AutoCreateIssue", EmitDefaultValue=false)]
        public BooleanValue AutoCreateIssue { get; set; }

        /// <summary>
        /// Gets or Sets AverageCost
        /// </summary>
        [DataMember(Name="AverageCost", EmitDefaultValue=false)]
        public DecimalValue AverageCost { get; set; }

        /// <summary>
        /// Gets or Sets Branch
        /// </summary>
        [DataMember(Name="Branch", EmitDefaultValue=false)]
        public StringValue Branch { get; set; }

        /// <summary>
        /// Gets or Sets CalculateDiscountsOnImport
        /// </summary>
        [DataMember(Name="CalculateDiscountsOnImport", EmitDefaultValue=false)]
        public BooleanValue CalculateDiscountsOnImport { get; set; }

        /// <summary>
        /// Gets or Sets Commissionable
        /// </summary>
        [DataMember(Name="Commissionable", EmitDefaultValue=false)]
        public BooleanValue Commissionable { get; set; }

        /// <summary>
        /// Gets or Sets Completed
        /// </summary>
        [DataMember(Name="Completed", EmitDefaultValue=false)]
        public BooleanValue Completed { get; set; }

        /// <summary>
        /// Gets or Sets CostCode
        /// </summary>
        [DataMember(Name="CostCode", EmitDefaultValue=false)]
        public StringValue CostCode { get; set; }

        /// <summary>
        /// Gets or Sets DiscountAmount
        /// </summary>
        [DataMember(Name="DiscountAmount", EmitDefaultValue=false)]
        public DecimalValue DiscountAmount { get; set; }

        /// <summary>
        /// Gets or Sets DiscountCode
        /// </summary>
        [DataMember(Name="DiscountCode", EmitDefaultValue=false)]
        public StringValue DiscountCode { get; set; }

        /// <summary>
        /// Gets or Sets DiscountedUnitPrice
        /// </summary>
        [DataMember(Name="DiscountedUnitPrice", EmitDefaultValue=false)]
        public DecimalValue DiscountedUnitPrice { get; set; }

        /// <summary>
        /// Gets or Sets DiscountPercent
        /// </summary>
        [DataMember(Name="DiscountPercent", EmitDefaultValue=false)]
        public DecimalValue DiscountPercent { get; set; }

        /// <summary>
        /// Gets or Sets ExtendedPrice
        /// </summary>
        [DataMember(Name="ExtendedPrice", EmitDefaultValue=false)]
        public DecimalValue ExtendedPrice { get; set; }

        /// <summary>
        /// Gets or Sets FreeItem
        /// </summary>
        [DataMember(Name="FreeItem", EmitDefaultValue=false)]
        public BooleanValue FreeItem { get; set; }

        /// <summary>
        /// Gets or Sets InventoryID
        /// </summary>
        [DataMember(Name="InventoryID", EmitDefaultValue=false)]
        public StringValue InventoryID { get; set; }

        /// <summary>
        /// Gets or Sets LastModifiedDate
        /// </summary>
        [DataMember(Name="LastModifiedDate", EmitDefaultValue=false)]
        public StringValue LastModifiedDate { get; set; }

        /// <summary>
        /// Gets or Sets LineDescription
        /// </summary>
        [DataMember(Name="LineDescription", EmitDefaultValue=false)]
        public StringValue LineDescription { get; set; }

        /// <summary>
        /// Gets or Sets LineNbr
        /// </summary>
        [DataMember(Name="LineNbr", EmitDefaultValue=false)]
        public IntValue LineNbr { get; set; }

        /// <summary>
        /// Gets or Sets LineType
        /// </summary>
        [DataMember(Name="LineType", EmitDefaultValue=false)]
        public StringValue LineType { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="Location", EmitDefaultValue=false)]
        public StringValue Location { get; set; }

        /// <summary>
        /// Gets or Sets ManualDiscount
        /// </summary>
        [DataMember(Name="ManualDiscount", EmitDefaultValue=false)]
        public BooleanValue ManualDiscount { get; set; }

        /// <summary>
        /// Gets or Sets MarkForPO
        /// </summary>
        [DataMember(Name="MarkForPO", EmitDefaultValue=false)]
        public BooleanValue MarkForPO { get; set; }

        /// <summary>
        /// Gets or Sets OpenQty
        /// </summary>
        [DataMember(Name="OpenQty", EmitDefaultValue=false)]
        public DecimalValue OpenQty { get; set; }

        /// <summary>
        /// Gets or Sets Operation
        /// </summary>
        [DataMember(Name="Operation", EmitDefaultValue=false)]
        public StringValue Operation { get; set; }

        /// <summary>
        /// Gets or Sets OrderQty
        /// </summary>
        [DataMember(Name="OrderQty", EmitDefaultValue=false)]
        public DecimalValue OrderQty { get; set; }

        /// <summary>
        /// Gets or Sets OvershipThreshold
        /// </summary>
        [DataMember(Name="OvershipThreshold", EmitDefaultValue=false)]
        public DecimalValue OvershipThreshold { get; set; }

        /// <summary>
        /// Gets or Sets POSource
        /// </summary>
        [DataMember(Name="POSource", EmitDefaultValue=false)]
        public StringValue POSource { get; set; }

        /// <summary>
        /// Gets or Sets ProjectTask
        /// </summary>
        [DataMember(Name="ProjectTask", EmitDefaultValue=false)]
        public StringValue ProjectTask { get; set; }

        /// <summary>
        /// Gets or Sets PurchasingSettings
        /// </summary>
        [DataMember(Name="PurchasingSettings", EmitDefaultValue=false)]
        public PurchaseSettings PurchasingSettings { get; set; }

        /// <summary>
        /// Gets or Sets QtyOnShipments
        /// </summary>
        [DataMember(Name="QtyOnShipments", EmitDefaultValue=false)]
        public DecimalValue QtyOnShipments { get; set; }

        /// <summary>
        /// Gets or Sets ReasonCode
        /// </summary>
        [DataMember(Name="ReasonCode", EmitDefaultValue=false)]
        public StringValue ReasonCode { get; set; }

        /// <summary>
        /// Gets or Sets RequestedOn
        /// </summary>
        [DataMember(Name="RequestedOn", EmitDefaultValue=false)]
        public DateTimeValue RequestedOn { get; set; }

        /// <summary>
        /// Gets or Sets SalespersonID
        /// </summary>
        [DataMember(Name="SalespersonID", EmitDefaultValue=false)]
        public StringValue SalespersonID { get; set; }

        /// <summary>
        /// Gets or Sets ShipOn
        /// </summary>
        [DataMember(Name="ShipOn", EmitDefaultValue=false)]
        public DateTimeValue ShipOn { get; set; }

        /// <summary>
        /// Gets or Sets ShippingRule
        /// </summary>
        [DataMember(Name="ShippingRule", EmitDefaultValue=false)]
        public StringValue ShippingRule { get; set; }

        /// <summary>
        /// Gets or Sets Subitem
        /// </summary>
        [DataMember(Name="Subitem", EmitDefaultValue=false)]
        public StringValue Subitem { get; set; }

        /// <summary>
        /// Gets or Sets TaxCategory
        /// </summary>
        [DataMember(Name="TaxCategory", EmitDefaultValue=false)]
        public StringValue TaxCategory { get; set; }

        /// <summary>
        /// Gets or Sets UnbilledAmount
        /// </summary>
        [DataMember(Name="UnbilledAmount", EmitDefaultValue=false)]
        public DecimalValue UnbilledAmount { get; set; }

        /// <summary>
        /// Gets or Sets UndershipThreshold
        /// </summary>
        [DataMember(Name="UndershipThreshold", EmitDefaultValue=false)]
        public DecimalValue UndershipThreshold { get; set; }

        /// <summary>
        /// Gets or Sets UnitCost
        /// </summary>
        [DataMember(Name="UnitCost", EmitDefaultValue=false)]
        public DecimalValue UnitCost { get; set; }

        /// <summary>
        /// Gets or Sets UnitPrice
        /// </summary>
        [DataMember(Name="UnitPrice", EmitDefaultValue=false)]
        public DecimalValue UnitPrice { get; set; }

        /// <summary>
        /// Gets or Sets UOM
        /// </summary>
        [DataMember(Name="UOM", EmitDefaultValue=false)]
        public StringValue UOM { get; set; }

        /// <summary>
        /// Gets or Sets WarehouseID
        /// </summary>
        [DataMember(Name="WarehouseID", EmitDefaultValue=false)]
        public StringValue WarehouseID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SalesOrderDetail {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Allocations: ").Append(Allocations).Append("\n");
            sb.Append("  AlternateID: ").Append(AlternateID).Append("\n");
            sb.Append("  AutoCreateIssue: ").Append(AutoCreateIssue).Append("\n");
            sb.Append("  AverageCost: ").Append(AverageCost).Append("\n");
            sb.Append("  Branch: ").Append(Branch).Append("\n");
            sb.Append("  CalculateDiscountsOnImport: ").Append(CalculateDiscountsOnImport).Append("\n");
            sb.Append("  Commissionable: ").Append(Commissionable).Append("\n");
            sb.Append("  Completed: ").Append(Completed).Append("\n");
            sb.Append("  CostCode: ").Append(CostCode).Append("\n");
            sb.Append("  DiscountAmount: ").Append(DiscountAmount).Append("\n");
            sb.Append("  DiscountCode: ").Append(DiscountCode).Append("\n");
            sb.Append("  DiscountedUnitPrice: ").Append(DiscountedUnitPrice).Append("\n");
            sb.Append("  DiscountPercent: ").Append(DiscountPercent).Append("\n");
            sb.Append("  ExtendedPrice: ").Append(ExtendedPrice).Append("\n");
            sb.Append("  FreeItem: ").Append(FreeItem).Append("\n");
            sb.Append("  InventoryID: ").Append(InventoryID).Append("\n");
            sb.Append("  LastModifiedDate: ").Append(LastModifiedDate).Append("\n");
            sb.Append("  LineDescription: ").Append(LineDescription).Append("\n");
            sb.Append("  LineNbr: ").Append(LineNbr).Append("\n");
            sb.Append("  LineType: ").Append(LineType).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  ManualDiscount: ").Append(ManualDiscount).Append("\n");
            sb.Append("  MarkForPO: ").Append(MarkForPO).Append("\n");
            sb.Append("  OpenQty: ").Append(OpenQty).Append("\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
            sb.Append("  OrderQty: ").Append(OrderQty).Append("\n");
            sb.Append("  OvershipThreshold: ").Append(OvershipThreshold).Append("\n");
            sb.Append("  POSource: ").Append(POSource).Append("\n");
            sb.Append("  ProjectTask: ").Append(ProjectTask).Append("\n");
            sb.Append("  PurchasingSettings: ").Append(PurchasingSettings).Append("\n");
            sb.Append("  QtyOnShipments: ").Append(QtyOnShipments).Append("\n");
            sb.Append("  ReasonCode: ").Append(ReasonCode).Append("\n");
            sb.Append("  RequestedOn: ").Append(RequestedOn).Append("\n");
            sb.Append("  SalespersonID: ").Append(SalespersonID).Append("\n");
            sb.Append("  ShipOn: ").Append(ShipOn).Append("\n");
            sb.Append("  ShippingRule: ").Append(ShippingRule).Append("\n");
            sb.Append("  Subitem: ").Append(Subitem).Append("\n");
            sb.Append("  TaxCategory: ").Append(TaxCategory).Append("\n");
            sb.Append("  UnbilledAmount: ").Append(UnbilledAmount).Append("\n");
            sb.Append("  UndershipThreshold: ").Append(UndershipThreshold).Append("\n");
            sb.Append("  UnitCost: ").Append(UnitCost).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  UOM: ").Append(UOM).Append("\n");
            sb.Append("  WarehouseID: ").Append(WarehouseID).Append("\n");
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
            return this.Equals(input as SalesOrderDetail);
        }

        /// <summary>
        /// Returns true if SalesOrderDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of SalesOrderDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SalesOrderDetail input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && base.Equals(input) && 
                (
                    this.Allocations == input.Allocations ||
                    this.Allocations != null &&
                    this.Allocations.SequenceEqual(input.Allocations)
                ) && base.Equals(input) && 
                (
                    this.AlternateID == input.AlternateID ||
                    (this.AlternateID != null &&
                    this.AlternateID.Equals(input.AlternateID))
                ) && base.Equals(input) && 
                (
                    this.AutoCreateIssue == input.AutoCreateIssue ||
                    (this.AutoCreateIssue != null &&
                    this.AutoCreateIssue.Equals(input.AutoCreateIssue))
                ) && base.Equals(input) && 
                (
                    this.AverageCost == input.AverageCost ||
                    (this.AverageCost != null &&
                    this.AverageCost.Equals(input.AverageCost))
                ) && base.Equals(input) && 
                (
                    this.Branch == input.Branch ||
                    (this.Branch != null &&
                    this.Branch.Equals(input.Branch))
                ) && base.Equals(input) && 
                (
                    this.CalculateDiscountsOnImport == input.CalculateDiscountsOnImport ||
                    (this.CalculateDiscountsOnImport != null &&
                    this.CalculateDiscountsOnImport.Equals(input.CalculateDiscountsOnImport))
                ) && base.Equals(input) && 
                (
                    this.Commissionable == input.Commissionable ||
                    (this.Commissionable != null &&
                    this.Commissionable.Equals(input.Commissionable))
                ) && base.Equals(input) && 
                (
                    this.Completed == input.Completed ||
                    (this.Completed != null &&
                    this.Completed.Equals(input.Completed))
                ) && base.Equals(input) && 
                (
                    this.CostCode == input.CostCode ||
                    (this.CostCode != null &&
                    this.CostCode.Equals(input.CostCode))
                ) && base.Equals(input) && 
                (
                    this.DiscountAmount == input.DiscountAmount ||
                    (this.DiscountAmount != null &&
                    this.DiscountAmount.Equals(input.DiscountAmount))
                ) && base.Equals(input) && 
                (
                    this.DiscountCode == input.DiscountCode ||
                    (this.DiscountCode != null &&
                    this.DiscountCode.Equals(input.DiscountCode))
                ) && base.Equals(input) && 
                (
                    this.DiscountedUnitPrice == input.DiscountedUnitPrice ||
                    (this.DiscountedUnitPrice != null &&
                    this.DiscountedUnitPrice.Equals(input.DiscountedUnitPrice))
                ) && base.Equals(input) && 
                (
                    this.DiscountPercent == input.DiscountPercent ||
                    (this.DiscountPercent != null &&
                    this.DiscountPercent.Equals(input.DiscountPercent))
                ) && base.Equals(input) && 
                (
                    this.ExtendedPrice == input.ExtendedPrice ||
                    (this.ExtendedPrice != null &&
                    this.ExtendedPrice.Equals(input.ExtendedPrice))
                ) && base.Equals(input) && 
                (
                    this.FreeItem == input.FreeItem ||
                    (this.FreeItem != null &&
                    this.FreeItem.Equals(input.FreeItem))
                ) && base.Equals(input) && 
                (
                    this.InventoryID == input.InventoryID ||
                    (this.InventoryID != null &&
                    this.InventoryID.Equals(input.InventoryID))
                ) && base.Equals(input) && 
                (
                    this.LastModifiedDate == input.LastModifiedDate ||
                    (this.LastModifiedDate != null &&
                    this.LastModifiedDate.Equals(input.LastModifiedDate))
                ) && base.Equals(input) && 
                (
                    this.LineDescription == input.LineDescription ||
                    (this.LineDescription != null &&
                    this.LineDescription.Equals(input.LineDescription))
                ) && base.Equals(input) && 
                (
                    this.LineNbr == input.LineNbr ||
                    (this.LineNbr != null &&
                    this.LineNbr.Equals(input.LineNbr))
                ) && base.Equals(input) && 
                (
                    this.LineType == input.LineType ||
                    (this.LineType != null &&
                    this.LineType.Equals(input.LineType))
                ) && base.Equals(input) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && base.Equals(input) && 
                (
                    this.ManualDiscount == input.ManualDiscount ||
                    (this.ManualDiscount != null &&
                    this.ManualDiscount.Equals(input.ManualDiscount))
                ) && base.Equals(input) && 
                (
                    this.MarkForPO == input.MarkForPO ||
                    (this.MarkForPO != null &&
                    this.MarkForPO.Equals(input.MarkForPO))
                ) && base.Equals(input) && 
                (
                    this.OpenQty == input.OpenQty ||
                    (this.OpenQty != null &&
                    this.OpenQty.Equals(input.OpenQty))
                ) && base.Equals(input) && 
                (
                    this.Operation == input.Operation ||
                    (this.Operation != null &&
                    this.Operation.Equals(input.Operation))
                ) && base.Equals(input) && 
                (
                    this.OrderQty == input.OrderQty ||
                    (this.OrderQty != null &&
                    this.OrderQty.Equals(input.OrderQty))
                ) && base.Equals(input) && 
                (
                    this.OvershipThreshold == input.OvershipThreshold ||
                    (this.OvershipThreshold != null &&
                    this.OvershipThreshold.Equals(input.OvershipThreshold))
                ) && base.Equals(input) && 
                (
                    this.POSource == input.POSource ||
                    (this.POSource != null &&
                    this.POSource.Equals(input.POSource))
                ) && base.Equals(input) && 
                (
                    this.ProjectTask == input.ProjectTask ||
                    (this.ProjectTask != null &&
                    this.ProjectTask.Equals(input.ProjectTask))
                ) && base.Equals(input) && 
                (
                    this.PurchasingSettings == input.PurchasingSettings ||
                    (this.PurchasingSettings != null &&
                    this.PurchasingSettings.Equals(input.PurchasingSettings))
                ) && base.Equals(input) && 
                (
                    this.QtyOnShipments == input.QtyOnShipments ||
                    (this.QtyOnShipments != null &&
                    this.QtyOnShipments.Equals(input.QtyOnShipments))
                ) && base.Equals(input) && 
                (
                    this.ReasonCode == input.ReasonCode ||
                    (this.ReasonCode != null &&
                    this.ReasonCode.Equals(input.ReasonCode))
                ) && base.Equals(input) && 
                (
                    this.RequestedOn == input.RequestedOn ||
                    (this.RequestedOn != null &&
                    this.RequestedOn.Equals(input.RequestedOn))
                ) && base.Equals(input) && 
                (
                    this.SalespersonID == input.SalespersonID ||
                    (this.SalespersonID != null &&
                    this.SalespersonID.Equals(input.SalespersonID))
                ) && base.Equals(input) && 
                (
                    this.ShipOn == input.ShipOn ||
                    (this.ShipOn != null &&
                    this.ShipOn.Equals(input.ShipOn))
                ) && base.Equals(input) && 
                (
                    this.ShippingRule == input.ShippingRule ||
                    (this.ShippingRule != null &&
                    this.ShippingRule.Equals(input.ShippingRule))
                ) && base.Equals(input) && 
                (
                    this.Subitem == input.Subitem ||
                    (this.Subitem != null &&
                    this.Subitem.Equals(input.Subitem))
                ) && base.Equals(input) && 
                (
                    this.TaxCategory == input.TaxCategory ||
                    (this.TaxCategory != null &&
                    this.TaxCategory.Equals(input.TaxCategory))
                ) && base.Equals(input) && 
                (
                    this.UnbilledAmount == input.UnbilledAmount ||
                    (this.UnbilledAmount != null &&
                    this.UnbilledAmount.Equals(input.UnbilledAmount))
                ) && base.Equals(input) && 
                (
                    this.UndershipThreshold == input.UndershipThreshold ||
                    (this.UndershipThreshold != null &&
                    this.UndershipThreshold.Equals(input.UndershipThreshold))
                ) && base.Equals(input) && 
                (
                    this.UnitCost == input.UnitCost ||
                    (this.UnitCost != null &&
                    this.UnitCost.Equals(input.UnitCost))
                ) && base.Equals(input) && 
                (
                    this.UnitPrice == input.UnitPrice ||
                    (this.UnitPrice != null &&
                    this.UnitPrice.Equals(input.UnitPrice))
                ) && base.Equals(input) && 
                (
                    this.UOM == input.UOM ||
                    (this.UOM != null &&
                    this.UOM.Equals(input.UOM))
                ) && base.Equals(input) && 
                (
                    this.WarehouseID == input.WarehouseID ||
                    (this.WarehouseID != null &&
                    this.WarehouseID.Equals(input.WarehouseID))
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
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.Allocations != null)
                    hashCode = hashCode * 59 + this.Allocations.GetHashCode();
                if (this.AlternateID != null)
                    hashCode = hashCode * 59 + this.AlternateID.GetHashCode();
                if (this.AutoCreateIssue != null)
                    hashCode = hashCode * 59 + this.AutoCreateIssue.GetHashCode();
                if (this.AverageCost != null)
                    hashCode = hashCode * 59 + this.AverageCost.GetHashCode();
                if (this.Branch != null)
                    hashCode = hashCode * 59 + this.Branch.GetHashCode();
                if (this.CalculateDiscountsOnImport != null)
                    hashCode = hashCode * 59 + this.CalculateDiscountsOnImport.GetHashCode();
                if (this.Commissionable != null)
                    hashCode = hashCode * 59 + this.Commissionable.GetHashCode();
                if (this.Completed != null)
                    hashCode = hashCode * 59 + this.Completed.GetHashCode();
                if (this.CostCode != null)
                    hashCode = hashCode * 59 + this.CostCode.GetHashCode();
                if (this.DiscountAmount != null)
                    hashCode = hashCode * 59 + this.DiscountAmount.GetHashCode();
                if (this.DiscountCode != null)
                    hashCode = hashCode * 59 + this.DiscountCode.GetHashCode();
                if (this.DiscountedUnitPrice != null)
                    hashCode = hashCode * 59 + this.DiscountedUnitPrice.GetHashCode();
                if (this.DiscountPercent != null)
                    hashCode = hashCode * 59 + this.DiscountPercent.GetHashCode();
                if (this.ExtendedPrice != null)
                    hashCode = hashCode * 59 + this.ExtendedPrice.GetHashCode();
                if (this.FreeItem != null)
                    hashCode = hashCode * 59 + this.FreeItem.GetHashCode();
                if (this.InventoryID != null)
                    hashCode = hashCode * 59 + this.InventoryID.GetHashCode();
                if (this.LastModifiedDate != null)
                    hashCode = hashCode * 59 + this.LastModifiedDate.GetHashCode();
                if (this.LineDescription != null)
                    hashCode = hashCode * 59 + this.LineDescription.GetHashCode();
                if (this.LineNbr != null)
                    hashCode = hashCode * 59 + this.LineNbr.GetHashCode();
                if (this.LineType != null)
                    hashCode = hashCode * 59 + this.LineType.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.ManualDiscount != null)
                    hashCode = hashCode * 59 + this.ManualDiscount.GetHashCode();
                if (this.MarkForPO != null)
                    hashCode = hashCode * 59 + this.MarkForPO.GetHashCode();
                if (this.OpenQty != null)
                    hashCode = hashCode * 59 + this.OpenQty.GetHashCode();
                if (this.Operation != null)
                    hashCode = hashCode * 59 + this.Operation.GetHashCode();
                if (this.OrderQty != null)
                    hashCode = hashCode * 59 + this.OrderQty.GetHashCode();
                if (this.OvershipThreshold != null)
                    hashCode = hashCode * 59 + this.OvershipThreshold.GetHashCode();
                if (this.POSource != null)
                    hashCode = hashCode * 59 + this.POSource.GetHashCode();
                if (this.ProjectTask != null)
                    hashCode = hashCode * 59 + this.ProjectTask.GetHashCode();
                if (this.PurchasingSettings != null)
                    hashCode = hashCode * 59 + this.PurchasingSettings.GetHashCode();
                if (this.QtyOnShipments != null)
                    hashCode = hashCode * 59 + this.QtyOnShipments.GetHashCode();
                if (this.ReasonCode != null)
                    hashCode = hashCode * 59 + this.ReasonCode.GetHashCode();
                if (this.RequestedOn != null)
                    hashCode = hashCode * 59 + this.RequestedOn.GetHashCode();
                if (this.SalespersonID != null)
                    hashCode = hashCode * 59 + this.SalespersonID.GetHashCode();
                if (this.ShipOn != null)
                    hashCode = hashCode * 59 + this.ShipOn.GetHashCode();
                if (this.ShippingRule != null)
                    hashCode = hashCode * 59 + this.ShippingRule.GetHashCode();
                if (this.Subitem != null)
                    hashCode = hashCode * 59 + this.Subitem.GetHashCode();
                if (this.TaxCategory != null)
                    hashCode = hashCode * 59 + this.TaxCategory.GetHashCode();
                if (this.UnbilledAmount != null)
                    hashCode = hashCode * 59 + this.UnbilledAmount.GetHashCode();
                if (this.UndershipThreshold != null)
                    hashCode = hashCode * 59 + this.UndershipThreshold.GetHashCode();
                if (this.UnitCost != null)
                    hashCode = hashCode * 59 + this.UnitCost.GetHashCode();
                if (this.UnitPrice != null)
                    hashCode = hashCode * 59 + this.UnitPrice.GetHashCode();
                if (this.UOM != null)
                    hashCode = hashCode * 59 + this.UOM.GetHashCode();
                if (this.WarehouseID != null)
                    hashCode = hashCode * 59 + this.WarehouseID.GetHashCode();
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
