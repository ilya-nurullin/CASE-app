using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            try
            {
                command.ExecuteNonQuery();
                return 0;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Ошибка при выполнении SQL: " + e.Message + $"\n\n Выполняемый SQL: {query}");
                return -1;
            }
        }

        public int ExecuteNonQuery(string query)
        {
            return ExecuteNonQuery(dbConnection, query);
        }
    }
}
