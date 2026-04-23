using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Product_DB.DAL;
using Project_Sales_Management.BL;

using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection.Emit;
using static System.Windows.Forms.AxHost;


namespace Project_Sales_Management.BL
{
    internal class ClsProducts
    {
        
        public static DataTable GetAllCategories()
        {
            DataAccessLayer Dal = new DataAccessLayer();
            DataTable dt = new DataTable();

            try
            {
                Dal.Open();
                dt = Dal.select_Data("Get_All_Products_Categories", null);
                return dt;
            }
            finally
            {
                // Ceci sera exécuté même s'il y a une exception
                Dal.Close();
            }
           

        }

        public static DataTable GetAllProducts()
        {
            DataAccessLayer Dal = new DataAccessLayer();
            DataTable dt = new DataTable();

            try
            {
                Dal.Open();
                dt = Dal.select_Data("sp_GetAllProducts", null);
                return dt;
            }
            finally
            {
                // Ceci sera exécuté même s'il y a une exception
                Dal.Close();
            }


        }
        public static bool DeleteProduct(string ID)
        {
            DataAccessLayer Dal = new DataAccessLayer();
           
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

          
              
                 Dal.Execute_Data("sp_DeleteProduct", param);
                return true;
           

        }


        public static bool AddNewProject(int ID_Cat,string Label,string Id_Product
                                          ,int Qte, string Price,byte[] image)
        {

            DataAccessLayer Dal = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[6];


         
            param[0] = new SqlParameter("@ID_Cat", SqlDbType.Int);
            param[0].Value = ID_Cat;

            param[1] = new SqlParameter("@ID_Product", SqlDbType.VarChar, 50);
            param[1].Value = Id_Product;

            param[2] = new SqlParameter("@Label_Product", SqlDbType.VarChar, 50);
            param[2].Value = Label;

            param[3] = new SqlParameter("@Qte_Product", SqlDbType.Int);
            param[3].Value = Qte;

            param[4] = new SqlParameter("@Price", SqlDbType.VarChar,50);
            param[4].Value = Price;

            param[5] = new SqlParameter("@Image_Product", SqlDbType.VarBinary);
            param[5].Value =(object) image?? DBNull.Value;


          
            Dal.Execute_Data("AddNewProduct", param);
            Dal.Close();
           
            return true;
          

        }

        public static bool IsExistProduct(string ID)
        {
            DataAccessLayer dataAccessLayer = new DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            dataAccessLayer.Open();

            param[0]= new SqlParameter("ID_Product", SqlDbType.VarChar);
            param[0].Value = ID ;

            dt = dataAccessLayer.select_Data("IsExistProduct",param );
            

            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
                return false;
            

        }

        public static DataTable  GetImage(string ID)
        {
            DataAccessLayer dataAccessLayer = new DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            dataAccessLayer.Open();

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar,50);
            param[0].Value = ID;

            dt = dataAccessLayer.select_Data("sp_GetImage", param);


            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            else
                return dt;


        }

        public static DataTable SearshProduct(string ID)
        {
            DataAccessLayer dataAccessLayer = new DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            dataAccessLayer.Open();

            param[0] = new SqlParameter("@ID_Product", SqlDbType.VarChar,50);
            param[0].Value = ID;

            dt = dataAccessLayer.select_Data("sp_SearshProduct", param);


            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            else
                return dt ;


        }

        public static DataTable Find_Product(string ID)
        {
            DataAccessLayer dataAccessLayer = new DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            dataAccessLayer.Open();

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            dt = dataAccessLayer.select_Data("sp_Find_Product", param);


            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            else
                return dt;


        }

      
        public static bool UpdateProduct(int ID_Cat, string Label,
                                   string Id_Product, int Qte, string Price, byte[] image)
        {

            DataAccessLayer Dal = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[6];



            param[0] = new SqlParameter("@ID_Cat", SqlDbType.Int);
            param[0].Value = ID_Cat;

            param[1] = new SqlParameter("@ID_Product", SqlDbType.VarChar, 50);
            param[1].Value = Id_Product;

            param[2] = new SqlParameter("@Label", SqlDbType.VarChar, 50);
            param[2].Value = Label;

            param[3] = new SqlParameter("@Qte", SqlDbType.Int);
            param[3].Value = Qte;

            param[4] = new SqlParameter("@Price", SqlDbType.VarChar, 50);
            param[4].Value = Price;

            param[5] = new SqlParameter("@Image", SqlDbType.VarBinary);
            param[5].Value = (object)image ?? DBNull.Value;

          

            Dal.Execute_Data("sp_UpdateProduct", param);
            Dal.Close();

            return true;


        }



    }
}
