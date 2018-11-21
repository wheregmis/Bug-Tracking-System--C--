namespace BugTrackingSystem.com.bugtracking.views.com.bugtracking.views.userpanel
{
    partial class BugDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BugDetail));
            this.txtClass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtMethod = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtLine = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBugTitle = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtComments = new System.Windows.Forms.RichTextBox();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.listHistory = new MaterialSkin.Controls.MaterialListView();
            this.btnResolve = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtSourceCode = new ScintillaNET.Scintilla();
            this.txtResolvedCode = new ScintillaNET.Scintilla();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.picScreenshot = new System.Windows.Forms.PictureBox();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picScreenshot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtClass
            // 
            this.txtClass.Depth = 0;
            this.txtClass.Hint = "";
            this.txtClass.Location = new System.Drawing.Point(187, 240);
            this.txtClass.MaxLength = 32767;
            this.txtClass.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtClass.Name = "txtClass";
            this.txtClass.PasswordChar = '\0';
            this.txtClass.SelectedText = "";
            this.txtClass.SelectionLength = 0;
            this.txtClass.SelectionStart = 0;
            this.txtClass.Size = new System.Drawing.Size(342, 28);
            this.txtClass.TabIndex = 74;
            this.txtClass.TabStop = false;
            this.txtClass.UseSystemPasswordChar = false;
            // 
            // txtMethod
            // 
            this.txtMethod.Depth = 0;
            this.txtMethod.Hint = "";
            this.txtMethod.Location = new System.Drawing.Point(187, 201);
            this.txtMethod.MaxLength = 32767;
            this.txtMethod.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.PasswordChar = '\0';
            this.txtMethod.SelectedText = "";
            this.txtMethod.SelectionLength = 0;
            this.txtMethod.SelectionStart = 0;
            this.txtMethod.Size = new System.Drawing.Size(342, 28);
            this.txtMethod.TabIndex = 73;
            this.txtMethod.TabStop = false;
            this.txtMethod.UseSystemPasswordChar = false;
            // 
            // txtLine
            // 
            this.txtLine.Depth = 0;
            this.txtLine.Hint = "";
            this.txtLine.Location = new System.Drawing.Point(187, 161);
            this.txtLine.MaxLength = 32767;
            this.txtLine.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLine.Name = "txtLine";
            this.txtLine.PasswordChar = '\0';
            this.txtLine.SelectedText = "";
            this.txtLine.SelectionLength = 0;
            this.txtLine.SelectionStart = 0;
            this.txtLine.Size = new System.Drawing.Size(342, 28);
            this.txtLine.TabIndex = 72;
            this.txtLine.TabStop = false;
            this.txtLine.UseSystemPasswordChar = false;
            // 
            // txtBugTitle
            // 
            this.txtBugTitle.Depth = 0;
            this.txtBugTitle.Hint = "";
            this.txtBugTitle.Location = new System.Drawing.Point(187, 82);
            this.txtBugTitle.MaxLength = 32767;
            this.txtBugTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBugTitle.Name = "txtBugTitle";
            this.txtBugTitle.PasswordChar = '\0';
            this.txtBugTitle.SelectedText = "";
            this.txtBugTitle.SelectionLength = 0;
            this.txtBugTitle.SelectionStart = 0;
            this.txtBugTitle.Size = new System.Drawing.Size(342, 28);
            this.txtBugTitle.TabIndex = 71;
            this.txtBugTitle.TabStop = false;
            this.txtBugTitle.UseSystemPasswordChar = false;
            // 
            // cmbProject
            // 
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(187, 120);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(260, 24);
            this.cmbProject.TabIndex = 70;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(187, 524);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(426, 48);
            this.txtNotes.TabIndex = 69;
            this.txtNotes.Text = "";
            // 
            // cmbPriority
            // 
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.cmbPriority.Location = new System.Drawing.Point(187, 288);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(260, 24);
            this.cmbPriority.TabIndex = 68;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(31, 288);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(70, 24);
            this.materialLabel11.TabIndex = 67;
            this.materialLabel11.Text = "Priority";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(31, 524);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(61, 24);
            this.materialLabel10.TabIndex = 65;
            this.materialLabel10.Text = "Notes";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(31, 374);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(117, 24);
            this.materialLabel5.TabIndex = 62;
            this.materialLabel5.Text = "Source Code";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(31, 244);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(57, 24);
            this.materialLabel6.TabIndex = 61;
            this.materialLabel6.Text = "Class";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(31, 205);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(75, 24);
            this.materialLabel3.TabIndex = 60;
            this.materialLabel3.Text = "Method";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(31, 165);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(75, 24);
            this.materialLabel4.TabIndex = 59;
            this.materialLabel4.Text = "Line No";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(31, 122);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(70, 24);
            this.materialLabel2.TabIndex = 58;
            this.materialLabel2.Text = "Project";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(31, 82);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(85, 24);
            this.materialLabel1.TabIndex = 57;
            this.materialLabel1.Text = "Bug Title";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(648, 400);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(137, 24);
            this.materialLabel7.TabIndex = 76;
            this.materialLabel7.Text = "Resolved Code";
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(803, 534);
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(448, 58);
            this.txtComments.TabIndex = 79;
            this.txtComments.Text = "";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(648, 536);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(103, 24);
            this.materialLabel12.TabIndex = 78;
            this.materialLabel12.Text = "Comments";
            // 
            // listHistory
            // 
            this.listHistory.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listHistory.Depth = 0;
            this.listHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.listHistory.FullRowSelect = true;
            this.listHistory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listHistory.Location = new System.Drawing.Point(803, 118);
            this.listHistory.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listHistory.MouseState = MaterialSkin.MouseState.OUT;
            this.listHistory.Name = "listHistory";
            this.listHistory.OwnerDraw = true;
            this.listHistory.Size = new System.Drawing.Size(448, 204);
            this.listHistory.TabIndex = 80;
            this.listHistory.UseCompatibleStateImageBehavior = false;
            this.listHistory.View = System.Windows.Forms.View.Details;
            this.listHistory.DoubleClick += new System.EventHandler(this.listHistory_DoubleClick);
            // 
            // btnResolve
            // 
            this.btnResolve.AutoSize = true;
            this.btnResolve.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnResolve.Depth = 0;
            this.btnResolve.Icon = null;
            this.btnResolve.Location = new System.Drawing.Point(1108, 646);
            this.btnResolve.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnResolve.Name = "btnResolve";
            this.btnResolve.Primary = true;
            this.btnResolve.Size = new System.Drawing.Size(143, 36);
            this.btnResolve.TabIndex = 83;
            this.btnResolve.Text = "Resolve Code";
            this.btnResolve.UseVisualStyleBackColor = true;
            this.btnResolve.Click += new System.EventHandler(this.btnResolve_Click);
            // 
            // txtSourceCode
            // 
            this.txtSourceCode.Location = new System.Drawing.Point(187, 329);
            this.txtSourceCode.Name = "txtSourceCode";
            this.txtSourceCode.Size = new System.Drawing.Size(426, 136);
            this.txtSourceCode.TabIndex = 86;
            // 
            // txtResolvedCode
            // 
            this.txtResolvedCode.Location = new System.Drawing.Point(803, 339);
            this.txtResolvedCode.Name = "txtResolvedCode";
            this.txtResolvedCode.Size = new System.Drawing.Size(448, 136);
            this.txtResolvedCode.TabIndex = 87;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(384, 474);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialFlatButton1.Size = new System.Drawing.Size(63, 36);
            this.materialFlatButton1.TabIndex = 88;
            this.materialFlatButton1.Text = "View";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Icon = null;
            this.materialFlatButton2.Location = new System.Drawing.Point(1021, 489);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(63, 36);
            this.materialFlatButton2.TabIndex = 89;
            this.materialFlatButton2.Text = "View";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(989, 82);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(71, 24);
            this.materialLabel8.TabIndex = 90;
            this.materialLabel8.Text = "History";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(31, 619);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(104, 24);
            this.materialLabel9.TabIndex = 91;
            this.materialLabel9.Text = "Screenshot";
            // 
            // picScreenshot
            // 
            this.picScreenshot.Location = new System.Drawing.Point(187, 578);
            this.picScreenshot.Name = "picScreenshot";
            this.picScreenshot.Size = new System.Drawing.Size(426, 75);
            this.picScreenshot.TabIndex = 92;
            this.picScreenshot.TabStop = false;
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Icon = null;
            this.materialFlatButton3.Location = new System.Drawing.Point(384, 662);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(63, 36);
            this.materialFlatButton3.TabIndex = 93;
            this.materialFlatButton3.Text = "View";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            this.materialFlatButton3.Click += new System.EventHandler(this.materialFlatButton3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1247, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 94;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // BugDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.materialFlatButton3);
            this.Controls.Add(this.picScreenshot);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.txtResolvedCode);
            this.Controls.Add(this.txtSourceCode);
            this.Controls.Add(this.btnResolve);
            this.Controls.Add(this.listHistory);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.materialLabel12);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.txtMethod);
            this.Controls.Add(this.txtLine);
            this.Controls.Add(this.txtBugTitle);
            this.Controls.Add(this.cmbProject);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.materialLabel11);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.MaximizeBox = false;
            this.Name = "BugDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BugDetail";
            this.Load += new System.EventHandler(this.BugDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picScreenshot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField txtClass;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMethod;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLine;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBugTitle;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.RichTextBox txtNotes;
        private System.Windows.Forms.ComboBox cmbPriority;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.RichTextBox txtComments;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialListView listHistory;
        private MaterialSkin.Controls.MaterialRaisedButton btnResolve;
        private ScintillaNET.Scintilla txtSourceCode;
        private ScintillaNET.Scintilla txtResolvedCode;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private System.Windows.Forms.PictureBox picScreenshot;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}