using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace COMPLAINBOX.DAL
{
    public class QueryDAL
    {
        

        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public QueryDAL()
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

        public DataTable Getproduct(BAL.QueryBAL obj)
        {
            string s = "SELECT * FROM Tbl_Product";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int QueryInsert(BAL.QueryBAL obj)
        {
            string qry = "insert into Tbl_Query values('" + obj.Querrys + "','Complaint Received','" + DateTime.Now.ToLongDateString().ToString() + "','" + obj.ProducttID + "')";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();
        }

        public DataTable ViewQuery(BAL.QueryBAL obj)
        {
            string s = "select * from Tbl_Registration tb inner join Tbl_Query cmt on tb.r_Id = cmt.r_Id inner join Tbl_Product pt on pt.Product_Id=cmt.Product_Id";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        public int Confirmupdateqry(BAL.QueryBAL obj)
        {
            string s = "update Tbl_Query set Q_Status='Confirmed' where Query_Id='" + obj.QuerryId+ "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }

    }
}