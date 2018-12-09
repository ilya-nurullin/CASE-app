using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WowCaseApp
{
    class SqlExecutor
    {
        private readonly SqlConnection dbConnection;
        private static readonly ILog log = LogManager.GetLogger(typeof(SqlExecutor));

        public SqlExecutor(SqlConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public static int ExecuteNonQuery(SqlConnection dbConnection, string query)
        {
            SqlCommand command = new SqlCommand(query, dbConnection);
            log.Debug("Execute SQL: "+query);
            return command.ExecuteNonQuery();
        }

        public int ExecuteNonQuery(string query)
        {
            return ExecuteNonQuery(dbConnection, query);
        }
    }
}
