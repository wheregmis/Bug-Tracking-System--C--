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
    public partial class BugDetail : MaterialForm
    {
        int bugID;
        String email;
        Image File;
        public BugDetail(int bugID, String email)
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
            this.bugID = bugID;
            this.email = email;
            loadData(bugID);
            fillComb();
            

            txtBugTitle.Enabled = false;

        }
        public void fillComb()
        {

            DataTable dt = new BugController().FillCombProject();

            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                string project = dt.Rows[i].Field<String>("projectName");
                cmbProject.Items.Add(project);
                //  Console.WriteLine(project);
            }

        }
        private void BugDetail_Load(object sender, EventArgs e)
        {
            DataTable dt = new BugController().GetBugDetail(this.bugID);

            String bugTitle = txtBugTitle.Text = dt.Rows[0].Field<String>("bugTitle");
            cmbProject.SelectedItem = dt.Rows[0].Field<String>("project");
            // int line = txtLine.Text = dt.Rows[0].Field<int>("line");
            int line = dt.Rows[0].Field<int>("line");
            txtLine.Text = line.ToString();
            String method = txtMethod.Text = dt.Rows[0].Field<String>("method");
            String bugClass = txtClass.Text = dt.Rows[0].Field<String>("class");
            String notes = txtNotes.Text = dt.Rows[0].Field<String>("notes");
            String code = txtSourceCode.Text = dt.Rows[0].Field<String>("sourceCode");
            cmbPriority.SelectedItem = dt.Rows[0].Field<String>("priority");
            byte[] img = (byte[])dt.Rows[0][8];
            this.File = byteArrayToImage(img);
            picScreenshot.Image = this.File;
            String reportedBy = txtNotes.Text = dt.Rows[0].Field<String>("reportedBy");
            if (reportedBy == this.email) {
                btnResolve.Visible = false;
            }
            
}

        public void loadData(int bugID)
        {
            listHistory.Clear();
            DataTable dt = new BugFixesController().GetFixesHistory(bugID);
            if (dt.Rows.Count > 0)
            {
                foreach (DataColumn column in dt.Columns)
                {
                    this.listHistory.Columns.Add(column.ColumnName, -2, HorizontalAlignment.Left);
                }
                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(row[0].ToString());
                    for (int i = 1; i < dt.Columns.Count; i++)
                    {
                        item.SubItems.Add(row[i].ToString());
                    }
                    listHistory.Items.Add(item);
                    listHistory.View = View.Details;
                }
            }
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {

            System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
            Image img = (Image)converter.ConvertFrom(byteArrayIn);

            return img;
        }

        private void listHistory_DoubleClick(object sender, EventArgs e)
        {
            int bugfixesID = Convert.ToInt32(listHistory.FocusedItem.SubItems[2].Text);
            DataTable df = new BugFixesController().GetBugFixes(bugfixesID);
            if (df.Rows.Count > 0)
            {
                String resolveCode = txtResolvedCode.Text = df.Rows[0].Field<String>("bugFix");
                String comments = txtComments.Text = df.Rows[0].Field<String>("comments");
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            
            new CodeView(txtSourceCode.Text).Show();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            new CodeView(txtResolvedCode.Text).Show();
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            new ImageView(this.File).Show();
        }

        private void btnResolve_Click(object sender, EventArgs e)
        {
            String resolveCode = txtResolvedCode.Text;
            String comments = txtComments.Text;
            int bugID = this.bugID;
            String resolvedBy = this.email;
            String resolvedDate = DateTime.Now.ToString("yyyy-MM-dd");

            Fixes fx = new Fixes(bugID, resolveCode, comments, resolvedBy, resolvedDate);
            new BugFixesController().insertBugFixes(fx);
            loadData(this.bugID);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
