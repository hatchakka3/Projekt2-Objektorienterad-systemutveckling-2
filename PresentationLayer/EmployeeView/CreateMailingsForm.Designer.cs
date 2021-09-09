namespace PresentationLayer.EmployeeView
{
    partial class CreateMailingsForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridViewMailings = new System.Windows.Forms.DataGridView();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnSeeRecievers = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMailings)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(327, 243);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Information";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 276);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 37);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridViewMailings
            // 
            this.dataGridViewMailings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMailings.Location = new System.Drawing.Point(385, 27);
            this.dataGridViewMailings.Name = "dataGridViewMailings";
            this.dataGridViewMailings.Size = new System.Drawing.Size(477, 243);
            this.dataGridViewMailings.TabIndex = 10;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(264, 276);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 37);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnSeeRecievers
            // 
            this.btnSeeRecievers.Location = new System.Drawing.Point(787, 276);
            this.btnSeeRecievers.Name = "btnSeeRecievers";
            this.btnSeeRecievers.Size = new System.Drawing.Size(75, 37);
            this.btnSeeRecievers.TabIndex = 13;
            this.btnSeeRecievers.Text = "Edit";
            this.btnSeeRecievers.UseVisualStyleBackColor = true;
            this.btnSeeRecievers.Click += new System.EventHandler(this.btnSeeRecievers_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(706, 276);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 37);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // CreateMailingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 337);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSeeRecievers);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dataGridViewMailings);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Name = "CreateMailingsForm";
            this.Text = "CreateMailingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMailings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridViewMailings;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnSeeRecievers;
        private System.Windows.Forms.Button btnDelete;
    }
}