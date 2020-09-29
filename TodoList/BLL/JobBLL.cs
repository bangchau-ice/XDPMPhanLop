using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class JobBLL
    {
        public static void insert(JobDTO job)
        {
            JobDAL.insert(job);
        }
    }
}
