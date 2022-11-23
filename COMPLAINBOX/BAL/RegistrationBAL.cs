using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using static System.Net.WebRequestMethods;
using System.IO;

namespace COMPLAINBOX.BAL
{
    public class RegistrationBAL
    {
      
            DAL.RegistrationDAL objreg1 = new DAL.RegistrationDAL();

            private string _name;
            private string _address;
            private string _email;
            private string _phone;
            private string _adduser;
            private string _addpsw;
        private int _loginid;
           

           public string Name_User
            {
                get
                {
                    return _name;
                }
                set
                {
                    _name = value;
                }
            }
            public string UAddress
            {
                get
                {
                    return _address;
                }
                set
                {
                    _address = value;
                }
            }
            public string UEmail
            {
                get
                {
                    return _email;
                }
                set
                {
                    _email = value;
                }
            }
            public string UPhone
            {
                get
                {
                    return _phone;
                }
                set
                {
                    _phone = value;
                }
            }
            public string adduser
            {
                get
                {
                    return _adduser;
                }
                set
                {
                    _adduser = value;
                }
            }
            public string addpassword
            {
                get
                {
                    return _addpsw;
                }
                set
                {
                    _addpsw = value;
                }
            }

        public int LoginId
        {
            get
            {
                return _loginid;
            }
            set
            {
                _loginid = value;
            }
        }




        public int registrationinsertion()
            {
                return objreg1.Insertreg(this);
            }
       public object userlogininfo()
        {
            return objreg1.insertlogin(this);
        }
        public DataTable loginfunction()
        {
            return objreg1.Loginfun(this);
        }

        public DataTable GetUserInfo()
        {
            return objreg1.getuserlog(this);
        }

        public DataTable Uview()
        {
            return objreg1.Viewuser(this);
        }

        public int Updateconfirm()
        {
            return objreg1.Confirmupdate(this);
        }
    }

}