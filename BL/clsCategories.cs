using Product_DB.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Sales_Management.BL
{
    internal class clsCategories
    {
        DataAccessLayer dataAccessLayer = new DataAccessLayer();
        public static  DataTable GetAllCategories()
        {

            DataAccessLayer dataAccessLayer = new DataAccessLayer();
            DataTable dt = new DataTable();

            try
            {
                dataAccessLayer.Open();
                dt = dataAccessLayer.select_Data("sp_GetAllCategories", null); 
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

        public static bool AddNewCategorie(string Description)
        {
            SqlParameter[] param = new SqlParameter[1];
            DataAccessLayer dataAccessLayer = new DataAccessLayer();
            param[0] = new SqlParameter("@Description", SqlDbType.VarChar);
            param[0].Value = Description;
            dataAccessLayer.Execute_Data("sp_AddNewCategorie", param);
            return true;
        }


    }
}
