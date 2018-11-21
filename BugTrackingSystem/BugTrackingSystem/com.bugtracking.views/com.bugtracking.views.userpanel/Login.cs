using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BugTrackingSystem.com.bugtracking.dbconnection;
using BugTrackingSystem.com.bugtracking.model;
using BugTrackingSystem.com.bugtracking.views;
using BugTrackingSystem.com.bugtracking.views.com.bugtracking.views.userpanel;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Threading;
using BugTrackingSystem.com.bugtracking.controller;
using BugTrackingSystem.com.bugtracking.views.com.bugtracking.views.adminpanel;

namespace BugTrackingSystem
{
    public partial class Login : MaterialForm
    {

        
        public Login()
        {
            InitializeComponent();
            // new Database().listUsers();

            txtPassword.PasswordChar = '*';

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
        }

        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            String validate = new Database().LoginValidate(txtEmail.Text, txtPassword.Text);
            if (validate == "No")
            {
                MessageBox.Show("Login UnSucessfull");

            }
            else
            {
                if (validate == "Admin")
                {
                    new AdminPage(txtEmail.Text, "Admin").Show();
                    this.Hide();
                }
                else {

                    DataTable dt = new UserController().GetUserDetails(txtEmail.Text);

                    int id = dt.Rows[0].Field<int>("userID");

                    String email = dt.Rows[0].Field<String>("userEmail");
                    String userRole = dt.Rows[0].Field<String>("userRole");
                    new UserDashboard(email, userRole).Show();
                    this.Hide();
                }
            
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = showPassword.Checked ? '\0' : '*';
        }

        private void btnForgetPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact Admin to reset your password");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
