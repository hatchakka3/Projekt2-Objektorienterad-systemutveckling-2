namespace PresentationLayer
{
    partial class EmployeeApp
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
            this.btnCreateActivity = new System.Windows.Forms.Button();
            this.btnEditPersonalInfo = new System.Windows.Forms.Button();
            this.btnMailings = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnSearchStudents = new System.Windows.Forms.Button();
            this.btnSeeActivities = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateActivity
            // 
            this.btnCreateActivity.Location = new System.Drawing.Point(12, 12);
            this.btnCreateActivity.Name = "btnCreateActivity";
            this.btnCreateActivity.Size = new System.Drawing.Size(165, 49);
            this.btnCreateActivity.TabIndex = 0;
            this.btnCreateActivity.Text = "Create activity";
            this.btnCreateActivity.UseVisualStyleBackColor = true;
            this.btnCreateActivity.Click += new System.EventHandler(this.btnCreateActivity_Click);
            // 
            // btnEditPersonalInfo
            // 
            this.btnEditPersonalInfo.Location = new System.Drawing.Point(12, 67);
            this.btnEditPersonalInfo.Name = "btnEditPersonalInfo";
            this.btnEditPersonalInfo.Size = new System.Drawing.Size(165, 49);
            this.btnEditPersonalInfo.TabIndex = 1;
            this.btnEditPersonalInfo.Text = "Edit personal information";
            this.btnEditPersonalInfo.UseVisualStyleBackColor = true;
            this.btnEditPersonalInfo.Click += new System.EventHandler(this.btnEditPersonalInfo_Click);
            // 
            // btnMailings
            // 
            this.btnMailings.Location = new System.Drawing.Point(12, 122);
            this.btnMailings.Name = "btnMailings";
            this.btnMailings.Size = new System.Drawing.Size(165, 49);
            this.btnMailings.TabIndex = 2;
            this.btnMailings.Text = "Create mailing";
            this.btnMailings.UseVisualStyleBackColor = true;
            this.btnMailings.Click += new System.EventHandler(this.btnMailings_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(12, 287);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(165, 49);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnSearchStudents
            // 
            this.btnSearchStudents.Location = new System.Drawing.Point(13, 177);
            this.btnSearchStudents.Name = "btnSearchStudents";
            this.btnSearchStudents.Size = new System.Drawing.Size(165, 49);
            this.btnSearchStudents.TabIndex = 4;
            this.btnSearchStudents.Text = "Search alumni";
            this.btnSearchStudents.UseVisualStyleBackColor = true;
            this.btnSearchStudents.Click += new System.EventHandler(this.btnSearchStudents_Click);
            // 
            // btnSeeActivities
            // 
            this.btnSeeActivities.Location = new System.Drawing.Point(12, 232);
            this.btnSeeActivities.Name = "btnSeeActivities";
            this.btnSeeActivities.Size = new System.Drawing.Size(165, 49);
            this.btnSeeActivities.TabIndex = 5;
            this.btnSeeActivities.Text = "See activities";
            this.btnSeeActivities.UseVisualStyleBackColor = true;
            this.btnSeeActivities.Click += new System.EventHandler(this.btnSeeActivities_Click);
            // 
            // EmployeeApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 351);
            this.Controls.Add(this.btnSeeActivities);
            this.Controls.Add(this.btnSearchStudents);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnMailings);
            this.Controls.Add(this.btnEditPersonalInfo);
            this.Controls.Add(this.btnCreateActivity);
            this.Name = "EmployeeApp";
            this.Text = "EmployeeApp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateActivity;
        private System.Windows.Forms.Button btnEditPersonalInfo;
        private System.Windows.Forms.Button btnMailings;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnSearchStudents;
        private System.Windows.Forms.Button btnSeeActivities;
    }
}