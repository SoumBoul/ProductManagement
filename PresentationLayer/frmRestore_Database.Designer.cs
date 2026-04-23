namespace Project_Sales_Management.PresentationLayer
{
    partial class frmRestore_Database
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
            this.btnRestore = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDB_Name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.Pink;
            this.btnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.Location = new System.Drawing.Point(267, 115);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(189, 42);
            this.btnRestore.TabIndex = 11;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Database Name:";
            // 
            // txtDB_Name
            // 
            this.txtDB_Name.Location = new System.Drawing.Point(217, 49);
            this.txtDB_Name.Multiline = true;
            this.txtDB_Name.Name = "txtDB_Name";
            this.txtDB_Name.Size = new System.Drawing.Size(389, 36);
            this.txtDB_Name.TabIndex = 12;
            // 
            // frmRestore_Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(679, 184);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDB_Name);
            this.Controls.Add(this.btnRestore);
            this.Name = "frmRestore_Database";
            this.Text = "frmRestore_Database";
            this.Load += new System.EventHandler(this.frmRestore_Database_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtDB_Name;
    }
}