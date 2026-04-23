using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using Project_Sales_Management.PresentationLayer;
using static Project_Sales_Management.PresentationLayer.frmAddNewUser;
using Project_Sales_Management.BL;
using System.Runtime.CompilerServices;


namespace Product_DB
{
    public class Business_Layer:FRM_Main
    {
       
        public static DataTable Login(string ID, string password)
        {
            DAL.DataAccessLayer dataAcces = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@PassWord", SqlDbType.VarChar, 50);
            param[1].Value = password;

        


            dataAcces.Open();

            //SP_Login Is a stored procedure saved in database
            DataTable dt = dataAcces.select_Data("SP_Login", param);

            dataAcces.Close();

            return dt;
            


        }

       






       

    }
}
