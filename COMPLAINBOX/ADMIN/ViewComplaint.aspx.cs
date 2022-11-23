using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COMPLAINBOX.ADMIN
{
    public partial class ViewComplaint1 : System.Web.UI.Page
    {
        //BAL.ComplaintBAL objdalcmplt = new BAL.ComplaintBAL();
        BAL.ComplaintBAL objcmp = new BAL.ComplaintBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = objcmp.viewcomplaint();
                GridView1.DataBind();
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            objcmp.CmplntId = id;
            int i = objcmp.Updateconfirm();
            GridView1.DataSource = objcmp.viewcomplaint();
            GridView1.DataBind();
        }







}   }