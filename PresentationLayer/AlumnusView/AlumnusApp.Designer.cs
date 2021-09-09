namespace PresentationLayer.AlumnusView
{
    partial class AlumnusApp
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
            this.btnViewProfile = new System.Windows.Forms.Button();
            this.btnSeeActivities = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnMyActivities = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.Location = new System.Drawing.Point(12, 12);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.Size = new System.Drawing.Size(245, 58);
            this.btnViewProfile.TabIndex = 0;
            this.btnViewProfile.Text = "View profile";
            this.btnViewProfile.UseVisualStyleBackColor = true;
            this.btnViewProfile.Click += new System.EventHandler(this.btnViewProfile_Click);
            // 
            // btnSeeActivities
            // 
            this.btnSeeActivities.Location = new System.Drawing.Point(12, 76);
            this.btnSeeActivities.Name = "btnSeeActivities";
            this.btnSeeActivities.Size = new System.Drawing.Size(245, 58);
            this.btnSeeActivities.TabIndex = 1;
            this.btnSeeActivities.Text = "See activities";
            this.btnSeeActivities.UseVisualStyleBackColor = true;
            this.btnSeeActivities.Click += new System.EventHandler(this.btnSeeActivities_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(12, 268);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(245, 58);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnMyActivities
            // 
            this.btnMyActivities.Location = new System.Drawing.Point(12, 140);
            this.btnMyActivities.Name = "btnMyActivities";
            this.btnMyActivities.Size = new System.Drawing.Size(245, 58);
            this.btnMyActivities.TabIndex = 3;
            this.btnMyActivities.Text = "See my activities";
            this.btnMyActivities.UseVisualStyleBackColor = true;
            this.btnMyActivities.Click += new System.EventHandler(this.btnMyActivities_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 204);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(245, 58);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search other alumni";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 397);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(245, 30);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete account";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // AlumnusApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 433);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnMyActivities);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnSeeActivities);
            this.Controls.Add(this.btnViewProfile);
            this.Name = "AlumnusApp";
            this.Text = "AlumnusApp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewProfile;
        private System.Windows.Forms.Button btnSeeActivities;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnMyActivities;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
    }
}