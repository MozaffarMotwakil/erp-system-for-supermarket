using System;
using System.Data.SqlClient;
using System.Data;
using DTOs.Products;

namespace DataAccess.Products
{
    public static class clsProductData
    {
        public static clsProductDTO FindProductByID(int productID)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Products_GetProductByID", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ProductID", productID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            clsProductDTO productDTO = null;

                            if (reader.Read())
                            {
                                productDTO = new clsProductDTO
                                {
                                    ProductID = productID,
                                    ProductName = Convert.ToString(reader["ProductName"]),
                                    Barcode = Convert.ToString(reader["Barcode"]),
                                    CategoryID = Convert.ToInt32(reader["CategoryID"]),
                                    MainUnitID = Convert.ToInt32(reader["MainUnitID"]),
                                    MainSupplierID = reader["MainSupplierID"] == DBNull.Value ? null : (int?)(reader["MainSupplierID"]),
                                    SellingPrice = Convert.ToDecimal(reader["SellingPrice"]),
                                    Description = (reader["Description"] != DBNull.Value) ? reader["Description"].ToString() : string.Empty,
                                    ImagePath = (reader["ImagePath"] != DBNull.Value) ? reader["ImagePath"].ToString() : string.Empty,
                                    IsActive = Convert.ToBoolean(reader["IsActive"]),
                                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]),
                                    CreatedAt = Convert.ToDateTime(reader["CreatedAt"])
                                };

                                productDTO.UpdatedByUserID = reader["UpdatedByUserID"] == DBNull.Value ?
                                    (int?)null :
                                    (int)reader["UpdatedByUserID"];

                                productDTO.UpdatedAt = reader["UpdatedAt"] == DBNull.Value ?
                                    (DateTime?)null :
                                    (DateTime)reader["UpdatedAt"];

