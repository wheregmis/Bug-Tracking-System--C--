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


        public String LoginValidate(String username, String password) {

            


             String query = "SELECT * FROM tbl_users WHERE userName='"+username+"' and userPassword='"+password+"'";

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
            try
            {
                SqlDataAdapter ada = new SqlDataAdapter(query, databaseConnection.ToString());
                DataTable dt = new DataTable();
                ada.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Console.WriteLine(dt.Rows[i]);
                }
                return dt;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public void insertData() {
            //  string query = "INSERT INTO user(`userName`, `firstName`, `lastName`, `userEmail`, `userPassword`, `userAddress`, `birthDate`, `gender`) VALUES ('" + test + "', '" + test + "', '" + test + "', '" + test + "', '" + test + "', '" + test + "', '" + test + "', '" + test + "')";
            // Which could be translated manually to :
            // INSERT INTO user(`id`, `first_name`, `last_name`, `address`) VALUES (NULL, 'Bruce', 'Wayne', 'Wayne Manor')

            String query = "";

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
