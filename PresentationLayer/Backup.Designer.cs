namespace Project_Sales_Management.PresentationLayer
{
    partial class Backup
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
            this.btnBuckup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDB_Name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBuckup
            // 
            this.btnBuckup.BackColor = System.Drawing.Color.Pink;
            this.btnBuckup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuckup.Location = new System.Drawing.Point(243, 113);
            this.btnBuckup.Name = "btnBuckup";
            this.btnBuckup.Size = new System.Drawing.Size(199, 42);
            this.btnBuckup.TabIndex = 0;
            this.btnBuckup.Text = "Backup";
            this.btnBuckup.UseVisualStyleBackColor = false;
            this.btnBuckup.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Database Name:";
            // 
            // txtDB_Name
            // 
            this.txtDB_Name.Enabled = false;
            this.txtDB_Name.Location = new System.Drawing.Point(217, 39);
            this.txtDB_Name.Multiline = true;
            this.txtDB_Name.Name = "txtDB_Name";
            this.txtDB_Name.Size = new System.Drawing.Size(418, 36);
            this.txtDB_Name.TabIndex = 5;
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(680, 199);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDB_Name);
            this.Controls.Add(this.btnBuckup);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Backup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup";
            this.Load += new System.EventHandler(this.Backup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuckup;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtDB_Name;
    }
}