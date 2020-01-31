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
    /// SalesInvoiceDetail
    /// </summary>
    [DataContract]
    public partial class SalesInvoiceDetail : Entity,  IEquatable<SalesInvoiceDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesInvoiceDetail" /> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="branchID">branchID.</param>
        /// <param name="calculateDiscountsOnImport">calculateDiscountsOnImport.</param>
        /// <param name="costCode">costCode.</param>
        /// <param name="description">description.</param>
        /// <param name="discountAmount">discountAmount.</param>
        /// <param name="discountPercent">discountPercent.</param>
        /// <param name="expirationDate">expirationDate.</param>
        /// <param name="inventoryDocType">inventoryDocType.</param>
        /// <param name="inventoryID">inventoryID.</param>
        /// <param name="inventoryRefNbr">inventoryRefNbr.</param>
        /// <param name="lineNbr">lineNbr.</param>
        /// <param name="location">location.</param>
        /// <param name="lotSerialNbr">lotSerialNbr.</param>
        /// <param name="manualDiscount">manualDiscount.</param>
        /// <param name="orderLineNbr">orderLineNbr.</param>
        /// <param name="orderNbr">orderNbr.</param>
        /// <param name="orderType">orderType.</param>
        /// <param name="origInvLineNbr">origInvLineNbr.</param>
        /// <param name="origInvNbr">origInvNbr.</param>
        /// <param name="origInvType">origInvType.</param>
        /// <param name="projectTask">projectTask.</param>
        /// <param name="qty">qty.</param>
        /// <param name="shipmentNbr">shipmentNbr.</param>
        /// <param name="subitem">subitem.</param>
        /// <param name="taxCategory">taxCategory.</param>
        /// <param name="transactionDescr">transactionDescr.</param>
        /// <param name="unitPrice">unitPrice.</param>
        /// <param name="uOM">uOM.</param>
        /// <param name="warehouseID">warehouseID.</param>
        public SalesInvoiceDetail(DecimalValue amount = default(DecimalValue), StringValue branchID = default(StringValue), BooleanValue calculateDiscountsOnImport = default(BooleanValue), StringValue costCode = default(StringValue), StringValue description = default(StringValue), DecimalValue discountAmount = default(DecimalValue), DecimalValue discountPercent = default(DecimalValue), DateTimeValue expirationDate = default(DateTimeValue), StringValue inventoryDocType = default(StringValue), StringValue inventoryID = default(StringValue), StringValue inventoryRefNbr = default(StringValue), IntValue lineNbr = default(IntValue), StringValue location = default(StringValue), StringValue lotSerialNbr = default(StringValue), BooleanValue manualDiscount = default(BooleanValue), IntValue orderLineNbr = default(IntValue), StringValue orderNbr = default(StringValue), StringValue orderType = default(StringValue), IntValue origInvLineNbr = default(IntValue), StringValue origInvNbr = default(StringValue), StringValue origInvType = default(StringValue), StringValue projectTask = default(StringValue), DecimalValue qty = default(DecimalValue), StringValue shipmentNbr = default(StringValue), StringValue subitem = default(StringValue), StringValue taxCategory = default(StringValue), StringValue transactionDescr = default(StringValue), DecimalValue unitPrice = default(DecimalValue), StringValue uOM = default(StringValue), StringValue warehouseID = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Amount = amount;
            this.BranchID = branchID;
            this.CalculateDiscountsOnImport = calculateDiscountsOnImport;
            this.CostCode = costCode;
            this.Description = description;
            this.DiscountAmount = discountAmount;
            this.DiscountPercent = discountPercent;
            this.ExpirationDate = expirationDate;
            this.InventoryDocType = inventoryDocType;
            this.InventoryID = inventoryID;
            this.InventoryRefNbr = inventoryRefNbr;
            this.LineNbr = lineNbr;
            this.Location = location;
            this.LotSerialNbr = lotSerialNbr;
            this.ManualDiscount = manualDiscount;
            this.OrderLineNbr = orderLineNbr;
            this.OrderNbr = orderNbr;
            this.OrderType = orderType;
            this.OrigInvLineNbr = origInvLineNbr;
            this.OrigInvNbr = origInvNbr;
            this.OrigInvType = origInvType;
            this.ProjectTask = projectTask;
            this.Qty = qty;
            this.ShipmentNbr = shipmentNbr;
            this.Subitem = subitem;
            this.TaxCategory = taxCategory;
            this.TransactionDescr = transactionDescr;
            this.UnitPrice = unitPrice;
            this.UOM = uOM;
            this.WarehouseID = warehouseID;
        }
        
        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="Amount", EmitDefaultValue=false)]
        public DecimalValue Amount { get; set; }

        /// <summary>
        /// Gets or Sets BranchID
        /// </summary>
        [DataMember(Name="BranchID", EmitDefaultValue=false)]
        public StringValue BranchID { get; set; }

        /// <summary>
        /// Gets or Sets CalculateDiscountsOnImport
        /// </summary>
        [DataMember(Name="CalculateDiscountsOnImport", EmitDefaultValue=false)]
        public BooleanValue CalculateDiscountsOnImport { get; set; }

        /// <summary>
        /// Gets or Sets CostCode
        /// </summary>
        [DataMember(Name="CostCode", EmitDefaultValue=false)]
        public StringValue CostCode { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets DiscountAmount
        /// </summary>
        [DataMember(Name="DiscountAmount", EmitDefaultValue=false)]
        public DecimalValue DiscountAmount { get; set; }

        /// <summary>
        /// Gets or Sets DiscountPercent
        /// </summary>
        [DataMember(Name="DiscountPercent", EmitDefaultValue=false)]
        public DecimalValue DiscountPercent { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        [DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
        public DateTimeValue ExpirationDate { get; set; }

        /// <summary>
        /// Gets or Sets InventoryDocType
        /// </summary>
        [DataMember(Name="InventoryDocType", EmitDefaultValue=false)]
        public StringValue InventoryDocType { get; set; }

        /// <summary>
        /// Gets or Sets InventoryID
        /// </summary>
        [DataMember(Name="InventoryID", EmitDefaultValue=false)]
        public StringValue InventoryID { get; set; }

        /// <summary>
        /// Gets or Sets InventoryRefNbr
        /// </summary>
        [DataMember(Name="InventoryRefNbr", EmitDefaultValue=false)]
        public StringValue InventoryRefNbr { get; set; }

        /// <summary>
        /// Gets or Sets LineNbr
        /// </summary>
        [DataMember(Name="LineNbr", EmitDefaultValue=false)]
        public IntValue LineNbr { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="Location", EmitDefaultValue=false)]
        public StringValue Location { get; set; }

        /// <summary>
        /// Gets or Sets LotSerialNbr
        /// </summary>
        [DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
        public StringValue LotSerialNbr { get; set; }

        /// <summary>
        /// Gets or Sets ManualDiscount
        /// </summary>
        [DataMember(Name="ManualDiscount", EmitDefaultValue=false)]
        public BooleanValue ManualDiscount { get; set; }

        /// <summary>
        /// Gets or Sets OrderLineNbr
        /// </summary>
        [DataMember(Name="OrderLineNbr", EmitDefaultValue=false)]
        public IntValue OrderLineNbr { get; set; }

        /// <summary>
        /// Gets or Sets OrderNbr
        /// </summary>
        [DataMember(Name="OrderNbr", EmitDefaultValue=false)]
        public StringValue OrderNbr { get; set; }

        /// <summary>
        /// Gets or Sets OrderType
        /// </summary>
        [DataMember(Name="OrderType", EmitDefaultValue=false)]
        public StringValue OrderType { get; set; }

        /// <summary>
        /// Gets or Sets OrigInvLineNbr
        /// </summary>
        [DataMember(Name="OrigInvLineNbr", EmitDefaultValue=false)]
        public IntValue OrigInvLineNbr { get; set; }

        /// <summary>
        /// Gets or Sets OrigInvNbr
        /// </summary>
        [DataMember(Name="OrigInvNbr", EmitDefaultValue=false)]
        public StringValue OrigInvNbr { get; set; }

        /// <summary>
        /// Gets or Sets OrigInvType
        /// </summary>
        [DataMember(Name="OrigInvType", EmitDefaultValue=false)]
        public StringValue OrigInvType { get; set; }

        /// <summary>
        /// Gets or Sets ProjectTask
        /// </summary>
        [DataMember(Name="ProjectTask", EmitDefaultValue=false)]
        public StringValue ProjectTask { get; set; }

        /// <summary>
        /// Gets or Sets Qty
        /// </summary>
        [DataMember(Name="Qty", EmitDefaultValue=false)]
        public DecimalValue Qty { get; set; }

        /// <summary>
        /// Gets or Sets ShipmentNbr
        /// </summary>
        [DataMember(Name="ShipmentNbr", EmitDefaultValue=false)]
        public StringValue ShipmentNbr { get; set; }

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
        /// Gets or Sets TransactionDescr
        /// </summary>
        [DataMember(Name="TransactionDescr", EmitDefaultValue=false)]
        public StringValue TransactionDescr { get; set; }

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
            sb.Append("class SalesInvoiceDetail {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BranchID: ").Append(BranchID).Append("\n");
            sb.Append("  CalculateDiscountsOnImport: ").Append(CalculateDiscountsOnImport).Append("\n");
            sb.Append("  CostCode: ").Append(CostCode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DiscountAmount: ").Append(DiscountAmount).Append("\n");
            sb.Append("  DiscountPercent: ").Append(DiscountPercent).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  InventoryDocType: ").Append(InventoryDocType).Append("\n");
            sb.Append("  InventoryID: ").Append(InventoryID).Append("\n");
            sb.Append("  InventoryRefNbr: ").Append(InventoryRefNbr).Append("\n");
            sb.Append("  LineNbr: ").Append(LineNbr).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  LotSerialNbr: ").Append(LotSerialNbr).Append("\n");
            sb.Append("  ManualDiscount: ").Append(ManualDiscount).Append("\n");
            sb.Append("  OrderLineNbr: ").Append(OrderLineNbr).Append("\n");
            sb.Append("  OrderNbr: ").Append(OrderNbr).Append("\n");
            sb.Append("  OrderType: ").Append(OrderType).Append("\n");
            sb.Append("  OrigInvLineNbr: ").Append(OrigInvLineNbr).Append("\n");
            sb.Append("  OrigInvNbr: ").Append(OrigInvNbr).Append("\n");
            sb.Append("  OrigInvType: ").Append(OrigInvType).Append("\n");
            sb.Append("  ProjectTask: ").Append(ProjectTask).Append("\n");
            sb.Append("  Qty: ").Append(Qty).Append("\n");
            sb.Append("  ShipmentNbr: ").Append(ShipmentNbr).Append("\n");
            sb.Append("  Subitem: ").Append(Subitem).Append("\n");
            sb.Append("  TaxCategory: ").Append(TaxCategory).Append("\n");
            sb.Append("  TransactionDescr: ").Append(TransactionDescr).Append("\n");
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
            return this.Equals(input as SalesInvoiceDetail);
        }

        /// <summary>
        /// Returns true if SalesInvoiceDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of SalesInvoiceDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SalesInvoiceDetail input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && base.Equals(input) && 
                (
                    this.BranchID == input.BranchID ||
                    (this.BranchID != null &&
                    this.BranchID.Equals(input.BranchID))
                ) && base.Equals(input) && 
                (
                    this.CalculateDiscountsOnImport == input.CalculateDiscountsOnImport ||
                    (this.CalculateDiscountsOnImport != null &&
                    this.CalculateDiscountsOnImport.Equals(input.CalculateDiscountsOnImport))
                ) && base.Equals(input) && 
                (
                    this.CostCode == input.CostCode ||
                    (this.CostCode != null &&
                    this.CostCode.Equals(input.CostCode))
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.DiscountAmount == input.DiscountAmount ||
                    (this.DiscountAmount != null &&
                    this.DiscountAmount.Equals(input.DiscountAmount))
                ) && base.Equals(input) && 
                (
                    this.DiscountPercent == input.DiscountPercent ||
                    (this.DiscountPercent != null &&
                    this.DiscountPercent.Equals(input.DiscountPercent))
                ) && base.Equals(input) && 
                (
                    this.ExpirationDate == input.ExpirationDate ||
                    (this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(input.ExpirationDate))
                ) && base.Equals(input) && 
                (
                    this.InventoryDocType == input.InventoryDocType ||
                    (this.InventoryDocType != null &&
                    this.InventoryDocType.Equals(input.InventoryDocType))
                ) && base.Equals(input) && 
                (
                    this.InventoryID == input.InventoryID ||
                    (this.InventoryID != null &&
                    this.InventoryID.Equals(input.InventoryID))
                ) && base.Equals(input) && 
                (
                    this.InventoryRefNbr == input.InventoryRefNbr ||
                    (this.InventoryRefNbr != null &&
                    this.InventoryRefNbr.Equals(input.InventoryRefNbr))
                ) && base.Equals(input) && 
                (
                    this.LineNbr == input.LineNbr ||
                    (this.LineNbr != null &&
                    this.LineNbr.Equals(input.LineNbr))
                ) && base.Equals(input) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && base.Equals(input) && 
                (
                    this.LotSerialNbr == input.LotSerialNbr ||
                    (this.LotSerialNbr != null &&
                    this.LotSerialNbr.Equals(input.LotSerialNbr))
                ) && base.Equals(input) && 
                (
                    this.ManualDiscount == input.ManualDiscount ||
                    (this.ManualDiscount != null &&
                    this.ManualDiscount.Equals(input.ManualDiscount))
                ) && base.Equals(input) && 
                (
                    this.OrderLineNbr == input.OrderLineNbr ||
                    (this.OrderLineNbr != null &&
                    this.OrderLineNbr.Equals(input.OrderLineNbr))
                ) && base.Equals(input) && 
                (
                    this.OrderNbr == input.OrderNbr ||
                    (this.OrderNbr != null &&
                    this.OrderNbr.Equals(input.OrderNbr))
                ) && base.Equals(input) && 
                (
                    this.OrderType == input.OrderType ||
                    (this.OrderType != null &&
                    this.OrderType.Equals(input.OrderType))
                ) && base.Equals(input) && 
                (
                    this.OrigInvLineNbr == input.OrigInvLineNbr ||
                    (this.OrigInvLineNbr != null &&
                    this.OrigInvLineNbr.Equals(input.OrigInvLineNbr))
                ) && base.Equals(input) && 
                (
                    this.OrigInvNbr == input.OrigInvNbr ||
                    (this.OrigInvNbr != null &&
                    this.OrigInvNbr.Equals(input.OrigInvNbr))
                ) && base.Equals(input) && 
                (
                    this.OrigInvType == input.OrigInvType ||
                    (this.OrigInvType != null &&
                    this.OrigInvType.Equals(input.OrigInvType))
                ) && base.Equals(input) && 
                (
                    this.ProjectTask == input.ProjectTask ||
                    (this.ProjectTask != null &&
                    this.ProjectTask.Equals(input.ProjectTask))
                ) && base.Equals(input) && 
                (
                    this.Qty == input.Qty ||
                    (this.Qty != null &&
                    this.Qty.Equals(input.Qty))
                ) && base.Equals(input) && 
                (
                    this.ShipmentNbr == input.ShipmentNbr ||
                    (this.ShipmentNbr != null &&
                    this.ShipmentNbr.Equals(input.ShipmentNbr))
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
                    this.TransactionDescr == input.TransactionDescr ||
                    (this.TransactionDescr != null &&
                    this.TransactionDescr.Equals(input.TransactionDescr))
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.BranchID != null)
                    hashCode = hashCode * 59 + this.BranchID.GetHashCode();
                if (this.CalculateDiscountsOnImport != null)
                    hashCode = hashCode * 59 + this.CalculateDiscountsOnImport.GetHashCode();
                if (this.CostCode != null)
                    hashCode = hashCode * 59 + this.CostCode.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DiscountAmount != null)
                    hashCode = hashCode * 59 + this.DiscountAmount.GetHashCode();
                if (this.DiscountPercent != null)
                    hashCode = hashCode * 59 + this.DiscountPercent.GetHashCode();
                if (this.ExpirationDate != null)
                    hashCode = hashCode * 59 + this.ExpirationDate.GetHashCode();
                if (this.InventoryDocType != null)
                    hashCode = hashCode * 59 + this.InventoryDocType.GetHashCode();
                if (this.InventoryID != null)
                    hashCode = hashCode * 59 + this.InventoryID.GetHashCode();
                if (this.InventoryRefNbr != null)
                    hashCode = hashCode * 59 + this.InventoryRefNbr.GetHashCode();
                if (this.LineNbr != null)
                    hashCode = hashCode * 59 + this.LineNbr.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.LotSerialNbr != null)
                    hashCode = hashCode * 59 + this.LotSerialNbr.GetHashCode();
                if (this.ManualDiscount != null)
                    hashCode = hashCode * 59 + this.ManualDiscount.GetHashCode();
                if (this.OrderLineNbr != null)
                    hashCode = hashCode * 59 + this.OrderLineNbr.GetHashCode();
                if (this.OrderNbr != null)
                    hashCode = hashCode * 59 + this.OrderNbr.GetHashCode();
                if (this.OrderType != null)
                    hashCode = hashCode * 59 + this.OrderType.GetHashCode();
                if (this.OrigInvLineNbr != null)
                    hashCode = hashCode * 59 + this.OrigInvLineNbr.GetHashCode();
                if (this.OrigInvNbr != null)
                    hashCode = hashCode * 59 + this.OrigInvNbr.GetHashCode();
                if (this.OrigInvType != null)
                    hashCode = hashCode * 59 + this.OrigInvType.GetHashCode();
                if (this.ProjectTask != null)
                    hashCode = hashCode * 59 + this.ProjectTask.GetHashCode();
                if (this.Qty != null)
                    hashCode = hashCode * 59 + this.Qty.GetHashCode();
                if (this.ShipmentNbr != null)
                    hashCode = hashCode * 59 + this.ShipmentNbr.GetHashCode();
                if (this.Subitem != null)
                    hashCode = hashCode * 59 + this.Subitem.GetHashCode();
                if (this.TaxCategory != null)
                    hashCode = hashCode * 59 + this.TaxCategory.GetHashCode();
                if (this.TransactionDescr != null)
                    hashCode = hashCode * 59 + this.TransactionDescr.GetHashCode();
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
