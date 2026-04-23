using Product_DB.DAL;
using SAPBusinessObjects.WPF.ViewerShared.EMFRender;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Project_Sales_Management.PresentationLayer
{
    public partial class Backup : Form
    {
        public Backup()
        {
            InitializeComponent();


        }

        SqlConnection connection = new SqlConnection("server=.;database= DB1; User id= sa; password= 123456;");
        public void BackUp( string Database_Name)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();


            saveFileDialog.Filter = "Backup Files (*.bak) | *.bak";
           

            if (saveFileDialog.ShowDialog()== DialogResult.OK)
            {
                 string path = saveFileDialog.FileName;
               
                SqlCommand cmd = new SqlCommand($"Backup Database {Database_Name} to Disk= '"+ path+ " '", connection);

                connection.Open();
                cmd.ExecuteNonQuery();
            
                connection.Close();

                MessageBox.Show("The Backup of database succeeded successfully");
                btnBuckup.Enabled = false;
            }

           
       

        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            BackUp(txtDB_Name.Text);
        }

      
        private void Backup_Load(object sender, EventArgs e)
        {
            txtDB_Name.Text = "Product_DB";

        }

       
    }
}
