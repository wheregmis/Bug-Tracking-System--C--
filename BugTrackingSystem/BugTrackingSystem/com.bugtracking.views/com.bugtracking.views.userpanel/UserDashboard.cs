using BugTrackingSystem.com.bugtracking.controller;
using BugTrackingSystem.com.bugtracking.dbconnection;
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

namespace BugTrackingSystem.com.bugtracking.views.com.bugtracking.views.userpanel
{
    public partial class UserDashboard : MaterialForm
    {
        Image File;
        public UserDashboard(String email)
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
            this.WindowState = FormWindowState.Maximized;
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            new Database().SystemClose();
        }

        

        private void materialLabel9_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Image files (*.jpg, *.png) | *.jpg; *.png";

            if (f.ShowDialog() == DialogResult.OK)
            {
                this.File = Image.FromFile(f.FileName);


            }
        }

        private void listUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            String bugTitle = txtBugTitle.Text;
            String project = txtProject.Text;
            String line = txtLine.Text;
            String method = txtMethod.Text;
            String bugClass = txtClass.Text;
            String notes = txtNotes.Text;
            String code = txtSourceCode.Text;
            String priority = cmbPriority.SelectedItem.ToString();
            String date = DateTime.Now.ToString("dd.MM.yyy");
            String reportedBy = "";

            Bug b = new Bug(bugTitle, project, line, method, bugClass, notes, code, this.File, priority, date, reportedBy);
            new BugController().InsertBug(b);

        }
    }
}
