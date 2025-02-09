using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GourmetShopLibrary.Interfaces;
using GourmetShopLibrary.Models;
using Microsoft.Data.SqlClient;

namespace GourmetShopLibrary.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly string _connectionString;

        public OrderRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public void AddOrder(Order order)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("InsertNewProduct", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@OrderDate", order.OrderDate);
                    command.Parameters.AddWithValue("@OrderNumber", order.OrderNumber);
                    command.Parameters.AddWithValue("@UserID", order.UserID);
                    command.Parameters.AddWithValue("@totalAmount", order.TotalAmount);
                    command.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<Order> GetAllOrders()
        {
            var orders = new List<Order>();
            using (var connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("GetAllOrders", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    orders.Add(new Order
                    {
                        OrderID = reader.GetInt32(0),
                        OrderDate = reader.GetDateTime(1),
                        OrderNumber = reader.GetString(2),
                        UserID = reader.GetInt32(3),
                        TotalAmount = reader.GetDecimal(4)
                    });
                }
            }
            return orders;
        }

        public Order GetOrderById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
