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
                                Name = reader.GetString(1),
                                Price = reader.GetDecimal(2),
                                Stock = reader.GetInt32(3)
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
                                Name = reader.GetString(1),
                                Price = reader.GetDecimal(2),
                                Stock = reader.GetInt32(3)
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
                using (var command = new SqlCommand("INSERT INTO Product (Name, Price, Stock) VALUES (@Name, @Price, @Stock)", connection))
                {
                    command.Parameters.AddWithValue("@Name", product.Name);
                    command.Parameters.AddWithValue("@Price", product.Price);
                    command.Parameters.AddWithValue("@Stock", product.Stock);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateProduct(Product product)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("UPDATE Product SET Name = @Name, Price = @Price, Stock = @Stock WHERE ProductID = @ProductID", connection))
                {
                    command.Parameters.AddWithValue("@Name", product.Name);
                    command.Parameters.AddWithValue("@Price", product.Price);
                    command.Parameters.AddWithValue("@Stock", product.Stock);
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
