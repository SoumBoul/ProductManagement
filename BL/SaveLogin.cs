using Product_DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;

namespace Project_Sales_Management.BL
{
    public class SaveLogin
    {

        public string name { get; set; }
        public  string admin()
        {
           
            name = Frm_Login.Get_form.txtID.Text;
            return name;
        }
        


    }



}
