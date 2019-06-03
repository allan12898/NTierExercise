using Entity.Entities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DbAccess
    {
        public DataSet GetData_Status(Status obj)
        {
            DataSet result = new DataSet();
            string sql = "select * from tStatus where Id=" + obj.Id + "order by Id asc";
            SqlDataAdapter Adapter = new SqlDataAdapter(sql, DbConn());
            ;
            Adapter.Fill(result);

            return result;
        }

        
        public SqlConnection DbConn()
        {
            try
            {
                // Build connection string
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "localhost";   // update me
                builder.UserID = "sa";              // update me
                builder.Password = "your_password";      // update me
                builder.InitialCatalog = "master";

                // Connect to SQL
                Console.Write("Connecting to SQL Server ... ");
                SqlConnection connection = new SqlConnection(builder.ConnectionString);
                Console.Write("Connected ");

                return connection;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }

        }
    }
}
