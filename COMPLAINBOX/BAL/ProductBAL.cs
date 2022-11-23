using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting;
using System.Web;
using System.Xml.Linq;
using System.Data;
using System.Data.SqlClient;


namespace COMPLAINBOX.BAL
{
    public class ProductBAL
    {
        DAL.ProductDAL objpro = new DAL.ProductDAL();

        private int _prdID;
        private string _prdname;

        

        public int Pid
        {
            get
            {
                return _prdID;
            }
            set
            {
                _prdID = value;
            }
        }
        public string Pname
        {
            get
            {
                return _prdname;
            }
            set
            {
                _prdname = value;
            }
        }
       
        public int regproduct()
        {
            return objpro.Insertpro(this);
        }

        public DataTable prodview()
        {
            return objpro.Viewpro(this);
        }

        public  int Update()
        {
            return objpro.Updatepro(this);
        }

        public int deleteproduct()
        {
            return objpro.Deleteproduct(this);
        }
    }
}