using BugTrackingSystem.com.bugtracking.controller;
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
    public partial class ManageProjects : MaterialForm
    {
        String email;
        public int projectID;
        public ManageProjects(String email)
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

        //loading projects in the listview
        public void loadData()
        {
            listProjects.Clear();
            DataTable dt = new ProjectController().GetAllProjects();

            foreach (DataColumn column in dt.Columns)
            {
                this.listProjects.Columns.Add(column.ColumnName, -2, HorizontalAlignment.Left);
            }
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                listProjects.Items.Add(item);
                listProjects.View = View.Details;
            }
        }

        //method to make form empty
        private void btnEmpty_Click(object sender, EventArgs e)
        {
            EmptyForm();
        }

        //method to add project and storing the value in the model
        private void btnAdd_Click(object sender, EventArgs e)
        {
            String projectName = txtProjectName.Text;
            String StartDate = startDate.Value.Date.ToString("yyyy-MM-dd");
            String EndDate = endDate.Value.Date.ToString("yyyy-MM-dd");

            Project p = new Project(projectName, StartDate, EndDate);
            new ProjectController().InsertProjects(p);
            listProjects.Clear();
            loadData();

        }

        //method to update project and storing the value in the model
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String projectName = txtProjectName.Text;
            String StartDate = startDate.Value.Date.ToString("yyyy-MM-dd");
            String EndDate = endDate.Value.Date.ToString("yyyy-MM-dd");

            Project p = new Project(this.projectID, projectName, StartDate, EndDate);
            new ProjectController().UpdateProject(p);
            listProjects.Clear();
            loadData();
            
        }

        //method to fill the form when double clicked on the listview
        private void listProjects_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(listProjects.FocusedItem.SubItems[0].Text);
            Console.WriteLine(id);

            DataTable dt = new ProjectController().GetProjectDetails(id);

             this.projectID = dt.Rows[0].Field<int>("projectID");

            String projectName = txtProjectName.Text = dt.Rows[0].Field<String>("projectName");
            DateTime StartDate = startDate.Value = dt.Rows[0].Field<DateTime>("startDate");
            DateTime EndDate = endDate.Value = dt.Rows[0].Field<DateTime>("endDate");

            

        }

        public void EmptyForm() {
            txtProjectName.Text = "";
            startDate.Value = DateTime.UtcNow.Date;
            endDate.Value = DateTime.UtcNow.Date;
        }

        //method to delete project
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Project p = new Project(this.projectID);
            new ProjectController().DeleteProject(p);
            listProjects.Clear();
            loadData();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
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
    }
    }

