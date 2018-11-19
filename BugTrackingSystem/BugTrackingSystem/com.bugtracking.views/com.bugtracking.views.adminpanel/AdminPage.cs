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
    public partial class AdminPage : MaterialForm
    {
        public string email;
        public AdminPage(String email)
        {

            this.email = email;
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

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManageUsers(this.email).Show();
        }

        private void manageUsersPic_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManageUsers(this.email).Show();
        }

        private void ManageProjectsPic_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManageProjects().Show();
        }

        private void btnManageProjects_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManageProjects().Show();
        }

        private void ManageBugsPic_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManageBugs().Show();
        }

        private void btnManageBugs_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManageBugs().Show();
        }
    }
}
