using BugTrackingSystem.com.bugtracking.controller;
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

namespace BugTrackingSystem.com.bugtracking.views.com.bugtracking.views.userpanel
{
    public partial class UserDashboard : MaterialForm
    {
        String email;
        public UserDashboard(String email)
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
            lblProfile.Text = email;
            this.email = email;
  
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new UserProfile(this.email).Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void picReport_Click(object sender, EventArgs e)
        {
            new ReportBugs(this.email).Show();
            this.Hide();
        }

        private void picResolve_Click(object sender, EventArgs e)
        {
            new AllBugs(this.email).Show();
            this.Hide();
        }

        private void picBugList_Click(object sender, EventArgs e)
        {
            new BugList(this.email).Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to exit the System??", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to exit the System??", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UserProfile(this.email).Show();
        }

        private void bugsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ReportBugs(this.email).Show();
            this.Hide();
        }

        private void yourBugListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BugList(this.email).Show();
            this.Hide();
        }

        private void othersBugsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AllBugs(this.email).Show();
            this.Hide();
        }

        private void reportBugsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ReportBugs(this.email).Show();
            this.Hide();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UserDashboard(this.email).Show();
            this.Hide();
        }
    }
}
