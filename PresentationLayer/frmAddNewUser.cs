using Project_Sales_Management.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Sales_Management.PresentationLayer
{
    public partial class frmAddNewUser : Form
    {
        
        public frmAddNewUser()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            byte[] image;
            MemoryStream ms;
            if (pbUser.Image != null)
            {
                using (ms = new MemoryStream())
                {

                    pbUser.Image.Save(ms, pbUser.Image.RawFormat);



                }
                image = ms.ToArray();
            }
            else
            {
                image = null;
            }

            int permission = 0;
            if (rbListUsers.Checked == true)
            {
                permission = -1;
            }
            else if (rbNormal.Checked == true)
            {
                permission = 1;
            }
            else
                permission = 0;


            if (btnAdd.Text== "Add")
            {
               
                string ID = BL.clsUsers.Get_Last_UserID().ToString();
              
                if (BL.clsUsers.AddNewUser(ID, txtPassWord.Text, cbUserType.Text, txtFullName.Text, image, permission))
                {
                    MessageBox.Show("The User Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else 
            {
                btnAdd.Text = "Update";

                var FRM = Application.OpenForms["frmListUsers"] as frmListUsers;

                if (BL.clsUsers.UpdateUser(txtID.Text, txtPassWord.Text, cbUserType.Text, txtFullName.Text, image, permission))
                {
                    MessageBox.Show("The User Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                FRM.dataGirdUsers.DataSource = BL.clsUsers.Get_All_Users(); 



            }


        }

        private void frmAddNewUser_Load(object sender, EventArgs e)
        {
            
                cbUserType.Items.Add("Users");
                cbUserType.Items.Add("Normal");
                cbUserType.SelectedIndex = 0;
        }

        private void txtConfirmPassWord_Validating(object sender, CancelEventArgs e)
        {
            if(txtPassWord.Text != txtConfirmPassWord.Text)
            {
                MessageBox.Show(" Passwords are not Maches, try again ", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
          

        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images |*.PNG; *.JPG";

            if(ofd.ShowDialog()== DialogResult.OK)
            {
                pbUser.ImageLocation = ofd.FileName;
            }

        }
    }
}
