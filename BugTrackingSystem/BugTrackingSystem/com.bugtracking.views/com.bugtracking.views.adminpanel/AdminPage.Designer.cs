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
            ((System.ComponentModel.ISupportInitialize)(this.manageUsersPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManageProjectsPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManageBugsPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUsers
            // 
            this.btnUsers.AutoSize = true;
            this.btnUsers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUsers.Depth = 0;
            this.btnUsers.Icon = null;
            this.btnUsers.Location = new System.Drawing.Point(115, 524);
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
            this.btnManageProjects.Location = new System.Drawing.Point(568, 524);
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
            this.btnManageBugs.Location = new System.Drawing.Point(1007, 524);
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
            this.manageUsersPic.Location = new System.Drawing.Point(77, 341);
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
            this.ManageProjectsPic.Location = new System.Drawing.Point(542, 341);
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
            this.ManageBugsPic.Location = new System.Drawing.Point(957, 341);
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
            this.pictureBox4.Location = new System.Drawing.Point(12, 84);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(110, 116);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(1209, 84);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(59, 52);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.ManageBugsPic);
            this.Controls.Add(this.ManageProjectsPic);
            this.Controls.Add(this.manageUsersPic);
            this.Controls.Add(this.btnManageBugs);
            this.Controls.Add(this.btnManageProjects);
            this.Controls.Add(this.btnUsers);
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPage";
            ((System.ComponentModel.ISupportInitialize)(this.manageUsersPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManageProjectsPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManageBugsPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
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
    }
}