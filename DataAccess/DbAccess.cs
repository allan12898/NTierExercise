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
        public DataTable GetData_AllStatus()
        {
            DataTable result = new DataTable();
            string sql = "select * from tStatus order by Id asc";
            SqlDataAdapter Adapter = new SqlDataAdapter(sql, DbConn());
            ;

            Adapter.Fill(result);
            DbConn().Close();

            return result;
        }
        public DataSet GetData_Comment(Comment obj)
        {
            DataSet result = new DataSet();
            string sql = "select * from tComment where Id_Status=" + obj.StatusId + "order by Id asc";
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
                //builder.DataSource = "localhost";   // update me
                //builder.UserID = "sa";              // update me
                //builder.Password = "Password123";      // update me
                //builder.InitialCatalog = "NTier";
                string conn = "Data Source=localhost;Initial Catalog=NTier;Integrated Security=SSPI;";


                // Connect to SQL
                //Console.Write("Connecting to SQL Server ... ");
                SqlConnection connection = new SqlConnection(conn);
                //Console.Write("Connected ");

                return connection;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }

        }
        public void ConnClose()
        {
            DbConn().Close();
        }
    }
}
