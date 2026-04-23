namespace Project_Sales_Management.PresentationLayer
{
    partial class FrmProductMangement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearsh = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewProductManagement = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSaveToExel = new System.Windows.Forms.Button();
            this.btnPrintAllProduct = new System.Windows.Forms.Button();
            this.btnPrintProduct = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductManagement)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter The Word You Want to Searsh For:";
            // 
            // txtSearsh
            // 
            this.txtSearsh.Location = new System.Drawing.Point(729, 127);
            this.txtSearsh.Name = "txtSearsh";
            this.txtSearsh.Size = new System.Drawing.Size(520, 22);
            this.txtSearsh.TabIndex = 0;
            this.txtSearsh.TextChanged += new System.EventHandler(this.txtSearsh_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewProductManagement);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1249, 407);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Mangement Window";
            // 
            // dataGridViewProductManagement
            // 
            this.dataGridViewProductManagement.AllowUserToAddRows = false;
            this.dataGridViewProductManagement.AllowUserToDeleteRows = false;
            this.dataGridViewProductManagement.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridViewProductManagement.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProductManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProductManagement.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProductManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductManagement.Location = new System.Drawing.Point(6, 26);
            this.dataGridViewProductManagement.Name = "dataGridViewProductManagement";
            this.dataGridViewProductManagement.ReadOnly = true;
            this.dataGridViewProductManagement.RowHeadersWidth = 51;
            this.dataGridViewProductManagement.RowTemplate.Height = 24;
            this.dataGridViewProductManagement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductManagement.Size = new System.Drawing.Size(1237, 454);
            this.dataGridViewProductManagement.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSaveToExel);
            this.groupBox2.Controls.Add(this.btnPrintAllProduct);
            this.groupBox2.Controls.Add(this.btnPrintProduct);
            this.groupBox2.Controls.Add(this.btnImage);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(37, 508);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1249, 145);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Avalable Operation";
            // 
            // btnSaveToExel
            // 
            this.btnSaveToExel.BackColor = System.Drawing.Color.Pink;
            this.btnSaveToExel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveToExel.ForeColor = System.Drawing.Color.Black;
            this.btnSaveToExel.Location = new System.Drawing.Point(705, 91);
            this.btnSaveToExel.Name = "btnSaveToExel";
            this.btnSaveToExel.Size = new System.Drawing.Size(257, 35);
            this.btnSaveToExel.TabIndex = 7;
            this.btnSaveToExel.Text = "Save The List To an Exel File";
            this.btnSaveToExel.UseVisualStyleBackColor = false;
            // 
            // btnPrintAllProduct
            // 
            this.btnPrintAllProduct.BackColor = System.Drawing.Color.Pink;
            this.btnPrintAllProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintAllProduct.ForeColor = System.Drawing.Color.Black;
            this.btnPrintAllProduct.Location = new System.Drawing.Point(475, 91);
            this.btnPrintAllProduct.Name = "btnPrintAllProduct";
            this.btnPrintAllProduct.Size = new System.Drawing.Size(224, 35);
            this.btnPrintAllProduct.TabIndex = 6;
            this.btnPrintAllProduct.Text = "Print All Product";
            this.btnPrintAllProduct.UseVisualStyleBackColor = false;
            // 
            // btnPrintProduct
            // 
            this.btnPrintProduct.BackColor = System.Drawing.Color.Pink;
            this.btnPrintProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintProduct.ForeColor = System.Drawing.Color.Black;
            this.btnPrintProduct.Location = new System.Drawing.Point(245, 91);
            this.btnPrintProduct.Name = "btnPrintProduct";
            this.btnPrintProduct.Size = new System.Drawing.Size(224, 32);
            this.btnPrintProduct.TabIndex = 5;
            this.btnPrintProduct.Text = "Print Product";
            this.btnPrintProduct.UseVisualStyleBackColor = false;
            this.btnPrintProduct.Click += new System.EventHandler(this.btnPrintProduct_Click);
            // 
            // btnImage
            // 
            this.btnImage.BackColor = System.Drawing.Color.Pink;
            this.btnImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImage.ForeColor = System.Drawing.Color.Black;
            this.btnImage.Location = new System.Drawing.Point(861, 42);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(224, 32);
            this.btnImage.TabIndex = 4;
            this.btnImage.Text = "Product Image";
            this.btnImage.UseVisualStyleBackColor = false;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Pink;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(620, 42);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(224, 32);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update  Product";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Pink;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(381, 42);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(224, 32);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Selected Product";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Pink;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(142, 42);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(224, 32);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add New Product";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1110, 678);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(170, 35);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("STHupo", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(429, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(421, 44);
            this.label2.TabIndex = 4;
            this.label2.Text = "Product Mangement";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_Sales_Management.Properties.Resources.Exit_64;
            this.pictureBox1.Location = new System.Drawing.Point(1110, 678);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FrmProductMangement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1321, 734);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearsh);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "FrmProductMangement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductMangement";
            this.Load += new System.EventHandler(this.ProductMangement_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductManagement)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearsh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSaveToExel;
        private System.Windows.Forms.Button btnPrintAllProduct;
        private System.Windows.Forms.Button btnPrintProduct;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.DataGridView dataGridViewProductManagement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}