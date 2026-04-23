using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Sales_Management.PresentationLayer
{
    public partial class frmList_Orders : Form
    {
        DataTable dt = new DataTable();
        public frmList_Orders()
        {
            InitializeComponent();
            dgListOrders.DataSource= BL.ClsProducts.GetAllProducts();
            //dgListOrders.Columns[5].Visible = false;
        }

        private void frmList_Orders_Load(object sender, EventArgs e)
        {
           

        }

        private void dgListOrders_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
