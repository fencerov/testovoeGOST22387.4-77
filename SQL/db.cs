using System.Data.SqlClient;
using static SQL.sqlserver;

namespace SQL
{
    internal class db
    {
        private SqlConnection connection;
        private string connectionString;
        public db(string serverName)
        {
            connectionString = $"Data Source={serverName};Initial Catalog=testBD;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        public void openConnect()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnect()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }
    }
}
