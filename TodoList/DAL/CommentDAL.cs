using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class CommentDAL
    {
        public static List<CommentDTO> getcmn(int jId)
        {
            List<CommentDTO> data = new List<CommentDTO>();
            DAL.ConnectDB();
            DAL.conn.Open();
            string sql = "select * from Comment where job_id="+jId;
            SqlCommand cmd = new SqlCommand(sql, DAL.conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.HasRows)
            {
                while (reader.Read())
                {
                    CommentDTO cmn = new CommentDTO();
                    cmn.cmnId = reader.GetInt32(0);
                    cmn.jId = jId;
                    cmn.userId = reader.GetInt32(1);
                    cmn.cmnContent = reader.GetString(3);
                    cmn.cmnNgay = reader.GetDateTime(4).ToString();

                    data.Add(cmn);
                }
                reader.NextResult();
            }
            return data;
        }

        public static List<CommentDTO> getcmn(string jId)
        {
            List<CommentDTO> data = new List<CommentDTO>();
            DAL.ConnectDB();
            DAL.conn.Open();
            string sql = "select * from Comment where job_id like '" + jId + "'";
            SqlCommand cmd = new SqlCommand(sql, DAL.conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.HasRows)
            {
                while (reader.Read())
                {
                    CommentDTO cmn = new CommentDTO();
                    cmn.cmnId = reader.GetInt32(0);
                    cmn.jId = reader.GetInt32(2);
                    cmn.userId = reader.GetInt32(1);
                    cmn.cmnContent = reader.GetString(3);
                    cmn.cmnNgay = reader.GetDateTime(4).ToString();

                    data.Add(cmn);
                }
                reader.NextResult();
            }
            return data;
        }

        public static DataTable getCmn(int jId)
        {
            DAL.ConnectDB();
            DAL.conn.Open();
            string sql = @"select cmt_id as 'Mã bình luận', cmt_content as 'Bình luận', cmt_ngay as 'Ngày bình luận', user_name as 'Tên người bình luận'
from Comment, DBUser
where DBUser.user_id=Comment.user_id and job_id=" + jId;
            SqlCommand cmd = new SqlCommand(sql, DAL.conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

    }
}
