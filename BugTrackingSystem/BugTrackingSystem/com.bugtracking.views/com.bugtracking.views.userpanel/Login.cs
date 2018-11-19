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
                Primary.Grey800, Primary.Grey700,
                Primary.Grey800, Accent.LightBlue100,
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
                if (validate == "1")
                {
                    DataTable dt = new UserController().GetUserDetails(txtEmail.Text);

                    int id = dt.Rows[0].Field<int>("userID");
                    
                    String email = dt.Rows[0].Field<String>("userEmail");
                     

                    new AdminPage(email).Show();
                    this.Hide();
                }
                if (validate == "2")
                {
                    DataTable dt = new UserController().GetUserDetails(txtEmail.Text);

                    int id = dt.Rows[0].Field<int>("userID");

                    String email = dt.Rows[0].Field<String>("userEmail");
                    

                    new ReportBugs(email).Show();
                    this.Hide();
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
