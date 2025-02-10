using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GourmetShopLibrary
{
    public class ValidateUserLogin
    {
        private readonly string _connectionString;
        
        public ValidateUserLogin(string connectionString)
        {
            _connectionString = connectionString;
        }
        public int ValidateUser(string userLogin, string userPassword)
        {
            int roleID = 0;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("ValidateUserLogin", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserLogin", userLogin);
                    command.Parameters.AddWithValue("@UserPassword", userPassword);

                    // read the RoleId from the stored procedures results
                    
                    command.ExecuteNonQuery();
                    //roleID = (int) results.RoleId.Value; // set the value here

                    roleID = 2;
                }
            }
            return roleID;
        }
    }
}
