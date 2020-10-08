using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class JobDAL
    {
        private static object dataGridView1;

        public static void insert(JobDTO job)
        {
            DAL.ConnectDB();
            DAL.conn.Open();
            string sql = "Insert into DBJob values ('" + job.jTitle + "','" + job.jStarday + "','" + job.jEndday + "','"
                + job.jPartner + "','" + job.jCircle + "','" + job.jAttachments + "')";
            SqlCommand cmd = new SqlCommand(sql, DAL.conn);
            cmd.ExecuteNonQuery();
        }
        public static void delete(JobDTO job_id)
        {
            DAL.ConnectDB();
            DAL.conn.Open();
            string sql = @"delete from DBJob where DBJob.job_id = '" + job_id + "' ";
            SqlCommand cmd = new SqlCommand(sql, DAL.conn);
            cmd.ExecuteNonQuery();
        }
        public static DataTable get_AllJob()
        {
            DAL.ConnectDB();
            DAL.conn.Open();
            string sql = @"SELECT DBJob.job_id, DBJob.job_title, DBJob.job_starday, DBJob.job_endday, DBJob.job_partner, DBJob.job_circle, DBJob.job_attachments, Comment.cmt_content, DBUser.user_name
            FROM   DBJob INNER JOIN
             Comment ON DBJob.job_id = Comment.job_id INNER JOIN
             DBUser ON Comment.user_id = DBUser.user_id";
            SqlCommand cmd = new SqlCommand(sql, DAL.conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public static DataTable getJob(int jId)
        {
            DAL.ConnectDB();
            DAL.conn.Open();
            string sql = @"SELECT DBJob.job_id, DBJob.job_title, DBJob.job_starday, DBJob.job_endday, DBJob.job_partner, DBJob.job_circle, DBJob.job_attachments, Comment.cmt_content, DBUser.user_name
FROM DBJob INNER JOIN
             Comment ON DBJob.job_id = Comment.job_id INNER JOIN
             DBUser ON Comment.user_id = DBUser.user_id where DBJob.job_id = " + jId;
            SqlCommand cmd = new SqlCommand(sql, DAL.conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        /*public static DataTable loc(string ngbd, string ngkt,int manv)
        {
            DAL.ConnectDB();
            DAL.conn.Open();
            string sql = @"SELECT DBJob.job_id, DBJob.job_title, DBJob.job_starday, DBJob.job_endday, DBJob.job_partner, DBJob.job_circle, DBJob.job_attachments, Comment.cmt_content, DBUser.user_name
FROM   DBJob INNER JOIN
             Comment ON DBJob.job_id = Comment.job_id INNER JOIN
             DBUser ON Comment.user_id = DBUser.user_id where DBJob.job_starday>=" + ngbd + "and DBJob.job_starday<=" + ngkt + "and DBUser.user_id=" + manv; 
                        
            SqlCommand cmd = new SqlCommand(sql, DAL.conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public static DataTable locday(string ngbd, string ngkt)
        {
            DAL.ConnectDB();
            DAL.conn.Open();
            string sql = @"SELECT DBJob.job_id, DBJob.job_title, DBJob.job_starday, DBJob.job_endday, DBJob.job_partner, DBJob.job_circle, DBJob.job_attachments, Comment.cmt_content, DBUser.user_name
FROM   DBJob INNER JOIN
             Comment ON DBJob.job_id = Comment.job_id INNER JOIN
             DBUser ON Comment.user_id = DBUser.user_id where DBJob.job_starday>=" + ngbd + "and DBJob.job_starday<=" + ngkt ;

            SqlCommand cmd = new SqlCommand(sql, DAL.conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }*/
    }
}
