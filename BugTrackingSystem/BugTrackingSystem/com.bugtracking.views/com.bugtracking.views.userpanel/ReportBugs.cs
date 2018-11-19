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

namespace BugTrackingSystem.com.bugtracking.views.com.bugtracking.views.userpanel
{
    public partial class ReportBugs : MaterialForm
    {
        Image File;
        String email;
        public ReportBugs(String email)
        {
            this.email = email;
            
            InitializeComponent();
            fillComb();
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

        private void btnReport_Click(object sender, EventArgs e)
        {
            String bugTitle = txtBugTitle.Text;
            String project = cmbProject.SelectedItem.ToString();
            String line = txtLine.Text;
            String method = txtMethod.Text;
            String bugClass = txtClass.Text;
            String notes = txtNotes.Text;
            String code = txtSourceCode.Text;
            String priority = cmbPriority.SelectedItem.ToString();
            String date = DateTime.Now.ToString("dd.MM.yyy");
            String reportedBy = this.email;

            Bug b = new Bug(bugTitle, project, line, method, bugClass, notes, code, this.File, priority, date, reportedBy);
            new BugController().InsertBug(b);
        }

        private void materialLabel9_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Image files (*.jpg, *.png) | *.jpg; *.png";

            if (f.ShowDialog() == DialogResult.OK)
            {

                this.File = Image.FromFile(f.FileName);
                picScreenshot.Image = Image.FromFile(f.FileName);


            }
        }

       public void fillComb() {

            DataTable dt = new BugController().FillCombProject();

             for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                string project = dt.Rows[i].Field<String>("projectName");
                cmbProject.Items.Add(project);
              //  Console.WriteLine(project);
            }

        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            this.Hide();
            new BugDetail().Show();
        }
    }
}
