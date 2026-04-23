using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Sales_Management.PresentationLayer
{
    public partial class FRM_Main : Form
    {
        public static FRM_Main frm;

        public static  void Frm_Closed(object sender, FormClosedEventArgs e)
        {
            frm = null;

        }

        public static FRM_Main get_Frm_Main
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_Main();
                    frm.FormClosed += new  FormClosedEventHandler(Frm_Closed);

                }
               
                    return frm;
            }
        }

        private static void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public FRM_Main()
        {
            InitializeComponent();
            if(frm==null)
            { 
                frm = this;
            }

            this.productManagementToolStripMenuItem.Enabled = false;
            this.customersToolStripMenuItem.Enabled = false;
            this.usersToolStripMenuItem.Enabled = false;
            this.settingsToolStripMenuItem.Enabled = false;
            this.logINToolStripMenuItem.Enabled = true;
            this.logOutToolStripMenuItem.Enabled = true;
            this.backUpToolStripMenuItem.Enabled = false;
            this.restoreToolStripMenuItem.Enabled = false;
            
        }

        private void FRM_Main_Load(object sender, EventArgs e)
        {

        }

        private void logINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login frm = new Frm_Login();
            frm.ShowDialog();
        }

       void addNewPrToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmAddNewProduct frm = new FrmAddNewProduct();
            frm.ShowDialog();
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductMangement frm = new FrmProductMangement();
            frm.ShowDialog();
        }

        private void categoryManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Categories frm = new frm_Categories();
            frm.ShowDialog();
        }

        private void customerManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Customers frm = new frm_Customers();
            frm.ShowDialog();
        }

        private void salesManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void addNewSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Sales_Management frm = new frm_Sales_Management();
            frm.ShowDialog();
        }

        private void backUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Backup backup = new Backup();
            backup.ShowDialog();
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRestore_Database frm = new frmRestore_Database();
            frm.ShowDialog();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewUser frm = new frmAddNewUser();
            frm.ShowDialog();
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewCustomer frm = new frmAddNewCustomer();
            frm.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.UserID = 0;
            Program.Password = " ";
            frm.productManagementToolStripMenuItem.Enabled = false;
            frm.customersToolStripMenuItem.Enabled = false;
            frm.usersToolStripMenuItem.Enabled = false;
            frm.settingsToolStripMenuItem.Enabled = false;
        }

        private void usersManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListUsers frm = new frmListUsers();
            frm.ShowDialog();
        }

        private void userInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_User_Info frm = new frm_User_Info();

            frm.ShowDialog();
        }
    }
}
