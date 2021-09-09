namespace PresentationLayer.AlumnusView
{
    partial class AlumnusActivities
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSeeMore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActivities)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewActivities
            // 
            this.dataGridViewActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActivities.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewActivities.Name = "dataGridViewActivities";
            this.dataGridViewActivities.Size = new System.Drawing.Size(665, 284);
            this.dataGridViewActivities.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 302);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(101, 53);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSeeMore
            // 
            this.btnSeeMore.Location = new System.Drawing.Point(576, 302);
            this.btnSeeMore.Name = "btnSeeMore";
            this.btnSeeMore.Size = new System.Drawing.Size(101, 53);
            this.btnSeeMore.TabIndex = 2;
            this.btnSeeMore.Text = "See more information";
            this.btnSeeMore.UseVisualStyleBackColor = true;
            this.btnSeeMore.Click += new System.EventHandler(this.btnSeeMore_Click);
            // 
            // AlumnusActivities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 368);
            this.Controls.Add(this.btnSeeMore);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridViewActivities);
            this.Name = "AlumnusActivities";
            this.Text = "AlumnusActivities";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActivities)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewActivities;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSeeMore;
    }
}