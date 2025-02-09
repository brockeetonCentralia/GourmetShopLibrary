using GourmetShopLibrary.Interfaces;
using GourmetShopLibrary.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GourmetShopLibrary.Repositories
{
    // Did not include update or delete methods for OrderItem Repository
    // because order data should not be changed after it is placed

    public class OrderItemRepository : IOrderItemRepository
    {
        private readonly string _connectionString;

        public OrderItemRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void AddOrderItem(OrderItem orderItem)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("InsertNewProduct", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@OrderID", orderItem.OrderID);
                    command.Parameters.AddWithValue("@ProductId", orderItem.ProductID);
                    command.Parameters.AddWithValue("@UnitPrice", orderItem.UnitPrice);
                    command.Parameters.AddWithValue("@Quantity", orderItem.Quantity);
                    command.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<OrderItem> GetAllOrderItems()
        {
            var orderItems = new List<OrderItem>();
            using (var connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("GetAllOrderItems", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    orderItems.Add(new OrderItem
                    {
                        OrderID = reader.GetInt32(0),
                        ProductID = reader.GetInt32(1),
                        UnitPrice = reader.GetDecimal(2),
                        Quantity = reader.GetInt32(3)
                    });
                }
            }
            return orderItems;
        }

        public OrderItem GetOrderItemById(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("GetOderItemByID", connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new OrderItem
                            {
                                OrderID = reader.GetInt32(0),
                                ProductID = reader.GetInt32(1),
                                UnitPrice = reader.GetDecimal(2),
                                Quantity = reader.GetInt32(3)
                            };
                          

                        }
                    }
                }
            }
            return null;
        }
    }

    
}

