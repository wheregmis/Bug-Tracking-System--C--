namespace BugTrackingSystem.com.bugtracking.views.com.bugtracking.views.userpanel
{
    partial class UserDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new MaterialSkin.Controls.MaterialRaisedButton();
            this.listBugs = new MaterialSkin.Controls.MaterialListView();
            this.btnReport = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtMethod = new System.Windows.Forms.TextBox();
            this.txtLine = new System.Windows.Forms.TextBox();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.txtBugTitle = new System.Windows.Forms.TextBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSourceCode = new System.Windows.Forms.RichTextBox();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AutoSize = true;
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.Depth = 0;
            this.btnClose.Icon = null;
            this.btnClose.Location = new System.Drawing.Point(1337, 22);
            this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.Primary = true;
            this.btnClose.Size = new System.Drawing.Size(33, 36);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // listBugs
            // 
            this.listBugs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBugs.Depth = 0;
            this.listBugs.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.listBugs.FullRowSelect = true;
            this.listBugs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listBugs.Location = new System.Drawing.Point(709, 75);
            this.listBugs.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listBugs.MouseState = MaterialSkin.MouseState.OUT;
            this.listBugs.Name = "listBugs";
            this.listBugs.OwnerDraw = true;
            this.listBugs.Size = new System.Drawing.Size(645, 326);
            this.listBugs.TabIndex = 21;
            this.listBugs.UseCompatibleStateImageBehavior = false;
            this.listBugs.View = System.Windows.Forms.View.Details;
            this.listBugs.SelectedIndexChanged += new System.EventHandler(this.listUser_SelectedIndexChanged);
            // 
            // btnReport
            // 
            this.btnReport.AutoSize = true;
            this.btnReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReport.Depth = 0;
            this.btnReport.Icon = null;
            this.btnReport.Location = new System.Drawing.Point(316, 678);
            this.btnReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReport.Name = "btnReport";
            this.btnReport.Primary = true;
            this.btnReport.Size = new System.Drawing.Size(124, 36);
            this.btnReport.TabIndex = 19;
            this.btnReport.Text = "Report Bug";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(221, 220);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(308, 22);
            this.txtClass.TabIndex = 9;
            // 
            // txtMethod
            // 
            this.txtMethod.Location = new System.Drawing.Point(221, 181);
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.Size = new System.Drawing.Size(308, 22);
            this.txtMethod.TabIndex = 7;
            // 
            // txtLine
            // 
            this.txtLine.Location = new System.Drawing.Point(221, 141);
            this.txtLine.Name = "txtLine";
            this.txtLine.Size = new System.Drawing.Size(308, 22);
            this.txtLine.TabIndex = 5;
            // 
            // txtProject
            // 
            this.txtProject.Location = new System.Drawing.Point(221, 98);
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(308, 22);
            this.txtProject.TabIndex = 3;
            // 
            // txtBugTitle
            // 
            this.txtBugTitle.Location = new System.Drawing.Point(221, 58);
            this.txtBugTitle.Name = "txtBugTitle";
            this.txtBugTitle.Size = new System.Drawing.Size(308, 22);
            this.txtBugTitle.TabIndex = 1;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(21, 515);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(104, 24);
            this.materialLabel8.TabIndex = 12;
            this.materialLabel8.Text = "Screenshot";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(21, 343);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(117, 24);
            this.materialLabel5.TabIndex = 10;
            this.materialLabel5.Text = "Source Code";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(21, 218);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(57, 24);
            this.materialLabel6.TabIndex = 8;
            this.materialLabel6.Text = "Class";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(21, 179);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(75, 24);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Method";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(21, 139);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(75, 24);
            this.materialLabel4.TabIndex = 4;
            this.materialLabel4.Text = "Line No";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(21, 96);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(70, 24);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Project";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(21, 56);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(85, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Bug Title";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Location = new System.Drawing.Point(4, 59);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(10);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage3.Size = new System.Drawing.Size(1422, 511);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Resolve Bugs";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(1590, -9);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(33, 36);
            this.materialRaisedButton1.TabIndex = 4;
            this.materialRaisedButton1.Text = "x";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtNotes);
            this.tabPage1.Controls.Add(this.cmbPriority);
            this.tabPage1.Controls.Add(this.materialLabel11);
            this.tabPage1.Controls.Add(this.txtSourceCode);
            this.tabPage1.Controls.Add(this.materialLabel10);
            this.tabPage1.Controls.Add(this.materialLabel9);
            this.tabPage1.Controls.Add(this.materialLabel7);
            this.tabPage1.Controls.Add(this.listBugs);
            this.tabPage1.Controls.Add(this.btnReport);
            this.tabPage1.Controls.Add(this.txtClass);
            this.tabPage1.Controls.Add(this.txtMethod);
            this.tabPage1.Controls.Add(this.txtLine);
            this.tabPage1.Controls.Add(this.txtProject);
            this.tabPage1.Controls.Add(this.txtBugTitle);
            this.tabPage1.Controls.Add(this.materialLabel8);
            this.tabPage1.Controls.Add(this.materialLabel5);
            this.tabPage1.Controls.Add(this.materialLabel6);
            this.tabPage1.Controls.Add(this.materialLabel3);
            this.tabPage1.Controls.Add(this.materialLabel4);
            this.tabPage1.Controls.Add(this.materialLabel2);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 59);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1422, 790);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Report Bugs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(312, 515);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(135, 24);
            this.materialLabel9.TabIndex = 25;
            this.materialLabel9.Text = "-- Select Image";
            this.materialLabel9.Click += new System.EventHandler(this.materialLabel9_Click);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(955, 22);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(122, 24);
            this.materialLabel7.TabIndex = 23;
            this.materialLabel7.Text = "Your Bug List";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 90);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(20, 20, 50, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(20, 20);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1430, 853);
            this.tabControl1.TabIndex = 3;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(21, 257);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(61, 24);
            this.materialLabel10.TabIndex = 26;
            this.materialLabel10.Text = "Notes";
            // 
            // txtSourceCode
            // 
            this.txtSourceCode.Location = new System.Drawing.Point(221, 335);
            this.txtSourceCode.Name = "txtSourceCode";
            this.txtSourceCode.Size = new System.Drawing.Size(308, 155);
            this.txtSourceCode.TabIndex = 28;
            this.txtSourceCode.Text = "";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(21, 579);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(70, 24);
            this.materialLabel11.TabIndex = 29;
            this.materialLabel11.Text = "Priority";
            // 
            // cmbPriority
            // 
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.cmbPriority.Location = new System.Drawing.Point(221, 579);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(308, 24);
            this.cmbPriority.TabIndex = 30;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(221, 257);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(308, 58);
            this.txtNotes.TabIndex = 31;
            this.txtNotes.Text = "";
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 945);
            this.ControlBox = false;
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnClose);
            this.Name = "UserDashboard";
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton btnClose;
        private MaterialSkin.Controls.MaterialListView listBugs;
        private MaterialSkin.Controls.MaterialRaisedButton btnReport;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtMethod;
        private System.Windows.Forms.TextBox txtLine;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.TextBox txtBugTitle;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private System.Windows.Forms.RichTextBox txtSourceCode;
        private System.Windows.Forms.ComboBox cmbPriority;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private System.Windows.Forms.RichTextBox txtNotes;
    }
}