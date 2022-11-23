using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;
using static System.Net.WebRequestMethods;
using System.IO;


namespace COMPLAINBOX.DAL
{
    public class RegistrationDAL
    {
       
       
            public SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            public RegistrationDAL()
            {
                String conn = ConfigurationManager.ConnectionStrings["Complaint1"].ConnectionString;
                con = new SqlConnection(conn);
                cmd.Connection = con;
            }

            public SqlConnection Getcon()
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                return con;
            }

           public int Insertreg(BAL.RegistrationBAL obj)
            {
                string qry = "insert into Tbl_Registration values('" + obj.Name_User + "', '" + obj.UAddress + "', '" + obj.UEmail + "', '" + obj.UPhone + "','"+obj.LoginId+"')";
                SqlCommand cmd = new SqlCommand(qry, Getcon());
                return cmd.ExecuteNonQuery();
            }
            
            public object insertlogin(BAL.RegistrationBAL obj)
            {
                string qry = "insert into Tbl_Login values('" + obj.adduser+ "', '" + obj.addpassword + "','customer',0);select @@IDENTITY";
                SqlCommand cmd = new SqlCommand(qry, Getcon());
                return cmd.ExecuteScalar();
            }
        
            public DataTable getuserlog(BAL.RegistrationBAL obj)
            {
                string s = "select * from Tbl_Login where Username= '" + obj.adduser + "' and password= '" + obj.addpassword + "'";
                SqlCommand cmd = new SqlCommand(s, Getcon());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }

            public DataTable Loginfun(BAL.RegistrationBAL obj)
            {
                string qry = "SELECT * FROM Tbl_Login WHERE Username='" + obj.adduser + "' AND password='" + obj.addpassword + "'";
                SqlCommand cmd = new SqlCommand(qry, Getcon());

                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dtobj = new DataTable();
                ad.Fill(dtobj);
                return dtobj;
            }

            public DataTable Viewuser(BAL.RegistrationBAL obj)
            {
            string s = "SELECT * FROM Tbl_Registration ct inner join Tbl_Login lt on ct.Login_Id=lt.Login_Id"; 
            SqlCommand cmd = new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
            }

            public int Confirmupdate(BAL.RegistrationBAL obj)
            {
                string s = "update Tbl_Login set status='Confirmed' where Login_Id='" + obj.LoginId + "'";
                SqlCommand cmd = new SqlCommand(s, Getcon());
                return cmd.ExecuteNonQuery();
            }




    }
}