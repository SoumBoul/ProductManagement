using CrystalDecisions.ReportAppServer.DataDefModel;
using Product_DB.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.SessionState;
using System.Windows.Forms;

namespace Project_Sales_Management.BL
{
    internal class clsCustomers
    {
       
        public static DataTable GetAllCustomers()
        {
        DataAccessLayer dataAccessLayer = new DataAccessLayer();
        DataTable dt = new DataTable();
           
            dataAccessLayer.Open();
            dt= dataAccessLayer.select_Data("sp_GetAllCustomers", null);
            dataAccessLayer.Close();
            return dt;
        }
        public static bool Update_Customer(string First_Name, string Last_Name,string TeL, string Email, byte[] Image)
        {
            DataAccessLayer dataAccessLayer = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[5];
         
           
            param[0] = new SqlParameter("@First_Name", SqlDbType.VarChar, 50);
            param[0].Value = First_Name;
            param[1] = new SqlParameter("@Last_Name", SqlDbType.VarChar, 50);
            param[1].Value = Last_Name;
            param[2] = new SqlParameter("@TeL", SqlDbType.VarChar, 50);
            param[2].Value = TeL;
            param[3] = new SqlParameter("@Email", SqlDbType.VarChar, 50);
            param[3].Value = Email;
            param[4] = new SqlParameter("@Image_Customer", SqlDbType.VarBinary);
            param[4].Value = Image;

            try
            {
                
                dataAccessLayer.Execute_Data("sp_UpdateCustomer", param);
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex}");
            }


            return false;
        }

        public static bool Add_NewCustomer( string First_Name, string Last_Name, string TeL, string Email, byte[] Image)
        {
            DataAccessLayer dataAccessLayer = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@First_Name", SqlDbType.VarChar, 50);
            param[0].Value = First_Name;
            param[1] = new SqlParameter("@Last_Name", SqlDbType.VarChar, 50);
            param[1].Value = Last_Name;
            param[2] = new SqlParameter("@Tel ", SqlDbType.VarChar, 50);
            param[2].Value = TeL;
            param[3] = new SqlParameter("@Email", SqlDbType.VarChar, 50);
            param[3].Value = Email;
            param[4] = new SqlParameter("@Image_Customer", SqlDbType.VarBinary);
            param[4].Value = Image;
            

            try
            {

                dataAccessLayer.Execute_Data("sp_AddNewCustomer", param);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }


            return false;
        }

        public static void Delete_Customer(int ID)
        {

            DataAccessLayer dataAccessLayer = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_Customer", SqlDbType.Int);
            param[0].Value = ID;
            dataAccessLayer.Execute_Data("sp_DeleteCustomer",param);

        }
        public static DataTable Get_Image_Customer(int image_ID)
        {

            DataAccessLayer dataAccessLayer = new DataAccessLayer();
            dataAccessLayer.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = image_ID;

           DataTable dt= dataAccessLayer.select_Data("sp_GetImageCustomer", param);

            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            else
                return dt;
         


        }

        public static DataTable FindCustomer(string Customer_ID)
        {

            DataAccessLayer dataAccessLayer = new DataAccessLayer();
            dataAccessLayer.Open();
            
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID ", SqlDbType.VarChar);
            param[0].Value = Customer_ID;

            DataTable dt = dataAccessLayer.select_Data("sp_FindCustomer", param);

           

            return dt;



        }

        public static int Get_Last_CustomerID()
        {
            int CustomerID;
            DataAccessLayer dataAccessLayer = new DataAccessLayer();
            dataAccessLayer.Open();
            DataTable dt = dataAccessLayer.select_Data("sp_GetLast_CustomerID", null);

            CustomerID = Convert.ToInt32(dt.Rows[0][0].ToString());

            return CustomerID;

        }



    }
}
