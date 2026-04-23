using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_DB.DAL
{
    internal class DataAccessLayer
    {
        SqlConnection connection;
        public   DataAccessLayer()
        {

            connection= new SqlConnection("Server=.;Database=Product_DB;User Id=sa;Password=123456;");
        }

        public void Open()
        {

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public void Close()
        {

            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }
        public   DataTable select_Data(string StoredProcedure, SqlParameter[] param)
        {
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = StoredProcedure;
            SqlConnection connect = connection;
            command.Connection = connect;


            if (param!=null)
            {
                for(int i=0;i<param.Length;i++)
                {
                    command.Parameters.Add(param[i]);
                }
            }
           

            SqlDataReader reader = command.ExecuteReader();
            if ((reader.HasRows))
            {
                dt.Load(reader);
            }

           

                
            return dt;

        }

        public  void Execute_Data(string StoredProcedure, SqlParameter[] param)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = StoredProcedure;
            SqlConnection connect = connection;
            command.Connection = connect;

            connect.Open();

            if (param!=null)
            {
                for(int i=0;i<param.Length;i++)
                {
                    command.Parameters.Add(param[i]);
                }
            }

          

            command.ExecuteNonQuery();

            connect.Close();
            

        }


    }
}
