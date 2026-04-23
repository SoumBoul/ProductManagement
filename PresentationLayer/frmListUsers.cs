using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Sales_Management.PresentationLayer
{
    public partial class frmListUsers : Form
    {

       

        private void Newfrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            dt = BL.clsUsers.Get_All_Users();
            dataGirdUsers.DataSource = dt;
            dataGirdUsers.Columns[4].Visible = false;

            return dt;
        }

      
        public frmListUsers()
        {
            InitializeComponent();

            GetAllUsers();


        }

        private void frmListUsers_Load(object sender, EventArgs e)
        {

        }

        private void txtSearsh_TextChanged(object sender, EventArgs e)
        {
            dataGirdUsers.DataSource = BL.clsUsers.SearshUser(txtSearsh.Text);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddNewUser frm = new frmAddNewUser();
            frm.ShowDialog();
            GetAllUsers();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (MessageBox.Show("Are you sure do you want delete this User?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                if (BL.clsUsers.DeleteUser(dataGirdUsers.CurrentRow.Cells[0].Value.ToString()))
                    dataGirdUsers.DataSource = GetAllUsers();
                MessageBox.Show("Product Deleted Successfully", "information");
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {

            frmAddNewUser frm = new frmAddNewUser();
            frm.btnAdd.Text = "Update";
            frm.txtID.Text = dataGirdUsers.CurrentRow.Cells[0].Value.ToString();
            frm.txtFullName.Text = dataGirdUsers.CurrentRow.Cells[3].Value.ToString();
            frm.cbUserType.Text = dataGirdUsers.CurrentRow.Cells[4].Value.ToString();
            frm.txtPassWord.Text = dataGirdUsers.CurrentRow.Cells[1].Value.ToString();
            frm.txtConfirmPassWord.Text = dataGirdUsers.CurrentRow.Cells[1].Value.ToString();
         
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

    }
}
