using BugTrackingSystem.com.bugtracking.controller;
using BugTrackingSystem.com.bugtracking.views.com.bugtracking.views.userpanel;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTrackingSystem.com.bugtracking.views.com.bugtracking.views.adminpanel
{
    public partial class GitForm : MaterialForm
    {
        String email, localFolder;
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

           
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/xawbeenregmi/Bug-Tracking-System--C--");
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            //Commiting the message to local repo
            String username = "xawbeenregmi";
            String password = "n0b0dycanhackme";
            String repo = "https://github.com/xawbeenregmi/Bug-Tracking-System--C--/commits/master";
            String localfile = this.localFolder;
            GitController gc = new GitController(username, password, repo, localfile);
            gc.Commit(txtMessage.Text);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to exit the System??", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                Application.Exit();
            }
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //pushing the commits to github repo 
            String username = "xawbeenregmi";
            String password = "n0b0dycanhackme";
            String repo = "https://github.com/xawbeenregmi/Bug-Tracking-System--C--";
            String localfile = this.localFolder;
            GitController gc = new GitController(username, password, repo, localfile);
            gc.PushCommits();
        }

        private void RefreshCommitHistory_Click(object sender, EventArgs e)
        {

        }

        private void GitForm_Load(object sender, EventArgs e)
        {
           
        }
        

        private void btnHistory_Click(object sender, EventArgs e)
        {
            //getting the commit history into the textarea
            textHistory.SelectAll();
            textHistory.Clear();
            Console.SetOut(new ControlWriter(textHistory));
            String username = "xawbeenregmi";
            String password = "n0b0dycanhackme";
            String repo = "https://github.com/xawbeenregmi/Bug-Tracking-System--C--";
            String localfile = this.localFolder;
            new GitController(username, password, repo, localfile).getCommitHistory();
            textHistory.ReadOnly = true;
        }

        private void RefreshHistory_Click(object sender, EventArgs e)
        {
            //getting the commit history into the textarea
            textHistory.SelectAll();
            textHistory.Clear();
            Console.SetOut(new ControlWriter(textHistory));
            String username = "xawbeenregmi";
            String password = "n0b0dycanhackme";
            String repo = "https://github.com/xawbeenregmi/Bug-Tracking-System--C--";
            String localfile = this.localFolder;
            new GitController(username, password, repo, localfile).getCommitHistory();
            textHistory.ReadOnly = true;
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    lblLocalFolder.Text = fbd.SelectedPath;
                    this.localFolder = fbd.SelectedPath;
                }
            }
        }
    }

    public class ControlWriter : TextWriter
    {
        private Control textbox;
        public ControlWriter(Control textbox)
        {
            this.textbox = textbox;
        }

        public override void Write(char value)
        {
            textbox.Text += value;
        }

        public override void Write(string value)
        {
            textbox.Text += value;
        }

        public override Encoding Encoding
        {
            get { return Encoding.ASCII; }
        }
    }
}
