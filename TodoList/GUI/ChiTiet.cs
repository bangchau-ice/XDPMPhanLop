using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ChiTiet : Form
    {
       
        public ChiTiet(int id)
        {
            InitializeComponent();
            JobDTO job = new JobDTO();
            UserDTO user = new UserDTO();
            //CommentDTO cmn = new CommentDTO();
            List<CommentDTO> cmn = new List<CommentDTO>();
            List<UserDTO> userL = new List<UserDTO>();
           // List<string> listngay = new List<string>();
            job=BLL.JobBLL.getJobct(id);
            user = BLL.UserBLL.getUser(job.jPartner);
            
            cmn = BLL.CommentBLL.getcmn(id);
            userL = BLL.UserBLL.ListU(cmn);
            txtmcv.Text = id.ToString();
            txttcv.Text = job.jTitle.ToString();
            txtnbd.Text = job.jStarday.ToString();
            txtnkt.Text = job.jEndday.ToString();
            txtfdk.Text = job.jAttachments.ToString();

            if (job.jCircle.ToString().Equals('0')) txtpv.Text = "Public";
            else txtpv.Text = "Private";

            if (job.jStatus==0) txttt.Text = "Đang hoàn thành";
            else if (job.jStatus==1) txttt.Text = "Đã hoàn thành";
            else txttt.Text = "Trể hẹn";

            txtnlc.Text = user.uName;

            //cbbnbl.DataSource = userL;
            //cbbnbl.DisplayMember = "uName";
            //cbbnbl.ValueMember = "uId";
            //listngay=BLL.CommentBLL.getngcm()
            DataTable dt = BLL.CommentBLL.getCmn(id);
            dataGridView1.DataSource = dt;


        }
       
        private void label7_Click(object sender, EventArgs e)
        {

        }

       
    }
}
