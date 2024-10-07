using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class DapperSqlExecutor
    {
        public List<TResult> Query <TResult, TParameter>(string query, TParameter parameter, string connectionString)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<TResult> result = connection.Query<TResult>(query, parameter).ToList();
                return result;
            }
        }

        public TResult QuerySingle<TResult, TParameter>(string query, TParameter parameter, string connectionString)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                TResult result = connection.QuerySingle<TResult>(query, parameter);
                return result;
            }
        }

        public void Execute<TParameter>(string query, TParameter parameter, string connectionString)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, parameter);
            }
        }
        public TResult ExecuteScalar<TResult, TParameter>(string query, TParameter parameter, string connectionString)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                TResult result = connection.ExecuteScalar<TResult>(query, parameter);
                return result;
            }
        }
    }
}
