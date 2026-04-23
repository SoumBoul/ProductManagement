using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Sales_Management.PresentationLayer
{
    public partial class frm_Desplay_Customers : Form
    {
        public frm_Desplay_Customers()
        {
           InitializeComponent();
            dgListCustomers.DataSource = BL.clsCustomers.GetAllCustomers();


            dgListCustomers.Columns["Image_Customer"].Visible= false ;
            
        }

        private void frm_Desplay_Customers_Load(object sender, EventArgs e)
        {
          


            
        }

        private void dgListCustomers_DoubleClick(object sender, EventArgs e)
        {

            frm_Sales_Management.get_Form.txtCustomer_ID.Text = dgListCustomers.CurrentRow.Cells[0].Value.ToString();
            frm_Sales_Management.get_Form.txtFirstName.Text = dgListCustomers.CurrentRow.Cells[1].Value.ToString();
            frm_Sales_Management.get_Form.txtLastName.Text = dgListCustomers.CurrentRow.Cells[2].Value.ToString();
            frm_Sales_Management.get_Form.txtTel.Text = dgListCustomers.CurrentRow.Cells[3].Value.ToString();
            frm_Sales_Management.get_Form.txtEmail.Text = dgListCustomers.CurrentRow.Cells[4].Value.ToString();

            byte[] picture = (byte[])(dgListCustomers.CurrentRow.Cells[5].Value);
            MemoryStream ms = new MemoryStream(picture);
            frm_Sales_Management.get_Form.pbCustomer.Image = Image.FromStream(ms);

            Close();



        }



    }
}
