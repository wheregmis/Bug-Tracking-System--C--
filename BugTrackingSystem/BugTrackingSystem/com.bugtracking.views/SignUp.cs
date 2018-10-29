using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using BugTrackingSystem.com.bugtracking.model;

namespace BugTrackingSystem.com.bugtracking.views
{
    public partial class SignUp : MaterialForm
    {
        private User user;
        public SignUp()
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
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            string theDate = dob.Value.ToString("yyyy-MM-dd");
            string firstname = txtFirstName.Text;
            string username = txtUsername.Text;
            string email = txtEmail.Text;
            string address = txtAddress.Text;
            string gender = txtGender.Text;
            string lastname = txtLastName.Text;
            
            
            user = new User("Sabin");
            MessageBox.Show(user.getFirstName());

    }
    }
}
