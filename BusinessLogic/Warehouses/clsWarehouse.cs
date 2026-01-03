using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using BusinessLogic.Employees;
using BusinessLogic.Interfaces;
using BusinessLogic.Users;
using BusinessLogic.Validation;
using DataAccess.Warehouses;
using DTOs.Warehouses;

namespace BusinessLogic.Warehouses
{
    public class clsWarehouse : IEntityActivity
    {
        public enum enWarehouseType
        {
            ShopWarehouse = 1,
            MainWarehouse,
            SubWarehouse
        }

        public struct stBasicInfo
        {
            public string WarehouseName { get; set; }
            public string Address { get; set; }
            public string TypeName { get; set; }
            public bool IsActive { get; set; }
            public string ResponsibleEmployeeName { get; set; }
            public string ResponseEmplyeePhoneNumber { get; set; }
            public DateTime CreatedAt { get; set; }
            public DateTime? UpdatedAt { get; set; }
        }

        public struct stInventorySummary
        {
            public int ProductsCount { get; set; }
            public int InventoriesCount { get; set; }
            public int TotalQuantity { get; set; }
            public int SafeElements { get; set; }
            public int LowElements { get; set; }
            public int FinishedElements { get; set; }
            public int ItemsThatNeedToBeReordered { get; set; }
            public float ReorderQuantityAverage { get; set; }
            public int TotalStockTransactions { get; set; }
            public int TotalInsideStockTransactions { get; set; }
            public int TotalOutsideStockTransactions { get; set; }
            public float DailyTransactionsAverage { get; set; }
            public DateTime? LastInsideTransactionDate { get; set; }
            public DateTime? LastOutsideTransactionDate { get; set; }
        }

        public struct stFinancialSummary
        {
            public float InventoriesCostValue { get; set; }
            public float InventoriesSellingValue { get; set; }
            public float ExpectedProfit { get; set; }
            public float ProfitRate { get; set; }
            public float PurchasesValue { get; set; }
            public float ReturnPurchasesValue { get; set; }
            public float SellingValue { get; set; }
            public float ReturnSellingValue { get; set; }
        }

        public struct stKPIsSummary
        {
            public float SafeElementsRate { get; set; }
            public float LowElementsRate { get; set; }
            public float FinishedElementsRate { get; set; }
            public float ItemsThatNeedToBeReorderedRate { get; set; }
            public float ItemsWithoutReorderQuantityRate { get; set; }
            public float InsideStockTransactionsRate { get; set; }
            public float OutsideStockTransactionsRate { get; set; }
        }

        public int? WarehouseID { get; }
        public string WarehouseName { get; set; }
        public string Address { get; set; }
        public enWarehouseType Type { get; set; }
        public clsEmployee ResponsibleEmployeeInfo { get; set; }
        public bool IsActive { get; set; }
        public clsUser CreatedByUserInfo { get; }
        public DateTime? CreatedAt { get; }
        public clsUser UpdatedByUserInfo { get; }
        public DateTime? UpdatedAt { get; }
        public enMode Mode { get; }

        public clsWarehouse(string warehouseName, string address,
            enWarehouseType type, int responsibleEmployeeID)
        {
            WarehouseID = null;
            WarehouseName = warehouseName;
            Address = address;
            Type = type;
            ResponsibleEmployeeInfo = clsEmployeeService.Find(responsibleEmployeeID);
            IsActive = true;
            Mode = enMode.Add;
        }

        internal clsWarehouse(clsWarehouseDTO warehouseDTO)
        {
            WarehouseID = warehouseDTO.WarehouseID;
            WarehouseName = warehouseDTO.WarehouseName;
            Address = warehouseDTO.Address;
            Type = (enWarehouseType)warehouseDTO.TypeID;
            ResponsibleEmployeeInfo = clsEmployeeService.Find(warehouseDTO.ResponsibleEmployeeID);
            IsActive = warehouseDTO.IsActive;
            CreatedByUserInfo = clsUser.Find(warehouseDTO.CreatedByUserID ?? -1);
            CreatedAt = warehouseDTO.CreatedAt;
            UpdatedByUserInfo = clsUser.Find(warehouseDTO.UpdatedByUserID ?? -1);
            UpdatedAt = warehouseDTO.UpdatedAt;
            Mode = enMode.Update;
        }

