using System.Data.SqlClient;
namespace SQL
{
    internal class db
    {
        SqlConnection connection = new SqlConnection("Data Source=PkIvan\\SQLEXPRESS; Initial Catalog=testBD; Integrated Security=True");
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
