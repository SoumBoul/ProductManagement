namespace Project_Sales_Management.PresentationLayer
{
    partial class frm_Sales_Management
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearsh = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pbCustomer = new System.Windows.Forms.PictureBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtCustomer_ID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DateTimeName = new System.Windows.Forms.DateTimePicker();
            this.txtSalerName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtInvoice_ID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnNewSale = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSersh = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtQte = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTva = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgOrders = new System.Windows.Forms.DataGridView();
            this.MenuStripSales = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnDeleteLine = new System.Windows.Forms.Button();
            this.txtTotalPrices = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSearsh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomer)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).BeginInit();
            this.MenuStripSales.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearsh
            // 
            this.btnSearsh.Controls.Add(this.button1);
            this.btnSearsh.Controls.Add(this.pbCustomer);
            this.btnSearsh.Controls.Add(this.txtEmail);
            this.btnSearsh.Controls.Add(this.txtTel);
            this.btnSearsh.Controls.Add(this.txtLastName);
            this.btnSearsh.Controls.Add(this.txtFirstName);
            this.btnSearsh.Controls.Add(this.txtCustomer_ID);
            this.btnSearsh.Controls.Add(this.label6);
            this.btnSearsh.Controls.Add(this.label5);
            this.btnSearsh.Controls.Add(this.label4);
            this.btnSearsh.Controls.Add(this.label3);
            this.btnSearsh.Controls.Add(this.label2);
            this.btnSearsh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearsh.Location = new System.Drawing.Point(24, 100);
            this.btnSearsh.Name = "btnSearsh";
            this.btnSearsh.Size = new System.Drawing.Size(769, 272);
            this.btnSearsh.TabIndex = 0;
            this.btnSearsh.TabStop = false;
            this.btnSearsh.Text = "Customer Details";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(367, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 25);
            this.button1.TabIndex = 22;
            this.button1.Text = "Searsh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbCustomer
            // 
            this.pbCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbCustomer.Location = new System.Drawing.Point(480, 21);
            this.pbCustomer.Name = "pbCustomer";
            this.pbCustomer.Size = new System.Drawing.Size(272, 241);
            this.pbCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCustomer.TabIndex = 21;
            this.pbCustomer.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(204, 230);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(255, 24);
            this.txtEmail.TabIndex = 5;
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(204, 191);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(255, 24);
            this.txtTel.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(204, 150);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(255, 24);
            this.txtLastName.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(204, 110);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(255, 24);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtCustomer_ID
            // 
            this.txtCustomer_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer_ID.Location = new System.Drawing.Point(204, 70);
            this.txtCustomer_ID.Name = "txtCustomer_ID";
            this.txtCustomer_ID.ReadOnly = true;
            this.txtCustomer_ID.Size = new System.Drawing.Size(157, 24);
            this.txtCustomer_ID.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tel:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Customer_ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DateTimeName);
            this.groupBox2.Controls.Add(this.txtSalerName);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.txtInvoice_ID);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btnNewSale);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(814, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(581, 272);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Invoice Details";
            // 
            // DateTimeName
            // 
            this.DateTimeName.Location = new System.Drawing.Point(190, 185);
            this.DateTimeName.Name = "DateTimeName";
            this.DateTimeName.Size = new System.Drawing.Size(329, 27);
            this.DateTimeName.TabIndex = 8;
            // 
            // txtSalerName
            // 
            this.txtSalerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalerName.Location = new System.Drawing.Point(179, 228);
            this.txtSalerName.Name = "txtSalerName";
            this.txtSalerName.Size = new System.Drawing.Size(340, 24);
            this.txtSalerName.TabIndex = 9;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(179, 80);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescription.Size = new System.Drawing.Size(340, 90);
            this.txtDescription.TabIndex = 7;
            // 
            // txtInvoice_ID
            // 
            this.txtInvoice_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoice_ID.Location = new System.Drawing.Point(179, 40);
            this.txtInvoice_ID.Name = "txtInvoice_ID";
            this.txtInvoice_ID.ReadOnly = true;
            this.txtInvoice_ID.Size = new System.Drawing.Size(139, 27);
            this.txtInvoice_ID.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Saler Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Sale Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Invoice Description";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Invoice ID:";
            // 
            // btnNewSale
            // 
            this.btnNewSale.BackColor = System.Drawing.Color.Pink;
            this.btnNewSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSale.Location = new System.Drawing.Point(359, 34);
            this.btnNewSale.Name = "btnNewSale";
            this.btnNewSale.Size = new System.Drawing.Size(160, 33);
            this.btnNewSale.TabIndex = 10;
            this.btnNewSale.Text = "New Sale";
            this.btnNewSale.UseVisualStyleBackColor = false;
            this.btnNewSale.Click += new System.EventHandler(this.btnNewSale_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSersh);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtID);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.txtName);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.txtPrice);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txtQte);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtAmount);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtTva);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtTotal);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.dgOrders);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(98, 389);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1235, 236);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ordres";
            // 
            // btnSersh
            // 
            this.btnSersh.Location = new System.Drawing.Point(12, 55);
            this.btnSersh.Name = "btnSersh";
            this.btnSersh.Size = new System.Drawing.Size(70, 25);
            this.btnSersh.TabIndex = 30;
            this.btnSersh.Text = ".......";
            this.btnSersh.UseVisualStyleBackColor = true;
            this.btnSersh.Click += new System.EventHandler(this.btnSearsh_Click);
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.Purple;
            this.label7.Location = new System.Drawing.Point(6, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 29);
            this.label7.TabIndex = 29;
            this.label7.Text = "label7";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(91, 53);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 27);
            this.txtID.TabIndex = 28;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.ForeColor = System.Drawing.Color.Purple;
            this.label19.Location = new System.Drawing.Point(93, 23);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 29);
            this.label19.TabIndex = 27;
            this.label19.Text = "Id_Order";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(237, 53);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(100, 27);
            this.txtName.TabIndex = 26;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.ForeColor = System.Drawing.Color.Purple;
            this.label18.Location = new System.Drawing.Point(261, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 29);
            this.label18.TabIndex = 25;
            this.label18.Text = "Name";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(424, 53);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(100, 27);
            this.txtPrice.TabIndex = 24;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrice_KeyDown);
            // 
            // label17
            // 
            this.label17.ForeColor = System.Drawing.Color.Purple;
            this.label17.Location = new System.Drawing.Point(441, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 29);
            this.label17.TabIndex = 23;
            this.label17.Text = "Price";
            // 
            // txtQte
            // 
            this.txtQte.Location = new System.Drawing.Point(580, 53);
            this.txtQte.MaxLength = 10;
            this.txtQte.Name = "txtQte";
            this.txtQte.Size = new System.Drawing.Size(100, 27);
            this.txtQte.TabIndex = 22;
            this.txtQte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQte.TextChanged += new System.EventHandler(this.txtQte_TextChanged);
            this.txtQte.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQte_KeyDown);
            this.txtQte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQte_KeyPress);
            this.txtQte.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQte_KeyUp);
            // 
            // label16
            // 
            this.label16.ForeColor = System.Drawing.Color.Purple;
            this.label16.Location = new System.Drawing.Point(580, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 29);
            this.label16.TabIndex = 21;
            this.label16.Text = "Quantity";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(740, 53);
            this.txtAmount.MaxLength = 10;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(100, 27);
            this.txtAmount.TabIndex = 20;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // label15
            // 
            this.label15.ForeColor = System.Drawing.Color.Purple;
            this.label15.Location = new System.Drawing.Point(740, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 29);
            this.label15.TabIndex = 19;
            this.label15.Text = "Amount";
            // 
            // txtTva
            // 
            this.txtTva.Location = new System.Drawing.Point(885, 53);
            this.txtTva.MaxLength = 2;
            this.txtTva.Name = "txtTva";
            this.txtTva.Size = new System.Drawing.Size(100, 27);
            this.txtTva.TabIndex = 18;
            this.txtTva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTva.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTva_KeyDown);
            this.txtTva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTva_KeyPress);
            this.txtTva.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTva_KeyUp);
            // 
            // label14
            // 
            this.label14.ForeColor = System.Drawing.Color.Purple;
            this.label14.Location = new System.Drawing.Point(912, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 29);
            this.label14.TabIndex = 17;
            this.label14.Text = "Tva";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(1031, 53);
            this.txtTotal.MaxLength = 20;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 27);
            this.txtTotal.TabIndex = 16;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.ForeColor = System.Drawing.Color.Purple;
            this.label12.Location = new System.Drawing.Point(1046, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 29);
            this.label12.TabIndex = 15;
            this.label12.Text = "Total Price";
            // 
            // dgOrders
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgOrders.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrders.ColumnHeadersVisible = false;
            this.dgOrders.ContextMenuStrip = this.MenuStripSales;
            this.dgOrders.Location = new System.Drawing.Point(12, 88);
            this.dgOrders.Name = "dgOrders";
            this.dgOrders.RowHeadersWidth = 51;
            this.dgOrders.RowTemplate.Height = 24;
            this.dgOrders.Size = new System.Drawing.Size(1193, 141);
            this.dgOrders.TabIndex = 0;
            this.dgOrders.DoubleClick += new System.EventHandler(this.dgOrders_DoubleClick);
            // 
            // MenuStripSales
            // 
            this.MenuStripSales.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.MenuStripSales.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStripSales.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.toolStripMenuItem1,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.MenuStripSales.Name = "MenuStripSales";
            this.MenuStripSales.Size = new System.Drawing.Size(143, 100);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(142, 30);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(139, 6);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(142, 30);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(142, 30);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(528, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 57);
            this.label1.TabIndex = 8;
            this.label1.Text = "Main Sales Screen";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1040, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 20);
            this.label13.TabIndex = 16;
            this.label13.Text = "Total:";
            // 
            // btnDeleteLine
            // 
            this.btnDeleteLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteLine.Location = new System.Drawing.Point(46, 26);
            this.btnDeleteLine.Name = "btnDeleteLine";
            this.btnDeleteLine.Size = new System.Drawing.Size(263, 34);
            this.btnDeleteLine.TabIndex = 13;
            this.btnDeleteLine.Text = "Delete Current Line";
            this.btnDeleteLine.UseVisualStyleBackColor = true;
            // 
            // txtTotalPrices
            // 
            this.txtTotalPrices.Location = new System.Drawing.Point(1114, 26);
            this.txtTotalPrices.Name = "txtTotalPrices";
            this.txtTotalPrices.ReadOnly = true;
            this.txtTotalPrices.Size = new System.Drawing.Size(82, 22);
            this.txtTotalPrices.TabIndex = 21;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtTotalPrices);
            this.groupBox4.Controls.Add(this.btnDeleteLine);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(24, 620);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1393, 75);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1263, 715);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(170, 46);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Project_Sales_Management.Properties.Resources.Exit_64;
            this.pictureBox2.Location = new System.Drawing.Point(1263, 715);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Pink;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(717, 715);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(183, 34);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Pink;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(515, 715);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 34);
            this.button3.TabIndex = 20;
            this.button3.Text = "Print";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // frm_Sales_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1444, 773);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSearsh);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Sales_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales_Management";
            this.Load += new System.EventHandler(this.frm_Sales_Management_Load);
            this.btnSearsh.ResumeLayout(false);
            this.btnSearsh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomer)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).EndInit();
            this.MenuStripSales.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnNewSale;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.PictureBox pbCustomer;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtTel;
        public System.Windows.Forms.TextBox txtLastName;
        public System.Windows.Forms.TextBox txtFirstName;
        public System.Windows.Forms.TextBox txtCustomer_ID;
        public System.Windows.Forms.TextBox txtSalerName;
        public System.Windows.Forms.TextBox txtDescription;
        public System.Windows.Forms.TextBox txtInvoice_ID;
        public System.Windows.Forms.DataGridView dgOrders;
        public System.Windows.Forms.TextBox txtTotalPrices;
        public System.Windows.Forms.Button btnDeleteLine;
        public System.Windows.Forms.DateTimePicker DateTimeName;
        public System.Windows.Forms.GroupBox btnSearsh;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTva;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtQte;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnSersh;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtTotal;
        public System.Windows.Forms.ContextMenuStrip MenuStripSales;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button button3;
    }
}