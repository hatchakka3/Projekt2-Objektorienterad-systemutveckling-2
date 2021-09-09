namespace PresentationLayer.EmployeeView
{
    partial class ActivitiesForm
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
            this.dataGridViewActivities = new System.Windows.Forms.DataGridView();
            this.btnEditActivity = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnSeeMore = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSeeAlumni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActivities)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewActivities
            // 
            this.dataGridViewActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActivities.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewActivities.Name = "dataGridViewActivities";
            this.dataGridViewActivities.Size = new System.Drawing.Size(904, 339);
            this.dataGridViewActivities.TabIndex = 0;
            this.dataGridViewActivities.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewActivities_CellContentClick);
            // 
            // btnEditActivity
            // 
            this.btnEditActivity.Location = new System.Drawing.Point(798, 357);
            this.btnEditActivity.Name = "btnEditActivity";
            this.btnEditActivity.Size = new System.Drawing.Size(118, 51);
            this.btnEditActivity.TabIndex = 1;
            this.btnEditActivity.Text = "Edit activity";
            this.btnEditActivity.UseVisualStyleBackColor = true;
            this.btnEditActivity.Click += new System.EventHandler(this.btnEditActivity_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 357);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(118, 51);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(674, 357);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(118, 51);
            this.btnSignUp.TabIndex = 3;
            this.btnSignUp.Text = "Sign up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnSeeMore
            // 
            this.btnSeeMore.Location = new System.Drawing.Point(550, 357);
            this.btnSeeMore.Name = "btnSeeMore";
            this.btnSeeMore.Size = new System.Drawing.Size(118, 51);
            this.btnSeeMore.TabIndex = 4;
            this.btnSeeMore.Text = "See more information";
            this.btnSeeMore.UseVisualStyleBackColor = true;
            this.btnSeeMore.Click += new System.EventHandler(this.btnSeeMore_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(302, 357);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 51);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSeeAlumni
            // 
            this.btnSeeAlumni.Location = new System.Drawing.Point(426, 357);
            this.btnSeeAlumni.Name = "btnSeeAlumni";
            this.btnSeeAlumni.Size = new System.Drawing.Size(118, 51);
            this.btnSeeAlumni.TabIndex = 6;
            this.btnSeeAlumni.Text = "See alumni registered";
            this.btnSeeAlumni.UseVisualStyleBackColor = true;
            this.btnSeeAlumni.Click += new System.EventHandler(this.btnSeeAlumni_Click);
            // 
            // ActivitiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 429);
            this.Controls.Add(this.btnSeeAlumni);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSeeMore);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnEditActivity);
            this.Controls.Add(this.dataGridViewActivities);
            this.Name = "ActivitiesForm";
            this.Text = "ActivitiesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActivities)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewActivities;
        private System.Windows.Forms.Button btnEditActivity;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnSeeMore;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSeeAlumni;
    }
}