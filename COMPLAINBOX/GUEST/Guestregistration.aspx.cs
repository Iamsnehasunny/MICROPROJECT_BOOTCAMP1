using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COMPLAINBOX.GUEST
{
   
    public partial class Guestregistration1 : System.Web.UI.Page
    {
        BAL.RegistrationBAL objreg1 = new BAL.RegistrationBAL();
        

        protected void Button1_Click(object sender, EventArgs e)
        {
            objreg1.adduser = txtusername.Text;
            objreg1.addpassword = txtpswrd.Text;
           object ob= objreg1.userlogininfo();

            objreg1.Name_User = txtname.Text;
            objreg1.UAddress = txtaddress.Text;
            objreg1.UEmail = txtmail.Text;
            objreg1.UPhone = txtphn.Text;
            objreg1.LoginId =Convert.ToInt32( ob);            

            int i = objreg1.registrationinsertion();

            if (i == 1)
            {
                Response.Redirect("../GUEST/GuestLogin.aspx");



            }
            else
            {
                Response.Write("Faild to Register");
            }

        }
    }
}