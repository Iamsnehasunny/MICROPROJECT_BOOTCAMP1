using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Web.UI.HtmlControls;
using System.Data;
using System.Security.Policy;


namespace COMPLAINBOX.ADMIN
{
    public partial class Productviewadmin1 : System.Web.UI.Page
    {
        BAL.ProductBAL objprod = new BAL.ProductBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = objprod.prodview();
                GridView1.DataBind();
            }
        }

       
        

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = objprod.prodview();
            GridView1.DataBind(); 
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());



            TextBox txtname = new TextBox();
            txtname = (TextBox)GridView1.Rows[e.RowIndex].Cells[0].Controls[0];
            objprod.Pid = id;
            objprod.Pname = txtname.Text;
            int i = objprod.Update();
            GridView1.DataSource = objprod.prodview();
            GridView1.DataBind();

            


        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GridView1.DataSource = objprod.prodview();
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            objprod.Pid = id;
            int i = objprod.deleteproduct();
            GridView1.DataSource = objprod.prodview();
            GridView1.DataBind();
        }
    }
}