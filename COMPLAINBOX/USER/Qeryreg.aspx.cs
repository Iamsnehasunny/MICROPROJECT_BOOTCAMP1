using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COMPLAINBOX.USER
{
    public partial class Qeryreg : System.Web.UI.Page
    {
        BAL.QueryBAL objqrybal = new BAL.QueryBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlproduct.DataSource = objqrybal.getproduct();
                ddlproduct.DataTextField = "ProductName";
                ddlproduct.DataValueField = "Product_Id";
                ddlproduct.DataBind();
                ddlproduct.Items.Insert(0, new ListItem("-- Select --", "0"));

            }
        }

        protected void btnreg_Click(object sender, EventArgs e)
        {
           objqrybal.ProducttID = Convert.ToInt32(ddlproduct.SelectedValue);
            objqrybal.CustomerId = Convert.ToInt32(Session["custid"]);
            //objqrybal.Querrys = Request.Form["txtqery"];
            objqrybal.Querrys = txtqery.Text;

            int i = objqrybal.insertQery();
            if (i == 1)
            {
                Response.Write("<script>alert('Querry Registered Successfully');</script>");
                //ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('" + "Complaint Registered Successfully" + "');");
            }
        }
    }
}