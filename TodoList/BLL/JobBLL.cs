using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class JobBLL
    {
        public static void insert(JobDTO job)
        {
            JobDAL.insert(job);
        }
        public static DataTable getJob(int id)
        {
           return DAL.JobDAL.getJob(id);
        }
        public static DataTable getALLJob()
        {
            return DAL.JobDAL.get_AllJob();
        }
        public static DataTable getALLJob(int id)
        {
            return DAL.JobDAL.get_AllJob(id);
        }
        public static DataTable search(int jId)
        {
            return DAL.JobDAL.search(jId);
        }
        public static DataTable getUserJob(string jId)
        {
            return getUserJob(jId);
        }
        public static DataTable getAllJob(int id)
        {
            return JobDAL.get_AllJob(id);
        }
        public static JobDTO getJobct(int id)
        {
            JobDTO job = new JobDTO();
            job= DAL.JobDAL.getJobct(id);
            return job;
        }

        public static void deleteJob(int id)
        {
            DAL.JobDAL.deleteJob(id);
        }
        public static void update(JobDTO job)
        {
            DAL.JobDAL.updateJob(job);
        }
        public static DataTable locday(string ngbd, string ngkt)
        {
            return JobBLL.locday(ngbd,ngkt);
            
        }
        public static DataTable loc(string ngbd, string ngkt, int manv)
        {
            return JobDAL.loc(ngbd, ngkt, manv);
        }
    }
}
