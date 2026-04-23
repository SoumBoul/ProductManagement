using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Product_DB.DAL;


namespace Project_Sales_Management.BL
{
    internal class clsOrders
    {

        public static DataTable Get_Last_Order_Num()
        {

            DataAccessLayer dataAccessLayer = new DataAccessLayer();
            DataTable dt = new DataTable();
           

            dataAccessLayer.Open();
            dt= dataAccessLayer.select_Data("sp_Get_Last_Order_Num", null);

            dataAccessLayer.Close();
            return dt;

        }

        public static bool Add_Order( int ID_Order, DateTime Date_Order, int Customer_Id,
            string Description_Order, string Saler_Man)
        {
            SqlParameter[] param = new SqlParameter[5];
            DataAccessLayer dataAccessLayer = new DataAccessLayer();
            param[0] = new SqlParameter("@ID_Order", SqlDbType.Int);
            param[0].Value = ID_Order;
            param[1] = new SqlParameter("@Date_Order", SqlDbType.DateTime);
            param[1].Value = Date_Order;
            param[2] = new SqlParameter("@Customer_Id", SqlDbType.Int);
            param[2].Value = Customer_Id;
            param[3] = new SqlParameter("@Description_Order", SqlDbType.VarChar);
            param[3].Value = Description_Order;
            param[4] = new SqlParameter("@Sales_Man", SqlDbType.VarChar);
            param[4].Value = Saler_Man;
           

            dataAccessLayer.Execute_Data("sp_Insert_Order", param);
            return true;
        }

        public static bool IsExistOrder(int ID)
        {
            DataAccessLayer dataAccessLayer = new DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            dataAccessLayer.Open();

            param[0] = new SqlParameter("ID_Order", SqlDbType.Int);
            param[0].Value = ID;

            dt = dataAccessLayer.select_Data("IsExistOrder", param);


            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
                return false;


        }








    }
}
