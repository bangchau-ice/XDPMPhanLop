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
            int i = 0;
            List<UserDTO> data = new List<UserDTO>();
            data = UserDAL.get_AllUser();
            
            //for (int j = 0; j < data.Count; j++)
            foreach (UserDTO item in data)
            {
                string e = item.uEmail.ToString();
                if (item.uEmail == email)
                    if (item.uPass == pass)
                        i= item.uId;
                //else i = 0;
            }

            return i;

        }
        public static UserDTO getUser(int id)
        {
            UserDTO user = new UserDTO();
            user= DAL.UserDAL.getUser(id);
            return user;
        }

        public static List<UserDTO> ListU(List<CommentDTO> cmn)
        {
            List<UserDTO> data = new List<UserDTO>();
            data = DAL.UserDAL.listU(cmn);
            return data;
        }
    }
}
