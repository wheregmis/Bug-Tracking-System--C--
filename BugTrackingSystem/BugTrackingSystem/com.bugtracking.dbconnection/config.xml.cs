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
        // Prepare the connection

        String usertype;

        MySqlConnection databaseConnection = new MySqlConnection("datasource=localhost;username=root;password=;database=bugtrackingsystem;");


        public void listUsers()
        {

            // Select all
            string query = "SELECT * FROM users";

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                // Success, now list 

                // If there are available rows
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        Console.WriteLine(reader.GetInt64(0) + " - " + reader.GetString(1) + " - " + reader.GetString(2) + " - " + reader.GetString(3));
                        // Example to save in the listView1 :
                        //string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) };
                        //var listViewItem = new ListViewItem(row);
                        //listView1.Items.Add(listViewItem);
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


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
                        this.usertype = reader["userType"].ToString();        // 1st column text
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

        public DataTable getData(String query)
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

        public void insertData(String query) {
            
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("User succesfully registered");

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
        }

        public void updateData(String query) {
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("User succesfully Updated");

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
        }

        public void SystemClose()
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }
    }

    
}
