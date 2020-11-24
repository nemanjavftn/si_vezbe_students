using System.Data.SqlClient;

namespace DataAccessLayer
{
    public sealed class DBConnection
    {
        private static SqlConnection sqlConnection = null;
        private static SqlCommand sqlCommand = null;
        private static readonly object padlock = new object();

        private static string conStr = Constants.connectionString;
        // "AttachDbFileName=|DataDirectory|\\webshop.mdf;" +
        //"user id=Liviu;password = password;Server =(local)\\SqlExpress; " +
        //"Trusted_Connection = yes;database = webshop; connection timeout = 30";

        private DBConnection()
        {
        }

        private static SqlConnection SqlConnection
        {
            get
            {
                lock (padlock)
                {
                    if (sqlConnection == null)
                    {
                        sqlConnection = new SqlConnection(conStr);
                    }
                    return sqlConnection;
                }
            }
        }

        private static SqlCommand SqlCommand
        {
            get
            {
                lock (padlock)
                {
                    if (sqlCommand == null)
                    {
                        sqlCommand = new SqlCommand
                        {
                            Connection = sqlConnection
                        };
                    }
                    return sqlCommand;
                }
            }
        }

        private static void OpenConnection()
        {
            if (sqlConnection != null)
                sqlConnection.Open();
        }

        private static void CloseConnection()
        {
            if (sqlConnection != null)
                sqlConnection.Close();
        }

        public static SqlDataReader GetData(string commandText)
        {
            if (SqlConnection != null && SqlCommand != null)
            {
                OpenConnection();
                sqlCommand.CommandText = commandText;
                var result = sqlCommand.ExecuteReader();
                CloseConnection();
                return result;
            }
            return null;
        }

        public static int EditData(string commandText)
        {
            if (SqlConnection != null && SqlCommand != null)
            {
                OpenConnection();
                sqlCommand.CommandText = commandText;
                var result = sqlCommand.ExecuteNonQuery();
                CloseConnection();
                return result;
            }
            return 0;
        }
    }
}