namespace BugTrackingSystem.com.bugtracking.views.com.bugtracking.views.adminpanel
{
    partial class GitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GitForm));
            this.btnCommitHistory = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMessage = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnCommit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnPush = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.menubar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCommitHistory
            // 
            this.btnCommitHistory.AutoSize = true;
            this.btnCommitHistory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCommitHistory.Depth = 0;
            this.btnCommitHistory.Icon = null;
            this.btnCommitHistory.Location = new System.Drawing.Point(521, 642);
            this.btnCommitHistory.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCommitHistory.Name = "btnCommitHistory";
            this.btnCommitHistory.Primary = true;
            this.btnCommitHistory.Size = new System.Drawing.Size(293, 36);
            this.btnCommitHistory.TabIndex = 0;
            this.btnCommitHistory.Text = "Click to Open Commit History";
            this.btnCommitHistory.UseVisualStyleBackColor = true;
            this.btnCommitHistory.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(57, 416);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(88, 24);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Message";
            // 
            // txtMessage
            // 
            this.txtMessage.Depth = 0;
            this.txtMessage.Hint = "";
            this.txtMessage.Location = new System.Drawing.Point(214, 416);
            this.txtMessage.MaxLength = 32767;
            this.txtMessage.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.PasswordChar = '\0';
            this.txtMessage.SelectedText = "";
            this.txtMessage.SelectionLength = 0;
            this.txtMessage.SelectionStart = 0;
            this.txtMessage.Size = new System.Drawing.Size(280, 28);
            this.txtMessage.TabIndex = 2;
            this.txtMessage.TabStop = false;
            this.txtMessage.UseSystemPasswordChar = false;
            // 
            // btnCommit
            // 
            this.btnCommit.AutoSize = true;
            this.btnCommit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCommit.Depth = 0;
            this.btnCommit.Icon = null;
            this.btnCommit.Location = new System.Drawing.Point(404, 495);
            this.btnCommit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Primary = true;
            this.btnCommit.Size = new System.Drawing.Size(90, 36);
            this.btnCommit.TabIndex = 3;
            this.btnCommit.Text = "Commit";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(141, 216);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(934, 216);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(264, 170);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // btnPush
            // 
            this.btnPush.AutoSize = true;
            this.btnPush.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPush.Depth = 0;
            this.btnPush.Icon = null;
            this.btnPush.Location = new System.Drawing.Point(1034, 416);
            this.btnPush.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPush.Name = "btnPush";
            this.btnPush.Primary = true;
            this.btnPush.Size = new System.Drawing.Size(67, 36);
            this.btnPush.TabIndex = 7;
            this.btnPush.Text = "Push";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(100, 169);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(325, 24);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Commit Changes to Local Repository";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(964, 169);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(207, 24);
            this.materialLabel3.TabIndex = 9;
            this.materialLabel3.Text = "Push Changes to Origin";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1247, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
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
            this.menubar.Location = new System.Drawing.Point(521, 79);
            this.menubar.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.menubar.Name = "menubar";
            this.menubar.Size = new System.Drawing.Size(253, 31);
            this.menubar.TabIndex = 14;
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
            // GitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.ControlBox = false;
            this.Controls.Add(this.menubar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnCommitHistory);
            this.Name = "GitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GitForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.menubar.ResumeLayout(false);
            this.menubar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnCommitHistory;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMessage;
        private MaterialSkin.Controls.MaterialRaisedButton btnCommit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialRaisedButton btnPush;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.PictureBox pictureBox3;
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