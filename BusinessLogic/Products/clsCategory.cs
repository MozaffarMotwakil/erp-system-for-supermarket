using System;
using BusinessLogic.Interfaces;
using BusinessLogic.Users;
using BusinessLogic.Validation;
using DTOs.Products;

namespace BusinessLogic.Products
{
    public class clsCategory : IEntityActivity
    {
        public int? CategoryID { get; private set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public clsUser CreatedByUserInfo { get; set; }
        public DateTime? CreatedAt { get; set; }
        public clsUser UpdatedByUserInfo { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public enMode Mode { get; internal set; }

        public clsCategory(string categoryName, string description)
        {
            CategoryName = categoryName;
            Description = description;
            IsActive = true;
            Mode = enMode.Add;
        }

        internal clsCategory(clsCategoryDTO categoryDTO)
        {
            CategoryID = categoryDTO.CategoryID;
            CategoryName = categoryDTO.CategoryName;
            Description = categoryDTO.Description;
            IsActive = categoryDTO.IsActive;
            CreatedByUserInfo = clsUser.Find(categoryDTO.CreatedByUserID.GetValueOrDefault());
            CreatedAt = categoryDTO.CreatedAt;
            UpdatedByUserInfo = clsUser.Find(categoryDTO.UpdatedByUserID.GetValueOrDefault());
            UpdatedAt = categoryDTO.UpdatedAt;
            Mode = enMode.Update;
        }

        public bool GetActivityStatus()
        {
            return IsActive;
        }

        public bool MarkAsActive()
        {
            return clsCategoryService.CreateInstance().MarkAsActive(this);
        }

        public bool MarkAsInActive()
        {
            return clsCategoryService.CreateInstance().MarkAsInActive(this);
        }

        public clsCategoryDTO MappingToDTO()
        {
            return new clsCategoryDTO
            {
                CategoryID = this.CategoryID.GetValueOrDefault(),
                CategoryName = this.CategoryName,
                Description = this.Description,
                CreatedByUserID = this.CreatedByUserInfo?.UserID,
                UpdatedByUserID = this.UpdatedByUserInfo?.UserID
            };
        }

        public void TrimAllStringFields()
        {
            CategoryName = CategoryName.Trim();
            Description = Description.Trim();
        }

        public clsValidationResult Validated()
        {
            clsValidationResult validationResult = new clsValidationResult();
            TrimAllStringFields();

            if (string.IsNullOrWhiteSpace(CategoryName))
            {
                validationResult.AddError("إسم الصنف/الفئة", "لا يمكن أن يكون إسم الصنف/الفئة فارغا");
            }

            return validationResult;
        }

        public clsValidationResult Save()
        {
            return clsCategoryService.CreateInstance().Save(this);
        }

    }
}
