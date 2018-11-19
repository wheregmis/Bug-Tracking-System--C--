namespace BugTrackingSystem.com.bugtracking.views.com.bugtracking.views.adminpanel
{
    partial class ManageBugs
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
            this.listBugs = new MaterialSkin.Controls.MaterialListView();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
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
            this.listBugs.Location = new System.Drawing.Point(24, 136);
            this.listBugs.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listBugs.MouseState = MaterialSkin.MouseState.OUT;
            this.listBugs.Name = "listBugs";
            this.listBugs.OwnerDraw = true;
            this.listBugs.Size = new System.Drawing.Size(1227, 558);
            this.listBugs.TabIndex = 0;
            this.listBugs.UseCompatibleStateImageBehavior = false;
            this.listBugs.View = System.Windows.Forms.View.Details;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(497, 90);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(228, 24);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Bug List of Whole System";
            // 
            // ManageBugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.listBugs);
            this.Name = "ManageBugs";
            this.Text = "ManageBugs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listBugs;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}