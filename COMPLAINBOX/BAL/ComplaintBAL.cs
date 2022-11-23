using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting;
using System.Web;

namespace COMPLAINBOX.BAL
{
    public class ComplaintBAL
    {
        DAL.ComplaintDAL objdalcmplt = new DAL.ComplaintDAL();

        private int _complaintid;
        private int _customerid;
        private int _productid;
        private string _cmplnt;


        public int CmplntId
        {
            get
            {
                return _complaintid;
            }
            set
            {
                _complaintid = value;
            }
        }
        public int custId
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
        public int prodId
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
        public string cmplnt
        {
            get
            {
                return _cmplnt;
            }
            set
            {
                _cmplnt = value;
            }
        }
        public DataTable getproduct()
        {
            return objdalcmplt.Getproduct(this);
        }

        public int insertComplaint()
        {
            return objdalcmplt.complaintInsert(this);
        }

        public DataTable viewcomplaint()
        {
            return objdalcmplt.complaintview(this);
        }
        public int Updateconfirm()
        {
            return objdalcmplt.Confirmupdate(this);
        }
    }
}