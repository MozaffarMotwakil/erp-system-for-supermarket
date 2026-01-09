
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using BusinessLogic.Interfaces;
using BusinessLogic.Suppliers;
using BusinessLogic.Users;
using BusinessLogic.Validation;
using DataAccess.Products;
using DTOs.Products;

namespace BusinessLogic.Products
{
    public class clsProduct : IEntityActivity
    {
        public int? ProductID { get; private set; }
        public string ProductName { get; set; }
        public string Barcode { get; set; }
        public clsCategory CategoryInfo { get; private set; }
        public clsUnit MainUnitInfo { get; private set; }
        public List<clsProductUnitConversion> UnitConversions { get; } = new List<clsProductUnitConversion>();
        public List<clsDiscountItem> DiscountItems => clsDiscountItem.ConvertDiscountItemsTableToList(clsDiscountData.GetDiscountItemsForProduct(ProductID.GetValueOrDefault()));
        public List<clsTaxItem> TaxItems => clsTaxItem.ConvertTaxItemsTableToList(clsTaxData.GetTaxItemsForProduct(ProductID.GetValueOrDefault()));
        public clsSupplier MainSupplierInfo { get; private set; }
        public decimal SellingPrice { get; set; }
        public string Description { get; set; }
        internal string CurrentImagePath { get; set; }
        public string ImagePath { get; set; }
        public bool IsActive { get; }
        public clsUser CreatedByUserInfo { get; }
        public DateTime? CreatedAt { get; }
        public clsUser UpdatedByUserInfo { get; }
        public DateTime? UpdatedAt { get; }
        public enMode Mode { get; private set; }

        public List<clsUnit> AllUnits 
        {
            get
            {
                int[] productUnitIDs = clsProductService.GetAllProductUnits(ProductID.GetValueOrDefault())
                    .AsEnumerable()
                    .Select(unit => unit.Field<int>("UnitID"))
                    .ToArray();

                List<clsUnit> units = new List<clsUnit>();

                foreach (int unitID in productUnitIDs)
                {
                    units.Add(clsUnit.Find(unitID));
                }

                return units;
            }
        }

        public clsProduct(string productName, string barcode, int categoryID, int mainUnitID, List<clsProductUnitConversion> unitConversions,
            int? mainSupplierID, decimal sellingPrice, string description, string imagePath)
        {
            ProductID = null;
            ProductName = productName;
            Barcode = barcode;
            CategoryInfo = clsCategoryService.CreateInstance().Find(categoryID);
            MainUnitInfo = clsUnit.Find(mainUnitID);
            UnitConversions = unitConversions;
            MainSupplierInfo = clsSupplierService.CreateInstance().Find(mainSupplierID ?? -1);
            SellingPrice = sellingPrice;
            Description = description;
            ImagePath = imagePath;
            Mode = enMode.Add; 
        }

        internal clsProduct (clsProductDTO productDTO)
        {
            ProductID = productDTO.ProductID;
            ProductName = productDTO.ProductName;
            Barcode = productDTO.Barcode;
            CategoryInfo = clsCategoryService.CreateInstance().Find(productDTO.CategoryID);
            MainUnitInfo = clsUnit.Find(productDTO.MainUnitID);
            UnitConversions = clsProductUnitConversion.ConvertAlternativeUnitsTableToList(productDTO.UnitConversions);
            MainSupplierInfo = clsSupplierService.CreateInstance().Find(productDTO.MainSupplierID ?? -1);
            SellingPrice = productDTO.SellingPrice;
            Description = productDTO.Description;
            CurrentImagePath = productDTO.ImagePath;
            ImagePath = productDTO.ImagePath;
            IsActive = productDTO.IsActive;
            CreatedByUserInfo = clsUser.Find(productDTO.CreatedByUserID ?? -1);
            CreatedAt = productDTO.CreatedAt;
            UpdatedByUserInfo = productDTO.UpdatedByUserID is null ?
                null :
                clsUser.Find(productDTO.UpdatedByUserID ?? -1);
            UpdatedAt = productDTO.UpdatedAt;
            Mode = enMode.Update;
        }

        public bool GetActivityStatus()
        {
            return IsActive;
        }

        public bool MarkAsActive()
        {
            return clsProductService.CreateInstance().MarkAsActive(this);
        }

        public bool MarkAsInActive()
        {
            return clsProductService.CreateInstance().MarkAsInActive(this);
        }

        public DataTable GetProductUnitsTable()
        {
            return clsProductData.GetProductUnitsTable(this.ProductID ?? -1);
        }

        public DataTable GetSuppliersTable()
        {
            return clsProductData.GetSuppliersTable(this.ProductID ?? -1);
        }

