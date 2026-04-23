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
    public partial class frmAddNewCustomer : Form
    {
        public frmAddNewCustomer()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            byte[] ImageCustomer = null;


            if(pbCustomer.Image!=null)
            {
                using( MemoryStream ms = new MemoryStream())

                {
                   pbCustomer.Image.Save(ms, pbCustomer.Image.RawFormat);
                   ImageCustomer = ms.ToArray();

                }

            }
          


           if( BL.clsCustomers.Add_NewCustomer(txtFirstName.Text, txtLast_Name.Text, txtTel.Text, txtEmail.Text, ImageCustomer))
            {
                MessageBox.Show("Product Added Successfully");
            }

            txtCustomer_ID.Text = BL.clsCustomers.Get_Last_CustomerID().ToString();
        }

        private void btnSelectImageCustomer_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images: | *.PNG; *.jpg; *.GIF";

            if(ofd.ShowDialog()== DialogResult.OK)
            {
                string f = ofd.FileName;
                pbCustomer.Image = Image.FromFile(f);

            }



        }

        private void frmAddNewCustomer_Load(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
