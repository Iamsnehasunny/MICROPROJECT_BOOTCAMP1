using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace COMPLAINBOX.DAL
{
    public class ComplaintDAL
    {
        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public ComplaintDAL()
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

        public DataTable Getproduct(BAL.ComplaintBAL obj)
        {
            string s = "SELECT * FROM Tbl_Product";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int complaintInsert(BAL.ComplaintBAL obj)
        {
            string qry = "insert into Tbl_Complain values('" + obj.cmplnt + "','Complaint Received','" + DateTime.Now.ToLongDateString().ToString() + "','" + obj.prodId+"')";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();
        }

        public DataTable complaintview(BAL.ComplaintBAL obj)
        {
            string s = "select * from Tbl_Registration tb inner join Tbl_Complain cmt on tb.r_Id=cmt.r_Id inner join Tbl_Product pt on pt.Product_Id=cmt.Product_Id";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int Confirmupdate(BAL.ComplaintBAL obj)
        {
            string s = "update Tbl_Complain set C_Status='Confirmed' where Cm_Id='" + obj.CmplntId + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }
    }
}