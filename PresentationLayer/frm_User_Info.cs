using Project_Sales_Management.Properties;
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
    public partial class frm_User_Info : Form
    {
        public frm_User_Info()
        {
            InitializeComponent();
        }

        private void frm_User_Info_Load(object sender, EventArgs e)
        {
            txtFullName.Text = Program.SaleMan.ToString();
            txtID.Text = Program.UserID.ToString();

            try
            {
                DataTable dt = BL.clsUsers.Get_Image_User(txtID.Text);
                byte[] image = (byte[])(BL.clsUsers.Get_Image_User(txtID.Text)).Rows[0][0];
               
                if (dt.Rows.Count>0 && image!=null)
                {
                    using (MemoryStream ms = new MemoryStream(image))
                    {

                        pbUser.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pbUser.Image = Resources.Aucune_image_disponible;
                }
            }
           
            
            catch(Exception ex)
            {
                MessageBox.Show(" " + ex);
            }
           


        }
    }
}
