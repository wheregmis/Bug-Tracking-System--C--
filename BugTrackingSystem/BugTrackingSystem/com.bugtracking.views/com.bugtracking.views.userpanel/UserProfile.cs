using BugTrackingSystem.com.bugtracking.controller;
using BugTrackingSystem.com.bugtracking.model;
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

namespace BugTrackingSystem.com.bugtracking.views.com.bugtracking.views.userpanel
{
    public partial class UserProfile : MaterialForm
    {
        int id;
        String email, userRole;
        public UserProfile(String email)
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
            loadData();
        }

        /// <summary>
        /// Loading user data in the form 
        /// </summary>
        public void loadData() {

            Console.WriteLine(this.email);
            DataTable dt = new UserController().GetUserDetails(this.email);

            this.id = dt.Rows[0].Field<int>("userID");

            String firstname = txtFirstName.Text = dt.Rows[0].Field<String>("firstName");
            String lastname = txtLastName.Text = dt.Rows[0].Field<String>("lastName");
            String email = txtEmail.Text = dt.Rows[0].Field<String>("userEmail");
            String password = txtPassword.Text = dt.Rows[0].Field<String>("userPassword");
            String address = txtAddress.Text = dt.Rows[0].Field<String>("userAddress");
            cmbGender.SelectedItem = dt.Rows[0].Field<String>("gender");
            this.userRole = dt.Rows[0].Field<String>("userRole");
            dateOfBirth.Value = dt.Rows[0].Field<DateTime>("birthDate");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// method to update user info in the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String firstname = txtFirstName.Text;
            String lastname = txtLastName.Text;
            String email = txtEmail.Text;
            String password = txtPassword.Text;
            String address = txtAddress.Text;
            String userrole = this.userRole;

            User u = new User(this.id, firstname, lastname, email, password, address, userrole);
            new UserController().UpdateUser(u);
        }
    }
}
