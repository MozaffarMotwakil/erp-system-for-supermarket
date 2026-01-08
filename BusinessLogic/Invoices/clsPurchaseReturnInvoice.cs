using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLogic.Validation;
using BusinessLogic.Warehouses;
using DTOs.Invoices;

namespace BusinessLogic.Invoices
{
    public class clsPurchaseReturnInvoice : clsInvoice
    {
        public clsPurchaseInvoice OriginalInvoiceInfo { get; set; }

        public clsPurchaseReturnInvoice(int originalInvoiceID, DateTime invoiceDate, enPaymentStatus invoiceStatus,
            List<clsInvoiceLine> lines, int warehouseID, enPaymentMethod? paymentMethod, decimal? paymentAmount) :
            base(null, string.Empty, invoiceDate, enInvoiceType.PurchaseReturn, invoiceStatus, lines, warehouseID, 
                paymentMethod, paymentAmount, null, null)
        {
            OriginalInvoiceInfo = clsInvoiceService.CreateInstance().Find(originalInvoiceID) as clsPurchaseInvoice;
            InvoiceNo = OriginalInvoiceInfo != null ? "PR-" + DateTime.Today.Year + '-' + OriginalInvoiceInfo.InvoiceNo.Substring(8) + '-' + (OriginalInvoiceInfo.GetReturnInvoicesCount() + 1) : null;
        }

        internal clsPurchaseReturnInvoice(clsInvoiceDTO invoiceDTO) :
            base(invoiceDTO.InvoiceID, invoiceDTO.InvoiceNo, invoiceDTO.InvoiceDate, (enInvoiceType)invoiceDTO.InvoiceTypeID,
                (enPaymentStatus)invoiceDTO.InvoiceStatusID, clsInvoiceLine.ConvertInvoiceLinesDataTableToList(invoiceDTO.Lines, (enInvoiceType)invoiceDTO.InvoiceTypeID),
                invoiceDTO.WarehouseID, (enPaymentMethod?)invoiceDTO.PaymentMethodID, invoiceDTO.PaidAmount, invoiceDTO.CreatedByUserID,
                invoiceDTO.CreatedAt)
        {
            OriginalInvoiceInfo = clsInvoiceService.CreateInstance().Find(invoiceDTO.OriginalInvoiceID.Value) as clsPurchaseInvoice;
        }

        public override clsValidationResult Validated()
        {
            clsValidationResult validationResult = base.Validated();

            if (OriginalInvoiceInfo == null)
            {
                validationResult.AddError("الفاتورة الأصلية", "يجب أن تستند فاتورة المرتجعات على فاتورة أصلية");
            }

            if (Lines != null && OriginalInvoiceInfo != null)
            {
                foreach (clsInvoiceLine line in Lines)
                {
                    clsInvoiceLine oppositeLine = OriginalInvoiceInfo.Lines.First(opLine => opLine.ProductID == line.ProductID && opLine.UnitID == line.UnitID);

                    if (line.Quantity > oppositeLine.GetRemainingQuantity())
                    {
                        validationResult.AddError(line.ProductInfo.ProductName + "-" + line.UnitInfo.UnitName,
                            "لا يمكن إرجاع كمية أكبر من الكمية المشتراة المتبقية من هذا المنتج");
                    }

                    if (line.Quantity > clsInventoryService.GetInventoryQuantity(this.WarehouseInfo.WarehouseID ?? -1, line.ProductID.GetValueOrDefault(), line.UnitID.GetValueOrDefault()))
                    {
                        validationResult.AddError(line.ProductInfo.ProductName + "-" + line.UnitInfo.UnitName,
                            "كمية البضاعة التي يراد إرجاعها أكبر من كمية المخزون الحالي");
                    }
                }
            }

            return validationResult;
        }

        protected override clsInvoiceDTO MappingToDTO()
        {
            return new clsInvoiceDTO
            {
                InvoiceID = this.InvoiceID,
                InvoiceNo = this.InvoiceNo,
                InvoiceDate = this.InvoiceDate,
                InvoiceTypeID = (byte)this.InvoiceType,
                InvoiceStatusID = (byte)this.PaymentStatus,
                PartyID = this.OriginalInvoiceInfo?.Supplier?.PartyInfo.PartyID,
                Lines = clsInvoiceLine.ConvertInvoiceLinesListToDataTable(base.Lines),
                TotalSubTotal = this.TotalSubTotal,
                TotalDiscountAmount = this.TotalDiscountAmount,
                TotalTaxAmount = this.TotalTaxAmount,
                GrandTotal = this.GrandTotal,
                PaymentMethodID = (byte?)this.PaymentMethod,
                PaidAmount = this.PaidAmount,
                WarehouseID = this?.WarehouseInfo?.WarehouseID ?? -1,
                OriginalInvoiceID = OriginalInvoiceInfo?.InvoiceID,
                CreatedByUserID = clsAppSettings.CurrentUser.UserID,
            };
        }

        public override string GetPartyName()
        {
            return OriginalInvoiceInfo?.GetPartyName() ?? "N/A";
        }

    }
}