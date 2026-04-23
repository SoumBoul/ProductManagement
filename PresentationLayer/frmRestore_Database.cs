
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_Sales_Management.PresentationLayer
{
    public partial class frmRestore_Database : Form
    {
        public frmRestore_Database()
        {
            InitializeComponent();
            txtDB_Name.Text = "DB1";
        }

        SqlConnection connection = new SqlConnection("server=.;database= master; User id= sa; password= 123456;");

        public  void Restore_Database(string DB_Name)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = " Backup Files (*.Bak) | *.Bak";

            if (od.ShowDialog() == DialogResult.OK)
            {
                 string path = od.FileName;
                SqlCommand cmd = new SqlCommand($"Restore database {DB_Name} from Disk = '" + path + "' With replace", connection);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("The Restore of database succeeded successfully");
                btnRestore.Enabled = false;
            }

        }
        
        private void btnRestore_Click(object sender, EventArgs e)
        {
            Restore_Database( txtDB_Name.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            if(of.ShowDialog()== DialogResult.OK)
            {
                txtDB_Name.Text = of.FileName;

            }
        }

        private void frmRestore_Database_Load(object sender, EventArgs e)
        {
            txtDB_Name.Text = "Product_DB";
        }
    }
}
