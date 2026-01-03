using System;
using System.Data.SqlClient;
using System.Data;
using DTOs.Products;

namespace DataAccess.Products
{
    public static class clsProductCategoryData
    {
        public static clsCategoryDTO FindCategoryByID(int categoryID)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Categories_FindByID", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CategoryID", categoryID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            clsCategoryDTO categoryDTO = null;

                            if (reader.Read())
                            {
                                categoryDTO = new clsCategoryDTO
                                {
                                    CategoryID = categoryID,
                                    CategoryName = Convert.ToString(reader["CategoryName"]),
                                    Description = reader["Description"] != DBNull.Value ?
                                    Convert.ToString(reader["Description"]) :
                                    null,
                                    IsActive = Convert.ToBoolean(reader["IsActive"])
                                };
                            }

                            return categoryDTO;
                        }
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
        }

        public static bool AddCategory(clsCategoryDTO categoryDTO)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Categories_InsertCategory", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@CategoryName", categoryDTO.CategoryName);
                    command.Parameters.AddWithValue("@Description", clsDataSettings.GetDBNullIfNullOrEmpty(categoryDTO.Description));
                    command.Parameters.AddWithValue("@CreatedByUserID", categoryDTO.CreatedByUserID);

                    SqlParameter returnValueParam = new SqlParameter
                    {
                        Direction = ParameterDirection.ReturnValue
                    };

                    command.Parameters.Add(returnValueParam);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                        return (int)returnValueParam.Value == 1;
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
        }

        public static bool UpdateCategory(clsCategoryDTO categoryDTO)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Categories_UpdateCategory", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@CategoryID", categoryDTO.CategoryID);
                    command.Parameters.AddWithValue("@CategoryName", categoryDTO.CategoryName);
                    command.Parameters.AddWithValue("@Description", clsDataSettings.GetDBNullIfNullOrEmpty(categoryDTO.Description));
                    command.Parameters.AddWithValue("@UpdatedByUserID", categoryDTO.UpdatedByUserID);

                    SqlParameter returnValueParam = new SqlParameter
                    {
                        Direction = ParameterDirection.ReturnValue
                    };

                    command.Parameters.Add(returnValueParam);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                        return (int)returnValueParam.Value == 1;
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
        }

        public static bool DeleteCategory(int categoryID)
        {
            return clsDataSettings.ExecuteSimpleSP(
                "usp_Categories_DeleteCategory",
                "@CategoryID",
                categoryID
                );
        }

        public static DataTable GetAllCategorys()
        {
            return clsDataSettings.GetDataTable(
                "usp_Categories_GetAllCategories"
                );
        }

        public static DataTable GetCategoriesList()
        {
            return clsDataSettings.GetDataTable(
                "usp_Categories_GetCategoriesList"
                );
        }

        public static bool IsCategoryExists(int categoryID)
        {
            return clsDataSettings.ExecuteSimpleSP(
                "usp_Categories_IsExistsByID",
                "@CategoryID",
                categoryID
                );
        }

        public static bool IsCategoryExistsByName(string categoryName)
        {
            return clsDataSettings.ExecuteSimpleSP(
                "usp_Categories_IsExistsByName",
                "@CategoryName",
                categoryName
                );
        }

        public static bool SetActive(int categoryID, int updatedByUserID)
        {
            return clsDataSettings.ExecuteSimpleSP(
                "usp_Categories_SetActive",
                "@CategoryID",
                "@UpdatedByUserID",
                categoryID,
                updatedByUserID
                );
        }

        public static bool SetInActive(int categoryID, int updatedByUserID)
        {
            return clsDataSettings.ExecuteSimpleSP(
                "usp_Categories_SetInActive",
                "@CategoryID",
                "@UpdatedByUserID",
                categoryID,
                updatedByUserID
                );
        }

    }
}
