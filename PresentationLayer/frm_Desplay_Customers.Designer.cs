namespace Project_Sales_Management.PresentationLayer
{
    partial class frm_Desplay_Customers
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
            this.dgListCustomers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgListCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgListCustomers
            // 
            this.dgListCustomers.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgListCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgListCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgListCustomers.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgListCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgListCustomers.Location = new System.Drawing.Point(0, 0);
            this.dgListCustomers.Name = "dgListCustomers";
            this.dgListCustomers.RowHeadersWidth = 51;
            this.dgListCustomers.RowTemplate.Height = 24;
            this.dgListCustomers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgListCustomers.Size = new System.Drawing.Size(1030, 588);
            this.dgListCustomers.TabIndex = 0;
            this.dgListCustomers.DoubleClick += new System.EventHandler(this.dgListCustomers_DoubleClick);
            // 
            // frm_Desplay_Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 587);
            this.Controls.Add(this.dgListCustomers);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Desplay_Customers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_Desplay_Customers";
            this.Load += new System.EventHandler(this.frm_Desplay_Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgListCustomers;
    }
}