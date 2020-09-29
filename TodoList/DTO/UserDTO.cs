using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserDTO
    {
        private int u_id;
        private string u_name;
        private string u_pass;
        private string u_email;
        private int u_type;
        private string u_phone;

        public int uId
        {
            get
            {
                return u_id;
            }
            set
            {
                u_id = value;
            }
        }
        public string uName
        {
            get
            {
                return u_name;
            }
            set
            {
                u_name = value;
            }
        }
        public string uPass
        {
            get
            {
                return u_pass;
            }
            set
            {
                u_pass = value;
            }
        }
        public string uEmail
        {
            get
            {
                return u_email;
            }
            set
            {
                u_email = value;
            }
        }
        public int uType
        {
            get
            {
                return u_type;
            }
            set
            {
                u_type = value;
            }
        }
        public string uPhone
        {
            get
            {
                return u_phone;
            }
            set
            {
                u_phone = value;
            }
        }

        public UserDTO() { }

    }
}
