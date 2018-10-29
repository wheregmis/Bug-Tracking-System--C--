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
using MaterialSkin;
using MaterialSkin.Controls;

namespace BugTrackingSystem
{
    public partial class Registration : MaterialForm
    {
        

        public Registration()
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

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            //this.Hide();

            
            
            
        }

        public void disposeFrame() {
            Registration reg = new Registration();
            reg.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           Boolean validate = new Database().LoginValidate(txtUsername.Text, txtPassword.Text);
           if (validate)
         {
              MessageBox.Show("Login Successful");
       
           }
         else {
              MessageBox.Show("Login UnSucessfull");
            }
        }
    }
}
