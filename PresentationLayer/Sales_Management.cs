using Project_Sales_Management.BL;
using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Sales_Management.PresentationLayer
{
      
    public partial class frm_Sales_Management : Form

    {

       
        public SaveLogin login = new SaveLogin();
        public static frm_Sales_Management frm;
        public static void Form_Closer(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static frm_Sales_Management get_Form
        {
            get
            {
                if (frm == null)
                {
                    frm = new frm_Sales_Management();
                }


                return frm;
            }
        }

        DataTable dt = new DataTable();
        public void CreateDataTable()
        {
            dt.Columns.Add("id_Order");
            dt.Columns.Add("Name");
            dt.Columns.Add("Price");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Amount");
            dt.Columns.Add("Tva");
            dt.Columns.Add("Total Price");


            dgOrders.DataSource = dt;


        }
        public frm_Sales_Management()
        {
            if (frm == null)
            {
                frm = this;
            }
            InitializeComponent();
            txtSalerName.Text = login.admin();

            CreateDataTable();


        }

        public void TotalAmout()
        {
            if (txtPrice.Text == string.Empty && txtPrice.Text == string.Empty)
            {
                txtPrice.Focus();
                return;
            }
            double price = Convert.ToDouble(txtPrice.Text);
            double qte = Convert.ToDouble(txtQte.Text);
            txtAmount.Text = (price * qte).ToString();

        }
        public void TotalPrices()
        {
            if (txtTva.Text == string.Empty)
            {
                txtTva.Focus();
                return;
            }
            double amount = Convert.ToDouble(txtAmount.Text);
            double qte = Convert.ToDouble(txtQte.Text);
            double tva = Convert.ToDouble(txtTva.Text);

            txtTotal.Text = (amount - (amount * tva / 100)).ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            frm_Desplay_Customers frm = new frm_Desplay_Customers();

            frm.ShowDialog();


        }

        private void frm_Sales_Management_Load(object sender, EventArgs e)
        {
            txtSalerName.Text = Program.SaleMan;
            txtID.Width = 120;
            txtName.Width = 150;
            txtPrice.Width = 120;
            txtQte.Width = 120;
            txtAmount.Width = 110;
            txtTva.Width = 110;
            txtTotal.Width = 128;




        }

        public void Clear()
        {
            txtID.Text = " ";
            txtName.Text = " ";
            txtPrice.Text = " ";
            txtQte.Text = " ";
            txtAmount.Text = " ";
            txtTva.Text = " ";
            txtTotal.Text = " ";


        }

        private void btnNewSale_Click(object sender, EventArgs e)
        {
            txtInvoice_ID.Text = BL.clsOrders.Get_Last_Order_Num().Rows[0][0].ToString(); ;


        }



        private void btnSearsh_Click(object sender, EventArgs e)
        {
            frmList_Orders frm = new frmList_Orders();
            frm.ShowDialog();

            txtID.Text = frm.dgListOrders.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = frm.dgListOrders.CurrentRow.Cells[4].Value.ToString();
            txtPrice.Text = frm.dgListOrders.CurrentRow.Cells[3].Value.ToString();
            //txtTva.Text= dgOrders.CurrentRow.Cells[5].Value.ToString();


        }

        private void txtQte_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != num)
            {
                e.Handled = true;
            }

        }


        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != num)
            {
                e.Handled = true;
            }
        }

        private void txtTva_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != num)
            {
                e.Handled = true;
            }


        }

        private void txtQte_KeyDown(object sender, KeyEventArgs e)

        {
            for (int i = 0; i < dgOrders.Rows.Count; i++)
            {
                if (dgOrders.Rows[i].Cells[i].Value != null && dgOrders.Rows[i].Cells[i].Value.ToString() == txtID.Text)
                {
                    MessageBox.Show("Order ID exists");
                    Clear();
                    return;
                }
            }
            if (e.KeyCode != Keys.Enter)
            {
                txtQte.Focus();
            }
        }

        private void txtQte_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPrice.Text == string.Empty)
            {
                txtPrice.Focus();
                return;

            }
            double price = Convert.ToDouble(txtPrice.Text);

            if (txtQte.Text == string.Empty)
            {
                txtQte.Focus();
                return;
            }
            TotalAmout();
        }



        private void txtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                txtTva.Focus();
                return;
            }

            if (txtPrice.Text == string.Empty && txtQte.Text == string.Empty)
            {
                txtPrice.Focus();
                txtQte.Focus();
                return;
            }

        }

        private void txtQte_TextChanged(object sender, EventArgs e)
        {
            if (txtPrice.Text == string.Empty && txtQte.Text == string.Empty)
            {
                txtPrice.Focus();
                return;

            }



        }

        private void txtTva_KeyUp(object sender, KeyEventArgs e)
        {


            TotalPrices();

            bool isIdProductExist = (from DataGridViewRow r in dgOrders.Rows
                                     where r.Cells[0].FormattedValue.ToString() != string.Empty
                                     select r.Cells[0].FormattedValue).Contains(txtID.Text);


        }



        private void txtTva_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                DataRow row = dt.NewRow();

                for (int i = 0; i < dgOrders.Rows.Count - 1; i++)
                {
                    if (dgOrders.Rows[i].Cells[0].Value != null && dgOrders.Rows[i].Cells[i].Value.ToString() == txtID.Text)
                    {
                        MessageBox.Show("Order ID exists");
                        Clear();
                        return;
                    }
                }

                row[0] = txtID.Text;

                row[1] = txtName.Text;
                row[2] = txtPrice.Text;
                row[3] = txtQte.Text;
                row[4] = txtAmount.Text;
                row[5] = txtTva.Text;
                row[6] = txtTotal.Text;

                dt.Rows.Add(row);
                dgOrders.DataSource = dt;


                txtTotalPrices.Text = (from DataGridViewRow r in dgOrders.Rows
                                       where r.Cells[6].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(r.Cells[6].FormattedValue)).Sum().ToString();

                Double tva = Convert.ToDouble(txtTva.Text);

                if (BL.clsOrders.IsExistOrder(Convert.ToInt32(txtInvoice_ID.Text)))
                {


                    if (BL.clsOrder_Details.Update_Order_Detail(Convert.ToInt32(txtID.Text), Convert.ToInt32(txtInvoice_ID.Text), Convert.ToInt32(txtQte.Text), txtPrice.Text, tva, txtAmount.Text, txtTotal.Text))
                    {
                        MessageBox.Show("The Order Details Updated Successfully");
                    }

                }




                btnSersh.Focus();
                Clear();


                return;

            }

        }



        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Double tva = Convert.ToDouble(txtTva.Text);

            if (BL.clsOrder_Details.Add_Order_Detail(Convert.ToInt32(txtID.Text), Convert.ToInt32(txtInvoice_ID.Text), Convert.ToInt32(txtQte.Text), txtPrice.Text, tva, txtAmount.Text, txtTotal.Text))
            {
                MessageBox.Show("The Order Details Saved Successfully");
            }

        }

        private void dgOrders_DoubleClick(object sender, EventArgs e)
        {


            txtID.Text = dgOrders.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgOrders.CurrentRow.Cells[1].Value.ToString();
            txtPrice.Text = dgOrders.CurrentRow.Cells[2].Value.ToString();
            txtQte.Text = dgOrders.CurrentRow.Cells[3].Value.ToString();
            txtAmount.Text = dgOrders.CurrentRow.Cells[4].Value.ToString();
            txtTva.Text = dgOrders.CurrentRow.Cells[5].Value.ToString();
            txtTotal.Text = dgOrders.CurrentRow.Cells[6].Value.ToString();



            dgOrders.Rows.RemoveAt(dgOrders.CurrentRow.Index);

            txtQte.Focus();


        }
   

       

        private void btnSave_Click(object sender, EventArgs e)
        {
          
            if (!BL.clsOrders.IsExistOrder(Convert.ToInt32(txtInvoice_ID.Text)))
            {

                BL.clsOrders.Add_Order(Convert.ToInt32(txtInvoice_ID.Text), Convert.ToDateTime(DateTimeName.Text), Convert.ToInt32(txtCustomer_ID.Text), txtDescription.Text, txtSalerName.Text);
               
               
                for(int i=0; i<dgOrders.Rows.Count-1 ;i++)
                {
                    BL.clsOrder_Details.Add_Order_Detail(

                       
                        Convert.ToInt32(dgOrders.Rows[i].Cells[0].Value),
                        Convert.ToInt32(txtInvoice_ID.Text),

                        Convert.ToInt32(dgOrders.Rows[i].Cells[3].Value),
                        
                        dgOrders.Rows[i].Cells[2].Value.ToString(),
                        Convert.ToDouble(dgOrders.Rows[i].Cells[5].Value),
                        dgOrders.Rows[i].Cells[4].Value.ToString(),
                        dgOrders.Rows[i].Cells[6].Value.ToString()
                       
                        );
                }
                
                    MessageBox.Show("The Order details  Saved Successfully");
                

            }
        }
    }
}
