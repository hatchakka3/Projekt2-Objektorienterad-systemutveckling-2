namespace PresentationLayer.EmployeeView
{
    partial class CreateActivityForm
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
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.CalendarStartDate = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmitActivity = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 34);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(466, 162);
            this.txtDescription.TabIndex = 0;
            // 
            // CalendarStartDate
            // 
            this.CalendarStartDate.Location = new System.Drawing.Point(500, 34);
            this.CalendarStartDate.Name = "CalendarStartDate";
            this.CalendarStartDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Description";
            // 
            // btnSubmitActivity
            // 
            this.btnSubmitActivity.Location = new System.Drawing.Point(500, 208);
            this.btnSubmitActivity.Name = "btnSubmitActivity";
            this.btnSubmitActivity.Size = new System.Drawing.Size(220, 48);
            this.btnSubmitActivity.TabIndex = 4;
            this.btnSubmitActivity.Text = "Submit activity";
            this.btnSubmitActivity.UseVisualStyleBackColor = true;
            this.btnSubmitActivity.Click += new System.EventHandler(this.btnSubmitActivity_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 208);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 48);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CreateActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 268);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSubmitActivity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalendarStartDate);
            this.Controls.Add(this.txtDescription);
            this.Name = "CreateActivityForm";
            this.Text = "CreateActivityForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.MonthCalendar CalendarStartDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmitActivity;
        private System.Windows.Forms.Button btnBack;
    }
}