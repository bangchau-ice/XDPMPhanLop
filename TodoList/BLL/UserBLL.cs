using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserBLL
    {
        public UserBLL() { }


        public static List<UserDTO> get_AllUser()
        {

            List<UserDTO> data = new List<UserDTO>();
            data = UserDAL.get_AllUser();
            return data;
        }

        public static int SignIn(string email, string pass)
        {
            UserDTO u = new UserDTO();
            //int i = 0;
            List<UserDTO> data = new List<UserDTO>();
            data = UserDAL.get_AllUser();
            //for (int j = 0; j < data.Count; j++)
            foreach (UserDTO item in data)
            {
                string e = item.uEmail.ToString();
                if (item.uEmail == email)
                    return 1;
                //else i = 0;
            }

            return 0;

        }
    }
}
