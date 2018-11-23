namespace BugTrackingSystem.com.bugtracking.views.com.bugtracking.views.adminpanel
{
    partial class AdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            this.btnUsers = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnManageProjects = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnManageBugs = new MaterialSkin.Controls.MaterialFlatButton();
            this.manageUsersPic = new System.Windows.Forms.PictureBox();
            this.ManageProjectsPic = new System.Windows.Forms.PictureBox();
            this.ManageBugsPic = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblProfile = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
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
            ((System.ComponentModel.ISupportInitialize)(this.manageUsersPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManageProjectsPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManageBugsPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menubar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUsers
            // 
            this.btnUsers.AutoSize = true;
            this.btnUsers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUsers.Depth = 0;
            this.btnUsers.Icon = null;
            this.btnUsers.Location = new System.Drawing.Point(115, 567);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUsers.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Primary = false;
            this.btnUsers.Size = new System.Drawing.Size(150, 36);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.Text = "Manage Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnManageProjects
            // 
            this.btnManageProjects.AutoSize = true;
            this.btnManageProjects.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnManageProjects.Depth = 0;
            this.btnManageProjects.Icon = null;
            this.btnManageProjects.Location = new System.Drawing.Point(568, 567);
            this.btnManageProjects.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnManageProjects.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnManageProjects.Name = "btnManageProjects";
            this.btnManageProjects.Primary = false;
            this.btnManageProjects.Size = new System.Drawing.Size(183, 36);
            this.btnManageProjects.TabIndex = 1;
            this.btnManageProjects.Text = "Manage Projects";
            this.btnManageProjects.UseVisualStyleBackColor = true;
            this.btnManageProjects.Click += new System.EventHandler(this.btnManageProjects_Click);
            // 
            // btnManageBugs
            // 
            this.btnManageBugs.AutoSize = true;
            this.btnManageBugs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnManageBugs.Depth = 0;
            this.btnManageBugs.Icon = null;
            this.btnManageBugs.Location = new System.Drawing.Point(1007, 567);
            this.btnManageBugs.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnManageBugs.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnManageBugs.Name = "btnManageBugs";
            this.btnManageBugs.Primary = false;
            this.btnManageBugs.Size = new System.Drawing.Size(142, 36);
            this.btnManageBugs.TabIndex = 2;
            this.btnManageBugs.Text = "Manage Bugs";
            this.btnManageBugs.UseVisualStyleBackColor = true;
            this.btnManageBugs.Click += new System.EventHandler(this.btnManageBugs_Click);
            // 
            // manageUsersPic
            // 
            this.manageUsersPic.Image = ((System.Drawing.Image)(resources.GetObject("manageUsersPic.Image")));
            this.manageUsersPic.Location = new System.Drawing.Point(77, 324);
            this.manageUsersPic.Name = "manageUsersPic";
            this.manageUsersPic.Size = new System.Drawing.Size(233, 174);
            this.manageUsersPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.manageUsersPic.TabIndex = 3;
            this.manageUsersPic.TabStop = false;
            this.manageUsersPic.Click += new System.EventHandler(this.manageUsersPic_Click);
            // 
            // ManageProjectsPic
            // 
            this.ManageProjectsPic.Image = ((System.Drawing.Image)(resources.GetObject("ManageProjectsPic.Image")));
            this.ManageProjectsPic.Location = new System.Drawing.Point(542, 324);
            this.ManageProjectsPic.Name = "ManageProjectsPic";
            this.ManageProjectsPic.Size = new System.Drawing.Size(235, 174);
            this.ManageProjectsPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ManageProjectsPic.TabIndex = 4;
            this.ManageProjectsPic.TabStop = false;
            this.ManageProjectsPic.Click += new System.EventHandler(this.ManageProjectsPic_Click);
            // 
            // ManageBugsPic
            // 
            this.ManageBugsPic.Image = ((System.Drawing.Image)(resources.GetObject("ManageBugsPic.Image")));
            this.ManageBugsPic.Location = new System.Drawing.Point(957, 324);
            this.ManageBugsPic.Name = "ManageBugsPic";
            this.ManageBugsPic.Size = new System.Drawing.Size(235, 174);
            this.ManageBugsPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ManageBugsPic.TabIndex = 5;
            this.ManageBugsPic.TabStop = false;
            this.ManageBugsPic.Click += new System.EventHandler(this.ManageBugsPic_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 142);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(110, 96);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(1195, 129);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(70, 52);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(620, 653);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(131, 36);
            this.materialRaisedButton1.TabIndex = 8;
            this.materialRaisedButton1.Text = "Git Control";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(569, 653);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Depth = 0;
            this.lblProfile.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProfile.Location = new System.Drawing.Point(33, 241);
            this.lblProfile.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(66, 24);
            this.lblProfile.TabIndex = 10;
            this.lblProfile.Text = "Profile";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1248, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(1191, 184);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(76, 24);
            this.materialLabel1.TabIndex = 12;
            this.materialLabel1.Text = "Log Out";
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
            this.menubar.Location = new System.Drawing.Point(524, 80);
            this.menubar.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.menubar.Name = "menubar";
            this.menubar.Size = new System.Drawing.Size(253, 31);
            this.menubar.TabIndex = 13;
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
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.ControlBox = false;
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblProfile);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.ManageBugsPic);
            this.Controls.Add(this.ManageProjectsPic);
            this.Controls.Add(this.manageUsersPic);
            this.Controls.Add(this.btnManageBugs);
            this.Controls.Add(this.btnManageProjects);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.menubar);
            this.Name = "AdminPage";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.manageUsersPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManageProjectsPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManageBugsPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menubar.ResumeLayout(false);
            this.menubar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton btnUsers;
        private MaterialSkin.Controls.MaterialFlatButton btnManageProjects;
        private MaterialSkin.Controls.MaterialFlatButton btnManageBugs;
        private System.Windows.Forms.PictureBox manageUsersPic;
        private System.Windows.Forms.PictureBox ManageProjectsPic;
        private System.Windows.Forms.PictureBox ManageBugsPic;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel lblProfile;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
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