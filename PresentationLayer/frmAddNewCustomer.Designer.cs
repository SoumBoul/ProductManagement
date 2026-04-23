namespace Project_Sales_Management.PresentationLayer
{
    partial class frmAddNewCustomer
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1Product = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtLast_Name = new System.Windows.Forms.TextBox();
            this.txtCustomer_ID = new System.Windows.Forms.TextBox();
            this.btnSelectImageCustomer = new System.Windows.Forms.Button();
            this.pbCustomer = new System.Windows.Forms.PictureBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1Product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(219, 422);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(145, 39);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(37, 422);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(153, 39);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "   Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1Product
            // 
            this.groupBox1Product.Controls.Add(this.txtEmail);
            this.groupBox1Product.Controls.Add(this.txtTel);
            this.groupBox1Product.Controls.Add(this.txtLast_Name);
            this.groupBox1Product.Controls.Add(this.txtCustomer_ID);
            this.groupBox1Product.Controls.Add(this.btnSelectImageCustomer);
            this.groupBox1Product.Controls.Add(this.pbCustomer);
            this.groupBox1Product.Controls.Add(this.txtFirstName);
            this.groupBox1Product.Controls.Add(this.label6);
            this.groupBox1Product.Controls.Add(this.label5);
            this.groupBox1Product.Controls.Add(this.label4);
            this.groupBox1Product.Controls.Add(this.label3);
            this.groupBox1Product.Controls.Add(this.label2);
            this.groupBox1Product.Font = new System.Drawing.Font("Vivaldi", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1Product.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1Product.Location = new System.Drawing.Point(6, 41);
            this.groupBox1Product.Name = "groupBox1Product";
            this.groupBox1Product.Size = new System.Drawing.Size(732, 360);
            this.groupBox1Product.TabIndex = 19;
            this.groupBox1Product.TabStop = false;
            this.groupBox1Product.Text = "Customer";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial Narrow", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(138, 243);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(316, 39);
            this.txtEmail.TabIndex = 4;
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Arial Narrow", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(138, 198);
            this.txtTel.Multiline = true;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(267, 31);
            this.txtTel.TabIndex = 3;
            // 
            // txtLast_Name
            // 
            this.txtLast_Name.Font = new System.Drawing.Font("Arial Narrow", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLast_Name.Location = new System.Drawing.Point(138, 151);
            this.txtLast_Name.Multiline = true;
            this.txtLast_Name.Name = "txtLast_Name";
            this.txtLast_Name.Size = new System.Drawing.Size(267, 31);
            this.txtLast_Name.TabIndex = 2;
            // 
            // txtCustomer_ID
            // 
            this.txtCustomer_ID.Enabled = false;
            this.txtCustomer_ID.Font = new System.Drawing.Font("Arial Narrow", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer_ID.Location = new System.Drawing.Point(139, 67);
            this.txtCustomer_ID.Multiline = true;
            this.txtCustomer_ID.Name = "txtCustomer_ID";
            this.txtCustomer_ID.Size = new System.Drawing.Size(88, 21);
            this.txtCustomer_ID.TabIndex = 0;
            // 
            // btnSelectImageCustomer
            // 
            this.btnSelectImageCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectImageCustomer.ForeColor = System.Drawing.Color.DeepPink;
            this.btnSelectImageCustomer.Location = new System.Drawing.Point(486, 304);
            this.btnSelectImageCustomer.Name = "btnSelectImageCustomer";
            this.btnSelectImageCustomer.Size = new System.Drawing.Size(199, 39);
            this.btnSelectImageCustomer.TabIndex = 5;
            this.btnSelectImageCustomer.Text = "Select Image File";
            this.btnSelectImageCustomer.UseVisualStyleBackColor = true;
            this.btnSelectImageCustomer.Click += new System.EventHandler(this.btnSelectImageCustomer_Click);
            // 
            // pbCustomer
            // 
            this.pbCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbCustomer.Image = global::Project_Sales_Management.Properties.Resources.Aucune_image_disponible;
            this.pbCustomer.Location = new System.Drawing.Point(481, 23);
            this.pbCustomer.Name = "pbCustomer";
            this.pbCustomer.Size = new System.Drawing.Size(204, 259);
            this.pbCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCustomer.TabIndex = 12;
            this.pbCustomer.TabStop = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Arial Narrow", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(138, 106);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(267, 31);
            this.txtFirstName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmAddNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(765, 473);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1Product);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddNewCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddNewCustomer";
            this.Load += new System.EventHandler(this.frmAddNewCustomer_Load);
            this.groupBox1Product.ResumeLayout(false);
            this.groupBox1Product.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1Product;
        public System.Windows.Forms.Button btnSelectImageCustomer;
        public System.Windows.Forms.PictureBox pbCustomer;
        public System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtCustomer_ID;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtTel;
        public System.Windows.Forms.TextBox txtLast_Name;
    }
}