        public clsWarehouseDTO MappingToDTO()
        {
            return new clsWarehouseDTO
            {
               WarehouseID = WarehouseID,
               WarehouseName = WarehouseName,
               Address = Address,
               TypeID = (int)Type,
               ResponsibleEmployeeID = this.ResponsibleEmployeeInfo.EmployeeID,
               IsActive = IsActive,
               CreatedByUserID = CreatedByUserInfo?.UserID,
               CreatedAt = CreatedAt,
               UpdatedByUserID = UpdatedByUserInfo?.UserID,
               UpdatedAt = UpdatedAt
            };
        }

        public void UpdateResponsibleEmployee(int newResponsiableEmployeeID)
        {
            this.ResponsibleEmployeeInfo = clsEmployeeService.Find(newResponsiableEmployeeID);
        }

        public void TrimAllStringFields()
        {
            WarehouseName = WarehouseName.Trim();
            Address = Address.Trim();
        }

        public bool GetActivityStatus()
        {
            return IsActive;
        }

        public bool MarkAsActive()
        {
            return clsWarehouseService.CreateInstance().MarkAsActive(this);
        }

        public bool MarkAsInActive()
        {
            return clsWarehouseService.CreateInstance().MarkAsInActive(this);
        }

        public List<clsInventory> GetAvailableInventories()
        {
            int[] inventoryIDs = clsWarehouseData.GetAvailableInventoryIDsForWarehouse(this.WarehouseID ?? -1)
               .Rows
               .Cast<DataRow>()
               .Select(id => (int)id[0])
               .ToArray();

            List<clsInventory> availableInventories = new List<clsInventory>();

            foreach (int inventoryID in inventoryIDs)
            {
                clsInventory inventory = clsInventoryService.CreateInstance().Find(inventoryID);

                if (inventory.ProductInfo.IsActive)
                {
                    availableInventories.Add(inventory);
                }
            }

            return availableInventories;
        }

        public clsValidationResult Validated()
        {
            clsValidationResult validationResult = new clsValidationResult();
            TrimAllStringFields();

            if (string.IsNullOrWhiteSpace(WarehouseName))
            {
                validationResult.AddError("إسم المنتج", "لا يمكن أن يكون إسم المخزن فارغا");
            }

            if (string.IsNullOrWhiteSpace(Address))
            {
                validationResult.AddError("العنوان", "لا يمكن أن يكون العنوان فارغا");
            }

            if (ResponsibleEmployeeInfo == null)
            {
                validationResult.AddError("الموظف المسؤول", "لم يتم العثور على الموظف المسؤول");
            }

            return validationResult;
        }

        public stBasicInfo GetBasicInfo()
        {
            stBasicInfo basicInfo = new stBasicInfo();
            DataRow basicInfoData = clsWarehouseData.GetBasicInfo(this.WarehouseID ?? -1);

            if (basicInfoData == null || this.WarehouseID == null || this.WarehouseID < 1)
            {
                return basicInfo;
            }

            basicInfo.WarehouseName = Convert.ToString(basicInfoData["WarehouseName"]);
            basicInfo.Address = Convert.ToString(basicInfoData["Address"]);
            basicInfo.TypeName = Convert.ToString(basicInfoData["TypeName"]);
            basicInfo.IsActive = Convert.ToBoolean(basicInfoData["IsActive"]);
            basicInfo.ResponsibleEmployeeName = Convert.ToString(basicInfoData["ResponsibleEmployeeName"]);
            basicInfo.ResponseEmplyeePhoneNumber = Convert.ToString(basicInfoData["ResponseEmplyeePhoneNumber"]);
            basicInfo.CreatedAt = Convert.ToDateTime(basicInfoData["CreatedAt"]);
            basicInfo.UpdatedAt = basicInfoData["UpdatedAt"] == DBNull.Value ?
                (DateTime?)null :
                Convert.ToDateTime(basicInfoData["UpdatedAt"]);

            return basicInfo;
        }

