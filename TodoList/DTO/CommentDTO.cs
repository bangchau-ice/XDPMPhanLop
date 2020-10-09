using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class CommentDTO
    {
        int cmn_id;
        int job_id;
        int user_id;
        string cmn_content;
        string cmn_ngay;

        public int cmnId
        {
            get
            {
                return cmn_id;
            }
            set
            {
                cmn_id = value;
            }
        }
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
        public int userId
        {
            get
            {
                return user_id;
            }
            set
            {
               user_id = value;
            }
        }
        public string cmnContent
        {
            get
            {
                return cmn_content;
            }
            set
            {
                cmn_content = value;
            }
        }
        public string cmnNgay
        {
            get
            {
                return cmn_ngay;
            }
            set
            {
                cmn_ngay = value;
            }
        }
    }
}