                                if (reader.NextResult())
                                {
                                    if (reader.HasRows)
                                    {
                                        DataTable alternativeUnits = new DataTable();
                                        alternativeUnits.Load(reader);
                                        productDTO.UnitConversions = alternativeUnits;
                                    }
                                }
                            }

                            return productDTO;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new ApplicationException($"Error find product by ID.", ex);
                    }
                }
            }
        }

        public static bool AddProduct(clsProductDTO productDTO)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Products_InsertProduct", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ProductName", productDTO.ProductName);
                    command.Parameters.AddWithValue("@Barcode", productDTO.Barcode);
                    command.Parameters.AddWithValue("@CategoryID", productDTO.CategoryID);
                    command.Parameters.AddWithValue("@MainUnitID", productDTO.MainUnitID);
                    command.Parameters.AddWithValue("@MainSupplierID", clsDataSettings.GetDBNullIfNull(productDTO.MainSupplierID));
                    command.Parameters.AddWithValue("@SellingPrice", productDTO.SellingPrice);
                    command.Parameters.AddWithValue("@Description", clsDataSettings.GetDBNullIfNullOrEmpty(productDTO.Description));
                    command.Parameters.AddWithValue("@ImagePath", clsDataSettings.GetDBNullIfNullOrEmpty(productDTO.ImagePath));
                    command.Parameters.AddWithValue("@CreatedByUserID", productDTO.CreatedByUserID);
                    
                    SqlParameter parameter = command.Parameters.AddWithValue("@UnitConversions", productDTO.UnitConversions);
                    parameter.SqlDbType = SqlDbType.Structured;
                    parameter.TypeName = "tvp_ProductUnitConversionsType";

                    SqlParameter paramProductID = command.Parameters.Add("@ProductID", SqlDbType.Int);
                    paramProductID.Direction = ParameterDirection.Output;

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            productDTO.ProductID = (int)paramProductID.Value;
                        }

                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error adding product to database.", ex);
                    }
                }
            }
        }

        public static bool UpdateProduct(clsProductDTO productDTO)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Products_UpdateProduct", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ProductID", productDTO.ProductID);
                    command.Parameters.AddWithValue("@ProductName", productDTO.ProductName);
                    command.Parameters.AddWithValue("@Barcode", productDTO.Barcode);
                    command.Parameters.AddWithValue("@CategoryID", productDTO.CategoryID);
                    command.Parameters.AddWithValue("@MainUnitID", productDTO.MainUnitID);
                    command.Parameters.AddWithValue("@MainSupplierID", clsDataSettings.GetDBNullIfNull(productDTO.MainSupplierID));
                    command.Parameters.AddWithValue("@SellingPrice", productDTO.SellingPrice);
                    command.Parameters.AddWithValue("@Description", clsDataSettings.GetDBNullIfNullOrEmpty(productDTO.Description));
                    command.Parameters.AddWithValue("@ImagePath", clsDataSettings.GetDBNullIfNullOrEmpty(productDTO.ImagePath));
                    command.Parameters.AddWithValue("@UpdatedByUserID", productDTO.CreatedByUserID);

                    SqlParameter parameter = command.Parameters.AddWithValue("@UnitConversions", productDTO.UnitConversions);
                    parameter.SqlDbType = SqlDbType.Structured;
                    parameter.TypeName = "tvp_ProductUnitConversionsType";

                    try
                    {
                        connection.Open();
                        return command.ExecuteNonQuery() > 0;
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
        }

        public static DataTable GetAllProducts()
        {
            return clsDataSettings.GetDataTable(
                "usp_Products_GetAllProducts"
                );
        }

        public static DataTable GetProductUnitsTable(int productID)
        {
            return clsDataSettings.GetDataTable(
                "usp_Products_GetProductUnitsTable",
                "@ProductID",
                productID
                );
        }

        public static DataTable GetSuppliersTable(int productID)
        {
            return clsDataSettings.GetDataTable(
                "usp_Products_GetSuppliersTable",
                "@ProductID",
                productID
                );
        }

        public static DataTable GetInventoriesTable(int productID)
        {
            return clsDataSettings.GetDataTable(
                "usp_Products_GetInventoriesTable",
                "@ProductID",
                productID
                );
        }

        public static DataTable GetStockTransactionsTable(int productID)
        {
            return clsDataSettings.GetDataTable(
                "usp_Products_GetStockTransactionsTable",
                "@ProductID",
                productID
                );
        }

        public static DataTable GetProductsList()
        {
            return clsDataSettings.GetDataTable(
                "usp_Products_GetProductsList"
                );
        }
        
        public static DataTable GetProductHierarchyForTreeView()
        {
            return clsDataSettings.GetDataTable(
                "usp_Products_GetProductHierarchyForTreeView"
                );
        }

        public static bool DeleteProduct(int productID)
        {
            return clsDataSettings.ExecuteSimpleSP(
                "usp_Products_DeleteProduct", 
                "@ProductID", 
                productID
                );
        }

        public static bool IsProductExists(int productID)
        {
            return clsDataSettings.ExecuteSimpleSP(
                "usp_Products_IsExistsByID",
                "@ProductID",
                productID
                );
        }

        public static bool IsProductExistsByBarcode(string barcode)
        {
            return clsDataSettings.ExecuteSimpleSP(
                "usp_Products_IsExistsByBarcode", 
                "@Barcode",
                barcode
                );
        }
        
        public static bool IsBarcodeExists(int? currentProductID, string barcode)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Products_IsBarcodeExists", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ProductID", currentProductID);
                    command.Parameters.AddWithValue("@Barcode", barcode);

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

        public static bool IsProductExistsByName(string productName)
        {
            return clsDataSettings.ExecuteSimpleSP(
                "usp_Products_IsExistsByProductName",
                "@ProductName", 
                productName
                );
        }

        public static bool SetActive(int productID, int updatedByUserID)
        {
            return clsDataSettings.ExecuteSimpleSP(
                "usp_Products_SetActive",
                "@ProductID",
                "@UpdatedByUserID",
                productID,
                updatedByUserID
                );
        }

        public static bool SetInActive(int productID, int updatedByUserID)
        {
            return clsDataSettings.ExecuteSimpleSP(
                "usp_Products_SetInActive",
                "@ProductID",
                "@UpdatedByUserID",
                productID,
                updatedByUserID
                );
        }

    }
}
