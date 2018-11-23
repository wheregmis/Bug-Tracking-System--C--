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
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WrapMode = ScintillaNET.WrapMode;

namespace BugTrackingSystem.com.bugtracking.views.com.bugtracking.views.userpanel
{
    public partial class BugDetail : MaterialForm
    {
        int bugID, bugFixID;
        String email, reportedBy, status, userRole;
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
            btnStatus.Visible = false;
            radioWorked.Visible = false;
            radioNotWork.Visible = false;
            loadData(bugID);
            fillComb();
            txtBugTitle.Enabled = false;

            DataTable dt = new UserController().GetUserDetails(email);
            this.userRole = dt.Rows[0].Field<String>("userRole");

            //if the user is tester he will not be able to resolve the problem so
            if (userRole == "Tester") {
                btnResolve.Visible = false;
            }

        }

        //method to fill the projects in combobox
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
            // BASIC CONFIG
            // TextArea.Dock = System.Windows.Forms.DockStyle.Fill;
            txtSourceCode.TextChanged += (this.OnTextChanged);
            txtResolvedCode.TextChanged += (this.OnTextChanged);

            //    // INITIAL VIEW CONFIG
            txtSourceCode.WrapMode = WrapMode.None;
            txtSourceCode.IndentationGuides = IndentView.LookBoth;
            txtResolvedCode.WrapMode = WrapMode.None;
            txtResolvedCode.IndentationGuides = IndentView.LookBoth;

            //    // STYLING
            InitColors();
            InitSyntaxColoring();

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
            this.reportedBy = txtNotes.Text = dt.Rows[0].Field<String>("reportedBy");

