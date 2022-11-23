using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace COMPLAINBOX.USER
{
    public partial class Complaintregistration1 : System.Web.UI.Page
    {

        BAL.ComplaintBAL objcmplnt = new BAL.ComplaintBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlproduct.DataSource = objcmplnt.getproduct();
                ddlproduct.DataTextField = "ProductName";
                ddlproduct.DataValueField = "Product_Id";
                ddlproduct.DataBind();
                ddlproduct.Items.Insert(0, new ListItem("-- Select --", "0"));

            }
        }

        protected void btnreg_Click(object sender, EventArgs e)
        {
            objcmplnt.prodId = Convert.ToInt32(ddlproduct.SelectedValue);
            objcmplnt.custId = Convert.ToInt32(Session["custid"]);
            //objcmplnt.cmplnt = Request.Form["txtacomplaint"];
            objcmplnt.cmplnt = txtcomplaint.Text;

            int i = objcmplnt.insertComplaint();
            if (i == 1)
            {
                Response.Write("<script>alert('Complaint Registered Successfully');</script>");
            }
        }
    }
}