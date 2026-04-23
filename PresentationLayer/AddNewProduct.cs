using Product_DB.DAL;
using Project_Sales_Management.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Sales_Management.PresentationLayer
{
    public partial class FrmAddNewProduct : Form
    {

       
        public FrmAddNewProduct()
        {
            InitializeComponent();
            
            

          
        }



        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images: |*.JPG;*.GIF; *.PNG;*.BMP ";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbProduct.ImageLocation = ofd.FileName;
            }
        }

        private void FrmAddNewProduct_Load(object sender, EventArgs e)
        {
            cbProductType.DataSource = BL.ClsProducts.GetAllCategories();
            cbProductType.SelectedIndex = 0;
            cbProductType.DisplayMember = "Description";
            cbProductType.ValueMember = "ID_Cat";


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            if(btnAdd.Name == "btnAdd")
            {
                byte[] imageBytes = null;
                if (pbProduct.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pbProduct.Image.Save(ms, pbProduct.Image.RawFormat);
                        imageBytes = ms.ToArray();
                    }


                }

                if (ClsProducts.AddNewProject(Convert.ToInt32(cbProductType.SelectedValue), txtDescription.Text, txtProductID.Text, Convert.ToInt32(txtQuantity.Text), txtPrice.Text, imageBytes))
                {
                    MessageBox.Show("Product Added Successfully");

                   
                }
                else
                    MessageBox.Show("Added Failed", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

           else
            {
                byte[] imageBytes = null;
                if (pbProduct.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pbProduct.Image.Save(ms, pbProduct.Image.RawFormat);
                        imageBytes = ms.ToArray();
                    }


                }

                if (ClsProducts.UpdateProduct(Convert.ToInt32(cbProductType.SelectedValue), txtDescription.Text, txtProductID.Text ,Convert.ToInt32(txtQuantity.Text), txtPrice.Text, imageBytes))
                {
                    MessageBox.Show("Product Updated Successfully");

                    FrmProductMangement.Get_Form.dataGridViewProductManagement.DataSource = BL.ClsProducts.GetAllProducts(); ;


                }
                else
                    MessageBox.Show("Update Failed", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }


        }

        private void txtProductID_Validated(object sender, EventArgs e)
        {
            
                if (ClsProducts.IsExistProduct(txtProductID.Text) == true)
                {
                    MessageBox.Show("This ID_Product is already exist", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtProductID.Focus();
                    txtProductID.SelectionStart = txtProductID.Text.Length;
                }
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
  