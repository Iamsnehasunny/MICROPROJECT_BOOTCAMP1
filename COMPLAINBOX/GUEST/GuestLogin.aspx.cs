using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace COMPLAINBOX.GUEST
{
    public partial class GuestLogin : System.Web.UI.Page
    {
        BAL.RegistrationBAL objreg1 = new BAL.RegistrationBAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objreg1.adduser = txtusername.Text;
            objreg1.addpassword = txtpswrd.Text;

            DataTable dtobj = objreg1.loginfunction();
            
            if(dtobj.Rows.Count == 1)
            {
                Session["LId"] = dtobj.Rows[0]["Login_Id"].ToString();
                Session["Uname"] = dtobj.Rows[0]["Username"].ToString();

                string a = dtobj.Rows[0]["UserType"].ToString().Trim();


                if (a == "Admin")
                {
                    Response.Write("<script>alert('Admin Login Faild')</script>");
                    Response.Redirect("../ADMIN/AdminLogPage.aspx");
                }
                else
                {
                    string c = dtobj.Rows[0]["Status"].ToString().Trim();

                    if (c == "customer")
                    {
                        Response.Write("Logged in succesfully");
                        Response.Redirect("../USER/UserHome.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('Failed to login')</script>");
                        Response.Redirect("../GUEST/GuestHome.aspx");
                    }


                }
            }
        }
    }
}