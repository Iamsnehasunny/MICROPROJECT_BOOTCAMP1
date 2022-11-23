using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COMPLAINBOX.ADMIN
{
    public partial class ViewQery1 : System.Web.UI.Page
    {
        BAL.QueryBAL objqry = new BAL.QueryBAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = objqry.Qview();

                GridView1.DataBind();
            }

        }

        /*protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            objqry.QuerryId = id;
            int i = objqry.Updateconfirm();
            GridView1.DataSource = objqry.Qview();
            GridView1.DataBind();
        }*/
    }
}