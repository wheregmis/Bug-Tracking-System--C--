namespace BugTrackingSystem.com.bugtracking.views.com.bugtracking.views.userpanel
{
    partial class BugList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BugList));
            this.listBugs = new MaterialSkin.Controls.MaterialListView();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // listBugs
            // 
            this.listBugs.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBugs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBugs.Depth = 0;
            this.listBugs.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.listBugs.FullRowSelect = true;
            this.listBugs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listBugs.Location = new System.Drawing.Point(42, 129);
            this.listBugs.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listBugs.MouseState = MaterialSkin.MouseState.OUT;
            this.listBugs.Name = "listBugs";
            this.listBugs.OwnerDraw = true;
            this.listBugs.Size = new System.Drawing.Size(1192, 558);
            this.listBugs.TabIndex = 58;
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
            this.materialLabel7.Location = new System.Drawing.Point(533, 88);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(132, 24);
            this.materialLabel7.TabIndex = 59;
            this.materialLabel7.Text = "Your Bug Lists";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1249, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 60;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // BugList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.listBugs);
            this.Name = "BugList";
            this.Text = "BugList";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listBugs;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}