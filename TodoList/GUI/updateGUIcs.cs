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
    public partial class formsua : Form
    {
        public formsua(int id)
        {
            InitializeComponent();
           // public static int jId=this.id;
            JobDTO job = new JobDTO();
            UserDTO user = new UserDTO();
           // List<UserDTO> listUser = new List<UserDTO>();
            job = BLL.JobBLL.getJobct(id);
            user = BLL.UserBLL.getUser(job.jPartner);
            txtmcv.Text = id.ToString();
            txttcv.Text = job.jTitle.ToString();
            txtfdk.Text = job.jAttachments.ToString();

            dtngbd.Text = job.jStarday.ToString();
            dtngkt.Text = job.jEndday.ToString();

            cbbpv.Text = job.jCircle.ToString();
            cbbtt.Text = job.jStatus.ToString();
            cbbnglc.Text = user.uName;

            

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            JobDTO job = new JobDTO();
            job.jId = int.Parse(txtmcv.Text);
            job.jTitle = txttcv.Text;
            job.jStarday = dtngbd.Text.ToString();
            job.jEndday = dtngkt.Text.ToString();
           // job.jCircle = cbbpv.Text;
            job.jAttachments = txtfdk.Text;
            job.jPartner = int.Parse(cbbnglc.SelectedValue.ToString());
            //job.jStatus=cbbtt.
            if (cbbpv.Text == "Public") job.jCircle = "0";
            else job.jCircle = "1";

            if (cbbtt.Text == "Đang hoàn thành") job.jStatus = 0;
            else if (cbbtt.Text == "Đã hoàn thành") job.jStatus = 1;
            else job.jStatus = 2;

            BLL.JobBLL.update(job);
            MessageBox.Show("Cập nhật thành công");
        }

        private void formsua_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'todoList_DBDataSet5.DBUser' table. You can move, or remove it, as needed.
            this.dBUserTableAdapter.Fill(this.todoList_DBDataSet5.DBUser);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                String fileName;
                fileName = dlg.FileName;
                txtfdk.Text = fileName;
            }
        }
    }
}
