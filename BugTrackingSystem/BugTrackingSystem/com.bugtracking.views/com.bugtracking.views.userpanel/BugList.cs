using BugTrackingSystem.com.bugtracking.controller;
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
    public partial class BugList : MaterialForm
    {
        String email;
        public BugList(String email)
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

        /// <summary>
        /// loading bugs into the listview
        /// </summary>
        public void loadData()
        {
            listBugs.Clear();
            
            DataTable dt = new BugController().GetYourBugs(this.email);

            foreach (DataColumn column in dt.Columns)
            {
                this.listBugs.Columns.Add(column.ColumnName, -2, HorizontalAlignment.Left);
            }
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                listBugs.Items.Add(item);
                listBugs.View = View.Details;
            }
        }

        /// <summary>
        /// making it open the bug detail form when listview is double clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBugs_DoubleClick(object sender, EventArgs e)
        {
            int bugID = Convert.ToInt32(listBugs.FocusedItem.SubItems[1].Text);
            Console.WriteLine(bugID);

           // this.Hide();
            new BugDetail(bugID, this.email).Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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
