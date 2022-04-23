using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Api.Presistence.Repository
{
    public class BaseRepository
    {
        protected T QueryFirstOrDefault<T>(string sql, object parameters = null)
        {
            using (var connection = CreateConnection())
            {
                return connection.QueryFirstOrDefault<T>(sql, parameters);
            }
        }

        protected List<T> Query<T>(string sql, object parameters = null)
        {
            using (var connection = CreateConnection())
            {
                return connection.Query<T>(sql, parameters).ToList();
            }
        }

        protected int Execute(string sql, object parameters = null)
        {
            using (var connection = CreateConnection())
            {
                return connection.Execute(sql, parameters);
            }
        }

        // Other Helpers...

        private IDbConnection CreateConnection()
        {
            var connection = new SqlConnection(ConnectionString.GetConnectionString(""));
            // Properly initialize your connection here.
            return connection;
        }
    }
}
