using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;

namespace COMPLAINBOX.DAL
{
    public class ProductDAL
    {
        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public ProductDAL()
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

        public int Insertpro(BAL.ProductBAL obj)
        {
            string qry = "insert into Tbl_Product values('" + obj.Pname + "')";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();
        }

        public DataTable Viewpro(BAL.ProductBAL obj)
        {
            string s = "select * from Tbl_Product " ;
            SqlCommand cmd = new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int Updatepro(BAL.ProductBAL obj)
        {
            string qry = "update Tbl_Product set ProductName='" + obj.Pname + "' where Product_Id='" + obj.Pid + "'";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();
        }

        public int Deleteproduct(BAL.ProductBAL obj)
        {
            string s = "delete from Tbl_Product where Product_Id='" + obj.Pid + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }

       
    }
}