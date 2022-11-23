using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COMPLAINBOX.ADMIN
{
    public partial class UserView1 : System.Web.UI.Page
    {
        BAL.RegistrationBAL objpro = new BAL.RegistrationBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = objpro.Uview();
                GridView1.DataBind();
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            objpro.LoginId = id;
            int i = objpro.Updateconfirm();
            GridView1.DataSource = objpro.Uview();
            GridView1.DataBind();
        }
    }
}