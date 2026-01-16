using System.Data;
using System.Data.SqlClient;

namespace DataBaseChiLib
{
    public class DBConnect
    {
        public SqlConnection SqlConnection;

        public DBConnect(string serverName, string catalogName)
        {
            SqlConnection = new SqlConnection($@"Data Source={serverName};Initial Catalog={catalogName};Integrated Security=True");
        }

        public void openConnection()
        {
            if (SqlConnection.State == ConnectionState.Closed)
            {
                SqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (SqlConnection.State == ConnectionState.Open)
            {
                SqlConnection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return SqlConnection;
        }
    }
}
