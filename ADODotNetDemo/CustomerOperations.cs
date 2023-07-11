using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADODotNetDemo
{
    internal class CustomerOperations
    {
        public static void CreateDataBase()
        {
            SqlConnection sql = new SqlConnection("data Source=(localdb)\\MSSQLLocalDB;initial catalog=master; integrated security=true");
            try
            {
                //writing sql query
                string query = "Create database ADODotNetDemo";
                SqlCommand command = new SqlCommand(query, sql);
                //Opening Connection
                sql.Open();
                //Executing the SQL query
                command.ExecuteNonQuery();
                //Dispalying a message
                Console.WriteLine("DataBase Created Successfully");
                Console.WriteLine("------------------------------");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Smething Went Wrong"+ex);
            }
            finally
            {
                sql.Close();
            }
        }
    }
}
