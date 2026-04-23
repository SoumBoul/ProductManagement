namespace Project_Sales_Management.PresentationLayer
{
    partial class frmList_Orders
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
            this.dgListOrders = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgListOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgListOrders
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgListOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgListOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgListOrders.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgListOrders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgListOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgListOrders.Location = new System.Drawing.Point(0, 0);
            this.dgListOrders.Name = "dgListOrders";
            this.dgListOrders.RowHeadersWidth = 51;
            this.dgListOrders.RowTemplate.Height = 24;
            this.dgListOrders.Size = new System.Drawing.Size(986, 582);
            this.dgListOrders.TabIndex = 0;
            this.dgListOrders.DoubleClick += new System.EventHandler(this.dgListOrders_DoubleClick);
            // 
            // frmList_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(986, 582);
            this.Controls.Add(this.dgListOrders);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmList_Orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "List_Orders";
            this.Load += new System.EventHandler(this.frmList_Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgListOrders;
    }
}