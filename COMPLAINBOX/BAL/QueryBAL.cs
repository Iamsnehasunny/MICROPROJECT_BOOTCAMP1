using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting;
using System.Web;

namespace COMPLAINBOX.BAL
{
    
    public class QueryBAL
    {
        DAL.QueryDAL objqry = new DAL.QueryDAL();

        private int _querryid;
        private int _customerid;
        private int _productid;
        private string _querry;

        public int QuerryId
        {
            get
            {
                return _querryid;
            }
            set
            {
                _querryid = value;
            }
        }
        public int CustomerId
        {
            get
            {
                return _customerid;
            }
            set
            {
                _customerid = value;
            }
        }
        public int ProducttID
        {
            get
            {
                return _productid;
            }
            set
            {
                _productid = value;
            }
        }
        public string Querrys
        {
            get
            {
                return _querry;
            }
            set
            {
                _querry = value;
            }
        }

        public DataTable getproduct()
        {
            return objqry.Getproduct(this);
        }

        public int insertQery()
        {
            return objqry.QueryInsert(this);
        }

        public DataTable Qview()
        {
            return objqry.ViewQuery(this);
        }
        public int Queryconfirm()
        {
            return objqry.Confirmupdateqry(this);
        }

    }
}