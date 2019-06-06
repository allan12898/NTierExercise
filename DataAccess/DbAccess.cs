using System;
using System.Data;
using System.Data.SqlClient;


namespace DataAccess
{
    public class DbAccess
    {
        public DataSet GetData_Status(int Id)
        {
            DataSet result = new DataSet();
            string sql = "select * from tStatus where Id=" + Id + "order by Id asc";
            SqlDataAdapter Adapter = new SqlDataAdapter(sql, DbConn());
            ;

            Adapter.Fill(result);
            DbConn().Close();
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

        public DataSet GetData_Comment(int Id)
        {
            DataSet result = new DataSet();
            string sql = "select * from tComment where Id_Status=" + Id + "order by Id asc";
            SqlDataAdapter Adapter = new SqlDataAdapter(sql, DbConn());
            

            Adapter.Fill(result);
            DbConn().Close();
            return result;
        }
        public void PostComment( string Content)
        {
            //DataSet result = new DataSet();
            string sql = "Insert Into tComment() values ()";
            SqlCommand command = new SqlCommand(sql,DbConn());
            command.ExecuteNonQuery();

            DbConn().Close();
            //return result;
        }
        public void LikeStatus(int Id)
        {
            //DataSet result = new DataSet();
            string sql = "Insert Into tLike() values ()";
            SqlCommand command = new SqlCommand(sql, DbConn());
            command.ExecuteNonQuery();
            DbConn().Close();
        }
        public void UnlikeStatus(int Id)
        {
            //DataSet result = new DataSet();
            string sql = "Update tLike Set IsActive = 0 where Id =" + Id;
            SqlCommand command = new SqlCommand(sql, DbConn());
            command.ExecuteNonQuery();
            DbConn().Close();
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
                string conn = "Data Source=localhost;Initial Catalog=NTier2;Integrated Security=SSPI;";


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

    }
}
