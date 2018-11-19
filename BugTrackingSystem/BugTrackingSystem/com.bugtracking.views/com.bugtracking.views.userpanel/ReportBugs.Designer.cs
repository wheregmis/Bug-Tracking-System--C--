namespace BugTrackingSystem.com.bugtracking.views.com.bugtracking.views.userpanel
{
    partial class ReportBugs
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
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSourceCode = new System.Windows.Forms.RichTextBox();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.btnReport = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.txtBugTitle = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtLine = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtMethod = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtClass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.picScreenshot = new System.Windows.Forms.PictureBox();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.btnDetail = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.picScreenshot)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(237, 310);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(308, 58);
            this.txtNotes.TabIndex = 50;
            this.txtNotes.Text = "";
            // 
            // cmbPriority
            // 
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.cmbPriority.Location = new System.Drawing.Point(237, 606);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(308, 24);
            this.cmbPriority.TabIndex = 49;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(37, 606);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(70, 24);
            this.materialLabel11.TabIndex = 48;
            this.materialLabel11.Text = "Priority";
            // 
            // txtSourceCode
            // 
            this.txtSourceCode.Location = new System.Drawing.Point(237, 374);
            this.txtSourceCode.Name = "txtSourceCode";
            this.txtSourceCode.Size = new System.Drawing.Size(308, 113);
            this.txtSourceCode.TabIndex = 47;
            this.txtSourceCode.Text = "";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(37, 310);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(61, 24);
            this.materialLabel10.TabIndex = 46;
            this.materialLabel10.Text = "Notes";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(147, 554);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(82, 24);
            this.materialLabel9.TabIndex = 45;
            this.materialLabel9.Text = "-- Select ";
            this.materialLabel9.Click += new System.EventHandler(this.materialLabel9_Click);
            // 
            // btnReport
            // 
            this.btnReport.AutoSize = true;
            this.btnReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReport.Depth = 0;
            this.btnReport.Icon = null;
            this.btnReport.Location = new System.Drawing.Point(332, 651);
            this.btnReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReport.Name = "btnReport";
            this.btnReport.Primary = true;
            this.btnReport.Size = new System.Drawing.Size(124, 36);
            this.btnReport.TabIndex = 44;
            this.btnReport.Text = "Report Bug";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(37, 554);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(104, 24);
            this.materialLabel8.TabIndex = 43;
            this.materialLabel8.Text = "Screenshot";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(37, 396);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(117, 24);
            this.materialLabel5.TabIndex = 42;
            this.materialLabel5.Text = "Source Code";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(37, 271);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(57, 24);
            this.materialLabel6.TabIndex = 40;
            this.materialLabel6.Text = "Class";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(37, 232);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(75, 24);
            this.materialLabel3.TabIndex = 38;
            this.materialLabel3.Text = "Method";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(37, 192);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(75, 24);
            this.materialLabel4.TabIndex = 36;
            this.materialLabel4.Text = "Line No";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(37, 149);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(70, 24);
            this.materialLabel2.TabIndex = 34;
            this.materialLabel2.Text = "Project";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(37, 109);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(85, 24);
            this.materialLabel1.TabIndex = 32;
            this.materialLabel1.Text = "Bug Title";
            // 
            // cmbProject
            // 
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(237, 147);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(308, 24);
            this.cmbProject.TabIndex = 51;
            // 
            // txtBugTitle
            // 
            this.txtBugTitle.Depth = 0;
            this.txtBugTitle.Hint = "";
            this.txtBugTitle.Location = new System.Drawing.Point(237, 109);
            this.txtBugTitle.MaxLength = 32767;
            this.txtBugTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBugTitle.Name = "txtBugTitle";
            this.txtBugTitle.PasswordChar = '\0';
            this.txtBugTitle.SelectedText = "";
            this.txtBugTitle.SelectionLength = 0;
            this.txtBugTitle.SelectionStart = 0;
            this.txtBugTitle.Size = new System.Drawing.Size(308, 28);
            this.txtBugTitle.TabIndex = 52;
            this.txtBugTitle.TabStop = false;
            this.txtBugTitle.UseSystemPasswordChar = false;
            // 
            // txtLine
            // 
            this.txtLine.Depth = 0;
            this.txtLine.Hint = "";
            this.txtLine.Location = new System.Drawing.Point(237, 188);
            this.txtLine.MaxLength = 32767;
            this.txtLine.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLine.Name = "txtLine";
            this.txtLine.PasswordChar = '\0';
            this.txtLine.SelectedText = "";
            this.txtLine.SelectionLength = 0;
            this.txtLine.SelectionStart = 0;
            this.txtLine.Size = new System.Drawing.Size(308, 28);
            this.txtLine.TabIndex = 53;
            this.txtLine.TabStop = false;
            this.txtLine.UseSystemPasswordChar = false;
            // 
            // txtMethod
            // 
            this.txtMethod.Depth = 0;
            this.txtMethod.Hint = "";
            this.txtMethod.Location = new System.Drawing.Point(237, 228);
            this.txtMethod.MaxLength = 32767;
            this.txtMethod.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.PasswordChar = '\0';
            this.txtMethod.SelectedText = "";
            this.txtMethod.SelectionLength = 0;
            this.txtMethod.SelectionStart = 0;
            this.txtMethod.Size = new System.Drawing.Size(308, 28);
            this.txtMethod.TabIndex = 54;
            this.txtMethod.TabStop = false;
            this.txtMethod.UseSystemPasswordChar = false;
            // 
            // txtClass
            // 
            this.txtClass.Depth = 0;
            this.txtClass.Hint = "";
            this.txtClass.Location = new System.Drawing.Point(237, 267);
            this.txtClass.MaxLength = 32767;
            this.txtClass.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtClass.Name = "txtClass";
            this.txtClass.PasswordChar = '\0';
            this.txtClass.SelectedText = "";
            this.txtClass.SelectionLength = 0;
            this.txtClass.SelectionStart = 0;
            this.txtClass.Size = new System.Drawing.Size(308, 28);
            this.txtClass.TabIndex = 55;
            this.txtClass.TabStop = false;
            this.txtClass.UseSystemPasswordChar = false;
            // 
            // picScreenshot
            // 
            this.picScreenshot.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.picScreenshot.Location = new System.Drawing.Point(237, 493);
            this.picScreenshot.Name = "picScreenshot";
            this.picScreenshot.Size = new System.Drawing.Size(308, 107);
            this.picScreenshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picScreenshot.TabIndex = 56;
            this.picScreenshot.TabStop = false;
            // 
            // materialListView1
            // 
            this.materialListView1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView1.Location = new System.Drawing.Point(599, 149);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(638, 538);
            this.materialListView1.TabIndex = 57;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(867, 109);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(132, 24);
            this.materialLabel7.TabIndex = 58;
            this.materialLabel7.Text = "Your Bug Lists";
            // 
            // btnDetail
            // 
            this.btnDetail.AutoSize = true;
            this.btnDetail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDetail.Depth = 0;
            this.btnDetail.Icon = null;
            this.btnDetail.Location = new System.Drawing.Point(41, 662);
            this.btnDetail.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Primary = true;
            this.btnDetail.Size = new System.Drawing.Size(117, 36);
            this.btnDetail.TabIndex = 59;
            this.btnDetail.Text = "bug Detail";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // ReportBugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialListView1);
            this.Controls.Add(this.picScreenshot);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.txtMethod);
            this.Controls.Add(this.txtLine);
            this.Controls.Add(this.txtBugTitle);
            this.Controls.Add(this.cmbProject);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.materialLabel11);
            this.Controls.Add(this.txtSourceCode);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "ReportBugs";
            ((System.ComponentModel.ISupportInitialize)(this.picScreenshot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtNotes;
        private System.Windows.Forms.ComboBox cmbPriority;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private System.Windows.Forms.RichTextBox txtSourceCode;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialRaisedButton btnReport;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ComboBox cmbProject;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBugTitle;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLine;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMethod;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtClass;
        private System.Windows.Forms.PictureBox picScreenshot;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialRaisedButton btnDetail;
    }
}