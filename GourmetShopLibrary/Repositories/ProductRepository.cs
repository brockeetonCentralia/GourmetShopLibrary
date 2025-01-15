using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using GourmetShopLibrary.Interfaces;
using GourmetShopLibrary.Models;

namespace GourmetShopLibrary.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly string _connectionString;

        public ProductRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            var products = new List<Product>();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("SELECT * FROM Product", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            products.Add(new Product
                            {
                                ProductID = reader.GetInt32(0),
                                ProductName = reader.GetString(1),
                                SupplierID = reader.GetInt32(2),
                                UnitPrice = reader.GetDecimal(3),
                                Package = reader.GetInt32(4),
                                IsDiscontinued = reader.GetBoolean(5)
                            });
                        }
                    }
                }
            }
            return products;
        }

        public Product GetProductById(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("SELECT * FROM Product WHERE ProductID = @ProductID", connection))
                {
                    command.Parameters.AddWithValue("@ProductID", id);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Product
                            {
                                ProductID = reader.GetInt32(0),
                                ProductName = reader.GetString(1),
                                SupplierID = reader.GetInt32(2),
                                UnitPrice = reader.GetDecimal(3),
                                Package = reader.GetInt32(4),
                                IsDiscontinued = reader.GetBoolean(5)
                            };
                        }
                    }
                }
            }
            return null;
        }

        public void AddProduct(Product product)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("INSERT INTO Product (ProductName, SupplierID, UnitPrice, Package, IsDiscontinued) VALUES (@ProductName, @SupplierID, @UnitPrice, @Package, @IsDiscontinued)", connection))
                {
                    command.Parameters.AddWithValue("@ProductName", product.ProductName);
                    command.Parameters.AddWithValue("@SupplierID", product.SupplierID);
                    command.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
                    command.Parameters.AddWithValue("@Package", product.Package);
                    command.Parameters.AddWithValue("@IsDiscontinued", product.IsDiscontinued);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateProduct(Product product)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("UPDATE Product SET ProductName = @ProductName, SupplierID = @SupplierID, UnitPrice = @UnitPrice, Package = @Package, IsDiscontinued = @IsDiscontinued WHERE ProductID = @ProductID", connection))
                {
                    command.Parameters.AddWithValue("@ProductName", product.ProductName);
                    command.Parameters.AddWithValue("@SupplierID", product.SupplierID);
                    command.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
                    command.Parameters.AddWithValue("@Package", product.Package);
                    command.Parameters.AddWithValue("@IsDiscontinued", product.IsDiscontinued);
                    command.Parameters.AddWithValue("@ProductID", product.ProductID);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteProduct(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("DELETE FROM Product WHERE ProductID = @ProductID", connection))
                {
                    command.Parameters.AddWithValue("@ProductID", id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
