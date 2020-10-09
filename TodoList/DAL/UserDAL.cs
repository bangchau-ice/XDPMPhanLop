using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserDAL
    {
        //public User_dal() { }

        public static UserDTO getUser(int uId)
        {
            UserDTO u = new UserDTO();
            DAL.ConnectDB();
            DAL.conn.Open();
            string sql = "SELECT * FROM DBUser WHERE user_id=" + uId;
            SqlCommand cmd = new SqlCommand(sql, DAL.conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                u.uId = Int16.Parse(reader["user_id"].ToString());
                u.uName = reader["user_name"].ToString();
                u.uPass = reader["user_pass"].ToString();
                u.uEmail = reader["user_email"].ToString();
                u.uType = Int16.Parse(reader["user_type"].ToString());
                u.uPhone = reader["user_phone"].ToString();
            }
            return u;
        }
        public static List<UserDTO> get_AllUser()
        {
            List<UserDTO> data = new List<UserDTO>();
            DAL.ConnectDB();
            DAL.conn.Open();
            string sql = "SELECT * FROM DBUser";
            SqlCommand cmd = new SqlCommand(sql, DAL.conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.HasRows)
            {
                while (reader.Read())
                {
                    UserDTO u = new UserDTO();
                    u.uId = Int16.Parse(reader["user_id"].ToString());
                    u.uName = reader["user_name"].ToString();
                    u.uPass = reader["user_pass"].ToString();
                    u.uEmail = reader["user_email"].ToString();
                    u.uType = Int16.Parse(reader["user_type"].ToString());
                    u.uPhone = reader["user_phone"].ToString();
                    data.Add(u);
                }
                reader.NextResult();
            }
            return data;
        }
        public static List<UserDTO> listU(List<CommentDTO> cmn)
        {
            List<UserDTO> data = new List<UserDTO>();
            for(int i=0; i<cmn.Count(); i++)
            {
                UserDTO user = new UserDTO();
                user = getUser(cmn[i].userId);
                data.Add(user);
            }
            return data;

        }
    }
}
