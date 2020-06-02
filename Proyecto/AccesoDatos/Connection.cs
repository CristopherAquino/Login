using System.Data.SqlClient;

namespace AccesoDatos
{
    public abstract class Connection
    {
        private readonly string connectionstring;
        public Connection()
        {
            connectionstring = @"Data Source=DESKTOP-261MICJ\SQLEXPRESS;Initial Catalog=MyCompany;Integrated Security=True";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionstring);
        }

    }
}
