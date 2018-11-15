using BugTrackingSystem.com.bugtracking.controller;
using BugTrackingSystem.com.bugtracking.dbconnection;
using BugTrackingSystem.com.bugtracking.model;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Windows.Forms;

namespace BugTrackingSystem.com.bugtracking.views
{
    public partial class AdminDashboard : MaterialForm
    {
       
        public AdminDashboard(String email)
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
            loadData();
            cmbGender.SelectedItem = null;
            cmbGender.SelectedText = "--select--";
            cmbUserRole.SelectedItem = null;
            cmbUserRole.SelectedText = "--select--";

            Console.WriteLine("You are in admindashboard load section");

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            String firstname = txtFirstName.Text;
            String lastname = txtLastName.Text;
            String email = txtEmail.Text;
            String password = txtPassword.Text;
            String address = txtAddress.Text;
            String gender = cmbGender.SelectedItem.ToString();
            String userrole = cmbUserRole.SelectedItem.ToString();
            String dob = dateOfBirth.Value.ToString("yyyy-MM-dd");
            

            User u = new User(firstname, lastname, email, password, address, gender, userrole, dob);
            new UserController().InsertUser(u);
            loadData();
        }


        private void listUser_DoubleClick(object sender, EventArgs e)
        {
            
            String username = listUser.FocusedItem.SubItems[2].Text;
            Console.WriteLine(username);

           DataTable dt = new UserController().GetUserDetails(username);

            int id = dt.Rows[0].Field<int>("userID");
           
           String firstname = txtFirstName.Text = dt.Rows[0].Field<String>("firstName");
           String lastname = txtLastName.Text = dt.Rows[0].Field<String>("lastName");
           String email = txtEmail.Text = dt.Rows[0].Field<String>("userEmail");
           String password = txtPassword.Text = dt.Rows[0].Field<String>("userPassword");
           String address = txtAddress.Text = dt.Rows[0].Field<String>("userAddress");
            cmbGender.SelectedItem = dt.Rows[0].Field<String>("gender");
            cmbUserRole.SelectedItem = dt.Rows[0].Field<String>("userRole");
            dateOfBirth.Value = dt.Rows[0].Field<DateTime>("birthDate");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
            String firstname = txtFirstName.Text;
            String lastname = txtLastName.Text;
            String email = txtEmail.Text;
            String password = txtPassword.Text;
            String address = txtAddress.Text;
            String userrole = cmbUserRole.SelectedItem.ToString();
            
            User u = new User(firstname, lastname, email, password, address, userrole);
            new UserController().UpdateUser(u);
            loadData();
            
        }


        public void loadData() {

            listUser.Clear();
            String query = "select firstName AS 'First Name', lastName AS 'Last Name', userEmail as Email, userRole as 'User Role', gender as Gender, birthDate as 'Date of Birth' from tbl_users where userType = 2";
            DataTable dt = new Database().getData(query);

            foreach (DataColumn column in dt.Columns)
            {
                this.listUser.Columns.Add(column.ColumnName, -2, HorizontalAlignment.Left);
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
        }
    }
    }

