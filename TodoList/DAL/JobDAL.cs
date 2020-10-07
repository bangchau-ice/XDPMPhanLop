using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class JobDAL
    {
        public static void insert(JobDTO job)
        {
            DAL.ConnectDB();
            DAL.conn.Open();
            string sql = "Insert into DBJob values ('" + job.jTitle + "','" + job.jStarday + "','" + job.jEndday + "','"
                + job.jPartner + "','" + job.jCircle + "','" + job.jAttachments + "')";
            SqlCommand cmd = new SqlCommand(sql, DAL.conn);
            cmd.ExecuteNonQuery();
        }


    }
}
