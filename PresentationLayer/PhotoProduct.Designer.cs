namespace Project_Sales_Management.PresentationLayer
{
    partial class frm_PhotoProduct
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
            this.pbImageProduct = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImageProduct
            // 
            this.pbImageProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImageProduct.Location = new System.Drawing.Point(0, 0);
            this.pbImageProduct.Name = "pbImageProduct";
            this.pbImageProduct.Size = new System.Drawing.Size(711, 473);
            this.pbImageProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImageProduct.TabIndex = 0;
            this.pbImageProduct.TabStop = false;
            // 
            // frm_PhotoProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 473);
            this.Controls.Add(this.pbImageProduct);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_PhotoProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photo Product";
            ((System.ComponentModel.ISupportInitialize)(this.pbImageProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pbImageProduct;
    }
}