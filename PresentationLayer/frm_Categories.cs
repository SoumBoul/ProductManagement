using CrystalDecisions.ReportAppServer.DataDefModel;
using Product_DB.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Sales_Management.PresentationLayer
{
    public partial class frm_Categories : Form
    {
        public DataTable dt = new DataTable();
       
       
        BindingManagerBase bmb;
        SqlCommandBuilder cmb = new SqlCommandBuilder();
        SqlDataAdapter da;
        SqlConnection connection = new SqlConnection("Server=.;Database=Product_DB;User Id=sa;Password=123456;");
         
        public void GetAllCategories()
        {
            dt = BL.clsCategories.GetAllCategories();
            this.DataGirdCategiries.DataSource = dt;
            

        }
        public frm_Categories()
        {
            InitializeComponent();

            da = new SqlDataAdapter("select * from Categories", connection);
            da.Fill(dt);
            this.DataGirdCategiries.DataSource = dt;

            txtCat_ID.DataBindings.Add("Text", dt, "ID_Cat");
            txtDescription.DataBindings.Add("Text", dt, "Description");
            bmb= this.BindingContext[DataGirdCategiries.DataSource];


           


        }

        private void frm_Categories_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            lblCount.Text = (bmb.Position + 1) + "/" + (dt.Rows.Count);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bmb.Position += 1;
            lblCount.Text = (bmb.Position + 1) + "/" + (dt.Rows.Count);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bmb.Position -= 1;
            lblCount.Text = (bmb.Position + 1) + "/" + (dt.Rows.Count);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bmb.Position = dt.Rows.Count;
            lblCount.Text = (bmb.Position + 1) + "/" + (dt.Rows.Count);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            bmb.AddNew();
            txtDescription.Focus();
            txtCat_ID.Text = dt.Rows[dt.Rows.Count - 1][0].ToString();
            btnAdd.Enabled = false;

            lblCount.Text=  (bmb.Position + 1) + "/" + (dt.Rows.Count);
            btnAdd.Enabled = false;
            btnAddNewCat.Enabled = true;

        
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmb = new SqlCommandBuilder(da);
           
            da.Update(dt);
            MessageBox.Show("The Categorie Updated Successfully");
           
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnAddNewCat_Click(object sender, EventArgs e)
        {
           
            bmb.EndCurrentEdit();
            cmb = new SqlCommandBuilder(da);
            da.Update(dt);

            btnAddNewCat.Enabled = false;
            MessageBox.Show("The Categorie Added Successfully");
            btnAddNewCat.Enabled = false;
            btnAdd.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bmb.RemoveAt(bmb.Position);
            bmb.EndCurrentEdit();
             
            cmb = new SqlCommandBuilder(da);
            da.Update(dt);

            MessageBox.Show("The Categorie Deleted Successfully");

        }
    }
}
