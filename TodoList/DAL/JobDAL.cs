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
            string sql = @"SELECT DBJob.job_id, DBJob.job_title, DBJob.job_status, DBUser.user_name
            FROM   DBJob INNER JOIN
             DBUser ON DBJob.job_partner = DBUser.user_id";
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
        public static DataTable search(int jId)
        {
            DAL.ConnectDB();
            DAL.conn.Open();
            string sql = @"SELECT DBJob.job_id, DBJob.job_title, DBJob.job_status, DBUser.user_name
            FROM   DBJob INNER JOIN
             DBUser ON DBJob.job_partner = DBUser.user_id where job_id="+jId;
            SqlCommand cmd = new SqlCommand(sql, DAL.conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public static DataTable getUserJob(string jId)
        {
            DAL.ConnectDB();
            DAL.conn.Open();
            string sql = @"SELECT DBJob.job_title, DBJob.job_starday, DBJob.job_endday FROM DBJob WHERE DBJob.job_partner like '" + jId + "'";
            SqlCommand cmd = new SqlCommand(sql, DAL.conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

        public static JobDTO getJobct(int id)
        {
            JobDTO job = new JobDTO();
            DAL.ConnectDB();
            DAL.conn.Open();
            string sql = @"SELECT * FROM DBJob WHERE job_id= '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, DAL.conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                job.jId = id;
                job.jTitle = reader["job_title"].ToString();
                job.jStarday = reader["job_starday"].ToString();
                job.jEndday = reader["job_endday"].ToString();
                job.jCircle = reader["job_circle"].ToString();
                job.jAttachments = reader["job_attachments"].ToString();
                job.jPartner = Int16.Parse(reader["job_partner"].ToString());
                job.jStatus = Int16.Parse(reader["job_status"].ToString());
            }
            return job;
        }
        public static void deleteJob(int id)
        {
            DAL.ConnectDB();
            DAL.conn.Open();
            string sql = "delete from DBJob where job_id=" + id;
            SqlCommand cmd = new SqlCommand(sql, DAL.conn);
            cmd.ExecuteNonQuery();
        }
        public static void updateJob(JobDTO job)
        {
            DAL.ConnectDB();
            DAL.conn.Open();
            string sql = "update DBJob set job_title='" + job.jTitle + "',job_starday='" + job.jStarday +"',job_endday='"+job.jEndday+ "',job_circle='" + job.jCircle + "',job_attachments='" + job.jAttachments + "',job_status='" + job.jStatus + "',job_partner='" + job.jPartner + "' where job_id=" + job.jId;
            SqlCommand cmd = new SqlCommand(sql, DAL.conn);
            cmd.ExecuteNonQuery();
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
