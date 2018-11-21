namespace BugTrackingSystem.com.bugtracking.views.com.bugtracking.views.userpanel
{
    partial class AllBugs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllBugs));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.bugList = new MaterialSkin.Controls.MaterialListView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1248, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(512, 161);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(228, 24);
            this.materialLabel1.TabIndex = 15;
            this.materialLabel1.Text = "Bug List of Whole System";
            // 
            // bugList
            // 
            this.bugList.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bugList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bugList.Depth = 0;
            this.bugList.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.bugList.FullRowSelect = true;
            this.bugList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.bugList.Location = new System.Drawing.Point(27, 199);
            this.bugList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.bugList.MouseState = MaterialSkin.MouseState.OUT;
            this.bugList.Name = "bugList";
            this.bugList.OwnerDraw = true;
            this.bugList.Size = new System.Drawing.Size(1227, 468);
            this.bugList.TabIndex = 14;
            this.bugList.UseCompatibleStateImageBehavior = false;
            this.bugList.View = System.Windows.Forms.View.Details;
            // 
            // AllBugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.ControlBox = false;
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.bugList);
            this.Controls.Add(this.pictureBox2);
            this.Name = "AllBugs";
            this.Text = "AllBugs";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialListView bugList;
    }
}