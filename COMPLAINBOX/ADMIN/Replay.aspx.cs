using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COMPLAINBOX.ADMIN
{
    public partial class Replay : System.Web.UI.Page
    {
        BAL.QueryBAL queryBAL = new BAL.QueryBAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int queid = Convert.ToInt32(Request.QueryString["qid"]);
            queryBAL.Querrys = Query.Text;
            queryBAL.QuerryId = queid;
            int i = queryBAL.Queryconfirm();
            if (i == 1)
            {
                Response.Write("<script>alert('Reply Registered Successfully');</script>");



            }
        }
    }
}