        public DataTable GetInventoriesTable()
        {
            return clsProductData.GetInventoriesTable(this.ProductID ?? -1);
        }

        public DataTable GetStockTransactionsTable()
        {
            return clsProductData.GetStockTransactionsTable(this.ProductID ?? -1);
        }

        public void ChangeCategory(int newCategoryID)
        {
            CategoryInfo = clsCategoryService.CreateInstance().Find(newCategoryID);
        }

        public void ChangeMainUnit(int newUnitID)
        {
            MainUnitInfo = clsUnit.Find(newUnitID);
        }

        public void ChangeMainSupplier(string newSupplierName)
        {
            if (MainSupplierInfo?.PartyInfo.PartyName == newSupplierName)
            {
                return;
            }

            clsSupplier newSupplier = clsSupplierService.CreateInstance().Find(newSupplierName);

            if (newSupplier != null)
            {
                MainSupplierInfo = newSupplier;
            }
            else
            {
                this.DeleteMainSupplier();
            }
        }

        public void DeleteMainSupplier()
        {
            MainSupplierInfo = null;
        }

        public clsProductDTO MappingToDTO()
        {
            return new clsProductDTO
            {
                ProductID = this.ProductID,
                ProductName = this.ProductName,
                Barcode = this.Barcode,
                CategoryID = this.CategoryInfo.CategoryID.GetValueOrDefault(),
                MainUnitID = this.MainUnitInfo.UnitID,
                UnitConversions = clsProductUnitConversion.ConvertAlternativeUnitsListToTable(this.UnitConversions),
                MainSupplierID = this.MainSupplierInfo?.SupplierID,
                SellingPrice = this.SellingPrice,
                Description = this.Description,
                ImagePath = this.ImagePath,
                CreatedByUserID = this.CreatedByUserInfo?.UserID,
                UpdatedByUserID = this.UpdatedByUserInfo?.UserID
            };
        }

        public void TrimAllStringFields()
        {
            ProductName = ProductName.Trim();
            Barcode = Barcode.Trim();
            Description = Description.Trim();
        }

        public clsValidationResult Validated()
        {
            clsValidationResult validationResult = new clsValidationResult();
            TrimAllStringFields();

            if (string.IsNullOrWhiteSpace(ProductName))
            {
                validationResult.AddError("إسم المنتج", "لا يمكن أن يكون إسم المنتج فارغا");
            }

            if (string.IsNullOrWhiteSpace(Barcode))
            {
                validationResult.AddError("الباركود", "لا يمكن أن يكون الباركود فارغا");
            }

            if (CategoryInfo is null)
            {
                validationResult.AddError("التصنيف/الفئة", "يجب تعيين تصنيف");
            }

            if (MainUnitInfo is null)
            {
                validationResult.AddError("وحدة القياس الأساسية", "يجب تعيين وحدة القياس الأساسية");
            }

            if (UnitConversions != null && UnitConversions.Count > 0)
            {
                HashSet<int> uniqueAlternativeUnits = new HashSet<int>();
                HashSet<string> uniqueBarcodes = new HashSet<string>();

                foreach (var conversion in UnitConversions)
                {
                    if (conversion.AlternativeUnitID == MainUnitInfo.UnitID)
                    {
                        validationResult.AddError("وحدة القياس البديلة", "لا يمكن أن تكون وحدة القياس الأساسية وحدة قياس بديلة");
                    }

                    if (!uniqueAlternativeUnits.Add(conversion.AlternativeUnitID))
                    {
                        validationResult.AddError("وحدة القياس البديلة", "لا يمكن أن تتكرر وحدة القياس البديلة");
                    }

                    if (!string.IsNullOrWhiteSpace(conversion.Barcode) && !uniqueBarcodes.Add(conversion.Barcode))
                    {
                        validationResult.AddError("وحدة القياس البديلة",
                            $"لا يمكن أن يكون لوحدتين مختلفتين نفس الباركود ({conversion.UnitName}).");
                    }

                    if (!string.IsNullOrWhiteSpace(conversion.Barcode) && conversion.Barcode == this.Barcode)
                    {
                        validationResult.AddError("وحدة القياس البديلة",
                            $"لا يمكن أن يكون للوحدة البديلة \"{conversion.UnitName}\" نفس الباركود الخاص بالوحدة الأساسية");
                    }
                }
            }

            if (!float.TryParse(SellingPrice.ToString(), out float sellingPrice) || sellingPrice < 1)
            {
                validationResult.AddError("سعر البيع", "يجب أن يكون سعر البيع رقم أكبر من صفر");
            }

            return validationResult;
        }

    }
}
