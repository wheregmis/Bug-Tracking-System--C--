using BugTrackingSystem.com.bugtracking.controller;
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
    public partial class GitForm : MaterialForm
    {
        String email;
        public GitForm(String email)
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
            // webBrowser.Navigate("https://github.com/xawbeenregmi/Bug-Tracking-System--C--/commits/master");
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/xawbeenregmi/Bug-Tracking-System--C--/commits/master");
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            String username = "xawbeenregmi";
            String password = "n0b0dycanhackme";
            String repo = "https://github.com/xawbeenregmi/testingLibgit";
            String localfile = "C:/Users/xawbe/Documents/GitHub/Bug-Tracking-System--C--";
            GitController gc = new GitController(username, password, repo, localfile);
            gc.Commit(txtMessage.Text);
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            String username = "xawbeenregmi";
            String password = "n0b0dycanhackme";
            String repo = "https://github.com/xawbeenregmi/testingLibgit";
            String localfile = "C:/Users/xawbe/Documents/GitHub/Bug-Tracking-System--C--";
            GitController gc = new GitController(username, password, repo, localfile);
            gc.PushCommits();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
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
