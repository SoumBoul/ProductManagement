using Product_DB.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Sales_Management.BL
{
    internal class clsOrder_Details
    {
        public static bool Add_Order_Detail(int ID_Product, int Id_Order, int Qte, string Price,
            double Discount, string Amount, string Total_Amount)
        {
            SqlParameter[] param = new SqlParameter[7];
            DataAccessLayer dataAccessLayer = new DataAccessLayer();
            param[0] = new SqlParameter("@ID_Product", SqlDbType.Int);
            param[0].Value = ID_Product;
            param[1] = new SqlParameter("@ID_Order", SqlDbType.Int);
            param[1].Value = Id_Order;
            param[2] = new SqlParameter("@Qte", SqlDbType.Int);
            param[2].Value = Qte;
            param[3] = new SqlParameter("@Price", SqlDbType.VarChar);
            param[3].Value = Price;
            param[4] = new SqlParameter("@Discount", SqlDbType.Float);
            param[4].Value = Discount;
            param[5] = new SqlParameter("@Amount", SqlDbType.VarChar);
            param[5].Value = Amount;
            param[6] = new SqlParameter("@Total_Amount", SqlDbType.VarChar);
            param[6].Value = Total_Amount;

            dataAccessLayer.Execute_Data("sp_Insert_Order_Details", param);
            return true;
        }

        public static bool Update_Order_Detail(int ID_Product, int Id_Order, int Qte, string Price,
            double Discount, string Amount, string Total_Amount)
        {
            DataAccessLayer dataAccessLayer = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@ID_Product", SqlDbType.Int);
            param[0].Value = ID_Product;
            param[1] = new SqlParameter("@ID_Order", SqlDbType.Int);
            param[1].Value = Id_Order;
            param[2] = new SqlParameter("@Qte", SqlDbType.Int);
            param[2].Value = Qte;
            param[3] = new SqlParameter("@Price", SqlDbType.VarChar, 50);
            param[3].Value = Price;
            param[4] = new SqlParameter("@Discount", SqlDbType.Float);
            param[4].Value = Discount;
            param[5] = new SqlParameter("@Amount", SqlDbType.VarChar, 50);
            param[5].Value = Amount;
            param[6] = new SqlParameter("@Total_Amount", SqlDbType.VarChar, 50);
            param[6].Value = Total_Amount;

            try
            {

                dataAccessLayer.Execute_Data("sp_UpdateOrderDetails", param);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }


            return false;
        }



    }
}
