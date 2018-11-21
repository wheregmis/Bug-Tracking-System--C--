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

        private void listBugs_DoubleClick(object sender, EventArgs e)
        {
            int bugID = Convert.ToInt32(listBugs.FocusedItem.SubItems[1].Text);
            Console.WriteLine(bugID);

            this.Hide();
            new BugDetail(bugID, this.email).Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