        public stInventorySummary GetInventorySummary()
        {
            stInventorySummary inventorySummary = new stInventorySummary();
            DataRow inventorySummaryData = clsWarehouseData.GetInventorySummary(this.WarehouseID ?? -1);

            if (inventorySummaryData == null || this.WarehouseID == null || this.WarehouseID < 1)
            {
                return inventorySummary;
            }

            inventorySummary.ProductsCount = Convert.ToInt32(inventorySummaryData["ProductsCount"]);
            inventorySummary.InventoriesCount = Convert.ToInt32(inventorySummaryData["InventoriesCount"]);
            inventorySummary.TotalQuantity = Convert.ToInt32(inventorySummaryData["TotalQuantity"]);
            inventorySummary.SafeElements = Convert.ToInt32(inventorySummaryData["SafeElements"]);
            inventorySummary.LowElements = Convert.ToInt32(inventorySummaryData["LowElements"]);
            inventorySummary.FinishedElements = Convert.ToInt32(inventorySummaryData["FinishedElements"]);
            inventorySummary.ItemsThatNeedToBeReordered = Convert.ToInt32(inventorySummaryData["ItemsThatNeedToBeReordered"]);
            inventorySummary.ReorderQuantityAverage = Convert.ToSingle(inventorySummaryData["ReorderQuantityAverage"]);
            inventorySummary.TotalStockTransactions = Convert.ToInt32(inventorySummaryData["TotalStockTransactions"]);
            inventorySummary.TotalInsideStockTransactions = Convert.ToInt32(inventorySummaryData["TotalInsideStockTransactions"]);
            inventorySummary.TotalOutsideStockTransactions = Convert.ToInt32(inventorySummaryData["TotalOutsideStockTransactions"]);
            inventorySummary.DailyTransactionsAverage = Convert.ToSingle(inventorySummaryData["DailyTransactionsAverage"]);
            inventorySummary.LastInsideTransactionDate = inventorySummaryData["LastInsideTransactionDate"] == DBNull.Value ?
                (DateTime?)null:
                Convert.ToDateTime(inventorySummaryData["LastInsideTransactionDate"]);
            inventorySummary.LastOutsideTransactionDate =  inventorySummaryData["LastOutsideTransactionDate"] == DBNull.Value ?
                (DateTime?)null:
                Convert.ToDateTime(inventorySummaryData["LastOutsideTransactionDate"]);

            return inventorySummary;
        }

        public stFinancialSummary GetFinancialSummary()
        {
            stFinancialSummary financialSummary = new stFinancialSummary();
            DataRow financialSummaryData = clsWarehouseData.GetFinancialSummary(this.WarehouseID ?? -1);

            if (financialSummaryData == null || this.WarehouseID == null || this.WarehouseID < 1)
            {
                return financialSummary;
            }

            financialSummary.InventoriesCostValue = Convert.ToSingle(financialSummaryData["InventoriesCostValue"]);
            financialSummary.InventoriesSellingValue = Convert.ToSingle(financialSummaryData["InventoriesSellingValue"]);
            financialSummary.ExpectedProfit = Convert.ToSingle(financialSummaryData["ExpectedProfit"]);
            financialSummary.ProfitRate = Convert.ToSingle(financialSummaryData["ProfitRate"]);
            financialSummary.PurchasesValue = Convert.ToSingle(financialSummaryData["PurchasesValue"]);
            financialSummary.ReturnPurchasesValue = Convert.ToSingle(financialSummaryData["ReturnPurchasesValue"]);
            financialSummary.SellingValue = Convert.ToSingle(financialSummaryData["SellingValue"]);
            financialSummary.ReturnSellingValue = Convert.ToSingle(financialSummaryData["ReturnSellingValue"]);

            return financialSummary;
        }

        public stKPIsSummary GetKPIsSummary()
        {
            stKPIsSummary KPIsSummary = new stKPIsSummary();
            DataRow KPIsSummaryData = clsWarehouseData.GetKPIsSummary(this.WarehouseID ?? -1);

            if (KPIsSummaryData == null || this.WarehouseID == null || this.WarehouseID < 1)
            {
                return KPIsSummary;
            }

            KPIsSummary.SafeElementsRate = Convert.ToSingle(KPIsSummaryData["SafeElementsRate"]);
            KPIsSummary.LowElementsRate = Convert.ToSingle(KPIsSummaryData["LowElementsRate"]);
            KPIsSummary.FinishedElementsRate = Convert.ToSingle(KPIsSummaryData["FinishedElementsRate"]);
            KPIsSummary.ItemsThatNeedToBeReorderedRate = Convert.ToSingle(KPIsSummaryData["ItemsThatNeedToBeReorderedRate"]);
            KPIsSummary.ItemsWithoutReorderQuantityRate = Convert.ToSingle(KPIsSummaryData["ItemsWithoutReorderQuantityRate"]);
            KPIsSummary.InsideStockTransactionsRate = Convert.ToSingle(KPIsSummaryData["InsideStockTransactionsRate"]);
            KPIsSummary.OutsideStockTransactionsRate = Convert.ToSingle(KPIsSummaryData["OutsideStockTransactionsRate"]);

            return KPIsSummary;
        }

    }
}
