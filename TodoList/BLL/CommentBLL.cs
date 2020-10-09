using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CommentBLL
    {
        public static List<CommentDTO> getcmn(int jId)
        {
            List<CommentDTO> data = new List<CommentDTO>();
            data = DAL.CommentDAL.getcmn(jId);
            return data;
        }
        public static List<CommentDTO> getcmn(string jId)
        {
            List<CommentDTO> data = new List<CommentDTO>();
            data = DAL.CommentDAL.getcmn(jId);
            return data;
        }
        public static List<CommentDTO> getngcm(string uId, string jId)
        {
            string ngcm = "";
            List<CommentDTO> listngay = new List<CommentDTO>();
            List<CommentDTO> list = new List<CommentDTO>();
            list = getcmn(jId);
            for(int i=0; i < list.Count; i++)
            {
                if (list[i].userId.ToString()==uId)
                {
                    

                    

                    listngay.Add(list[i]);
                }
            }
          
            return listngay;
        }

        public static DataTable getCmn(int jId)
        {
            return DAL.CommentDAL.getCmn(jId);
        }
        /*public static string getcm(string uId, string jId,string cmnNgay)
        {
            string cmn = "";
            List<CommentDTO> list = new List<CommentDTO>();

        }*/
    }
}
