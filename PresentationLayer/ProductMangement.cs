using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Project_Sales_Management.PresentationLayer
{
    public partial class FrmProductMangement : Form
    {
        public static FrmProductMangement frm;

        public static void Form_Closed(object sendr, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static FrmProductMangement Get_Form
        {
            get
            {
                if(frm==null)
                {
                    FrmProductMangement frm = new FrmProductMangement();
                    frm.FormClosed += new FormClosedEventHandler(Form_Closed);
                }

               
                    return frm;
            }
           

        }

        public static DataTable GetAllProducts()
        {
            return BL.ClsProducts.GetAllProducts();
        }
        public FrmProductMangement()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            dataGridViewProductManagement.DataSource= GetAllProducts();
           

        }

        private void ProductMangement_Load(object sender, EventArgs e)
        {

        }

        private void txtSearsh_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
             dt= BL.ClsProducts.SearshProduct(txtSearsh.Text);
            dataGridViewProductManagement.DataSource = dt;


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddNewProduct frm = new FrmAddNewProduct();

            frm.ShowDialog();
            dataGridViewProductManagement.DataSource = GetAllProducts();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
          if(  MessageBox.Show("Are you sure do you want delete this produc?","Delete",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
                {

                if(BL.ClsProducts.DeleteProduct(dataGridViewProductManagement.CurrentRow.Cells[0].Value.ToString()))
                dataGridViewProductManagement.DataSource = GetAllProducts();
                MessageBox.Show("Product Deleted Successfully", "information");

               
            }

          else
                MessageBox.Show("Error", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
            FrmAddNewProduct frm = new FrmAddNewProduct();

            
            frm.txtTitle.Text = "Update Product";
            frm.btnAdd.Name = "Update";

            frm.txtProductID.Text = dataGridViewProductManagement.CurrentRow.Cells[0].Value.ToString();
            frm.cbProductType.Text = dataGridViewProductManagement.CurrentRow.Cells[4].Value.ToString();
           
            frm.txtQuantity.Text=(Convert.ToInt32(dataGridViewProductManagement.CurrentRow.Cells[2].Value).ToString());
            frm.txtPrice.Text= dataGridViewProductManagement.CurrentRow.Cells[3].Value.ToString();
            frm.txtDescription.Text= dataGridViewProductManagement.CurrentRow.Cells[1].Value.ToString();

            DataTable dt = new DataTable();

            dt = BL.ClsProducts.GetImage(dataGridViewProductManagement.CurrentRow.Cells[0].Value.ToString());
            byte[] image = (byte[])(BL.ClsProducts.GetImage(dataGridViewProductManagement.CurrentRow.Cells[0].Value.ToString()).Rows[0][0]);
            MemoryStream ms = new MemoryStream(image);

            frm.pbProduct.Image = Image.FromStream(ms);

            frm.txtProductID.Enabled = false;

           
            frm.ShowDialog();

            

            
            
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            frm_PhotoProduct frm = new frm_PhotoProduct();

            DataTable dt = new DataTable();
            dt = BL.ClsProducts.GetImage(dataGridViewProductManagement.CurrentRow.Cells[0].Value.ToString());
            if(dt.Rows.Count>0)
           { 
                byte[] image = (byte[])(BL.ClsProducts.GetImage(dataGridViewProductManagement.CurrentRow.Cells[0].Value.ToString()).Rows[0][0]);

                 MemoryStream ms = new MemoryStream(image);
                frm.pbImageProduct.Image = Image.FromStream(ms);
            }
            else
            {
                return;
            }

            frm.ShowDialog();

            
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrintProduct_Click(object sender, EventArgs e)
        {
            frm_PrintDocument frm = new frm_PrintDocument();

           
            
            frm.ShowDialog();
        }
    }
}
