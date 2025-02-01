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
        public bool ValidateUser(string username, string password)
        {

            using (var connection = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Username", username, DbType.String);
                parameters.Add("@Password", password, DbType.String);

                int result = connection.QuerySingle<int>("ValidateUserLogin", parameters, commandType: CommandType.StoredProcedure);

                return result == 1;
            }
        }
    }
}
