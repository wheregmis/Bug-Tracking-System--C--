namespace BugTrackingSystem.com.bugtracking.views.com.bugtracking.views.adminpanel
{
    partial class ManageProjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageProjects));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtProjectName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.listProjects = new MaterialSkin.Controls.MaterialListView();
            this.btnEmpty = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.menubar = new System.Windows.Forms.MenuStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bugsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.menubar.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(68, 153);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(126, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Project Name";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Depth = 0;
            this.txtProjectName.Hint = "";
            this.txtProjectName.Location = new System.Drawing.Point(260, 153);
            this.txtProjectName.MaxLength = 32767;
            this.txtProjectName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.PasswordChar = '\0';
            this.txtProjectName.SelectedText = "";
            this.txtProjectName.SelectionLength = 0;
            this.txtProjectName.SelectionStart = 0;
            this.txtProjectName.Size = new System.Drawing.Size(303, 28);
            this.txtProjectName.TabIndex = 1;
            this.txtProjectName.TabStop = false;
            this.txtProjectName.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(68, 280);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(92, 24);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Start Date";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(68, 403);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(85, 24);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "End Date";
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(260, 280);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(303, 22);
            this.startDate.TabIndex = 5;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(260, 405);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(303, 22);
            this.endDate.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(455, 529);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(58, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 56;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(280, 529);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 55;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(112, 529);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Depth = 0;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(402, 585);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Primary = true;
            this.btnDelete.Size = new System.Drawing.Size(161, 36);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.Text = "Delete Project";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdate.Depth = 0;
            this.btnUpdate.Icon = null;
            this.btnUpdate.Location = new System.Drawing.Point(218, 585);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Primary = true;
            this.btnUpdate.Size = new System.Drawing.Size(166, 36);
            this.btnUpdate.TabIndex = 52;
            this.btnUpdate.Text = "Update Project";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Depth = 0;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(65, 585);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Primary = true;
            this.btnAdd.Size = new System.Drawing.Size(135, 36);
            this.btnAdd.TabIndex = 51;
            this.btnAdd.Text = "Add Project";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listProjects
            // 
            this.listProjects.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listProjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listProjects.Depth = 0;
            this.listProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.listProjects.FullRowSelect = true;
            this.listProjects.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listProjects.Location = new System.Drawing.Point(590, 153);
            this.listProjects.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listProjects.MouseState = MaterialSkin.MouseState.OUT;
            this.listProjects.Name = "listProjects";
            this.listProjects.OwnerDraw = true;
            this.listProjects.Size = new System.Drawing.Size(661, 468);
            this.listProjects.TabIndex = 57;
            this.listProjects.UseCompatibleStateImageBehavior = false;
            this.listProjects.View = System.Windows.Forms.View.Details;
            this.listProjects.DoubleClick += new System.EventHandler(this.listProjects_DoubleClick);
            // 
            // btnEmpty
            // 
            this.btnEmpty.AutoSize = true;
            this.btnEmpty.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEmpty.Depth = 0;
            this.btnEmpty.Icon = null;
            this.btnEmpty.Location = new System.Drawing.Point(218, 652);
            this.btnEmpty.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEmpty.Name = "btnEmpty";
            this.btnEmpty.Primary = true;
            this.btnEmpty.Size = new System.Drawing.Size(181, 36);
            this.btnEmpty.TabIndex = 58;
            this.btnEmpty.Text = "Make Form Empty";
            this.btnEmpty.UseVisualStyleBackColor = true;
            this.btnEmpty.Click += new System.EventHandler(this.btnEmpty_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1248, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 59;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // menubar
            // 
            this.menubar.AutoSize = false;
            this.menubar.Dock = System.Windows.Forms.DockStyle.None;
            this.menubar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menubar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem,
            this.editToolStripMenuItem,
            this.manageToolStripMenuItem});
            this.menubar.Location = new System.Drawing.Point(495, 79);
            this.menubar.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.menubar.Name = "menubar";
            this.menubar.Size = new System.Drawing.Size(253, 31);
            this.menubar.TabIndex = 60;
            this.menubar.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(68, 27);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 27);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.projectsToolStripMenuItem,
            this.bugsToolStripMenuItem});
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(75, 27);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // projectsToolStripMenuItem
            // 
            this.projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            this.projectsToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.projectsToolStripMenuItem.Text = "Projects";
            this.projectsToolStripMenuItem.Click += new System.EventHandler(this.projectsToolStripMenuItem_Click);
            // 
            // bugsToolStripMenuItem
            // 
            this.bugsToolStripMenuItem.Name = "bugsToolStripMenuItem";
            this.bugsToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.bugsToolStripMenuItem.Text = "Bugs";
            this.bugsToolStripMenuItem.Click += new System.EventHandler(this.bugsToolStripMenuItem_Click);
            // 
            // ManageProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.ControlBox = false;
            this.Controls.Add(this.menubar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnEmpty);
            this.Controls.Add(this.listProjects);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.materialLabel1);
            this.Name = "ManageProjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageProject";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.menubar.ResumeLayout(false);
            this.menubar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtProjectName;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialRaisedButton btnDelete;
        private MaterialSkin.Controls.MaterialRaisedButton btnUpdate;
        private MaterialSkin.Controls.MaterialRaisedButton btnAdd;
        private MaterialSkin.Controls.MaterialListView listProjects;
        private MaterialSkin.Controls.MaterialRaisedButton btnEmpty;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.MenuStrip menubar;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bugsToolStripMenuItem;
    }
}