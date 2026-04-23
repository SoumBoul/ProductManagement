using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Product_DB.DAL;
using System.Data;
using System.Windows.Forms;

namespace Project_Sales_Management.BL
{
    internal class clsUsers
    {

        public static bool AddNewUser(string ID, string PassWord, string UserType,
                                          string FullName, byte[] image, int Permission)
        {

            DataAccessLayer Dal = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[6];



            param[0] = new SqlParameter("@ID", SqlDbType.VarChar,50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@PassWord", SqlDbType.VarChar, 50);
            param[1].Value = PassWord;

            param[2] = new SqlParameter("@UserType", SqlDbType.VarChar, 50);
            param[2].Value = UserType;

            param[3] = new SqlParameter("@FullName", SqlDbType.VarChar, 50);
            param[3].Value = FullName;

            param[4] = new SqlParameter("@Image", SqlDbType.Image, 100);
            param[4].Value = image;

            param[5] = new SqlParameter("@Permission", SqlDbType.Int);
            param[5].Value = Permission;


            Dal.Execute_Data("sp_AddNewUser", param);
            Dal.Close();

            return true;


        }

        public static DataTable Get_User_Type()
        {

            DataAccessLayer dataAccessLayer = new DataAccessLayer();
            DataTable dt = new DataTable();

            try
            {
                dataAccessLayer.Open();
                dt = dataAccessLayer.select_Data("sp_Get_UserType", null);
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                dataAccessLayer.Close();
            }
            return dt;

        }

        public static int Permission(int id)
        {

            DataAccessLayer dataAccessLayer = new DataAccessLayer();
            DataTable dt = new DataTable();

            SqlParameter [] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = id;


            try
            {
                dataAccessLayer.Open();
                dt = dataAccessLayer.select_Data("sp_Permissions", param);
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                dataAccessLayer.Close();
            }


             int d= Convert.ToInt32(dt.Rows[0][0].ToString());
            return d;
        }

        public static int Get_Last_UserID()
        {
            int UserID;
            DataAccessLayer dataAccessLayer = new DataAccessLayer();
            dataAccessLayer.Open();
            DataTable dt = dataAccessLayer.select_Data("sp_GetLast_UserID", null);

            UserID = Convert.ToInt32(dt.Rows[0][0].ToString());

            return UserID;

        }

        public static string Get_UserID(string fullName)
        {
             string UserID="";
            DataAccessLayer dataAccessLayer = new DataAccessLayer();
            dataAccessLayer.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@FullName", SqlDbType.VarChar, 50);
            param[0].Value = fullName;

            DataTable dt = dataAccessLayer.select_Data("sp_Searsh_UserID", param);

            if(dt.Rows.Count>0)
            {
                UserID = dt.Rows[0][0].ToString();

            }
            dataAccessLayer.Close();


            return UserID;

        }

        public static DataTable Get_All_Users()
        {
           
            DataAccessLayer dataAccessLayer = new DataAccessLayer();
            dataAccessLayer.Open();
            DataTable dt = dataAccessLayer.select_Data("sp_Get_All_Users", null);

           

            return dt;

        }
        public static DataTable SearshUser(string letter)
        {
            DataAccessLayer dataAccessLayer = new DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            dataAccessLayer.Open();

            param[0] = new SqlParameter("@Letter", SqlDbType.VarChar, 50);
            param[0].Value = letter;

            dt = dataAccessLayer.select_Data("sp_Searsh_Users", param);


            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            else
                return dt;


        }

        public static bool DeleteUser(string ID)
        {
            DataAccessLayer Dal = new DataAccessLayer();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_User", SqlDbType.VarChar, 50);
            param[0].Value = ID;



            Dal.Execute_Data("sp_Delete_User", param);
            return true;


        }

        public static bool UpdateUser(string ID, string Password,
                                 string UserType, string FullName, byte[] image, int Permission)
        {

            DataAccessLayer Dal = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[6];



            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@PassWord", SqlDbType.VarChar, 50);
            param[1].Value = Password;

            param[2] = new SqlParameter("@UserType", SqlDbType.VarChar, 50);
            param[2].Value = UserType;

            param[3] = new SqlParameter("@FullName", SqlDbType.VarChar, 50);
            param[3].Value = FullName;

            param[4] = new SqlParameter("@Image", SqlDbType.VarBinary);
            param[4].Value = (object)image ?? DBNull.Value;

            param[5] = new SqlParameter("@Permission", SqlDbType.Int);
            param[5].Value = Permission;



            Dal.Execute_Data("sp_Update_User", param);
            Dal.Close();

            return true;


        }

        public static DataTable Get_Image_User(string image_ID)
        {

            DataAccessLayer dataAccessLayer = new DataAccessLayer();
            dataAccessLayer.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar,50);
            param[0].Value = image_ID;

            DataTable dt = dataAccessLayer.select_Data("sp_GetImageUser ", param);

            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            else
                return dt;



        }



    }
}
