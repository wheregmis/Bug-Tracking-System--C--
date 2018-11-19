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

namespace BugTrackingSystem.com.bugtracking.views.com.bugtracking.views.adminpanel
{
    public partial class ManageProjects : MaterialForm
    {
        public int projectID;
        public ManageProjects()
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

            loadData();
        }

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

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            EmptyForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String projectName = txtProjectName.Text;
            String StartDate = startDate.Value.Date.ToString("yyyy-MM-dd");
            String EndDate = endDate.Value.Date.ToString("yyyy-MM-dd");

            Project p = new Project(projectName, StartDate, EndDate);
            new ProjectController().insertProjects(p);
            listProjects.Clear();
            loadData();

        }

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Project p = new Project(this.projectID);
            new ProjectController().DeleteProject(p);
            listProjects.Clear();
            loadData();
        }

       
    }
    }

