using BugTrackingSystem.com.bugtracking.controller;
using BugTrackingSystem.com.bugtracking.dbconnection;
using BugTrackingSystem.com.bugtracking.model;
using BugTrackingSystem.com.bugtracking.views.com.bugtracking.views.userpanel;
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

namespace BugTrackingSystem.com.bugtracking.views.com.bugtracking.views.adminpanel
{
    public partial class ManageUsers : MaterialForm
    {
        String email;
        public int id;
        public ManageUsers(String email)
        {
            InitializeComponent();
            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey500,
                Primary.BlueGrey800, Accent.LightBlue100,
                TextShade.WHITE
              );
            this.email = email;
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            loadData();
            cmbGender.SelectedItem = null;
            cmbGender.SelectedText = "--SELECT--";
            cmbUserRole.SelectedItem = null;
            cmbUserRole.SelectedText = "--SELECT--";
        }
        public void loadData()
        {

            listUser.Clear();
            String query = "select firstName AS 'First Name', lastName AS 'Last Name', userEmail as Email, userRole as 'User Role', gender as Gender, birthDate as 'Date of Birth' from tbl_users";
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

        private void listUser_DoubleClick(object sender, EventArgs e)
        {
            String email1 = listUser.FocusedItem.SubItems[2].Text;
            Console.WriteLine(email1);

            DataTable dt = new UserController().GetUserDetails(email1);

           this.id = dt.Rows[0].Field<int>("userID");

            String firstname = txtFirstName.Text = dt.Rows[0].Field<String>("firstName");
            String lastname = txtLastName.Text = dt.Rows[0].Field<String>("lastName");
            String email = txtEmail.Text = dt.Rows[0].Field<String>("userEmail");
            String password = txtPassword.Text = dt.Rows[0].Field<String>("userPassword");
            String address = txtAddress.Text = dt.Rows[0].Field<String>("userAddress");
            cmbGender.SelectedItem = dt.Rows[0].Field<String>("gender");
            cmbUserRole.SelectedItem = dt.Rows[0].Field<String>("userRole");
            dateOfBirth.Value = dt.Rows[0].Field<DateTime>("birthDate");
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
            ClearData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            String firstname = txtFirstName.Text;
            String lastname = txtLastName.Text;
            String email = txtEmail.Text;
            String password = txtPassword.Text;
            String address = txtAddress.Text;
            String userrole = cmbUserRole.SelectedItem.ToString();

            User u = new User(this.id, firstname, lastname, email, password, address, userrole);
            new UserController().UpdateUser(u);
            loadData();
            ClearData();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {

            ClearData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            User u = new User(this.id);
            new UserController().DeleteUser(u);
            loadData();
            ClearData();
        }

        public void ClearData() {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtPassword.Text = "";
            cmbGender.SelectedItem = null;
            cmbGender.SelectedText = "--SELECT--";
            cmbUserRole.SelectedItem = null;
            cmbUserRole.SelectedText = "--SELECT--";
            dateOfBirth.Value = DateTime.UtcNow.Date;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AdminPage(this.email, "Admin").Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UserProfile(this.email).Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ManageUsers(this.email).Show();
            this.Hide();
        }

        private void projectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ManageProjects(this.email).Show();
            this.Hide();
        }

        private void bugsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ManageBugs(this.email, "admin").Show();
            this.Hide();
        }
    }
}
