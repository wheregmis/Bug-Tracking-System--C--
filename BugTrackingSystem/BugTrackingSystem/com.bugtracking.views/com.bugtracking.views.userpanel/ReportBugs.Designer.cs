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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportBugs));
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
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
            this.listBugs = new MaterialSkin.Controls.MaterialListView();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.TextArea = new ScintillaNET.Scintilla();
            this.btnView = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnViewPic = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picScreenshot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(237, 295);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(406, 58);
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
            this.cmbPriority.Location = new System.Drawing.Point(237, 615);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(324, 24);
            this.cmbPriority.TabIndex = 49;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(37, 613);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(70, 24);
            this.materialLabel11.TabIndex = 48;
            this.materialLabel11.Text = "Priority";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(37, 295);
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
            this.materialLabel9.Location = new System.Drawing.Point(147, 539);
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
            this.btnReport.Location = new System.Drawing.Point(237, 672);
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
            this.materialLabel8.Location = new System.Drawing.Point(37, 539);
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
            this.materialLabel5.Location = new System.Drawing.Point(37, 381);
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
            this.materialLabel6.Location = new System.Drawing.Point(37, 256);
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
            this.materialLabel3.Location = new System.Drawing.Point(37, 217);
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
            this.materialLabel4.Location = new System.Drawing.Point(37, 177);
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
            this.materialLabel2.Location = new System.Drawing.Point(37, 134);
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
            this.materialLabel1.Location = new System.Drawing.Point(37, 94);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(85, 24);
            this.materialLabel1.TabIndex = 32;
            this.materialLabel1.Text = "Bug Title";
            // 
            // cmbProject
            // 
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(237, 132);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(324, 24);
            this.cmbProject.TabIndex = 51;
            // 
            // txtBugTitle
            // 
            this.txtBugTitle.Depth = 0;
            this.txtBugTitle.Hint = "";
            this.txtBugTitle.Location = new System.Drawing.Point(237, 94);
            this.txtBugTitle.MaxLength = 32767;
            this.txtBugTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBugTitle.Name = "txtBugTitle";
            this.txtBugTitle.PasswordChar = '\0';
            this.txtBugTitle.SelectedText = "";
            this.txtBugTitle.SelectionLength = 0;
            this.txtBugTitle.SelectionStart = 0;
            this.txtBugTitle.Size = new System.Drawing.Size(406, 28);
            this.txtBugTitle.TabIndex = 52;
            this.txtBugTitle.TabStop = false;
            this.txtBugTitle.UseSystemPasswordChar = false;
            // 
            // txtLine
            // 
            this.txtLine.Depth = 0;
            this.txtLine.Hint = "";
            this.txtLine.Location = new System.Drawing.Point(237, 173);
            this.txtLine.MaxLength = 32767;
            this.txtLine.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLine.Name = "txtLine";
            this.txtLine.PasswordChar = '\0';
            this.txtLine.SelectedText = "";
            this.txtLine.SelectionLength = 0;
            this.txtLine.SelectionStart = 0;
            this.txtLine.Size = new System.Drawing.Size(406, 28);
            this.txtLine.TabIndex = 53;
            this.txtLine.TabStop = false;
            this.txtLine.UseSystemPasswordChar = false;
            // 
            // txtMethod
            // 
            this.txtMethod.Depth = 0;
            this.txtMethod.Hint = "";
            this.txtMethod.Location = new System.Drawing.Point(237, 213);
            this.txtMethod.MaxLength = 32767;
            this.txtMethod.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.PasswordChar = '\0';
            this.txtMethod.SelectedText = "";
            this.txtMethod.SelectionLength = 0;
            this.txtMethod.SelectionStart = 0;
            this.txtMethod.Size = new System.Drawing.Size(406, 28);
            this.txtMethod.TabIndex = 54;
            this.txtMethod.TabStop = false;
            this.txtMethod.UseSystemPasswordChar = false;
            // 
            // txtClass
            // 
            this.txtClass.Depth = 0;
            this.txtClass.Hint = "";
            this.txtClass.Location = new System.Drawing.Point(237, 252);
            this.txtClass.MaxLength = 32767;
            this.txtClass.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtClass.Name = "txtClass";
            this.txtClass.PasswordChar = '\0';
            this.txtClass.SelectedText = "";
            this.txtClass.SelectionLength = 0;
            this.txtClass.SelectionStart = 0;
            this.txtClass.Size = new System.Drawing.Size(406, 28);
            this.txtClass.TabIndex = 55;
            this.txtClass.TabStop = false;
            this.txtClass.UseSystemPasswordChar = false;
            // 
            // picScreenshot
            // 
            this.picScreenshot.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.picScreenshot.Location = new System.Drawing.Point(237, 495);
            this.picScreenshot.Name = "picScreenshot";
            this.picScreenshot.Size = new System.Drawing.Size(406, 76);
            this.picScreenshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picScreenshot.TabIndex = 56;
            this.picScreenshot.TabStop = false;
            // 
            // listBugs
            // 
            this.listBugs.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBugs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBugs.Depth = 0;
            this.listBugs.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.listBugs.FullRowSelect = true;
            this.listBugs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listBugs.Location = new System.Drawing.Point(695, 149);
            this.listBugs.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listBugs.MouseState = MaterialSkin.MouseState.OUT;
            this.listBugs.Name = "listBugs";
            this.listBugs.OwnerDraw = true;
            this.listBugs.Size = new System.Drawing.Size(542, 538);
            this.listBugs.TabIndex = 57;
            this.listBugs.UseCompatibleStateImageBehavior = false;
            this.listBugs.View = System.Windows.Forms.View.Details;
            this.listBugs.DoubleClick += new System.EventHandler(this.listBugs_DoubleClick);
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
            // TextArea
            // 
            this.TextArea.Location = new System.Drawing.Point(237, 359);
            this.TextArea.Name = "TextArea";
            this.TextArea.Size = new System.Drawing.Size(406, 82);
            this.TextArea.TabIndex = 60;
            this.TextArea.TextChanged += new System.EventHandler(this.TextArea_TextChanged);
            // 
            // btnView
            // 
            this.btnView.AutoSize = true;
            this.btnView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnView.Depth = 0;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Icon = null;
            this.btnView.Location = new System.Drawing.Point(571, 450);
            this.btnView.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnView.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnView.Name = "btnView";
            this.btnView.Primary = false;
            this.btnView.Size = new System.Drawing.Size(63, 36);
            this.btnView.TabIndex = 61;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnViewPic
            // 
            this.btnViewPic.AutoSize = true;
            this.btnViewPic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnViewPic.Depth = 0;
            this.btnViewPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPic.Icon = null;
            this.btnViewPic.Location = new System.Drawing.Point(571, 580);
            this.btnViewPic.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnViewPic.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnViewPic.Name = "btnViewPic";
            this.btnViewPic.Primary = false;
            this.btnViewPic.Size = new System.Drawing.Size(63, 36);
            this.btnViewPic.TabIndex = 62;
            this.btnViewPic.Text = "View";
            this.btnViewPic.UseVisualStyleBackColor = true;
            this.btnViewPic.Click += new System.EventHandler(this.btnViewPic_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdate.Depth = 0;
            this.btnUpdate.Icon = null;
            this.btnUpdate.Location = new System.Drawing.Point(519, 672);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Primary = true;
            this.btnUpdate.Size = new System.Drawing.Size(125, 36);
            this.btnUpdate.TabIndex = 63;
            this.btnUpdate.Text = "Update Bug";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1248, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 64;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // ReportBugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnViewPic);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.TextArea);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.listBugs);
            this.Controls.Add(this.picScreenshot);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.txtMethod);
            this.Controls.Add(this.txtLine);
            this.Controls.Add(this.txtBugTitle);
            this.Controls.Add(this.cmbProject);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.materialLabel11);
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
            this.Load += new System.EventHandler(this.ReportBugs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picScreenshot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtNotes;
        private System.Windows.Forms.ComboBox cmbPriority;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
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
        private MaterialSkin.Controls.MaterialListView listBugs;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private ScintillaNET.Scintilla TextArea;
        private MaterialSkin.Controls.MaterialFlatButton btnView;
        private MaterialSkin.Controls.MaterialFlatButton btnViewPic;
        private MaterialSkin.Controls.MaterialRaisedButton btnUpdate;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}