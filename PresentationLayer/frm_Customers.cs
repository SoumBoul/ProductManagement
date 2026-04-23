
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Project_Sales_Management.PresentationLayer
{
    public partial class frm_Customers : Form
    {

        public DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommandBuilder cmd;
        BindingManagerBase bmb;

        SqlConnection connection = new SqlConnection("Server=.;Database=Product_DB;User Id=sa;Password=123456;");

        public frm_Customers()
        {
            InitializeComponent();
            dt = BL.clsCustomers.GetAllCustomers();
            da = new SqlDataAdapter("select *from Customers", connection);
         

           
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            
            byte[] MyImage = (byte[])dt.Rows[0]["Image_Customer"];

            

            BL.clsCustomers.Add_NewCustomer(txtFirstName.Text, txtLastName.Text,txtTel.Text,txtEmail.Text, MyImage);

            MessageBox.Show("The Customer Added Successfully");

            txtFirstName.Text = " ";
            txtLastName.Text = " ";
            txtTel.Text = " ";
            txtEmail.Text = " ";
           

            dt = BL.clsCustomers.GetAllCustomers();



        }

        private void button5_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            lblCount.Text = (bmb.Position + 1) + "/" + dt.Rows.Count;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bmb.Position += 1;
            lblCount.Text = (bmb.Position + 1) + "/" + dt.Rows.Count;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bmb.Position -= 1;
            lblCount.Text = (bmb.Position + 1) + "/" + dt.Rows.Count;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bmb.Position = dt.Rows.Count;
            lblCount.Text = (bmb.Position + 1) + "/" + dt.Rows.Count;

        }

        private void frm_Customers_Load(object sender, EventArgs e)
        {

            dt = BL.clsCustomers.GetAllCustomers();
            dgCustomers.DataSource = dt;

            
            dgCustomers.Columns["Image_Customer"].Visible = false;
            dgCustomers.Columns["ID_Customer"].Visible = false;

           
            txtFirstName.DataBindings.Add("text", dt, "First_Name");
            txtLastName.DataBindings.Add("text", dt, "Last_Name");
            txtTel.DataBindings.Add("text", dt, "Tel");
            txtEmail.DataBindings.Add("text", dt, "Email");


            

            byte[] image = (byte[])dt.Rows[0]["Image_Customer"];


            if (dt.Rows[0]["Image_Customer"] == DBNull.Value)
            {
                pbImage1.Image = null;
                return;
            }

            else

            {
                using (MemoryStream ms = new MemoryStream(image))
                {
                    pbImage1.Image = Image.FromStream(ms);
                }

                //pbImage1.DataBindings.Add("Image", dt, "Image_Customer");
            }

            bmb = BindingContext[dgCustomers.DataSource];


        }

        private void pbImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images |*.png;*.gpj";
            if(ofd.ShowDialog()== DialogResult.OK)
            {
                pbImage1.ImageLocation = ofd.FileName;
            }
              
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Byte[] MyImage = null;
            if (pbImage1.Image!=null)
            {
                MemoryStream ms = new MemoryStream();
                pbImage1.Image.Save(ms, pbImage1.Image.RawFormat);
                MyImage = ms.ToArray();

            }
            else
            {
                pbImage1.Image = null;
            }

          
            if (BL.clsCustomers.Update_Customer(txtFirstName.Text, txtLastName.Text, txtTel.Text, txtEmail.Text, MyImage))
            {
                MessageBox.Show("The Customer Updated Successfully");
                dgCustomers.DataSource = BL.clsCustomers.GetAllCustomers();

            }
            else
                MessageBox.Show("Error");


         

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure do you want delete this Customer? ","Delete",MessageBoxButtons.OK,MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                int ID = int.Parse(dgCustomers.CurrentRow.Cells[0].Value.ToString());
                BL.clsCustomers.Delete_Customer(ID);
                MessageBox.Show("The Customer Deleted successfully");
                dgCustomers.DataSource = BL.clsCustomers.GetAllCustomers();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgCustomers_Click(object sender, EventArgs e)
        {

        }

        private void dgCustomers_DoubleClick(object sender, EventArgs e)
        {

            int id = ((int)dgCustomers.CurrentRow.Cells[0].Value);


           byte[] image=(byte[])  BL.clsCustomers.Get_Image_Customer(id).Rows[0][0];

            MemoryStream ms = new MemoryStream(image);
            pbImage1.Image = Image.FromStream(ms); 

            
           

        }

        private void pbSearsh_Click(object sender, EventArgs e)
        {
            dgCustomers.DataSource = BL.clsCustomers.FindCustomer(txtSearsh.Text);
                
        }

        private void txtSearsh_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtSearsh_TextChanged(object sender, EventArgs e)
        {
           
                pbSearsh_Click(sender, e);
            
        }

       
    }
}
