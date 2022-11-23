using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COMPLAINBOX.ADMIN
{
    public partial class ProductReg1 : System.Web.UI.Page
    {
        BAL.ProductBAL objprod = new BAL.ProductBAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objprod.Pname = txtprname.Text;


            int i = objprod.regproduct();

                    if(i == 1)
                {
                    Response.Write("successfully inserted");
                }
                else
                {
                    Response.Write("unsuucessfull");
                }
        }
    }
}