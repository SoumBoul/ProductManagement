using System;

using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Product_DB;
using Project_Sales_Management.PresentationLayer;
using System.Windows.Forms.VisualStyles;


namespace Project_Sales_Management
{
    public enum enPermission { None = 0, NormalUser = 1, GetAllPermissions = -1 };
 
    public partial class Frm_Login :Form
    {
       public static  Frm_Login frm ;

        

        public static void Form_Closed(object sender,FormClosedEventArgs e)
        {
            frm = null;
        }
        public static Frm_Login Get_form
        {
            get
            {
                if(frm==null)
                {
                   frm =new Frm_Login();

                  frm.FormClosed += new FormClosedEventHandler(Form_Closed);
                }
                return frm;
            }



        }

        public Frm_Login()
        {
            if(frm==null)
            {
                 frm= this;
            }
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            int userPermission = Convert.ToInt32(Project_Sales_Management.BL.clsUsers.Permission(Convert.ToInt32(txtID.Text)));

            if ((userPermission & (int)enPermission.NormalUser) == (int)enPermission.NormalUser)
            {
               
                FRM_Main.get_Frm_Main.usersToolStripMenuItem.Enabled = true;
                FRM_Main.get_Frm_Main.usersToolStripMenuItem.Visible = true;

            }

            else 
            {
                FRM_Main.get_Frm_Main.usersToolStripMenuItem.Visible = false;
            }

            Business_Layer BL = new Business_Layer();
            DataTable dt=  Business_Layer.Login(txtID.Text, txtPassWord.Text);

            if(dt.Rows.Count>0)
            {
               
                FRM_Main.get_Frm_Main.folderToolStripMenuItem.Enabled = true;
                FRM_Main.get_Frm_Main.productManagementToolStripMenuItem.Enabled = true;
                FRM_Main.get_Frm_Main.customersToolStripMenuItem.Enabled = true;
                FRM_Main.get_Frm_Main.restoreToolStripMenuItem.Enabled = true;
                FRM_Main.get_Frm_Main.backUpToolStripMenuItem.Enabled = true;

                //FRM_Main.get_Frm_Main.usersToolStripMenuItem.Enabled = false;
                FRM_Main.get_Frm_Main.categoryManagementToolStripMenuItem.Enabled = true;
                FRM_Main.get_Frm_Main.settingsToolStripMenuItem.Enabled = true;
                Program.SaleMan = dt.Rows[0]["FullName"].ToString();
                Program.Password = dt.Rows[0]["PassWord"].ToString();
                Program.UserID = Convert.ToInt32(dt.Rows[0]["ID"].ToString());
                this.Close();
            }

            else
                MessageBox.Show("Login Failed");
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
