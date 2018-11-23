using BugTrackingSystem.com.bugtracking.controller;
using BugTrackingSystem.com.bugtracking.model;
using MaterialSkin;
using MaterialSkin.Controls;
using ScintillaNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
                Primary.BlueGrey800, Primary.BlueGrey500,
                Primary.BlueGrey800, Accent.LightBlue100,
                TextShade.WHITE
              );
            loadData();
            
        }

        /// <summary>
        /// loading the bugs in the listview
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
        /// adding the bugs in the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReport_Click(object sender, EventArgs e)
        {
            String bugTitle = txtBugTitle.Text;
            String project = cmbProject.SelectedItem.ToString();
            String line = txtLine.Text;
            String method = txtMethod.Text;
            String bugClass = txtClass.Text;
            String notes = txtNotes.Text;
            String code = TextArea.Text;
            String priority = cmbPriority.SelectedItem.ToString();
            String date = DateTime.Now.ToString("yyyy-MM-dd");
            String reportedBy = this.email;

            Bug b = new Bug(bugTitle, project, line, method, bugClass, notes, code, this.File, priority, date, reportedBy);
            new BugController().InsertBug(b);
            loadData();
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

        private void ReportBugs_Load(object sender, EventArgs e)
        {
            // TextArea = new ScintillaNET.Scintilla();
            // TextPanel.Controls.Add(TextArea);

            // BASIC CONFIG
           // TextArea.Dock = System.Windows.Forms.DockStyle.Fill;
            TextArea.TextChanged += (this.OnTextChanged);

            //    // INITIAL VIEW CONFIG
            TextArea.WrapMode = WrapMode.None;
            TextArea.IndentationGuides = IndentView.LookBoth;

            //    // STYLING
            InitColors();
            InitSyntaxColoring();
        }

        private void TextArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void OnTextChanged(object sender, EventArgs e)
        {

        }

        public static Color IntToColor(int rgb)
        {
            return Color.FromArgb(255, (byte)(rgb >> 16), (byte)(rgb >> 8), (byte)rgb);
        }

        private void InitSyntaxColoring()
        {

            // Configure the default style
            TextArea.StyleResetDefault();
            TextArea.Styles[Style.Default].Font = "Consolas";
            TextArea.Styles[Style.Default].Size = 10;
            TextArea.Styles[Style.Default].BackColor = IntToColor(0x212121);
            TextArea.Styles[Style.Default].ForeColor = IntToColor(0xFFFFFF);
            TextArea.StyleClearAll();

            // Configure the CPP (C#) lexer styles
            TextArea.Styles[Style.Cpp.Identifier].ForeColor = IntToColor(0xD0DAE2);
            TextArea.Styles[Style.Cpp.Comment].ForeColor = IntToColor(0xBD758B);
            TextArea.Styles[Style.Cpp.CommentLine].ForeColor = IntToColor(0x40BF57);
            TextArea.Styles[Style.Cpp.CommentDoc].ForeColor = IntToColor(0x2FAE35);
            TextArea.Styles[Style.Cpp.Number].ForeColor = IntToColor(0xFFFF00);
            TextArea.Styles[Style.Cpp.String].ForeColor = IntToColor(0xFFFF00);
            TextArea.Styles[Style.Cpp.Character].ForeColor = IntToColor(0xE95454);
            TextArea.Styles[Style.Cpp.Preprocessor].ForeColor = IntToColor(0x8AAFEE);
            TextArea.Styles[Style.Cpp.Operator].ForeColor = IntToColor(0xE0E0E0);
            TextArea.Styles[Style.Cpp.Regex].ForeColor = IntToColor(0xff00ff);
            TextArea.Styles[Style.Cpp.CommentLineDoc].ForeColor = IntToColor(0x77A7DB);
            TextArea.Styles[Style.Cpp.Word].ForeColor = IntToColor(0x48A8EE);
            TextArea.Styles[Style.Cpp.Word2].ForeColor = IntToColor(0xF98906);
            TextArea.Styles[Style.Cpp.CommentDocKeyword].ForeColor = IntToColor(0xB3D991);
            TextArea.Styles[Style.Cpp.CommentDocKeywordError].ForeColor = IntToColor(0xFF0000);
            TextArea.Styles[Style.Cpp.GlobalClass].ForeColor = IntToColor(0x48A8EE);

            TextArea.Lexer = Lexer.Cpp;

            TextArea.SetKeywords(0, "class extends implements import interface new case do while else if for in switch throw get set function var try catch finally while with default break continue delete return each const namespace package include use is as instanceof typeof author copy default deprecated eventType example exampleText exception haxe inheritDoc internal link mtasc mxmlc param private return see serial serialData serialField since throws usage version langversion playerversion productversion dynamic private public partial static intrinsic internal native override protected AS3 final super this arguments null Infinity NaN undefined true false abstract as base bool break by byte case catch char checked class const continue decimal default delegate do double descending explicit event extern else enum false finally fixed float for foreach from goto group if implicit in int interface internal into is lock long new null namespace object operator out override orderby params private protected public readonly ref return switch struct sbyte sealed short sizeof stackalloc static string select this throw true try typeof uint ulong unchecked unsafe ushort using var virtual volatile void while where yield");
            TextArea.SetKeywords(1, "void Null ArgumentError arguments Array Boolean Class Date DefinitionError Error EvalError Function int Math Namespace Number Object RangeError ReferenceError RegExp SecurityError String SyntaxError TypeError uint XML XMLList Boolean Byte Char DateTime Decimal Double Int16 Int32 Int64 IntPtr SByte Single UInt16 UInt32 UInt64 UIntPtr Void Path File System Windows Forms ScintillaNET");

        }
        private void InitColors()
        {

            TextArea.SetSelectionBackColor(true, IntToColor(0x114D9C));

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string code = TextArea.Text;
            new CodeView(code).Show();
        }

        private void btnViewPic_Click(object sender, EventArgs e)
        {
            new ImageView(this.File).Show();
        }

        /// <summary>
        /// auto fill the forn when double clicked on the listview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBugs_DoubleClick(object sender, EventArgs e)
        {
            int bugID = Convert.ToInt32(listBugs.FocusedItem.SubItems[1].Text);
            Console.WriteLine(bugID);

            DataTable dt = new BugController().GetBugDetail(bugID);

            String bugTitle = txtBugTitle.Text = dt.Rows[0].Field<String>("bugTitle");
            cmbProject.SelectedItem = dt.Rows[0].Field<String>("project");
           // int line = txtLine.Text = dt.Rows[0].Field<int>("line");
            int line = dt.Rows[0].Field<int>("line");
            txtLine.Text = line.ToString();
            String method = txtMethod.Text = dt.Rows[0].Field<String>("method");
            String bugClass = txtClass.Text = dt.Rows[0].Field<String>("class");
            String notes = txtNotes.Text = dt.Rows[0].Field<String>("notes");
            String code = TextArea.Text = dt.Rows[0].Field<String>("sourceCode");
            cmbPriority.SelectedItem= dt.Rows[0].Field<String>("priority");
            byte[] img = (byte[])dt.Rows[0][8];
            this.File = byteArrayToImage(img);
            picScreenshot.Image = this.File;
            
        }

        /// <summary>
        /// method to convert byte[] into image
        /// </summary>
        /// <param name="byteArrayIn"></param>
        /// <returns>img</returns>
        public Image byteArrayToImage(byte[] byteArrayIn)
        {

            System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
            Image img = (Image)converter.ConvertFrom(byteArrayIn);

            return img;
        }

        /// <summary>
        /// method to update the bugs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int bugID = Convert.ToInt32(listBugs.FocusedItem.SubItems[1].Text);

            String bugTitle = txtBugTitle.Text;
            String project = cmbProject.SelectedItem.ToString();
            String line = txtLine.Text;
            String method = txtMethod.Text;
            String bugClass = txtClass.Text;
            String notes = txtNotes.Text;
            String code = TextArea.Text;
            String priority = cmbPriority.SelectedItem.ToString();
            String date = DateTime.Now.ToString("yyyy-MM-dd");
            String reportedBy = this.email;

            Bug b = new Bug(bugID, bugTitle, project, line, method, bugClass, notes, code, this.File, priority, date, reportedBy);
            new BugController().UpdateBugs(b);
            loadData();
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
