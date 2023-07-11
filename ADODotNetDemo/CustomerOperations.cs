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
                Console.WriteLine("Smething Went Wrong" + ex);
            }
            finally
            {
                sql.Close();
            }
        }
        public static SqlConnection sql = new SqlConnection("data Source=(localdb)\\MSSQLLocalDB;initial catalog=ADODotNetDemo; integrated security=true");
        public static void CreateTable()
        {
            try
            {
                //writting sql querry
                string query = "create table CustomerData(Id int identity(1,1)primary key, Name varchar(200), City varchar(30))";
                SqlCommand command = new SqlCommand(query, sql);
                //Opening Connection
                sql.Open();
                //Executing the Sql query
                command.ExecuteNonQuery();
                //Display a message
                Console.WriteLine("Table Created Successfully");
                Console.WriteLine("---------------------------");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Smething Went Wrong" + ex);
            }
            finally
            {
                sql.Close();
            }
        }
        public static void InsertData()
        {
            try
            {
                //writing sql query
                string query = "Insert into CustomerData values('Somu','Banglore'),('Anil','Banglore'),('Kumar','Kolar')";
                SqlCommand command = new SqlCommand(query, sql);
                //Opening Connection
                sql.Open();
                //Executing the Sql query
                command.ExecuteNonQuery();
                //Display a message
                Console.WriteLine("Data Inserted Successfully");
                Console.WriteLine("--------------------------");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Smething Went Wrong" + ex);
            }
            finally
            {
                sql.Close();
            }
        }
    }
}
