using DAL;
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
    public partial class AddJob : Form
    {
        public AddJob()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            JobDTO job = new JobDTO();
            job.jTitle = txtTencv.Text;
            job.jStarday = dtNgbd.Value.ToString();
            job.jEndday = dtNgkt.Value.ToString();
            job.jStatus = "1";
            job.jPartner = cbNglc.Text;
            job.jCircle = cbPhamvi.Text;
            job.jAttachments = txtDinhkem.Text;
            JobDAL.insert(job);
        }
    }
}