            //if the user is the one who reported the bug he cant resolve the issue
            if (this.reportedBy == this.email) {
                btnResolve.Visible = false;
               
            }
            
}

        //loading the bug fixes in the listview
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

        /// <summary>
        /// converts byte[] to image
        /// </summary>
        /// <param name="byteArrayIn"></param>
        /// <returns>image file</returns>
        public Image byteArrayToImage(byte[] byteArrayIn)
        {

            System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
            Image img = (Image)converter.ConvertFrom(byteArrayIn);

            return img;
        }

        /// <summary>
        /// filling the resolved code when double clicked on the listview showing history
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listHistory_DoubleClick(object sender, EventArgs e)
        {
            radioWorked.Checked = false;
            radioNotWork.Checked = false;
            int bugfixesID = Convert.ToInt32(listHistory.FocusedItem.SubItems[2].Text);
            DataTable df = new BugFixesController().GetBugFixes(bugfixesID);
            if (df.Rows.Count > 0)
            {
                this.bugFixID = df.Rows[0].Field<int>("bugfixesID");
                String resolveCode = txtResolvedCode.Text = df.Rows[0].Field<String>("bugFix");
                String comments = txtComments.Text = df.Rows[0].Field<String>("comments");
                 this.status = df.Rows[0].Field<String>("fixStatus");
            }
            // initializing the radiobuttons
            radioWorked.Visible = true;
            radioNotWork.Visible = true;
            radioWorked.Checked = false;
            radioNotWork.Checked = false;
           

            if (this.status == "It Worked")
            {
                radioWorked.Checked = true;

            }
            if (this.status == "It Doesnt Work")
            {
                radioNotWork.Checked = true;

            }

            //if the user is the one who reported the bug he will be able to update the status of bug fixes if it worked or not
            if (reportedBy == this.email)
                {

                btnStatus.Visible = true;
                 
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

        /// <summary>
        /// method to insert the fix of the bug in the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            this.Hide();
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
            //Configuring for Source Code
            // Configure the default style
            txtSourceCode.StyleResetDefault();
            txtSourceCode.Styles[Style.Default].Font = "Consolas";
            txtSourceCode.Styles[Style.Default].Size = 10;
            txtSourceCode.Styles[Style.Default].BackColor = IntToColor(0x212121);
            txtSourceCode.Styles[Style.Default].ForeColor = IntToColor(0xFFFFFF);
            txtSourceCode.StyleClearAll();

            // Configure the CPP (C#) lexer styles
            txtSourceCode.Styles[Style.Cpp.Identifier].ForeColor = IntToColor(0xD0DAE2);
            txtSourceCode.Styles[Style.Cpp.Comment].ForeColor = IntToColor(0xBD758B);
            txtSourceCode.Styles[Style.Cpp.CommentLine].ForeColor = IntToColor(0x40BF57);
            txtSourceCode.Styles[Style.Cpp.CommentDoc].ForeColor = IntToColor(0x2FAE35);
            txtSourceCode.Styles[Style.Cpp.Number].ForeColor = IntToColor(0xFFFF00);
            txtSourceCode.Styles[Style.Cpp.String].ForeColor = IntToColor(0xFFFF00);
            txtSourceCode.Styles[Style.Cpp.Character].ForeColor = IntToColor(0xE95454);
            txtSourceCode.Styles[Style.Cpp.Preprocessor].ForeColor = IntToColor(0x8AAFEE);
            txtSourceCode.Styles[Style.Cpp.Operator].ForeColor = IntToColor(0xE0E0E0);
            txtSourceCode.Styles[Style.Cpp.Regex].ForeColor = IntToColor(0xff00ff);
            txtSourceCode.Styles[Style.Cpp.CommentLineDoc].ForeColor = IntToColor(0x77A7DB);
            txtSourceCode.Styles[Style.Cpp.Word].ForeColor = IntToColor(0x48A8EE);
            txtSourceCode.Styles[Style.Cpp.Word2].ForeColor = IntToColor(0xF98906);
            txtSourceCode.Styles[Style.Cpp.CommentDocKeyword].ForeColor = IntToColor(0xB3D991);
            txtSourceCode.Styles[Style.Cpp.CommentDocKeywordError].ForeColor = IntToColor(0xFF0000);
            txtSourceCode.Styles[Style.Cpp.GlobalClass].ForeColor = IntToColor(0x48A8EE);

            txtSourceCode.Lexer = Lexer.Cpp;

            txtSourceCode.SetKeywords(0, "class extends implements import interface new case do while else if for in switch throw get set function var try catch finally while with default break continue delete return each const namespace package include use is as instanceof typeof author copy default deprecated eventType example exampleText exception haxe inheritDoc internal link mtasc mxmlc param private return see serial serialData serialField since throws usage version langversion playerversion productversion dynamic private public partial static intrinsic internal native override protected AS3 final super this arguments null Infinity NaN undefined true false abstract as base bool break by byte case catch char checked class const continue decimal default delegate do double descending explicit event extern else enum false finally fixed float for foreach from goto group if implicit in int interface internal into is lock long new null namespace object operator out override orderby params private protected public readonly ref return switch struct sbyte sealed short sizeof stackalloc static string select this throw true try typeof uint ulong unchecked unsafe ushort using var virtual volatile void while where yield");
            txtSourceCode.SetKeywords(1, "void Null ArgumentError arguments Array Boolean Class Date DefinitionError Error EvalError Function int Math Namespace Number Object RangeError ReferenceError RegExp SecurityError String SyntaxError TypeError uint XML XMLList Boolean Byte Char DateTime Decimal Double Int16 Int32 Int64 IntPtr SByte Single UInt16 UInt32 UInt64 UIntPtr Void Path File System Windows Forms ScintillaNET");



            //Configuring for Resolved Code

            // Configure the default style
            txtResolvedCode.StyleResetDefault();
            txtResolvedCode.Styles[Style.Default].Font = "Consolas";
            txtResolvedCode.Styles[Style.Default].Size = 10;
            txtResolvedCode.Styles[Style.Default].BackColor = IntToColor(0x212121);
            txtResolvedCode.Styles[Style.Default].ForeColor = IntToColor(0xFFFFFF);
            txtResolvedCode.StyleClearAll();

            // Configure the CPP (C#) lexer styles
            txtResolvedCode.Styles[Style.Cpp.Identifier].ForeColor = IntToColor(0xD0DAE2);
            txtResolvedCode.Styles[Style.Cpp.Comment].ForeColor = IntToColor(0xBD758B);
            txtResolvedCode.Styles[Style.Cpp.CommentLine].ForeColor = IntToColor(0x40BF57);
            txtResolvedCode.Styles[Style.Cpp.CommentDoc].ForeColor = IntToColor(0x2FAE35);
            txtResolvedCode.Styles[Style.Cpp.Number].ForeColor = IntToColor(0xFFFF00);
            txtResolvedCode.Styles[Style.Cpp.String].ForeColor = IntToColor(0xFFFF00);
            txtResolvedCode.Styles[Style.Cpp.Character].ForeColor = IntToColor(0xE95454);
            txtResolvedCode.Styles[Style.Cpp.Preprocessor].ForeColor = IntToColor(0x8AAFEE);
            txtResolvedCode.Styles[Style.Cpp.Operator].ForeColor = IntToColor(0xE0E0E0);
            txtResolvedCode.Styles[Style.Cpp.Regex].ForeColor = IntToColor(0xff00ff);
            txtResolvedCode.Styles[Style.Cpp.CommentLineDoc].ForeColor = IntToColor(0x77A7DB);
            txtResolvedCode.Styles[Style.Cpp.Word].ForeColor = IntToColor(0x48A8EE);
            txtResolvedCode.Styles[Style.Cpp.Word2].ForeColor = IntToColor(0xF98906);
            txtResolvedCode.Styles[Style.Cpp.CommentDocKeyword].ForeColor = IntToColor(0xB3D991);
            txtResolvedCode.Styles[Style.Cpp.CommentDocKeywordError].ForeColor = IntToColor(0xFF0000);
            txtResolvedCode.Styles[Style.Cpp.GlobalClass].ForeColor = IntToColor(0x48A8EE);

            txtResolvedCode.Lexer = Lexer.Cpp;

            txtResolvedCode.SetKeywords(0, "class extends implements import interface new case do while else if for in switch throw get set function var try catch finally while with default break continue delete return each const namespace package include use is as instanceof typeof author copy default deprecated eventType example exampleText exception haxe inheritDoc internal link mtasc mxmlc param private return see serial serialData serialField since throws usage version langversion playerversion productversion dynamic private public partial static intrinsic internal native override protected AS3 final super this arguments null Infinity NaN undefined true false abstract as base bool break by byte case catch char checked class const continue decimal default delegate do double descending explicit event extern else enum false finally fixed float for foreach from goto group if implicit in int interface internal into is lock long new null namespace object operator out override orderby params private protected public readonly ref return switch struct sbyte sealed short sizeof stackalloc static string select this throw true try typeof uint ulong unchecked unsafe ushort using var virtual volatile void while where yield");
            txtResolvedCode.SetKeywords(1, "void Null ArgumentError arguments Array Boolean Class Date DefinitionError Error EvalError Function int Math Namespace Number Object RangeError ReferenceError RegExp SecurityError String SyntaxError TypeError uint XML XMLList Boolean Byte Char DateTime Decimal Double Int16 Int32 Int64 IntPtr SByte Single UInt16 UInt32 UInt64 UIntPtr Void Path File System Windows Forms ScintillaNET");

        }

        /// <summary>
        /// if the bugfix status was set to it worked and submitted, the status of bug will be updated to fixed from on progress
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStatus_Click(object sender, EventArgs e)
        {

            var checkedButton = Controls.OfType<RadioButton>()
                                       .FirstOrDefault(r => r.Checked);
            String fixStatus = checkedButton.Text;
            MessageBox.Show(fixStatus);
            new BugFixesController().UpdateFixes(this.bugFixID, fixStatus);
            if (fixStatus == "It Worked") {
                new BugController().UpdateStatus(this.bugID);
            }
        }

        private void InitColors()
        {

            txtSourceCode.SetSelectionBackColor(true, IntToColor(0x114D9C));
            txtResolvedCode.SetSelectionBackColor(true, IntToColor(0x114D9C));

        }
    }
}
