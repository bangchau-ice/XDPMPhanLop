using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class JobDTO
    {
        private int job_id;
        private string job_title;
        private string job_starday;
        private string job_endday;
        private string job_status;
        private string job_partner;
        private string job_circle;
        private string job_attachments;

        public int jId
        {
            get
            {
                return job_id;
            }
            set
            {
                job_id = value;
            }
        }
        public string jTitle
        {
            get
            {
                return job_title;
            }
            set
            {
                job_title = value;
            }
        }
        public string jStarday
        {
            get
            {
                return job_starday;
            }
            set
            {
                job_starday = value;
            }
        }
        public string jEndday
        {
            get
            {
                return job_endday;
            }
            set
            {
                job_endday = value;
            }
        }
        public string jStatus
        {
            get
            {
                return job_status;
            }
            set
            {
                job_status = value;
            }
        }
        public string jPartner
        {
            get
            {
                return job_partner;
            }
            set
            {
                job_partner = value;
            }
        }
        public string jCircle
        {
            get
            {
                return job_circle;
            }
            set
            {
                job_circle = value;
            }
        }
        public string jAttachments
        {
            get
            {
                return job_attachments;
            }
            set
            {
                job_attachments = value;
            }
        }
        public JobDTO() { }
    }
}
