using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BugTrackingSystem.com.bugtracking.dbconnection
{



    class Database
    {
         String usertype;
        // Prepare the connection
        MySqlConnection databaseConnection = new MySqlConnection("datasource=localhost;username=root;password=;database=bugtrackingsystem;");


        //validating login and userrole
        public String LoginValidate(String email, String password) {

             String query = "SELECT * FROM tbl_users WHERE userEmail='"+email+"' and userPassword='"+password+"'";

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        this.usertype = reader["userRole"].ToString();        // 1st column text
                        Console.WriteLine(this.usertype);
                    }
                    databaseConnection.Close();
                    return this.usertype;
                }
                else
                {
                    Console.WriteLine("No rows found.");
                    databaseConnection.Close();
                    return "No";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "No";
            }
        }

        //getting data from database and loading it into datatable and returning it
        public DataTable GetData(String query)
        {
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                var dataTable = new DataTable();
                dataTable.Load(reader);
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        //inserting bug into database 
        //While inserting it in normal way image wasnt loading so i need to add parameter in the query
        //thats why i need to create a seperate method to insert bugs
        public void InsertBug(String query, byte[] img) {
            
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.Parameters.Add("@img", MySqlDbType.LongBlob);
            commandDatabase.Parameters["@img"].Value = img;
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                 databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
        }

        //Updating data into database
        public void UpdateData(String query) {
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
        }

        //Deleting data in database
        public void DeleteData(String query) {
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
        }

       //method to insert Data in the database
        public void InsertData(String query)
        {

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
        }

    }

    
}
