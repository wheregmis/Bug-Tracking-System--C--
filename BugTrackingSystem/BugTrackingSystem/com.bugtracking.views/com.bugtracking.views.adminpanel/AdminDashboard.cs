using BugTrackingSystem.com.bugtracking.controller;
using BugTrackingSystem.com.bugtracking.dbconnection;
using BugTrackingSystem.com.bugtracking.model;
using BugTrackingSystem.com.bugtracking.views.com.bugtracking.views.adminpanel;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTrackingSystem.com.bugtracking.views
{
    public partial class AdminDashboard : MaterialForm
    {
       
        public AdminDashboard()
        {
            InitializeComponent();

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Grey800, Primary.Grey700,
                Primary.Grey800, Accent.LightBlue100,
                TextShade.WHITE

               

            );

            this.WindowState = FormWindowState.Maximized;
            
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            new Database().SystemClose();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            
            String query = "select firstName AS 'First Name', lastName AS 'Last Name', userName as Username, userEmail as Email, userRole as 'User Role', gender as Gender, birthDate as 'Date of Birth' from tbl_users";
            DataTable dt = new Database().getData(query);

            foreach (DataColumn column in dt.Columns)
            {
                this.listUser.Columns.Add(column.ColumnName,- 2, HorizontalAlignment.Left);
            }
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                listUser.Items.Add(item);
                listUser.View = View.Details;
            }
            

            Console.WriteLine("You are in admindashboard load section");

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String user_username = txtUsername.Text;
            String firstname = txtFirstName.Text;
            String lastname = txtLastName.Text;
            String email = txtEmail.Text;
            String password = txtPassword.Text;
            String address = txtAddress.Text;
            String gender = cmbGender.SelectedItem.ToString();
            String userrole = cmbUserRole.SelectedItem.ToString();
            String dob = dateOfBirth.Value.ToString("yyyy-MM-dd");
            

            User u = new User(user_username, firstname, lastname, email, password, address, gender, userrole, dob);
            new UserController().InsertUser(u);

        }


        private void listUser_DoubleClick(object sender, EventArgs e)
        {
            
            String username = listUser.FocusedItem.SubItems[2].Text;
            Console.WriteLine(username);

           DataTable dt = new UserController().GetUserDetails(username);

            int id = dt.Rows[0].Field<int>("userID");
           String user_username = txtUsername.Text = dt.Rows[0].Field<String>("userName");
           String firstname = txtFirstName.Text = dt.Rows[0].Field<String>("firstName");
           String lastname = txtLastName.Text = dt.Rows[0].Field<String>("lastName");
           String email = txtEmail.Text = dt.Rows[0].Field<String>("userEmail");
           String password = txtPassword.Text = dt.Rows[0].Field<String>("userPassword");
           String address = txtAddress.Text = dt.Rows[0].Field<String>("userAddress");
            



        }
    }
    }

