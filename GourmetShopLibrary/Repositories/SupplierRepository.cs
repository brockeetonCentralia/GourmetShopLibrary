﻿using GourmetShopLibrary.Interfaces;
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
    public class SupplierRepository : ISupplierRepository
    {
        private readonly string _connectionString;

        public SupplierRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Supplier> GetAllSuppliers()
        {
            var Suppliers = new List<Supplier>();
            using (var connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("GetAllSuppliers", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Suppliers.Add(new Supplier
                    {
                        SupplierID = reader.GetInt32(0),
                        CompanyName = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        ContactName = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        ContactTitle = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        City = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                        Country = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                        Phone = reader.IsDBNull(6) ? string.Empty : reader.GetString(6),
                        Fax = reader.IsDBNull(7) ? string.Empty : reader.GetString(7)
                    });
                }
            }
            return Suppliers;
        }

        public Supplier GetSupplierById(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("SELECT * FROM Supplier WHERE SupplierID = @SupplierID", connection))
                {
                    command.Parameters.AddWithValue("@SupplierID", id);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Supplier
                            {
                                SupplierID = reader.GetInt32(0),
                                CompanyName = reader.GetString(1),
                                ContactName = reader.GetString(2),
                                ContactTitle = reader.GetString(3),
                                City = reader.GetString(4),
                                Country = reader.GetString(5),
                                Phone = reader.GetString(6),
                                Fax = reader.GetString(7)
                            };
                        }
                    }
                }
            }
            return null;
        }

        public void AddSupplier(Supplier Supplier)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("InsertNewSupplier", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ContactName", Supplier.ContactName);
                    command.Parameters.AddWithValue("@CompanyName", Supplier.CompanyName);
                    command.Parameters.AddWithValue("@ContactTitle", Supplier.ContactTitle);
                    command.Parameters.AddWithValue("@City", Supplier.City);
                    command.Parameters.AddWithValue("@Country", Supplier.Country);
                    command.Parameters.AddWithValue("@Phone", Supplier.Phone);
                    command.Parameters.AddWithValue("@Fax", Supplier.Fax);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateSupplier(Supplier Supplier)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("UpdateSupplier", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ContactName", Supplier.ContactName);
                    command.Parameters.AddWithValue("@CompanyName", Supplier.CompanyName);
                    command.Parameters.AddWithValue("@ContactTitle", Supplier.ContactTitle);
                    command.Parameters.AddWithValue("@City", Supplier.City);
                    command.Parameters.AddWithValue("@Country", Supplier.Country);
                    command.Parameters.AddWithValue("@Phone", Supplier.Phone);
                    command.Parameters.AddWithValue("@Fax", Supplier.Fax);
                    command.Parameters.AddWithValue("@SupplierID", Supplier.SupplierID);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void DeleteSupplier(int id)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (var command = new SqlCommand("CheckProduct", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@SupplierID", id);
                        int productCount = (int)command.ExecuteScalar();

                        if (productCount > 0)
                        {
                            throw new InvalidOperationException("Supplier is being used by a product");
                        }
                    }

                    using (var command = new SqlCommand("DeleteSupplier", connection))
                    {
                        ///error is because trying to delete a supplier that a product is using. 
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@SupplierID", id);
                        command.ExecuteNonQuery();
                    }
                }

            }
            catch (InvalidOperationException ex)
            {
                throw new Exception("Supplier is being used by a product.");
            }
        }
    }
}

